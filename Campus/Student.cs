


namespace StudentA
{
    class Student
    {
        public string firstName;
        public string lastName;
        int id;
        string birthDate;
        public float gpa = 5;
        public bool isMale;
        public List<string> courses = new List<string>();
        byte maxNumberOfCourses = 5;

        public bool takeCourse(string courseName)
        {
            if (courses?.Count() > maxNumberOfCourses)
            {
                return false;
            }
            Console.WriteLine("I added this course " + courseName);
            courses.Add(courseName);


            return true;
        }

    }
}



