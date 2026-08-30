using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    #region Question 03
    internal class ExpressShipment:Shipment
    {
        private decimal express;

        public decimal Express
        {
            get { return express; }
            set
            {
                if (value >= 0)
                    express = value;
            }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, decimal express, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            Express = express;
        }

        // Override EstimatedCost: DeliveryFee + (Weight * 5) + ExtraFee
        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + Express; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Tracking Code   : {trackingCode}");
            Console.WriteLine($"Description     : {description}");
            Console.WriteLine($"Weight          : {wight} KG");
            Console.WriteLine($"Delivery Fee    : {deliveryFee} EGP");
            Console.WriteLine($"Extra Fee       : {express} EGP");
            Console.WriteLine($"Estimated Cost  : {EstimatedCost} EGP");
        }
    }
                      #endregion
}

