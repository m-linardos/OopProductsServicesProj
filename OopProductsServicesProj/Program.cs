using System;

namespace OopProductsServicesProj {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            var pBW = new Products(1, "B W", 10, 2500);         //Did in class  




            var sBS     //Did in class  


























            Services SupBasic = new Services();     // Can use 'var' in place of first word 'Services'
            SupBasic.Id = 2;                // Can put values in parens and avoid writing the bottome 4 lines
            SupBasic.Name = "Basic Support";
            SupBasic.Rate = 50;
            SupBasic.Hours = 550;

            Services SupPriority = new Services();
            SupPriority.Id = 2;
            SupPriority.Name = "Priority Support";
            SupPriority.Rate = 100;
            SupPriority.Hours = 750;

            Services Sup247 = new Services();
            Sup247.Id = 3;
            Sup247.Name = "24x7 Support";
            Sup247.Rate = 25;
            Sup247.Hours = 1000;


            Products WidgBasic = new Products();
            WidgBasic.Id = 1;
            WidgBasic.Name = "Basic Widget";
            WidgBasic.Price = 10;
            WidgBasic.Units = 2500;

            Products WidgAdvanced = new Products();
            WidgAdvanced.Id = 1;
            WidgAdvanced.Name = "Advanced Widget";
            WidgAdvanced.Price = 25;
            WidgAdvanced.Units = 1500;

            Products WidgSupreme = new Products();
            WidgSupreme.Id = 1;
            WidgSupreme.Name = "Basic Widget";
            WidgSupreme.Price = 50;
            WidgSupreme.Units = 1000;

            var sales = new SaleCategory[] {                        //Did in class  // Can put new instance directly in array instead of in var
                pBW, pAW, pSW, sBS, sPS, Sup247,

                new Membership(21, "Basic Membership", 100, 500),       
                new Membership(21, "Basic Membership", 100, 500),
                new Membership(21, "Basic Membership", 100, 500)
            };

            SalesCategory sc = new SalesCategory();
            decimal GetSalesTotal = sc.GetSalesTotal();


            Console.WriteLine($"The total revenue for the year is ${GetSalesTotal}");
        }
    }
}


/* INSTRUCTIONS
 * 
 * Sell widgets and connected services.  
 * Time to report earnings - need to tally up revenue from products and services.  
 * Products - id int, Name string, Price decimal, Units int  
 * Services - Id int, Name string, Rate int (rate/hr in whole numbers), 
 *    Hours int (# hrs of service rendered to customers for whole yr
 * Build system with products supplies(price*unit), hours and rate for each service, grand total of each product serv (rate * hr)
 * Total - all prods + services
 * create class prod, serv
 *      Test - create instance of prod like basic widget, advanced and supreme widget/ 
 *      Test - create instance of services - basic, adv, premium
 * similar to banking app
 * What is common between them?  Could replicate name in both of or create a base class (like saletype)
 *      can inherit name for prod and servc
 * */



        }
    }
}
