
namespace Assiment6.Net.OOP02.SmartDeliveryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 - Theoretical Questions

            #region Question 1
            // a) What is the difference between a class and a struct?
            // Answer:
            // A class is a reference type, while a struct is a value type.
            // Classes support inheritance, while structs cannot inherit from another class or struct.
            // Classes can have destructors, while structs cannot.
            // Structs are generally suitable for small and lightweight data,
            // while classes are more suitable for larger and more complex objects.
            // If we define a constructor in a class, the compiler does not automatically
            // provide a parameterless constructor.

            // b) Why are classes more suitable than structs
            //    for large applications?
            //
            // Answer:
            // Because classes are reference types, they can be easily shared and passed
            // around in large applications without copying the entire object.
            // They also support inheritance and polymorphism, which allow for more
            // flexible, reusable, and maintainable code.
            // Structs are value types and are generally more suitable for small,
            // lightweight data.
            // The struct store in stack which has limited space compared with the heap,
            // so storing very large amounts of data on the stack may cause a stack overflow.
            // However, structs are not always stored on the stack.



            #endregion

            #region Question 2

            // Consider the given inheritance code.


            // a) Which class is the parent class?
            //
            // Answer:
            //shipment is the parent class.


            // b) Which class is the child class?
            //
            // Answer:
            //ExpressShipment is the child class.


            // c) What members are inherited by ExpressShipment?
            //
            // Answer: TrackingCode



            // d) Why is inheritance better than duplicating
            //    the same code in multiple classes?
            //
            // Answer:
            //Inheritance reduces code duplication and allows code reuse.
            // Common members can be written once in the parent class
            // and reused by child classes.
            // This makes the code easier to maintain and modify.


            #endregion

            #endregion
            #region Part 02 - Practical

            // ==========================================
            // Create a DeliveryCenter.
            // ==========================================

            #region Create DeliveryCenter

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            #endregion


            // =========================================
            // Read the center name from the user.
            // ==========================================

            #region Read Center Name
            Console.WriteLine("Enter Delivery Center Name :");
            string centerName = Console.ReadLine()??"";
            deliveryCenter.CenterName = centerName;
            Console.WriteLine("==========================================");
            Console.WriteLine($"Delivery Center : {centerName}");
            Console.WriteLine("==========================================");
            #endregion


            // ==========================================
            // Create one StandardShipment.
            // ==========================================

            #region  Standard Shipment

            StandardShipment standardShipment;
            Console.WriteLine("Tracking Code : ");
            string trackingCode = ReadValidString("Tracking Code");
            Console.WriteLine("Description :");
            string description = ReadValidString("Description");
            Console.WriteLine("Weight :");
            decimal weight= ReadValidDecimal("Weight");
            Console.WriteLine("Delivery Fee :");
            decimal deliveryFee = ReadValidDecimal("Delivery Fee");
            standardShipment = new StandardShipment(trackingCode, description, weight, deliveryFee,default);
            #endregion


            // ==========================================
            // Create one ExpressShipment.
            // ==========================================

            #region Express Shipment

            ExpressShipment expressShipment;
            Console.WriteLine("Tracking Code : ");
             trackingCode = ReadValidString("Tracking Code");
            Console.WriteLine("Description :");
            description = ReadValidString("Description");
            Console.WriteLine("Weight :");
            weight = ReadValidDecimal("Weight");
            Console.WriteLine("Delivery Fee :");
            deliveryFee = ReadValidDecimal("Delivery Fee");
            Console.WriteLine("Extra Fee :");
            decimal extraFee = ReadValidDecimal("Extra Fee");
            expressShipment = new ExpressShipment(trackingCode, description, weight, deliveryFee,default ,extraFee);

            #endregion


            // ==========================================
            // Create one InternationalShipment.
            // ==========================================

            #region International Shipment
            InternationalShipment internationalShipment;
            Console.WriteLine("Tracking Code : ");
            trackingCode = ReadValidString("Tracking Code");
            Console.WriteLine("Description :");
            description = ReadValidString("Description");
            Console.WriteLine("Weight :");
            weight = ReadValidDecimal("Weight");
            Console.WriteLine("Delivery Fee :");
            deliveryFee = ReadValidDecimal("Delivery Fee");
            Console.WriteLine("Destination Country :");
            String destinationCountry = ReadValidString("Destination Country");
            Console.WriteLine("Customs Fee :");
            decimal customsFee = ReadValidDecimal("Customs Fee");
            internationalShipment = new InternationalShipment(trackingCode, description, weight, deliveryFee, default, destinationCountry, customsFee);

            #endregion

            // ==========================================
            // Add the shipments to the delivery center.
            // ==========================================

            #region Q7 - Add Shipments
            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);


            #endregion


            // ==========================================
            //Print all shipments.
            // ==========================================

            #region  Print All Shipments

            deliveryCenter.PrintAllShipments();

            #endregion


            // ==========================================
            // Search for a shipment using the existing tracking code indexer.
            // Remove one shipment using its tracking code.
            // ==========================================

            #region Search & Remove Shipment

            Console.WriteLine("Enter Tracking Code to Remove :");
            trackingCode = ReadValidString("TrackingCode");
            Shipment Current = deliveryCenter[trackingCode];
            if (Current == null)
            {
                Console.WriteLine("Shipment is not Found");
            }
            else { deliveryCenter.RemoveShipment(trackingCode); }

            #endregion


            // ==========================================
            // Print the remaining shipments.
            // ==========================================

            #region Print Remaining Shipments
            Console.WriteLine("======================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("======================================");
            deliveryCenter.PrintAllShipments();

            #endregion

            #endregion

            //validationMethods
            #region Validation Methods
            static string ReadValidString(string message)
            {
                string input;
                do
                {
                    input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine($"{message} cannot be empty or whitespace. Please enter a valid {message}.");
                    }
                } while (string.IsNullOrWhiteSpace(input));
                return input;
            }
            static decimal ReadValidDecimal(string message)
            {
                decimal value;
                bool isValid = false;
                if (message.ToLower() == "weight" || message.ToLower() == "delivery fee")
                {     do
                    {
                        isValid = decimal.TryParse(Console.ReadLine(), out value);
                        if (!isValid || value <= 0)
                        {
                            Console.WriteLine($"{message} must be a positive number. Please enter a valid {message}.");
                        }
                    } while (!isValid || value <= 0);

                }
                else
                {
                    do
                    {
                        isValid = decimal.TryParse(Console.ReadLine(), out value);
                        if (!isValid || value < 0)
                        {
                            Console.WriteLine($"{message} must be a positive number. Please enter a valid {message}.");
                        }
                    } while (!isValid || value < 0);
                }
                return value;
            }

            #endregion
        }
    }
}