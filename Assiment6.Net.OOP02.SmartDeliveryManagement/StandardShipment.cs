using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment6.Net.OOP02.SmartDeliveryManagement
{
    internal class StandardShipment:Shipment
    {
        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        #region Constructor

        // Create a constructor that initializes
        // all inherited members using
        // constructor chaining.

        public StandardShipment(string trackingCode, string description,
            decimal weight, decimal deliveryFee, DeliveryAddress Destination)
            : base(trackingCode,description,weight,deliveryFee, Destination)
        {
        }
        #endregion
        // ==========================================
        // Methods
        // ==========================================

        #region Methods
        override public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} Kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");

        }
        #endregion

    }
}
