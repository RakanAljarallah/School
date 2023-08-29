// See https://aka.ms/new-console-template for more information

using StudentA;

class School
{
    public static void Main(string[] args)
    {
        Student noor = new Student();
        noor.firstName = "noor";
        noor.lastName = "Alsadoon";

        noor.takeCourse("c# class");
        Console.WriteLine(noor.courses.Count());
        noor.takeCourse("metaVerse class");
        Console.WriteLine(noor.courses.Count());
        noor.takeCourse("web3 class");
        Console.WriteLine(noor.courses.Count());
        noor.takeCourse("maya class");
        Console.WriteLine(noor.courses.Count());
        noor.takeCourse("metspark class");
        Console.WriteLine(noor.courses.Count());
        noor.takeCourse("javascript class");
        Console.WriteLine(noor.courses.Count());
        noor.takeCourse("unity class");


    }
}