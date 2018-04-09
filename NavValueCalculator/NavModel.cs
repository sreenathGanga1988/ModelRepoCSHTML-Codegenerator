using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavValueCalculator
{
    public  class NavModel
    {
       
        public Decimal totalspendofday { get; set; }
        public Decimal totalQty { get; set; }
        public Decimal totalValue { get; set; }
        public Decimal Purchaseprice { get; set; }
        public Decimal Sellablevalue { get; set; }

        public Decimal DailyBankCharge { get; set; }

        public Decimal BankFixedCharge { get; set; }
        public Decimal BankGST { get; set; }

        public Decimal BankChargeforCurrentTransaction { get; set; }



        public Decimal BrokerageTax { get; set; }
        public Decimal BrokeragePercent { get; set; }
        public Decimal TotalBrockerage { get; set; }


        public Decimal TotalCumulativeValue { get; set; }
        public Decimal Totalvalueatpurchasre { get; set; }

        public Decimal MinimumSellablevalue { get; set; }

        public Decimal BrockerageAtSelling { get; set; }

    }
}
