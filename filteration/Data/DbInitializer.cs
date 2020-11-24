using filteration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filteration.Data
{
    public class DbInitializer
    {
        public static void Initialize(StudentContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
            new Student{FirstName="Ahmed",LastName="Ali",BirthDate=DateTime.Parse("1994-09-01")},
            new Student{FirstName="Mona",LastName="Lotfy",BirthDate=DateTime.Parse("1994-09-01")},
            new Student{FirstName="Sara",LastName="Mohamed",BirthDate=DateTime.Parse("1995-09-01")},
            new Student{FirstName="Mohamed",LastName="Fawzy",BirthDate=DateTime.Parse("1995-09-01")},
            new Student{FirstName="Mona",LastName="Ahmed",BirthDate=DateTime.Parse("1993-09-01")},
            new Student{FirstName="Sayed",LastName="Ibrahim",BirthDate=DateTime.Parse("1991-09-01")},
            new Student{FirstName="Walaa",LastName="Abdallah",BirthDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Sayed",LastName="Fathy",BirthDate=DateTime.Parse("2001-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }
    }
}
