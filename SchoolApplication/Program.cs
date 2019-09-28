using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase;

namespace SchoolApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolDBEntities())
            {
                
                Subscriber role = new Subscriber { DiscordName = "alex" };
                db.Subscriber.Add(role);
                db.SaveChanges();
                Console.WriteLine("DB created");
            }
            Console.ReadKey();
        }
    }
}
