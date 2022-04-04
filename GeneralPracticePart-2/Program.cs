using GeneralPracticePart_2.Exceptions;
using GeneralPracticePart_2.Models;
using System;

namespace GeneralPracticePart_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            User user = new User("Status");

          
            bool check = true;
            do
          {
            Console.WriteLine("====== Menu ======");
            Console.WriteLine("1. Share status");
            Console.WriteLine("2. Get all statuses");
            Console.WriteLine("3. Get status by id");
            Console.WriteLine("4. Filter status by date ");
            Console.WriteLine("0. Quit");

            string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":   
                    try
                    {

                            Console.WriteLine("Status Title:");
                            string content = Console.ReadLine();
                            Console.WriteLine("Content:");
                            string title = Console.ReadLine();
                            Console.WriteLine($"DateTime:{DateTime.Now.ToString("ss")}");
                            Status status = new Status(title, content);
                            user.ShareStatus(status);
                        }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (CapacityLimitException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                        break;
                    case "2":

                            foreach (var item in user.GetAllStatuses())
                            {
                                item.GetStatusInfo();
                                Console.WriteLine("");
                            }
                        

                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("Id-ni daxil edin");
                            int id = Convert.ToInt32(Console.ReadLine());
                            user.GetStatusById(id).GetStatusInfo();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                       
                        foreach (var item in user.FilterStatusByDate(1, DateTime.Now))
                        {
                            item.GetStatusInfo();
                            
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                        
                    default:
                        Console.WriteLine("Not found!");
                        break;
            }
                } while (check) ;

        }
   }
 }

