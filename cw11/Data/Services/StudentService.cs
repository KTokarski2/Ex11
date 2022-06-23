using cw11.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Data.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> Students { get; set; }
        public StudentService()
        {
            Students = new List<Student>()
            {
                new Student
                {
                    IdStudent = 1,
                    FirstName = "Biggie",
                    LastName = "Smalls",
                    BirthDate = DateTime.Parse("1979-02-01"),
                    Avatar = "https://gravatar.com/avatar/798f7add0a0f7241e84c63342df3faec?s=400&d=robohash&r=x",
                    Studies = "Informatyka"
                },
                new Student
                {
                    IdStudent = 2,
                    FirstName = "Tupac",
                    LastName = "Shakur",
                    BirthDate = DateTime.Parse("1981-01-01"),
                    Avatar = "https://gravatar.com/avatar/798f7add0a0f7241e84c63342df3faec?s=400&d=robohash&r=x",
                    Studies = "Zarządzanie informacją"
                },
                new Student
                {
                    IdStudent = 3,
                    FirstName = "Zbigniew",
                    LastName = "Kolano",
                    BirthDate = DateTime.Parse("2012-01-01"),
                    Avatar = "https://gravatar.com/avatar/798f7add0a0f7241e84c63342df3faec?s=400&d=robohash&r=x",
                    Studies = "SNM"
                },

                new Student
                {
                    IdStudent = 4,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    BirthDate = DateTime.Parse("1997-09-28"),
                    Avatar = "https://gravatar.com/avatar/798f7add0a0f7241e84c63342df3faec?s=400&d=robohash&r=x",
                    Studies = "RapGra"
                },

                new Student
                {
                    IdStudent = 5,
                    FirstName = "Roman",
                    LastName = "Polanski",
                    BirthDate = DateTime.Parse("1954-02-12"),
                    Avatar = "https://gravatar.com/avatar/798f7add0a0f7241e84c63342df3faec?s=400&d=robohash&r=x",
                    Studies = "SNM"
                }


            };
        }
        public void DeleteStudent(int id)
        {
            Students.Remove(GetStudent(id));
        }

        public Student GetStudent(int id)
        {
            return Students.FirstOrDefault(e => e.IdStudent == id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }
    }
}
