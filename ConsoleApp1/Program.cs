using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            string file = "tickets.txt";
            string choice;

            do
            {
                Console.WriteLine("1. Read data \n 2. Create file \n 3. Exit");
                choice = Console.ReadLine();

                if(choice == "1")
                {

                    
                    using (StreamReader reader = File.OpenText(file))
                    {
                        string line = "";
                        
                        while ((line = reader.ReadLine()) != null && (line = reader.ReadLine()) != "TicketID,Summary,Status,Priority,Submitter,Assigned,Watching")
                        {

                            Console.WriteLine(line);

                        }
                        Console.WriteLine("");
                        reader.Close();
                    }
                    

                }
                if(choice == "2")
                {
                    StreamWriter writer = new StreamWriter(file);
                    writer.WriteLine("TicketID,Summary,Status,Priority,Submitter,Assigned,Watching");

                    string resp;
                    do
                    {
                        Console.WriteLine("Create a ticket? Y/N");
                        resp = Console.ReadLine();

                        if (resp.ToUpper() == "Y")
                        {
                            Console.WriteLine("Ticket ID:");
                            string id = Console.ReadLine();
                            Console.WriteLine("Summary:");
                            string summary = Console.ReadLine();
                            Console.WriteLine("Status:");
                            string status = Console.ReadLine();
                            Console.WriteLine("Priority:");
                            string priority = Console.ReadLine();
                            Console.WriteLine("Submitter: ");
                            string submitter = Console.ReadLine();
                            Console.WriteLine("Assigned: ");
                            string assigned = Console.ReadLine();
                            Console.WriteLine("Watching: ");
                            string watching = Console.ReadLine();

                            writer.WriteLine("{0},{1},{2},{3},{4},{5},{6}", id, summary, status, priority, submitter, assigned, watching);
                            writer.Close();

                        }
                    } while (resp.ToUpper() == "Y");


                }



            } while (choice == "1" || choice == "2");





        }
    }
}
