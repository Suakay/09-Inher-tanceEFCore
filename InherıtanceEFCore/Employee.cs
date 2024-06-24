using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherıtanceEFCore
{
    internal class Employee:BasePerson
    {
        public int EmployeeID {  get; set; }    
        public DateTime AdmisistioınDate {  get; set; } 
        public string JobDescription {  get; set; } 

    }
}
