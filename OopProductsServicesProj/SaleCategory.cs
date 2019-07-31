using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProj {
    public class SaleCategory {

        public int Id { get; set; }
        public string Name /*{ get; set; }*/;



        /*public int CatTotal(int Rate, int Hours) {
            return Rate * Hours;
        }
        */
        public decimal GetSalesTotal(int ServTotal, decimal ProdTotal) {            
            return ServTotal * ProdTotal;
        }










        //SalesCategory[] SalesCategories = new SalesCategory[] {serv1, prod1}

        ////public decimal CatTotal(decimal total1, decimal total2) {        /////// bad start
        ////    foreach (SalesCategory sc in SalesCategories) {
        //        return total1 * total2;
        //    }

    }
}
