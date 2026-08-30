using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    #region Question 06
    internal class DeliveryCenter
    {
        private Shipment[] ShipmentArray = new Shipment[20];

        public Driver Driver { get; set; }
        private string centerName;

        public string CenterName
        {
            get { return centerName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    centerName = value;
            }
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < ShipmentArray.Length)
                    return ShipmentArray[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < ShipmentArray.Length)
                    ShipmentArray[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (var s in ShipmentArray)
                {
                    if (s != null && s.trackingCode == trackingCode)
                        return s;
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < ShipmentArray.Length; i++)
            {
                if (ShipmentArray[i] == null)
                {
                    ShipmentArray[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < ShipmentArray.Length; i++)
            {
                if (ShipmentArray[i] != null && ShipmentArray[i].trackingCode == trackingCode)
                {
                    ShipmentArray[i] = null;
                    return true;
                }
            }
            return false;
        }

        // Dynamic Binding Call
        public void PrintAllShipments()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            if (Driver != null)
            {
                Console.WriteLine($"Driver : {Driver.FullName}");
            }
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < ShipmentArray.Length; i++)
            {
                if (ShipmentArray[i] != null)
                {
                    ShipmentArray[i].PrintShipment();
                    Console.WriteLine("------------------------------------------");
                }
            }
        }
    }
#endregion
}

