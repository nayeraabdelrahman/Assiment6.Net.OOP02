using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment6.Net.OOP02.SmartDeliveryManagement
{
        class Shipment
        {
            string trackingCode;
            string description;
            decimal weight;
            decimal deliveryFee;
            // Destination Property-Type: DeliveryAddress
            // Public get and set.
            public DeliveryAddress Destination { get; set; }

            // ==========================================
            // PROPERTIES
            // ==========================================

            #region Properties
            public string TrackingCode
            {
                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        trackingCode = value;
                    }
                }
                get { return trackingCode; }
            }

            // Description Property Public get and set.
            // Description cannot be: null-empty-whitespace
            //If invalid: Keep the previous valid value.
            public string Description
            {
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        description = value;
                    }
                }
                get { return description; }
            }

            // Weight Property:Public get and set.
            // Weight must be greater than 0.
            // If invalid: Keep the previous valid value.
            public decimal Weight
            {
                set
                {
                    if (value > 0)
                    {
                        weight = value;
                    }
                }
                get { return weight; }
            }

            // DeliveryFee PropertyPublic getter-Private setter.
            // DeliveryFee must be greater than 0.
            public decimal DeliveryFee
            {
                private set
                {
                    if (value > 0)
                    {
                        deliveryFee = value;
                    }
                }
                get { return deliveryFee; }
            }

            // EstimatedCost Read-only calculated property.
            // Return:DeliveryFee + (Weight * 5)
            virtual public decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5);
                }

            }
        #endregion
        // ==========================================
        // CONSTRUCTORS
        // ==========================================

        #region Constructors

        // Constructor 1 -Receives:trackingCode
        // Default values:Description = "Unknown"-Weight = 1-DeliveryFee = 50-Destination = default
            public Shipment():this("Unknown","Unknown",1,50.0m,default)
            {

            }
            public Shipment(string trackingCode) : this(trackingCode,"Unknown", 1,50.0m, default)
            {

            }

            // Constructor 2-
            // Receives: trackingCode-description-weight-deliveryFee-destination
            public Shipment(string trackingCode, string description,
            decimal weight, decimal deliveryFee, DeliveryAddress Destination)
            {
                TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
                this.Destination = Destination;
            }

            #endregion
            // ==========================================
            // METHODS
            // ==========================================
            #region Methods

            // UpdateDeliveryFee(decimal newFee)
            // Update DeliveryFee only if
            // newFee > 0.
            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                {
                    this.deliveryFee = newFee;
                }
            }
            // PrintShipment() Print:
            // TrackingCode
            // Description
            // Weight
            // DeliveryFee
            // Destination
            // EstimatedCost
            public void PrintShipment()
            {
                Console.WriteLine($"Tracking Code: {TrackingCode}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Weight: {Weight} Kg");
                Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
                Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
                Console.WriteLine($"Estimated Cost: {EstimatedCost}");

            }

            #endregion
        }

}
