using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionary
{
    class Program
    {
        //-----------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            // DICTIONARY: Pair "key" and "value"
            //Key is similar to an index.
            // Push: add to the end of the queue
            //Pop: Return and REMOVE FIRST item in the queue

            SampleExample();
            //InteractieExample();

            WaitForAnyKey();
        }
        //-----------------------------------------------------------------------------------------------------------
        static void InteractiveExample()
        {
            // Create queue instance
            Dictionary<string, int> ageBook = new Dictionary<string, int>();
            PrintCommands();
            //add to the end of the queue
            while (true)
            {
                Console.WriteLine("\nEnter Command: ");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "a":
                    case "add":
                        {
                            Console.WriteLine("Please enter a Key: ");
                            string key = Console.ReadLine();
                            bool found = ageBook.ContainsKey(key);
                            if (found)
                            {
                                Console.WriteLine("Please enter an age: ");
                                int age = Convert.ToInt32(Console.ReadLine());
                                ageBook.Add(key, age);
                            Console.WriteLine("Added the age " + age + "for \""+key+"\" to the dictionary.");
                            }else
                                Console.WriteLine("That key has already been used!");
                        }
                        break;
                    case "r":
                    case "remove":
                        {
                            Console.WriteLine("Please enter a key: ");
                            string key = Console.ReadLine();
                            bool found = ageBook.Remove(key);
                            if (found)
                                Console.WriteLine("Successfully removed \"" + key + "\"");
                            else
                                Console.WriteLine("Key not found in dictionary.");
                        }
                        break;
                    case "g":
                    case "get":
                        {
                            Console.WriteLine("Please enter a key: ");
                            string key = Console.ReadLine();
                            int value = 0;
                            bool found = ageBook.TryGetValue(key, out value);
                            if (found)
                                Console.WriteLine("Successfully removed \"" + key + "\"with an age of "+value);
                            else
                                Console.WriteLine("Key not found in dictionary.");
                        }
                        break;
                  
                    case "s":
                    case "set":
                        {
                            Console.WriteLine("Please enter a key: ");
                            string key = Console.ReadLine();
                            bool found = ageBook.ContainsKey(key);
                            if (found)
                            {
                                Console.Write("Plese enter an age: ");
                                int ageNew =Convert.ToInt32( Console.ReadLine());
                                int ageOld = ageBook[key];
                                ageBook[key] = ageNew;
                                Console.WriteLine("Successfully changed the age \"" + ageOld + "\" to \"" + ageNew + "\" for " + key+"\".");
                            }
                            else
                                Console.WriteLine("Key not found in dictionary.");
                        }
                        break;
                    case "cv":
                    case "containsvalue":
                        {
                            Console.WriteLine("Please enter a age: ");
                            int value = Convert.ToInt32(Console.ReadLine());

                            bool found = ageBook.ContainsValue(value);
                            if (found)
                                Console.WriteLine("Successfully found" + value + "in the dictionary. ");
                            else
                                Console.WriteLine("Age not found in dictionary. ");
                        }
                        break;
                    case "ck":
                    case "containskey":
                        {
                            Console.WriteLine("Please enter a key: ");
                            string key = Console.ReadLine();

                            bool found = ageBook.ContainsKey(key);
                            if (found)
                                Console.WriteLine("Successfully found" + key + "in the dictionary. ");
                            else
                                Console.WriteLine("Key not found in dictionary. ");
                        }
                        break;
                    case "c":
                    case "clear":
                        {
                            PrintCommands();

                            Console.WriteLine("\nCleared" + ageBook.Count + "values");
                            ageBook.Clear();
                        }
                        break;
                    case "p":
                    case "print":
                        {
                            PrintValues<string, int>(ageBook);
                        }
                        break;
                    case "q":
                    case "quit":
                    case "x":
                    case "exit":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid command: " + input);
                        }
                        break;
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        static void PrintCommands()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Commands: ");
            Console.WriteLine("-----------------");
            Console.WriteLine("a or add        -to add a value.");
            Console.WriteLine("r or remove     -to remove a specific value.");
            Console.WriteLine("ra or removeAt  -to remove a value at an index.");
            Console.WriteLine("wa or writeAt   -to write a value at an index.");
            Console.WriteLine("rr or readAt    -to read(print) a value at an index.");
            Console.WriteLine("c or clear      -clears the list of all values.");
            Console.WriteLine("p or print       -prints all values in the queue.");
            Console.WriteLine("q or quit        -Quit / exit the program.");
            Console.WriteLine("------------------");
        }
        //-----------------------------------------------------------------------------------------------------------
        static void SampleExample()
        {
            //create queue onstance
            Dictionary<string, int> ageBook = new Dictionary<string, int>();
            // add to the end of the queue
            ageBook.Add("jill", 33);
            ageBook.Add("jack", 42);
            ageBook.Add("Mary", 25);
            ageBook.Add("Tom", 51);// explicit additon

            ageBook["Alfred"] = 99;// implicit additon

            PrintValues<string, int>(ageBook);

            Console.WriteLine("Fixing Tom's age by one year.  ");
            ageBook["Tom"] =50;

            Console.WriteLine("Adding a year to Mary's age.  ");
            ageBook["Mary"] += 1;

            PrintValues<string, int>(ageBook);
        }
        static void PrintValues<tk,tv>(Dictionary<tk, tv> _dictionary)
        {
            if (_dictionary.Count > 0)
            {
                Console.WriteLine("\nDictionary Keys & Values:\n--------------------------------------------------");
                int i = 0;
                foreach (tk key in _dictionary.Keys)
                {
                    Console.WriteLine(i + ".)Key: \"" + key + "\"Value:" + _dictionary[key]);
                    ++i;
                }

            }
            else
            {
                Console.WriteLine("No values to print!");
            }
            Console.WriteLine("\n");

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------
        static void WaitForAnyKey()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
