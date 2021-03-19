using System;

namespace Collection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SuperCollection<int> a = new SuperCollection<int>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tSuperCollection\n\n");
            Console.ResetColor();

            Console.WriteLine("Choose with which type will work your collection.");
            ChoiceItemType();
            char valueType = Console.ReadKey().KeyChar;
            Console.Clear();
            
            bool processRun = true;
            while (processRun)
            {
                Menu();

                char choice = Console.ReadKey().KeyChar;
                Console.Clear();
                
                switch (choice)
                {
                    case '1':
                        a.AddElement(12);
                        a.AddElement(13);
                        a.AddElement(14);
                        a.AddElement(5);
                        a.AddElement(6);
                        a.AddElement(7);
                        a.AddElement(9);
                        a.AddElement(1);
                        a.AddElement(4);
                        
                        Console.WriteLine("Press any button to continue....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        a.ShowCollection();
                        
                        Console.WriteLine("Press any button to continue....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        a.RemoveAllElements();
                        
                        Console.WriteLine("Press any button to continue....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '4':
                        a.RemoveElement();
                        Console.WriteLine("Press any button to continue....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '5':
                        
                        Console.WriteLine("Press any button to continue....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '6':
                        
                        Console.WriteLine("Press any button to continue....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '7':
                        processRun = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("1<-->Show collection.");
            Console.WriteLine("2<-->Add element to collection.");
            Console.WriteLine("3<-->Delete exiting element.");
            Console.WriteLine("4<-->Delete all the elements.");
            Console.WriteLine("5<-->Sort collection.");
            Console.WriteLine("6<-->Find element in collection.");
            Console.WriteLine("7<-->Exit from the app.");
            Console.WriteLine("ALEX<->ALEX<->ALEX<->ALEX");
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Enter menu point: ");
            Console.ResetColor();
        }

        static void ChoiceItemType()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1)Integers.");
            Console.WriteLine("2)String.");
            Console.WriteLine("3)ISuperObject.");
            Console.WriteLine("4)The wheel of fortune.");
            Console.Write("Your choice is: ");
            Console.ResetColor();
        }
    }
}