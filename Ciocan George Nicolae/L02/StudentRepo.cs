using System.Collections.Generic;

namespace ApiStudent
{
    public static class StudentRepo
    {
        public static List<Student> Student=new List<Student>()
        {
            new Student()
            {
                id=1,
                nume="Blaga",
                prenume="Cristi",
                facultate="AC",
                an=3
            },
            new Student()
            {
                id=2,
                nume="Ciocan",
                prenume="George",
                facultate="AC",
                an=4
            }
        };
    }
}