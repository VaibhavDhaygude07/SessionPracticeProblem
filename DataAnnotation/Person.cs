using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace DataAnnotation
{
    internal class Person1
    {
        [Required(ErrorMessage = "name is required")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "please give name min 4 letters")]
        public string Name { get; set; }

        [Range(18, 65, ErrorMessage="age should be min 18")]
        public int Age { get; set; }

        [Required(ErrorMessage="email is rquired")]
        [EmailAddress(ErrorMessage="please provide valid email")]
        public string Email { get; set; }
       

    }
}
