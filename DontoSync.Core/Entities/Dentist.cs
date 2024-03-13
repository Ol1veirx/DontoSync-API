using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DontoSync.Core.Entities
{
    public class Dentist 
    {
        public int Id { get; set; }
        public int Username { get; set; }
        public string Password { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public string CRO {  get; set; }
    }
}
