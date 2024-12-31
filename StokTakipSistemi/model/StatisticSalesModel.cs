using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.model
{
    internal class StatisticSalesModel
    {
        private int sumOfSalesQuantity;
        private double sumOfSalesPrices;

        public StatisticSalesModel(int sumOfSalesQuantity, double sumOfSalesPrices)
        {
            this.sumOfSalesQuantity = sumOfSalesQuantity;    
            this.sumOfSalesPrices = sumOfSalesPrices;    
        }

        public int getSumOfSalesQuantity() {  return sumOfSalesQuantity; }
        public double getSumOfSalesPrices() {  return sumOfSalesPrices; }
    }
}
