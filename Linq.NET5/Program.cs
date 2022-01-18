﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.NET5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the first data source.
            List<Student> students = new List<Student>()
                {
                    new Student { First="Svetlana",
                        Last="Omelchenko",
                        ID=111,
                        Street="123 Main Street",
                        City="Seattle",
                        Scores= new List<int> { 97, 92, 81, 60 } },
                    new Student { First="Claire",
                        Last="O’Donnell",
                        ID=112,
                        Street="124 Main Street",
                        City="Redmond",
                        Scores= new List<int> { 75, 84, 91, 39 } },
                    new Student { First="Sven",
                        Last="Mortensen",
                        ID=113,
                        Street="125 Main Street",
                        City="Lake City",
                        Scores= new List<int> { 88, 94, 65, 91 } },
                };

            // Create the second data source.
            List<Teacher> teachers = new List<Teacher>()
                {
                    new Teacher { First="Ann", Last="Beebe", ID=945, City="Seattle" },
                    new Teacher { First="Alex", Last="Robinson", ID=956, City="Redmond" },
                    new Teacher { First="Michiyo", Last="Sato", ID=972, City="Tacoma" }
                };

            // Create the query.
            //var peopleInSeattle = (from student in students
            //                       where student.City == "Seattle"
            //                       select student.Last)
            //                       .Concat(from teacher in teachers
            //                               where teacher.City == "Seattle"
            //                               select teacher.Last);

            var peopleInSeattle = (from student in students
                                   where student.City == "Seattle"
                                   select new { Name = student.First, LastName = student.Last })
                                   .Concat(from teacher in teachers
                                           where teacher.City == "Seattle"
                                           select new { Name = teacher.First, LastName = teacher.Last });

            Console.WriteLine("The following students and teachers live in Seattle:");
            // Execute the query.
            foreach (var person in peopleInSeattle)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /* Output:
            The following students and teachers live in Seattle:
            Omelchenko
            Beebe
         */

    }
}
