using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    #region Question 01
    internal class Shipment
    {
        private string TrackingCode;
        private string Description;
        private decimal Weight;
        private decimal DeliveryFee;
        private DeliveryAddress _destination;

        public DeliveryAddress Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public string trackingCode
        {
            get { return TrackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    TrackingCode = value;
            }
        }

        public string description
        {
            get { return Description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    Description = value;
            }
        }

        public decimal wight
        {
            get { return Weight; }
            set
            {
                if (value > 0)
                    Weight = value;
            }
        }

        public decimal deliveryFee
        {
            get { return DeliveryFee; }
            private set
            {
                if (value > 0)
                    DeliveryFee = value;
            }
        }

        // Virtual Property
        public virtual decimal EstimatedCost
        {
            get { return deliveryFee + (wight * 5); }
        }

        // Method Overloading
        public void UpdateWeight(decimal newWeight)
        {
            wight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            wight = newWeight + packingWeight;
        }

        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress())
        {
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            _destination = destination;
        }

        // Virtual Method
        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code   : {trackingCode}");
            Console.WriteLine($"Description     : {description}");
            Console.WriteLine($"Weight          : {wight} KG");
            Console.WriteLine($"Delivery Fee    : {deliveryFee} EGP");
            Console.WriteLine($"Estimated Cost  : {EstimatedCost} EGP");
        }
    }
    #endregion
}

