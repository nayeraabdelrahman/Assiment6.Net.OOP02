using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment6.Net.OOP02.SmartDeliveryManagement
{
    internal class DeliveryCenter
    {
        // ==========================================
        // FIELDS
        // ==========================================

        #region Fields

        // Center Name
        // Private Shipment[] array.
        // Maximum size = 20.
        string centerName;
        Shipment[] shipments;


        #endregion
        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        #region Constructor

        // Initialize the Shipment array
        // with a size of 20.


        #endregion
        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }


        // ==========================================
        // INTEGER INDEXER
        // ==========================================

        #region Integer Indexer

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                else
                {
                    return default;
                }
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        #endregion

        // ==========================================
        // STRING INDEXER
        // ==========================================

        #region String Indexer

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return default;
            }
        }
        #endregion
        // ==========================================
        // METHODS
        // ==========================================

        #region Methods

        // AddShipment(Shipment shipment)
        // Add the shipment to the first available position.
        // Return true:if added successfully.Return false:if the DeliveryCenter is full.
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }


        #endregion
    }
}
