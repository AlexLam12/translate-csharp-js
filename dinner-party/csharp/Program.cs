using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[]args)
        {
            List<Guest> guests = GetGuests();

            Table tableOne = new Table("Table One");
            Table tableTwo = new Table("Table Two")

            foreach (Guest guest in guests)
            {
                List<string> Table1Occupations = tableOne.GuestList.Select(guest => guest.Occupation).ToList();
                if (Table1Occupations.Contains(guest.Occupation))
                {
                    tableTwo.AddGuest(guest);
                }
                else 
                {
                    tableOne.AddGuest(guest);
                }
            }

            Console.WriteLine(tableOne.Name);
            foreach (Guest guest in tableOne.GuestList)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }
            Console.WriteLine(tableTwo.Name);
            foreach (Guest guest in tableTwo.GuestList)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");

            }

            List<Guest> GetGuests()
            {

                List<Guest> guests = new List<Guest> {
                    new Guest {
                        FullName = "Marilyn Monroe",
                        Occupation = "entertainer",
                        Bio = new List<string> {
                            "(1926 - 1962) American actress, singer, model"
                        }
                    },
                    new Guest {
                        FullName = "Abraham Lincoln",
                        Occupation = "politician",
                        Bio = new List<string> {
                            "(1809 - 1865) US President during American civil war"
                        }
                    },
                    new Guest {
                        FullName = "Martin Luther King",
                        Occupation = "activist",
                        Bio = new List<string> {
                            "(1929 - 1968)  American civil rights campaigner"
                        }
                    },
                    new Guest {
                        FullName = "Rosa Parks",
                        Occupation = "activist",
                        Bio = new List<string> {
                            "(1913 - 2005)  American civil rights activist"
                        }
                    },
                    new Guest {
                        FullName = "Peter Sellers",
                        Occupation = "entertainer",
                        Bio = new List<string> {
                            "(1925 - 1980) British actor and comedian"
                        }
                    },
                    new Guest {
                        FullName = "Alan Turing",
                        Occupation = "computer scientist",
                        Bio = new List<string> {
                            "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                        }
                    },
                    new Guest {
                        FullName = "Admiral Grace Hopper",
                        Occupation = "computer scientist",
                        Bio = new List<string> {
                            "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                        }
                    },
                    new Guest {
                        FullName = "Indira Gandhi",
                        Occupation = "politician",
                        Bio = new List<string> {
                            "(1917 - 1984) Prime Minister of India 1966 - 1977"
                        }
                    }
                };

                return guests;
            }
        }

            public class Guest
            {
                public string Name { get; set; }
                public string Occupation { get; set; }
                public string bio { get; set; }
            }

            public class Table
            {
            public List<string> Guests { get; set; }
            public string Name { get; set; } 
            }
        }
    }

