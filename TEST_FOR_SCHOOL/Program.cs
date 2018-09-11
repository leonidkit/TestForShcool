using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_FOR_SCHOOL
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            int numb;

            List<Obj> dataList = new List<Obj>();
            do
            {
                Console.WriteLine("1. Print data\n2. Add Item\n3. Remove Item\nQ. Exit\n\n");
                cki = Console.ReadKey(true);

                switch (cki.Key.ToString())
                {
                    case "D1":
                        if (dataList.Count != 0)
                        {
                            int count = 1;

                            foreach (Obj objItem in dataList)
                            {
                                Console.Write(count++ + ". ");
                                Console.WriteLine(objItem.ToString());
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("\nNothing to print...");
                        }
                        break;

                    case "D2":
                        Console.WriteLine("\n1. Add Person\n2. Add Car\n3. Add Message\nQ. Exit\n");
                        ConsoleKeyInfo ckiInto;
                        bool flag = true;
                        do
                        {
                            ckiInto = Console.ReadKey(true);
                            if(ckiInto.Key.ToString() == "Q") break;

                            switch (ckiInto.Key.ToString())
                            {
                                case "D1":
                                    Person prsn = new Person();

                                    Console.Write("\nFirst Name: ");
                                    prsn.FirstName = Console.ReadLine();

                                    Console.Write("\nLast Name: ");
                                    prsn.LastName = Console.ReadLine();

                                    Console.Write("\nAge: ");
                                    if(!Int32.TryParse(Console.ReadLine(), out numb))
                                    {
                                        Console.WriteLine("Enter a number, please!");
                                        break;
                                    }
                                    else
                                    {
                                        if(numb > 110 || numb < 4)
                                        {
                                            Console.WriteLine("You can`t use it!");
                                            break;
                                        }
                                        prsn.Age = numb;
                                    }

                                    dataList.Add(prsn);
                                    flag = false;
                                    break;
                                case "D2":
                                    Car cr = new Car();

                                    Console.Write("\nModel: ");
                                    cr.ModelCar = Console.ReadLine();

                                    Console.Write("\nCar Year: ");
                                    if (!Int32.TryParse(Console.ReadLine(), out numb))
                                    {
                                        Console.WriteLine("Enter a number, please!");
                                        break;
                                    }
                                    else
                                    {
                                        if(numb < 1806 || numb >2018)
                                        {
                                            Console.WriteLine("Car has never been!");
                                            break;
                                        }
                                        cr.ReleaseYear = numb;
                                    }

                                    dataList.Add(cr);
                                    flag = false;
                                    break;
                                case "D3":
                                    Message msg = new Message();

                                    Console.Write("\nMessage: ");
                                    msg.Msg = Console.ReadLine();

                                    dataList.Add(msg);
                                    flag = false;
                                    break;
                            }
                        } while (flag);
                        
                        break;

                    case "D3":
                        Console.WriteLine("\nRemove(Enter a number of position, please): ");
                        if (!Int32.TryParse(Console.ReadLine(), out numb))
                        {
                            Console.WriteLine("Enter a number, please!");
                            break;
                        }
                        else
                        {
                            dataList.Remove(dataList[numb - 1]);
                        }
                        break;
                }
            } while (cki.Key.ToString() != "Q");
        }
    }
}
