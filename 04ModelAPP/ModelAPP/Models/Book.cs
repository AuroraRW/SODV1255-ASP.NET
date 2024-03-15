using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ModelAPP.Models
{
    //////////////Model binding//////////////////
    //public class Book
    //{
    //    [FromRoute]
    //    public int? BookId { get; set; }

    //    [FromQuery]
    //    public string? Author { get; set; }
    //}

    ////////////////Form data binding////////////////////
    //public class Book
    //{
    //    public int? BookId { get; set; }

    //    public string? Author { get; set; }
    //}

    //////////////////Model Validation///////////////
    //public class Book
    //{
    //    public int? BookId { get; set; }
    //    [Required]
    //    public string BookName { get; set; }
    //    public string? Author { get; set; }
    //}

    ///////////////////show error message/////////////
    //public class Book
    //{
    //    public int? BookId { get; set; }
    //    [Required(ErrorMessage = "{0} should be not empty")]
    //    [Display(Name = "The name of book")]
    //    public string BookName { get; set; }
    //    public string? Author { get; set; }
    //}

    /////////////////build in model validation////////////
    public class Book
    {
        public int? BookId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Book Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} and {1} characters long")]
        public string BookName { get; set; }
        public string? Author { get; set; }

        [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
        public double? Price { get; set; }

        [EmailAddress(ErrorMessage = "{0} should be a proper email address")]
        [Required(ErrorMessage = "{0} can't be blank")]
        public string AuthorEmail { get; set; }


        [Required(ErrorMessage = "{0} can't be blank")]
        public string? Password { get; set; }


        [Required(ErrorMessage = "{0} can't be blank")]
        [Compare("Password", ErrorMessage = "{0} and {1} do not match")]
        [Display(Name = "Re-enter Password")]
        public string? ConfirmPassword { get; set; }
    }

}
