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
    public class Service : ISerializable
    {
        public DateOnly DateOfService;

        public decimal serviceTotalPrice { get; set; }

        public decimal getTotalPrice()
        {
            this.calculateTotalPrice();
            return this.serviceTotalPrice;
        }


        public List<ServiceItem> ServiceItems { get; set; }

        public Service(DateOnly date) 
        {
            this.DateOfService = date;
            ServiceItems = new List<ServiceItem>();
            serviceTotalPrice = 0;
        }

        public void addServiceItem(ServiceItem serviceItem)
        {
            ServiceItems.Add(serviceItem);
            calculateTotalPrice();
        }

        public override string? ToString()
        {
            return "Датум на сервис: " + DateOfService + "      Цена  " + serviceTotalPrice;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("DateOfService", DateOfService.ToDateTime(TimeOnly.MinValue));
            info.AddValue("ServiceItems", ServiceItems);
        }

        public Service(SerializationInfo info, StreamingContext context)
        {
            this.DateOfService = DateOnly.FromDateTime(info.GetDateTime("DateOfService"));
            this.ServiceItems = (List<ServiceItem>) info.GetValue("ServiceItems", typeof(List<ServiceItem>));
        }

        private void calculateTotalPrice()
        {
            Decimal totPrice = 0;
            foreach (ServiceItem item in ServiceItems)
            {
                totPrice += item.TotalPrice;
            }
            this.serviceTotalPrice = totPrice;
        }

    }
}
