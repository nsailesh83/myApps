using System.ComponentModel.DataAnnotations;

namespace myAppy1.API.Dtos
{
       public class UserForRegistrationDto
    {
      
        [Required]
        public string  Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="You must specify a password between 4 and 8 characters")]
        public string  Password {get;set;}
    
    }
}