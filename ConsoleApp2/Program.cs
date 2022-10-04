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
                new Member("Linh","Le","Male",new DateTime(2000,10,1),"0915975898","HANOI",true),
                new Member("Linh","Tran","Male",new DateTime(2001,10,2),"0962689212","PHUTHO",false),
                new Member("Linh","Nguyen","FeMale",new DateTime(2001,10,3),"0988356436","HANOI",false),
                new Member("Linh","Bui","FeMale",new DateTime(1999,10,3),"0913356436","HANOI",false)
            };

            while (true)
            {
                Console.Write("\n");
                Console.Write("---------------------");
                Console.Write("\n\n");
                Console.Write("\nSelect choice:\n");
                Console.Write("1 - Return a list of members who is Male" +
                    "\n2 - Return the oldest one based on Age" +
                    "\n3 - Return a list that contain FullName only." +
                    "\n4 - Rerurn 3 lists: " +
                    "\n5 - Return the first person who was born in Ha Noi" +
                    "\n6 - Exit. \n");
                Console.Write("Enter your choice: ");

                int opt;

                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.Write("Return a list members who is Male\n");
                        var maleMembers = list.Where(m => m.Gender == "Male");

                        foreach (var Member in maleMembers)
                        {
                            Console.WriteLine(Member.Information);
                        }
                        break;

                    case 2:
                        Console.Write("Return the oldest one based on Age\n");

                        // var oldestMember = list.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).FirstOrDefault();

                        var maxAge = list.Max(Member => Member.Age);
                        var oldestMember = list.Find(x => x.Age == maxAge);
                        if (oldestMember != null)
                        {
                            Console.WriteLine(oldestMember.Information);
                        }
                        break;

                    case 3:
                        Console.Write("Return a new list that contains FullName only\n");

                        var listFullName = (from Member in list
                                            select new { FullName = Member.FirstName + " " + Member.LastName }).ToList();
                        listFullName.ForEach(item => Console.WriteLine(item.FullName));
                        break;
                    case 4:
                        Console.WriteLine("Return 3 lists:\n");
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
                                                Console.WriteLine(item.Information);
                                        }
                                        break;
                                    };
                                case 2:
                                    {
                                        Console.WriteLine("List members have birth year > 2000:");
                                        foreach (var item in list)
                                        {
                                            if (item.DateOfBirth.Year > 2000)
                                                Console.WriteLine(item.Information);
                                        }
                                        break;
                                    };
                                case 3:
                                    {
                                        Console.WriteLine("List members have birth year < 2000:");
                                        foreach (var item in list)
                                        {
                                            if (item.DateOfBirth.Year < 2000)
                                                Console.WriteLine(item.Information);
                                        }
                                        break;
                                    }
                            }
                        } while (option >= 1 && option <= 3);
                        break;
                    case 5:
                        Console.WriteLine("Return the first person was born in Hanoi\n:");

                        var result = from Member in list
                                     where Member.BirthPlace.ToUpper() == "HANOI"
                                     select Member;
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.Information);
                            break;
                        }
                        break;
                }
            }
        }
    }
}
