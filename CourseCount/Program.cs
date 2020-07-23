using CourseCount.Entities;
using System;
using System.Collections.Generic;

namespace CourseCount
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Users> users = new HashSet<Users>();

            Console.Write("How many Users for Course A: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                users.Add(new Users {Id=id });
            }
            Console.Write("How many Users for Course B: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                users.Add(new Users { Id = id });
            }
            Console.Write("How many Users for Course C: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                users.Add(new Users { Id = id });
            }

            Console.WriteLine();
            Console.WriteLine(users.Count);
        }
    }
}
