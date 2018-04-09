using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavValueCalculator
{
    public class CalculateRepo
    {

        public NavModel CalculateNav(NavModel model)
        {




            model.BankFixedCharge = 100;
            model.BankGST = 18;
            model.BrokeragePercent = 5;
            model.BrokerageTax = 25;



           model.DailyBankCharge = (model.BankFixedCharge + (model.BankFixedCharge * (model.BankGST / 100)));
            model.BankChargeforCurrentTransaction = model.totalValue * (model.DailyBankCharge / model.totalspendofday);


            
            model.TotalBrockerage = calcualteBrockerage(model.totalValue, model.BrokeragePercent, model.BrokerageTax);        
            model.TotalCumulativeValue = model.TotalBrockerage + model.BankChargeforCurrentTransaction + model.totalValue;
            model.Totalvalueatpurchasre = model.TotalCumulativeValue / model.totalQty;

            Decimal totalatselling = model.Totalvalueatpurchasre * model.totalQty;
            model.BrockerageAtSelling = calcualteBrockerage(totalatselling, model.BrokeragePercent, model.BrokerageTax);

            model.MinimumSellablevalue = (totalatselling + model.BrockerageAtSelling) / model.totalQty;
            return model;
        }


        public decimal calcualteBrockerage( Decimal Totalvalue, Decimal BrokeragePercent, Decimal BrokerageTax)
        {
            Decimal totalvalue = (Totalvalue * (BrokeragePercent / 1000));
            totalvalue = totalvalue+( totalvalue * (BrokerageTax / 100));
            return totalvalue;
        }
   

    }
}
