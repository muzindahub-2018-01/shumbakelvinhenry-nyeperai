using System;
namespace my_project_1
{
    class program
    {
        static void Main(string[] args)
        {

            int option;

            Console.WriteLine("Hello viewer welcome to ZBC tv and radio services");
            Console.WriteLine("Enter 1 to choose tv services");
            Console.WriteLine("Enter 2 to choose radio services");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Welcome to ZBC tv services, Please select the program you would like to watch");

                Console.WriteLine("1.Tunga");
                Console.WriteLine("2.Wenera");
                Console.WriteLine("3.Another Chance");
                Console.WriteLine("4.Pedyo Kure");
                Console.WriteLine("5.Kuchina");
                Console.WriteLine("6.Mawoko Matema");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Tunga will be viewed on Friday at 19:30");
                    Console.ReadLine();
                }

                if (choice == 2)
                {
                    Console.WriteLine("Wenera will be viewed on Monday at 19:30");
                    Console.ReadLine();
                }

                if (choice == 3)
                {
                    Console.WriteLine("Another Chance will be viewed on Friday at 18:30");
                    Console.ReadLine();
                }
                if (choice == 4)
                {
                    Console.WriteLine("Pedyo Kure will be viewed on Monday at 18:00");
                    Console.ReadLine();
                }

                if (choice == 5)
                {
                    Console.WriteLine("Kuchina will be viewed on Tuesday at 19:00");
                    Console.ReadLine();
                }

                if (choice == 6)
                {
                    Console.WriteLine("Mawoko Matema will be viewed on wednesday at 19:02");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Result unknown");
                }



            }

            if (option == 2)
            {
                int choice;
                Console.WriteLine("Welcome to ZBC radio services, Please select the program you would like to watch");

                Console.WriteLine("1.The drive");
                Console.WriteLine("2.The Connection");
                Console.WriteLine("3.The BreakFast Club");
                Console.WriteLine("4.Power Kids");


                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("The drive with Dj Chilli happens every weekday at 3-6");


                }

                if (choice == 2)
                {
                    Console.WriteLine("The Connection with Mrs Rach happens every weekday at 9-12");

                }

                if (choice == 3)
                {
                    Console.WriteLine("The BreakFast Club with Tari and Tafi happens every weekday from 6-9");

                }

                if (choice == 4)
                {
                    Console.WriteLine("Power Kids with Chamvari happens every week day from 2-3");
                }


            }

            else
            {
                Console.WriteLine("Result unknown");
                Console.ReadLine();
            }

            Console.WriteLine("Thank you for choosing ZBC Broadcasting  services");
            Console.ReadLine();
        }
    }
}