using System;

namespace StudentExercises
{
public class Instructor
{
    
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string SlackHandle { get; set; }
    public string Specialty { get; set; }
    public int CohortNumber { get; set;}

    public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    public void AssignExercise(string Student, string Exercise)
    {
    
    }
    
    }


}


