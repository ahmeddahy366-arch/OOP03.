namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1

            //    Q1 Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?


            //Overloading → same name, different parameters.
            //Overriding → same method, different implementation in child clas

            //b)  What is the difference between Static Binding and Dynamic Binding?

            //static Binding ->Early Binding = Compile Time = Reference Type =overloading
            //dynamic Binding ->Late Binding = Run Time    = Actual Object = overriding
            #endregion
            #region question2

            //Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //    A sealed class cannot be inherited.

            //b)  What is the difference between a sealed class and a sealed method?
            //        A sealed class prevents inheritance, while a sealed method prevents further overriding of that method.


            //c)  Can a sealed method be overridden? Why?
            //No A sealed method cannot be overridden because sealed prevents further overriding in derived classes.
            #endregion
            #region Question 10

            // 10 a, b, c. Create Driver, DeliveryCenter, and Assign Driver to DeliveryCenter
            Driver driver = new Driver(1, "ahmed", "01141643066");
            DeliveryCenter center = new DeliveryCenter();
            center.Driver = driver;

            // 10 d, e, f. Create StandardShipment, ExpressShipment, and InternationalShipment
            StandardShipment standardShipment = new StandardShipment("TRACK123", "Electronics", 5.0m, 10.0m, new DeliveryAddress("sohge", " in main 1", 123));
            ExpressShipment express = new ExpressShipment("EX001", "Laptop", 5, 70, 30, new DeliveryAddress("Sohag", "Street 2", 20));
            InternationalShipment international = new InternationalShipment("IN001", "Clothes", 8, 100, "Saudi Arabia", 40, new DeliveryAddress("Sohag", "Street 3", 30));

            // 10 g, h. Add all shipments to DeliveryCenter and Print All Shipments
            center.AddShipment(standardShipment);
            center.AddShipment(express);
            center.AddShipment(international);
            center.PrintAllShipments();

            // 10 i. Call DeliveryHelper.PrintShipmentDetails() for each shipment
            DeliveryHelper.PrintShipmentDetails(standardShipment);
            DeliveryHelper.PrintShipmentDetails(express);
            DeliveryHelper.PrintShipmentDetails(international);

            // 10 j. Demonstrate both versions of UpdateWeight()
            standardShipment.UpdateWeight(15);
            standardShipment.UpdateWeight(20, 3);

            // 10 k. Build a Shipment[] holding mixed types and print all of them in a loop
            Shipment[] shipments =
            {
        standardShipment,
        express,
        international
    };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
            }

            // 10 l. Demonstrate the sealed class and sealed method
            CompletedShipment completed = new CompletedShipment("SH004", "Delivered Items", 1.5m, 40.0m, new DeliveryAddress("Giza", "Pyramids", 10));
            PriorityInternationalShipment priorityInt = new PriorityInternationalShipment("SH005", "Medical Equipment", 10.0m, 200.0m, "USA", 150.0m, new DeliveryAddress("Cairo", "Naser City", 15));

            completed.PrintShipment();
            priorityInt.GenerateCustomsReport();
        }

    }
    }
            #endregion

