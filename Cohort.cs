using System;

namespace StudentExercises
{
public class Cohort
{
    
    public int Number { get; set; }

    public string Students { get;}

    public string Instructors { get;}
public string CohortStudent
        {
            get
            {
                return $"{Students}";
            }
        }
}
}