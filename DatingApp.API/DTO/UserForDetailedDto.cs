using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.DTO
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set;} 
     //   public byte[] PasswordHash { get; set; } //should not be mapped
    //    public byte[] PasswordSalt { get; set; } //should not be mapped
        public string Gender { get; set; }
    //    public DateTime DateOfBirth { get; set; } //should not be mapped
        public int Age { get; set; }
        public string KnownAs { get; set; } 
        public DateTime Created { get; set; }   
        public DateTime LastActive { get; set; } 
        public string Introduction { get; set; }
        public string  LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }  
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}