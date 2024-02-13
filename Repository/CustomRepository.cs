using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataServicePack.Repository
{
    public class CustomRepository
    {
        private readonly string filepath;

        public CustomRepository()
        {
           string text = File.ReadAllText(@"D:\officeproject\DataServicePack\appsettings.json");
           var appsetting = JsonSerializer.Deserialize<Appsetting>(text);

           
            /* filepath = Convert.ToString(customer);*/
             filepath = (appsetting.customerinfofilepath);
        }


        public Customer GetCustomerInfo()

        {
            string text = File.ReadAllText(filepath);
            var customer = JsonSerializer.Deserialize<Customer>(text);          

            return customer;

        }
        public string SetCustomerInfo(Customer customerinfo)
        {
            //string text = File.ReadAllText(filepath);
            var customer = JsonSerializer.Serialize(customerinfo);

            File.WriteAllText(filepath, customer);
            return "";

        }
    }
}
