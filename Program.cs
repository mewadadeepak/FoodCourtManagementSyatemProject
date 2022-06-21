using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourt__Management___System
{
        internal class Program
        {
            private static void menu()
            {
                
            Console.WriteLine("!!!!!!!!!*********WELCOME TO FOOD COURT MANAGEMENT SYSTEM********!!!!!!!!!!!");
                Console.WriteLine("@Please Choose The Following Below Option from 1 to 4  If You Want to Process Ahead otherwise press 0 for exist ");
                Console.WriteLine("Press 1 : To  Manage Food Items");
                Console.WriteLine("Press 2 : To  Manage the Category ");
                Console.WriteLine("Press 3 : To  Manage the sales");
                Console.WriteLine("Press 4 : To  Reports Of The Food Court Manag System");

                Console.WriteLine("Press 5 : To Exit");
                Console.Write("   ");
            }
            static void Main(string[] args)
            {
                MngFCategory manageFoodCategory = new MngFCategory();
                MngSals manageSales = new MngSals();
                MngFItem manageFoodItems = new MngFItem();
                ReportsOfFoodCourt reportsOffoodcourt = new ReportsOfFoodCourt();

            mainmenu:
                menu();


                int choisedata = Convert.ToInt32(Console.ReadLine());
                switch (choisedata)
                {
                    case 1:
                        manageFoodItems.PerformAction();
                        goto mainmenu;
                    case 2:
                        manageFoodCategory.PerformAction();
                        goto mainmenu;
                    case 3:
                        manageSales.PerformAction();
                        goto mainmenu;
                    case 4:
                        reportsOffoodcourt.performAction();
                        goto mainmenu;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect choise");
                        goto mainmenu;

                }

                Console.ReadLine();
            }
        }
    }
