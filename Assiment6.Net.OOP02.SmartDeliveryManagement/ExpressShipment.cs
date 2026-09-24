using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment6.Net.OOP02.SmartDeliveryManagement
{
    internal class ExpressShipment:Shipment
    {
            // ==========================================
            // FIELDS
            // ==========================================

            #region Fields

            // Extra Fee
            decimal extraFee;

            #endregion


            // ==========================================
            // PROPERTIES
            // ==========================================

            #region Properties

            // ExtraFee
            // Must be greater than or equal to 0.
             public decimal ExtraFee{
                    set
                    {
                        if (value >= 0)
                        {
                            extraFee = value;
                        }
                    }
                    get { return extraFee; }
                }

        // EstimatedCost
        // Override the inherited property.
        // DeliveryFee + (Weight * 5) + ExtraFee
        override public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5)+ ExtraFee;
            }

        }
        #endregion


        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        #region Constructor

        // Initialize all inherited members
        // using constructor chaining.
        // Also initialize ExtraFee.
        public ExpressShipment(string trackingCode, string description,
          decimal weight, decimal deliveryFee, DeliveryAddress Destination, decimal extraFee)
          : base(trackingCode, description, weight, deliveryFee, Destination)
        {
            ExtraFee = extraFee;
        }


        #endregion

    }
}
