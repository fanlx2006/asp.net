using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StudentEntities1 dbcontext = new StudentEntities1())
            {
                dbcontext.Students.Add(new Student()
                {
                    SchoolId = 33,
                    Name = "yemei"
                });
                dbcontext.SaveChanges();
            }


        }
    }
}
