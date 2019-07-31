using System;                        //Did in class
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProj {
    public class Membership : SaleCategory {

        public int fee { get; set; }            // fee for membership
        public int units { get; set; }            // sold in units (gives flexibility to sell year or mos allotments)

        public override decimal CalcSales() {           // overrides calcsales in program (use CalcSales in place of class totals
            return fee * units;                          // What if our company gets only half of membership sales (other half goes to insurance comp).  You would divide CalcSales by 2;
        }

        public Membership(int Id, string Name, int Fee, int Units) : base(Id, Name) {
            this.fee = Fee;     // names from parameter list are on left side
            this
       

    }
}
