using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo4.Models
{
    public static class ExtensionMath
    {
        public static int Add(this Math1 math,int num1,int num2)
        {
            return num1 + num2;
        }
    }
}