using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Student emily = new Student()
            {
                FirstName = "Emily",
                LastName = "Taylor",
                SlackHandle = "EmilyFromSpringfield",
                CohortNumber = 50

            };

            Student suzanne = new Student()
            {
                FirstName = "Suzanne",
                LastName = "Taylor",
                SlackHandle = "SuzanneFromSpringfield",
                CohortNumber = 50
            };

            Student eric = new Student()
            {
                FirstName = "Eric",
                LastName = "Taylor",
                SlackHandle = "EricFromSpringfield",
                CohortNumber = 50
            };

            Student pete = new Student()
            {
                FirstName = "Pete",
                LastName = "Jenkins",
                SlackHandle = "EricFromSpringfield",
                CohortNumber = 34
            };

            Cohort c34 = new Cohort()
            {
                Number = 34,
            };

            Cohort c50 = new Cohort()
            {
                Number = 50,
            };

            Cohort c55 = new Cohort()
            {
                Number = 55,
            };

            Instructor blanche = new Instructor()
            {
                FirstName = "Blanche",
                LastName = "Devereaux",
                SlackHandle = "IGotBD",
                Specialty = "Wink Wink Nudge Nudge",
                CohortNumber = 50
            };

            Instructor rose = new Instructor()
            {
                FirstName = "Rose",
                LastName = "Nylund",
                SlackHandle = "IWearDresses",
                Specialty = "Stories About Home",
                CohortNumber = 55
            };

            Instructor dorothy = new Instructor()
            {
                FirstName = "Dorothy",
                LastName = "Syspornack",
                SlackHandle = "LiteratureLady42",
                Specialty = "Subbin'",
                CohortNumber = 50
            };

            Instructor sofia = new Instructor()
            {
                FirstName = "Sofia",
                LastName = "Petrillo",
                SlackHandle = "BlackPurseShorty",
                Specialty = "Quips",
                CohortNumber = 50
            };

            Exercise ternary = new Exercise()
            {
                Name = "Ternary Traveler",
                Language = "JavaScript",
            };
            Exercise trestlebridge = new Exercise()
            {
                Name = "Trestlebridge Farm",
                Language = "C#",
            };
            Exercise nashville = new Exercise()
            {
                Name = "Welcome To Nashville",
                Language = "JavaScript",
            };
            Exercise nutshell = new Exercise()
            {
                Name = "Nutshell",
                Language = "React",
            };


            sofia.AssignExercise(emily.FirstName, nutshell.Name);
            sofia.AssignExercise(suzanne.FirstName, trestlebridge.Name);
            dorothy.AssignExercise(eric.FirstName, nutshell.Name);
            dorothy.AssignExercise(pete.FirstName, nashville.Name);
            rose.AssignExercise(eric.FirstName, nutshell.Name);
            rose.AssignExercise(suzanne.FirstName, nutshell.Name);
            blanche.AssignExercise(emily.FirstName, ternary.Name);
            blanche.AssignExercise(eric.FirstName, ternary.Name);

            List<Student> students = new List<Student>() {
        emily,
        suzanne,
        eric,
        pete,
        };

            List<Exercise> exercises = new List<Exercise>() {
        ternary,
        trestlebridge,
        nashville,
        nutshell
        };



            List<Instructor> instructors = new List<Instructor>() {
        blanche,
        rose,
        dorothy,
        sofia
        };

            List<Cohort> cohorts = new List<Cohort>() {
        c34,
        c50,
        c55
        };

            IEnumerable<Exercise> JsExercises = exercises
        .Where(e => e.Language == ("JavaScript"));
            foreach (Exercise e in JsExercises)
                Console.WriteLine($"{e.Name} contains {e.Language}");

            IEnumerable<Student> StudentCohorts = students
        .Where(s => s.FirstName == s.FirstName);
            foreach (Student s in StudentCohorts)
                Console.WriteLine($"{s.FirstName} is in Cohort {s.CohortNumber}");

            IEnumerable<Instructor> InstructorCohorts = instructors
        .Where(i => i.FirstName == i.FirstName);
            foreach (Instructor i in InstructorCohorts)
                Console.WriteLine($"{i.FirstName} is in Cohort {i.CohortNumber}");

            var sortByStudentLastName = students.OrderBy(s => s);

            foreach (Student s in sortByStudentLastName)
            {
                Console.WriteLine(s.LastName);
            }


            Console.WriteLine($"{sofia.FirstName} done assigned {emily.FirstName} the {nutshell.Name}");
            Console.WriteLine($"{sofia.FirstName} also assigned {suzanne.FirstName} something, but hers is {trestlebridge.Name}");
            Console.WriteLine($"{dorothy.FirstName} assigned {eric.FirstName} {nutshell.Name}");
            Console.WriteLine($"{dorothy.FirstName} also assigned {pete.FirstName} something, but it is {nashville.Name}");
            Console.WriteLine($"{rose.FirstName} assigned {eric.FirstName}  {nutshell.Name}");
            Console.WriteLine($"{rose.FirstName} also assigned {suzanne.FirstName} something, but it is {nutshell.Name}");
            Console.WriteLine($"{blanche.FirstName}  assigned {emily.FirstName} {ternary.Name}");
            Console.WriteLine($"{blanche.FirstName} also assigned {eric.FirstName} something, but it is {ternary.Name}");
            Console.WriteLine($"My ladies are {emily.FirstName} {emily.LastName} & {suzanne.FirstName} {suzanne.LastName}");
        }
    }
}
