using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourt__Management___System
{
        public class ReportsOfFoodCourt : CommonFLD
        {
            public void performAction()
            {
            upper:
                menu();
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        ListAllItem(@"C:\Training\DotNetTraining\FoodCourt__Management___System\fooditem.txt");
                        goto upper;
                    case 2:
                        ListAllItem(@"C:\Training\DotNetTraining\FoodCourt__Management___System\category.txt");
                        goto upper;
                    case 3:
                        ListAllItem(@"C:\Training\DotNetTraining\FoodCourt__Management___System\sales.txt");
                        goto upper;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Wrong Choise ");
                        goto upper;

                }


            }
            private void menu()
            {
                Console.WriteLine("Press a : for The Show Reports Of Food Items ");
                Console.WriteLine("Press b : for the Show Reports of food category ");
                Console.WriteLine("Press c : for the Show Reports of sales");

                Console.WriteLine("Press d : Goto OutSide");
                Console.Write("                                                     ");
            }
        }
    }