using DataServicePack.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServicePack
{
    public class Autumn
    {
        public string Autumndetails()

        {

            CustomRepository customerrepository = new CustomRepository(); //object creation
            var customerinfo = customerrepository.GetCustomerInfo();

        Autumn:
            Console.WriteLine("**********Carrier info**********");
            Console.WriteLine("AUTUMN");
            Console.WriteLine("1)All Time");
            Console.WriteLine("2)Night Data(11pm-6am");
            Console.WriteLine("3)Night Voice");
            Console.WriteLine("4)SMS");
            Console.WriteLine("5)Eco Voice");
            Console.WriteLine("6)Recurring Data");
            Console.WriteLine("7)Unlimited FB/YouTube");
            Console.WriteLine("**-back*#-main");
            String number = (Console.ReadLine());

            switch (number)
            {
                case "1":
                Alltime:
                    Console.WriteLine("**********Carrier info**********");
                    Console.WriteLine("ALL TIME");
                    Console.WriteLine("1)200MB@Rs15-1Day");
                    Console.WriteLine("2)500MB@Rs25-1Day");
                    Console.WriteLine("3)2.5GB@Rs75-3Days");
                    Console.WriteLine("4)2.5GB@Rs95-7Days");
                    Console.WriteLine("5)5GB@Rs290-28Days");
                    Console.WriteLine("6)20GB@Rs500-28Daya");
                    Console.WriteLine("7)35GB@Rs800-28Days");
                    Console.WriteLine("**-back *#-main");
                    String AllTIME = (Console.ReadLine());

                    switch (AllTIME)
                    {
                        case "1":
                            int Chargeof1 = 15;
                            if (customerinfo.balance >= Chargeof1)
                            {
                                Console.WriteLine("Successfull");
                                customerinfo.balance -= Chargeof1;
                                Console.WriteLine(customerinfo.balance);

                                var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);

                            }
                            else
                                Console.WriteLine("-----------insufficient Balance-----------");
                            Console.WriteLine(customerinfo.balance);
                            goto Alltime;
                            break;
                        case "2":
                            int chargeof2 = 25;
                            if (customerinfo.balance >= chargeof2)
                            {
                                Console.WriteLine("Successfull");
                            }
                            else
                                Console.WriteLine("-----------insufficient Balance-----------");
                            goto Alltime;
                            break;
                        case "3":
                            int chargeof3 = 75;
                            if (customerinfo.balance >= chargeof3)
                            {
                                Console.WriteLine("Successfull");
                            }
                            else
                                Console.WriteLine("-----------insufficient Balance-----------");
                            goto Alltime;
                            break;
                        case "4":
                            int chargeof4 = 95;
                            if (customerinfo.balance >= chargeof4)
                            {
                                Console.WriteLine("Successfull");
                            }
                            else
                                Console.WriteLine("-----------insufficient Balance-----------");
                            goto Alltime;
                            break;
                        case "5":
                            int chargeof5 = 290;
                            if (customerinfo.balance >= chargeof5)
                            {
                                Console.WriteLine("Successfull");
                            }
                            else
                                Console.WriteLine("-----------insufficient Balance-----------");
                            goto Alltime;
                            break;
                        case "6":
                            int chargeof6 = 500;
                            if (customerinfo.balance >= chargeof6)
                            {
                                Console.WriteLine("Successfull");
                            }
                            else
                                Console.WriteLine("-----------insufficient Balance-----------");
                            goto Alltime;
                            break;
                        case "7":
                            int chargeof7 = 800;
                            if (customerinfo.balance >= chargeof7)
                            {
                                Console.WriteLine("Successfull");
                            }
                            else
                                Console.WriteLine("-----------insufficient Balance-----------");
                            goto Alltime;
                            break;
                        case "#":
                            {
                                goto Autumn;
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("-------invalid inputs---------");
                                goto Alltime;
                            }
                            break;


                    }
                    break;
                case "#":
                    {
                        goto Autumn;
                    }break;
                    
            }
            return "";
        }
        public string Sahan()
        {
            return "";
        }
    }
}
