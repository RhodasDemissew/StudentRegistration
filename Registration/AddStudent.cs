using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    internal class AddStudent
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public DateTime schoolyear { get; set; }
        public char gender { get; set; }

        public static List<AddStudent> addStudents = new List<AddStudent>();

        public string add()
        {
            addStudents.Add(this);
            return "Successfully Registerd!";
        }

        public static List<AddStudent> get() 
        {
            return addStudents;
        }
    }
}
