
namespace Assiment6.Net.OOP02.SmartDeliveryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 - Theoretical Questions

            // ==========================================
            // QUESTION 1
            // ==========================================

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


            // ==========================================
            // QUESTION 2
            // ==========================================

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
            // QUESTION 1
            // Create a DeliveryCenter.
            // ==========================================

            #region Q1 - Create DeliveryCenter



            #endregion


            // ==========================================
            // QUESTION 2
            // Read the center name from the user.
            // ==========================================

            #region Q2 - Read Center Name



            #endregion


            // ==========================================
            // QUESTION 3
            // Create one StandardShipment.
            // ==========================================

            #region Q3 - Standard Shipment



            #endregion


            // ==========================================
            // QUESTION 4
            // Create one ExpressShipment.
            // ==========================================

            #region Q4 - Express Shipment



            #endregion


            // ==========================================
            // QUESTION 5
            // Create one InternationalShipment.
            // ==========================================

            #region Q5 - International Shipment



            #endregion


            // ==========================================
            // QUESTION 6
            // Read all shipment data from the user.
            // ==========================================

            #region Q6 - Read Shipment Data



            #endregion


            // ==========================================
            // QUESTION 7
            // Add the shipments to the delivery center.
            // ==========================================

            #region Q7 - Add Shipments



            #endregion


            // ==========================================
            // QUESTION 8
            // Print all shipments.
            // ==========================================

            #region Q8 - Print All Shipments



            #endregion


            // ==========================================
            // QUESTION 9
            // Search for a shipment using the existing
            // tracking code indexer.
            // ==========================================

            #region Q9 - Search Shipment



            #endregion


            // ==========================================
            // QUESTION 10
            // Remove one shipment using its tracking code.
            // ==========================================

            #region Q10 - Remove Shipment



            #endregion


            // ==========================================
            // QUESTION 11
            // Print the remaining shipments.
            // ==========================================

            #region Q11 - Print Remaining Shipments



            #endregion

            #endregion
        }
    }
}