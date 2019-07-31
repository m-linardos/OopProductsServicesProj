using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProj {
    class Services : SaleCategory {

        public int Rate;
        public int Hours;

        public int ServTotal(int Rate, int Hours) {
            return Rate * Hours;
        }
    }
}
