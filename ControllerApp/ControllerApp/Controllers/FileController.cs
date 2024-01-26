using Microsoft.AspNetCore.Mvc;
namespace ControllerApp.Controllers
{
    public class FileController:Controller
    {
        // return anything in WebRoot folder
        [Route("/File1")]
        public VirtualFileResult File1()
        {
            //return new VirtualFileResult("/Samples/Sample.pdf", "application/pdf");
            return File("/Samples/Sample.pdf", "application/pdf");
        }

        // return the file in hard drive
        [Route("/File2")]
        public PhysicalFileResult File2()
        {
            //return new PhysicalFileResult("C:\\00code\\SampleFile\\Sample.pdf", "application/pdf");

            return PhysicalFile("C:\\00code\\SampleFile\\Sample.pdf", "application/pdf");
        }


        [Route("/File3")]
        public IActionResult File3()
        {
            if (System.IO.File.Exists("C:\\00code\\SampleFile\\Sample.pdf"))
            {
                return PhysicalFile("C:\\00code\\SampleFile\\Sample.pdf", "application/pdf");
            }
            return File("/Samples/2.pdf", "application/pdf");
        }
    }
}
