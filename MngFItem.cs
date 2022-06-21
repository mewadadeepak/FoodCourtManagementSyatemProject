using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FoodCourt__Management___System
    {
        public class MngFItem : CommonFLD
        {
            private ArrayList arrayList = new ArrayList();
            public void PerformAction()
            {
            AgainAndAgain:
                menu();
                int choise = Convert.ToInt32(System.Console.ReadLine());
                switch (choise)
                {
                    case 1:
                    addmore:
                        Console.Write(" Enter the new food item id ");
                        int newfoodid = Convert.ToInt32(System.Console.ReadLine());
                        Console.Write("Enter the new food item name ");
                        string newfoodname = Console.ReadLine();
                        Console.Write("Enter the food's Category");
                        string catname = Console.ReadLine();
                        Console.WriteLine("Enter Per Plate price ");
                        int newfoodprice = Convert.ToInt32(Console.ReadLine());


                        string date = DateTime.Now.ToString();
                        arrayList.Add(newfoodid);
                        arrayList.Add(newfoodname);
                        arrayList.Add(catname);
                        arrayList.Add(newfoodprice);
                        arrayList.Add(date);
                        AddnewItem(@"C:\Training\DotNetTraining\FoodCourt__Management___System\fooditem.txt", arrayList);
                        arrayList.Clear();
                        Console.Write(" Do you Want more Press 1:");
                        int check = Convert.ToInt32(Console.ReadLine());
                        if (check == 1)
                        {
                            goto addmore;
                        }
                        goto AgainAndAgain;
                    case 2:
                        Console.Write("Enter the food item's id To Show Of Its Details : ");
                        int showcatid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the food item's name To Show Of Its Details : ");
                        string showcatname = Console.ReadLine();
                        ViewDetailsOfItems(showcatid, showcatname, @"C:\Training\DotNetTraining\FoodCourt__Management___System\fooditem.txt");
                        goto AgainAndAgain;
                    case 3:
                        ListAllItem(@"C:\Training\DotNetTraining\FoodCourt__Management___System\fooditem.txt");
                        goto AgainAndAgain;
                    case 4:
                    updatemore:
                        Console.Write("Enter the   Food item id To update Of Its Details : ");
                        int updatefoodid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the  food item name To update Of Its Details : ");

                        string updatefoodname = Console.ReadLine();
                        ViewDetailsOfItems(updatefoodid, updatefoodname, @"C:\Training\DotNetTraining\FoodCourt__Management___System\fooditem.txt");
                        Console.Write("Enter the new Name Of its Above Food items : ");
                        string updatename = Console.ReadLine();
                        Console.Write("Update the Food' category item name ");
                        string updatefoodcat = Console.ReadLine();
                        Console.Write(" Update The food /plate Price ");
                        int prc = Convert.ToInt32(Console.ReadLine());
                        string date2 = DateTime.Now.ToString();
                        arrayList.Add(updatefoodid);
                        arrayList.Add(updatename);
                        arrayList.Add(updatefoodcat);
                        arrayList.Add(prc);
                        arrayList.Add(date2);

                        UpdateExistItem(updatefoodid, updatefoodname, arrayList, @"C:\Training\DotNetTraining\FoodCourt__Management___System\fooditem.txt");
                        arrayList.Clear();
                        Console.Write(" Do you Want more Press 1:");
                        int check2 = Convert.ToInt32(Console.ReadLine());
                        if (check2 == 1)
                        {
                            goto updatemore;
                        }
                        goto AgainAndAgain;



                    case 5:
                        break;
                    default:
                        Console.WriteLine(" wrong Choise ");
                        goto AgainAndAgain;
                }

            }
          private void menu()
            {

                Console.WriteLine("Press 1 : To Add New food Item ");
                Console.WriteLine("Press 2 : To the Show Details Of food items ");
                Console.WriteLine("Press 3 : To the Show List Of All food itms ");
                Console.WriteLine("Press 4 : To Update The Exist food item ");
                Console.WriteLine("Press 5 : To Close);
                Console.Write(" ");
            }

        }
    }