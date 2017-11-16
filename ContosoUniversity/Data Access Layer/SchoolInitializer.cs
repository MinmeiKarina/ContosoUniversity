using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data_Access_Layer
{
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstMidName="Grace",LastName="Holcomb",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="Samantha",LastName="Cloutier",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Minmei Karina",LastName="Findlay",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Bassam",LastName="Romolino",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Maxwell",LastName="Strauch",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Maryn",LastName="O'Brien", EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="James",LastName="Thomas",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Ethan",LastName="Bradley",EnrollmentDate=DateTime.Parse("2005-09-01")},
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID=1050,Title="Brass Pedagogy",Credits=3},
                new Course{CourseID=4022,Title="Music Theory I",Credits=3},
                new Course{CourseID=4041,Title="Composition",Credits=3},
                new Course{CourseID=1045,Title="Calculus",Credits=4},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,Title="Chemistry",Credits=4},
                new Course{CourseID=2041,Title="Fundamentals of Speech",Credits=3},
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=2021,Grade=Grade.B},
                new Enrollment{StudentID=1,CourseID=2041,Grade=Grade.C},
                new Enrollment{StudentID=2,CourseID=4022,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.C},
                new Enrollment{StudentID=2,CourseID=2041,Grade=Grade.A},
                new Enrollment{StudentID=3,CourseID=4041},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=2041,Grade=Grade.A},
                new Enrollment{StudentID=5,CourseID=3141,Grade=Grade.B},
                new Enrollment{StudentID=6,CourseID=4022,Grade=Grade.A},
                new Enrollment{StudentID=7,CourseID=2021,Grade=Grade.C}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}