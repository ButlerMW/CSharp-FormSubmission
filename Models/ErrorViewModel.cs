using System;
using System.ComponentModel.DataAnnotations;


namespace FormSubmission.Models
{
    public class User
    {     
        [Required]
        [MinLength(2)]
        // [Display(FirstName = "Your first name")]
        public string FirstName {get;set;}
        [Required]
        [MinLength(2)]
        [Display()]
        public string LastName {get;set;}
        [Required]
        [Range(0,150)]
        public int Age {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        
    }
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

}