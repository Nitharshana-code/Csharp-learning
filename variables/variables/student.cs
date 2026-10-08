using System;
using System.Collections.Generic;
using System.Text;

namespace variables
{
    internal class Student
    {

        //instant variable - declared outside a method
        public string name = "nitharshana";
        public string dept_name = "ba.english";
        public string clg_name = "govt. arts clg, pmk";


        public void student_details()
        {
            Console.WriteLine(name);
            Console.WriteLine(dept_name);
            Console.WriteLine(clg_name);
        }


    }
}

