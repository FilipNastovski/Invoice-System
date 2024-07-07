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
    public class Customer : ISerializable
    {
        public String Name { get; set; }
        public String  LastName { get; set; }

        public List<Motorcycle> Motorcycles { get; set; }

        //Maybe unnececary, service history can be read from client's motorcycles
        public List<Service> ServiceHistory { get; set; }

        public Customer(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            Motorcycles = new List<Motorcycle>();
            ServiceHistory = new List<Service>();
        }

        public void addMotorcycle(Motorcycle motorcycle)
        {
            Motorcycles.Add(motorcycle);
        }

        public override string? ToString()
        {
            return Name + " " + LastName;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", Name);
            info.AddValue("lastName", LastName);
            info.AddValue("Motorcycles", Motorcycles);
        }

        public Customer(SerializationInfo info, StreamingContext context)
        {
            this.Name = info.GetString("name");
            this.LastName = info.GetString("lastName");
            this.Motorcycles = (List<Motorcycle>)info.GetValue("Motorcycles", typeof(List<Motorcycle>));
        }
    }
}
