using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_System
{
    public class Invoice
    {
        private int ID;
        private DateOnly date;
        private int paymentDays;
        private string receiver;
        private Service service;


        public Invoice(int ID, DateOnly date, int paymentDays, string receiver, Service service)
        {
            this.ID = ID;
            this.date = date;
            this.paymentDays = paymentDays;
            this.receiver = receiver;
            this.service = service;
        }



    }
}
