
namespace Courses{
    class Course
    {
        List<string> courses = new List<string>();
        int numberOfCourses = 0;
        

        string getCourse(string courseName)
        {
            return courses.Find((value) => value.Equals(courseName));
        }

        void addCourse(string courseName){
            courses.Add(courseName);
        }



    }
}

