using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpInSematec.Models
{

    //Container For Methods and Property
    //Template for object
    //Custom Data Type
    internal class Student
    {
        //AccessModifier DataType Name {get; set;}
        public int Id { get; set; }
        //int Id;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalCode { get; set; }
        public string PhoneNumber { get; set; }


        //methods
    }
}
