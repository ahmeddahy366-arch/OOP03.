using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    #region Question 04
    internal class InternationalShipment :Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destinationCountry, decimal customsFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override decimal EstimatedCost  
        {
            get { return base.EstimatedCost + customsFee; }
        }

        // Full Override PrintShipment with extra fields
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Tracking Code       : {trackingCode}");
            Console.WriteLine($"Description         : {description}");
            Console.WriteLine($"Weight              : {wight} KG");
            Console.WriteLine($"Delivery Fee        : {deliveryFee} EGP");
            Console.WriteLine($"Destination Country : {destinationCountry}");
            Console.WriteLine($"Customs Fee         : {customsFee} EGP");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating customs report...");
        }
    }
           #endregion

}
