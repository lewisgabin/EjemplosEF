using System;

namespace firstAplication
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
        }
    }
}
