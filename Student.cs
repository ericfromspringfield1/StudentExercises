using System;

namespace StudentExercises
{
    public class Student
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }
        public int CohortNumber { get; set; }
        public string CurrentExercises { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}

