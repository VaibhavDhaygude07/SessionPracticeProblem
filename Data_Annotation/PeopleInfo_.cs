using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace Data_Annotation
{
    internal class PeopleInfo_
    {//name, email, age, gender,phonenumber,zip code
        [Required(ErrorMessage = "Name is required ")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Please give name minimum 4 letters")]
        public string name { get; set; }

        [Required(ErrorMessage ="Email is required ")]
        [EmailAddress(ErrorMessage ="Please enter valid email")]
        public string email { get; set; }

        [Range(18,60,ErrorMessage="Age should be min 18")]
        public int age { get; set; }

        [Required(ErrorMessage ="Gender is required")]
        public string gender { get; set; }

        [Required(ErrorMessage ="Phone number is required")]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage ="Zip code is required")]
        public int zipcode { get; set; }


    }
    
    

    
}
