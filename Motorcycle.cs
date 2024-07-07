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
    public class Motorcycle : ISerializable
    {
        public String Model { get; set; }

        public int Year { get; set; }

        public int Kilometers { get; set; }

        public List<Service> ServiceHistory{ get; set; }

        public Motorcycle(string model, int year, int kilometers)
        {
            Model = model;
            Year = year;
            Kilometers = kilometers;
            ServiceHistory = new List<Service>();
        }

        public override string? ToString()
        {
            return Model + ", " + Year + ", " + Kilometers;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Model", Model);
            info.AddValue("Year", Year);
            info.AddValue("Kilometers", Kilometers);
            info.AddValue("ServiceHistory", ServiceHistory);
        }

        public Motorcycle(SerializationInfo info, StreamingContext context)
        {
            this.Model = info.GetString("Model");
            this.Year = info.GetInt32("Year");
            this.Kilometers = info.GetInt32("Kilometers");
            this.ServiceHistory = (List<Service>) info.GetValue("ServiceHistory", typeof(List<Service>));
            
        }
    }
}
