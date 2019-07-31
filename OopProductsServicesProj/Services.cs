using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProj {
    public class Services : SaleCategory {

        public int Rate { get; set; }           // could make private and then use public GET constructor
        public int Hours { get; set; }

        public int ServTotal(int Rate, int Hours) {
            return Rate * Hours;
        }
    }
}
