


namespace Students
{
    class Student : Person, Exam
    {
        public float gpa = 5;

        public List<string> courses = new List<string>();
        byte maxNumberOfCourses = 5;

        // this my comment
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

        public void registerExam()
        {
            throw new NotImplementedException();
        }

        public void takeExam()
        {
            throw new NotImplementedException();
        }
    }

}



