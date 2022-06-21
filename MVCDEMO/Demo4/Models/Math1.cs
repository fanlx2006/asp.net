using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo4.Models
{
    public class Math1
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int Circle(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}