
using DataServicePack;
using DataServicePack.Repository;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Datapack 
{
    static void Main(string[] args)
    {


        CustomRepository customerrepository = new CustomRepository(); //object creation
        var customerinfo = customerrepository.GetCustomerInfo(); //function calling

       

        Console.WriteLine("USSD Code");
        Begin:
        String Dial = Console.ReadLine();

        if (Dial == "*1415#")
        {
            First:
            Console.WriteLine("Carrier Info");
            Console.WriteLine("1)AUTUMN");
            Console.WriteLine("2)Prepaid Packs");
            Console.WriteLine("3)Unlimited Night Data");
            Console.WriteLine("4)Voice");
            Console.WriteLine("5)4G");
            Console.WriteLine("6)6GB/Day");
            Console.WriteLine("7)INT-SERVICES");
            Console.WriteLine("8)UNLIMITED");
            Console.WriteLine("9)Day Packs");
            Console.WriteLine("10)StayConnected");

            int Pack = Convert.ToInt32(Console.ReadLine());

            switch (Pack)
            {
                /* case 1:
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
                     String number =(Console.ReadLine());

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
                         case "2":
                         Nightdatapack:
                             Console.WriteLine("**********Carrier info**********");
                             Console.WriteLine("Night Data Pack");
                             Console.WriteLine("1)Unlimited");
                             Console.WriteLine("**-back *#-main");

                             String Nightdata = Console.ReadLine();
                             switch (Nightdata)
                             {
                                 case "1":
                                     {
                                         Nightdata:
                                         Console.WriteLine("*********Carrier info**********");
                                         Console.WriteLine("1)1Night@Rs20");
                                         Console.WriteLine("**-back *#-main");


                                         String Night1 = Console.ReadLine();

                                         switch(Night1) 
                                         {
                                             case "1":
                                                 {
                                                     int chargeof1 = 20;
                                                     if (customerinfo.balance >= chargeof1)
                                                     {
                                                         customerinfo.balance -= chargeof1;
                                                         Console.WriteLine("successfull");
                                                         var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);
                                                     }
                                                     else
                                                         Console.WriteLine("----------insufficient balance---------");
                                                     goto Nightdata;
                                                 }break;
                                             case "#":
                                                 {
                                                     goto Nightdatapack;
                                                 }break;
                                         }

                                     } 
                                     break;
                                 case "#":
                                     goto Autumn;
                                     break;
                             }
                             break;
                         case "3":
                             NIGHTDATAUNLIMITED:
                             Console.WriteLine("**********Carrier info***********");
                             Console.WriteLine("NIGHT DATA UNLIMITED(11pm-6am");
                             Console.WriteLine("1)1Night@Rs20");
                             Console.WriteLine("**-back *#-main");

                             string nightdataunlimited =Console.ReadLine();
                             switch (nightdataunlimited)
                             {
                                 case "1":
                                     {
                                         float chargeof1 = 20;
                                         if(customerinfo.balance>=chargeof1)
                                         {
                                             customerinfo.balance-=chargeof1;
                                             Console.WriteLine("Successfull");
                                             Console.WriteLine(customerinfo.balance);
                                             var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);

                                         }
                                         else
                                         {
                                             Console.WriteLine("---------insufficient balance ------------");
                                             goto NIGHTDATAUNLIMITED;
                                         }
                                     }
                                     break;
                                 case "#":
                                     {
                                         goto Autumn;
                                     }break;
                             }break;
                         case "4":
                             SMS:
                             Console.WriteLine("**********Carrier info***********");
                             Console.WriteLine("SMS Offer");
                             Console.WriteLine("1)100-AllNet@Rs15-1Day");
                             Console.WriteLine("2)200-AllNet@Rs29-3Days");
                             Console.WriteLine("3)300-AllNet@Rs98-28Days");

                             Console.WriteLine("**-back *#-main");

                             string smsselect =Console.ReadLine();
                             switch(smsselect)
                             {
                                 case "1":
                                     {
                                         int chargeof1 = 15;
                                         if (customerinfo.balance >= chargeof1)
                                         {
                                             Console.WriteLine("Succesfull");
                                             customerinfo.balance -= chargeof1;
                                             Console.WriteLine(customerinfo.balance);

                                             var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);

                                         }
                                         else
                                         {
                                             Console.WriteLine("---------insufficient balance-----------");
                                             goto SMS;

                                         }
                                     }
                                     break;
                                  case "2":
                                     {
                                         int chargeof2 = 29;
                                         if(customerinfo.balance>= chargeof2)
                                         {
                                             Console.WriteLine("Successfull");
                                             customerinfo.balance -= chargeof2;
                                             Console.WriteLine(customerinfo.balance);

                                             var setcustomerinfo =customerrepository.SetCustomerInfo(customerinfo);  

                                         }else
                                         {
                                             Console.WriteLine("-----------insufficient balance--------");
                                             goto SMS;
                                         }   
                                     }break;
                                   case "3":
                                     {
                                         int chargeof3 = 98;
                                         if (customerinfo.balance >= chargeof3)
                                         {
                                             Console.WriteLine("succesfull");
                                             customerinfo.balance -= chargeof3;
                                             Console.WriteLine(customerinfo.balance);

                                             var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);
                                         }
                                         else
                                         {
                                             Console.WriteLine("-----------insufficient balance--------");
                                             goto SMS;
                                         }
                                     }break;
                                    case "#":
                                     {
                                         goto Autumn;
                                     }

                         }break;     
                         case "5":
                             EcoVoice:
                             Console.WriteLine("**********Carrier info***********");
                             Console.WriteLine("Eco Voice");
                             Console.WriteLine("1)110Min/Day@Rs95-7Days");
                             Console.WriteLine("2)110Min/Day@Rs375-28Days");
                             Console.WriteLine("**-back*#-main");

                             string ecovoiceselect = Console.ReadLine();

                             switch (ecovoiceselect)
                             {
                                 case "1":
                                     {
                                         int chargeof1 = 95;
                                         if (customerinfo.balance >= chargeof1) 
                                         {
                                             Console.WriteLine("Successfull");
                                             customerinfo.balance -= chargeof1;
                                             Console.WriteLine(customerinfo.balance);

                                             var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);
                                         }
                                         else
                                         {
                                             Console.WriteLine("-----insufficient-------");
                                             goto EcoVoice;
                                         }
                                     }break;
                                 case "2":
                                     {
                                         int chargeof2 = 375;
                                         if(customerinfo.balance >=chargeof2)
                                         {
                                             Console.WriteLine("Succesfull");
                                             customerinfo.balance -= chargeof2;      
                                             Console.WriteLine(customerinfo.balance);

                                             var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);

                                         }
                                         else
                                         {
                                             Console.WriteLine("-------insufficient------");
                                             goto EcoVoice;
                                         }
                                     }break;
                                 case "#":
                                     {
                                         goto Autumn;
                                     }break;
                             }break;
                         case "6":
                         RecurringData:
                             Console.WriteLine("**********Carrier info**********");
                             Console.WriteLine("Recurring Data");
                             Console.WriteLine("1)700MB/Day@Rs299-28Days");
                             Console.WriteLine("**-back *#-main");

                             string recurringdataselect = Console.ReadLine();    

                             switch(recurringdataselect)
                             {
                                 case "1":
                                     {
                                         int chargeof1 = 299;
                                         if(customerinfo.balance>=chargeof1)
                                         {
                                             Console.WriteLine("Successfull");
                                             customerinfo.balance -= chargeof1;  
                                             Console.WriteLine(customerinfo.balance);

                                             var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);
                                         }
                                         else
                                         {
                                             Console.WriteLine("---------insufficient balance-------");
                                             goto RecurringData;
                                         }
                                     }break;
                                 case "#":
                                     {
                                         goto Autumn;
                                     }
                             }
                             break;
                         case "7":
                             UnlimitedFbYoutube:
                                 Console.WriteLine("********Carrier info ********");
                                 Console.WriteLine("Unlimited Fb/YouTube");
                                 Console.WriteLine("1)Unlimited-Facebook@Rs55-3Days");
                                 Console.WriteLine("2)Unlimited-Youtube@Rs55-3Days");
                                 Console.WriteLine("3)1.5GB-Youtube-AddOn@Rs15-3Days");
                                 Console.WriteLine("4)1.5GB-Fb-AddOn@Rs15-3Days");
                                 Console.WriteLine("**-back *#-main");

                                 string UnlimitedFbYoutubeSelect = Console.ReadLine();   

                                 switch(UnlimitedFbYoutubeSelect)
                                 {
                                     case "1":
                                         {
                                             int chargeof1 = 55;
                                             if(customerinfo.balance>=chargeof1)
                                             {
                                                 Console.WriteLine("Successfull");
                                                 customerinfo.balance -= chargeof1;
                                                 Console.WriteLine(customerinfo.balance);

                                                 var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);
                                             }
                                             else
                                             {
                                             Console.WriteLine("---------insufficient balance---------");
                                             goto UnlimitedFbYoutube;
                                             }
                                         }break;
                                     case "2":
                                         {
                                             int chargeof2 = 55;
                                             if(customerinfo.balance>=chargeof2)
                                             {
                                                 Console.WriteLine("Successfull");
                                                 customerinfo.balance -= chargeof2;
                                                 Console.WriteLine(customerinfo.balance);

                                                 var setcustomerinfo = customerrepository.SetCustomerInfo(customerinfo);
                                             }
                                             else
                                             {
                                                 Console.WriteLine("----------insufficient balance--------");
                                                 goto UnlimitedFbYoutube;
                                             }
                                         }break;
                                 }break;
                         case "#":
                         goto First;
                     }break;*/
                case 1:
                    Autumn autumn = new Autumn();
                    autumn.Autumndetails();
                    break;
                case 2:
                    Console.WriteLine("Prepaid Packs");
                    break;
                case 3:
                    Console.WriteLine("Unlimited Night Data");
                    break;
                case 4:
                    Console.WriteLine("Voice");
                    Voice voice = new Voice();
                    voice.Voicedetails();
                    break;
                case 5:
                    Console.WriteLine("4G");
                    break;
                case 6:
                    Console.WriteLine("6GB/Day");
                    break;
                case 7:
                    Console.WriteLine("INT-SERVICES");
                    break;
                case 8:
                    Console.WriteLine("UNLIMITED");
                    break;
                case 9:
                    Console.WriteLine("Day Packs");
                    break;
                case 10:
                    Console.WriteLine("StayConnected");
                    break;
            }
        }
        else
            Console.WriteLine("Incorrect");
        goto Begin;
    }
}
