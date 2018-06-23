

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace myAppy1.API.models
{
   
  public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Gender { get;set;}
        public DateTime DateOfBirth { get;set;}

        public string knownAs {get; set;}

        public DateTime LastActive {get; set;}

        public string Introduction {get;set;}

        public string lookingFor {get;set;}

        public string Interests {get;set;}

        public string City {get;set;}

        public string Country {get;set;}

        public ICollection<Photo> Photos {get;set;}

        public User()
        {
            Photos = new Collection<Photo>();
        }
        
        
    }
}
