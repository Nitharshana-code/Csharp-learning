using System;
using System.Collections.Generic;
using System.Text;

namespace variables
{
    internal class student
    {

        //Instant variable - declared outside a method
        public string name = "Nitharshana";
        public string dept_name = "BA.English";
        public string clg_name = "Govt. arts clg, pmk";


        public void student_details()
        {
            Console.WriteLine(name);
            Console.WriteLine(dept_name);
            Console.WriteLine(clg_name);
        }


    }
}
