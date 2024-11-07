using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLater.Concrete
{
    public class Users : IdentityUser<int>
    {
       
        public string Name { get; set; }
        public override string UserName { get; set; }
       
    }
}
