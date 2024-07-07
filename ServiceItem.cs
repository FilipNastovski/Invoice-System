using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Invoice_System
{
    [Serializable]
    public class ServiceItem : ISerializable
    {
        public String Description { get; set; }

        public String MeasurementUnit { get; set; }
        public decimal Quantity { get; set; }

        public decimal PricePerUnit { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal LaborCost{ get; set; }

        public String Tax { get; set; }

        public ServiceItem(string description, String MeasurementUnit, decimal quantity, decimal pricePerUnit, decimal LaborCost, String Tax) 
        {
            this.Description = description;
            this.MeasurementUnit = MeasurementUnit;
            this.Quantity = quantity;
            this.PricePerUnit = pricePerUnit;
            this.LaborCost = LaborCost;
            this.TotalPrice = Decimal.Multiply(pricePerUnit, quantity);
            this.Tax = Tax;
            switch (Tax)
            {
                case "18%":
                    TotalPrice = Decimal.Multiply(TotalPrice, 1.18m);
                    break;
                case "10%":
                    TotalPrice = Decimal.Multiply(TotalPrice, 1.10m);
                    break;
                case "5%":
                    TotalPrice = Decimal.Multiply(TotalPrice, 1.05m);
                    break;
                case "0%":
                    break;
                default:
                    MessageBox.Show("Данокот не е внесен правилно");
                    break;
            }
            this.TotalPrice += LaborCost;
        }

        public override string ToString()
        {
            return $"Опис: {Description}\t" +
                   $"ЕМ: {MeasurementUnit}\t" +
                   $"Кол: {Quantity}\t" +
                   $"Цена парче: {PricePerUnit:C}\t" +
                   $"Вкупно: {TotalPrice:C}\t" +
                   $"Рабат: {LaborCost:C}\t" +
                   $"Данок: {Tax}\t";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Description",Description);
            info.AddValue("MeasurementUnit",MeasurementUnit);
            info.AddValue("Quantity",Quantity);
            info.AddValue("PricePerUnit",PricePerUnit);
            info.AddValue("TotalPrice",TotalPrice);
            info.AddValue("LaborCost",LaborCost);
            info.AddValue("Tax", Tax);
        }

        public ServiceItem(SerializationInfo info, StreamingContext context)
        {
            this.Description = info.GetString("Description");
            this.MeasurementUnit = info.GetString("MeasurementUnit");
            this.Quantity = info.GetDecimal("Quantity");
            this.PricePerUnit = info.GetDecimal("PricePerUnit");
            this.TotalPrice = info.GetDecimal("TotalPrice");
            this.LaborCost = info.GetDecimal("LaborCost");
            this.Tax = info.GetString("Tax");
        }
    }
}
