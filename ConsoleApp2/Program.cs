using System;
using System.Collections.Generic;
using System.Linq;

namespace RookiesAssignment2
{   
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> list = new List<Member>()
            {
                new Member("Linh","Le","Male",new DateTime(2000,10,1),"0915975898","Ha Noi",true),
                new Member("Linh","Tran","Male",new DateTime(2001,10,2),"0962689212","Phu Tho",false),
                new Member("Linh","Nguyen","FeMale",new DateTime(2001,10,3),"0988356436","Ha Noi",false),
                new Member("Linh","Bui","FeMale",new DateTime(1999,10,3),"0913356436","Ha Noi",false)
            };

            Console.WriteLine("1. List male:");
            foreach (var item in list)
            {
                if (item.Gender == "Male")
               {
                   Console.WriteLine(item);
               }
            }

            Console.WriteLine("2. Oldest:");
            uint oldestMemberAge = 0;

            foreach (var item in list)
            {
                if (item.Age > oldestMemberAge)
                {
                    oldestMemberAge = item.Age;
                }
            }

            foreach (var item in list)
            {
                if (item.Age == oldestMemberAge)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.WriteLine("3. List FullName:");
            foreach (var item in list)
            {
                string FullName = item.FirstName + " " + item.LastName;
                Console.WriteLine(FullName);
            }

            Console.WriteLine("5. Return the first person was born in Hanoi:");

            List<Member> member = list.Where(item => item.BirthPlace == "Ha Noi").ToList();
            Console.WriteLine(member);


            Console.WriteLine("4. 3 List:");
            int option = 0;
            do
            {
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("List members have birth year = 2000:");
                            foreach (var item in list)
                            {
                                if (item.DateOfBirth.Year == 2000)
                                    Console.WriteLine(item);
                            }
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("List members have birth year > 2000:");
                            foreach (var item in list)
                            {
                                if (item.DateOfBirth.Year > 2000)
                                    Console.WriteLine(item);
                            }
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("List members have birth year < 2000:");
                            foreach (var item in list)
                            {
                                if (item.DateOfBirth.Year < 2000)
                                    Console.WriteLine(item);
                            }
                            break;
                        }
                }
            } while (option >= 1 && option <= 3);
        }
    }
}
