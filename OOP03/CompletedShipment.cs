using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    #region Question 08

    internal class CompletedShipment:Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment (Sealed Class)");
            base.PrintShipment();
        }
    }
}
    #endregion
