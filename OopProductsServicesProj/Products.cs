using System;/
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProj {
    class Products : SaleCategory {

        public decimal Price;
        public int Units;

        public decimal ProdTotal(decimal Price, int Units) {
            return Price * Units;
        }

       
        }
    }
}
