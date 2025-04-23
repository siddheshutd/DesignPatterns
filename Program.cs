﻿using StatePattern;
using ChainOfResponsibilityPattern; // Add this using statement
using ProxyPattern;
using System;
using ObserverPattern;
using DecoratorPattern;
using FactoryPattern; // Add for Console

class Program{

    static void Main() {
                                /* Observer Pattern */
        IStocksObservable macbookObservable = new MacBookObservable(0);
        EmailAlertObserver observer1 = new EmailAlertObserver("siddheshutd@gmail.com");
        EmailAlertObserver observer2 = new EmailAlertObserver("siddheshutd@gmail2.com");
        EmailAlertObserver observer3 = new EmailAlertObserver("");
        EmailAlertObserver observer4 = new EmailAlertObserver("");
        macbookObservable.Add(observer1);
        macbookObservable.Add(observer2);
        macbookObservable.Add(observer3);
        macbookObservable.Add(observer4);
        int count = int.Parse(Console.ReadLine()!);
        macbookObservable.AddStock(count);

                                /* Decorator Pattern */
        IBasePizza pizza = new Jalapenos(new CheeseBurst(new Margherita()));
        Console.WriteLine($"Pizza cost is {pizza.GetCost()}");

                                /* Factory Pattern */
        VehicleFactory carFactory = new CarFactory();
        carFactory.DeliverVehicle();

        VehicleFactory bikeFactory = new BikeFactory();
        bikeFactory.DeliverVehicle();

                                /* Chain of Responsibility Pattern */
        //Create handlers
        IWithdrawHandler handler50 = new FiftyPoundHandler();
        IWithdrawHandler handler20 = new TwentyPoundHandler();
        IWithdrawHandler handler10 = new TenPoundHandler();

        // Set up the chain: 50 -> 20 -> 10
        handler50.SetNextHandler(handler20);
        handler20.SetNextHandler(handler10);

        // Process a withdrawal request
        int amountToWithdraw = 180; // Example amount
        Console.WriteLine($"Attempting to withdraw £{amountToWithdraw}:");
        handler50.Dispense(amountToWithdraw);

        Console.WriteLine("\nAttempting to withdraw £125:");
        handler50.Dispense(125); // Example with remainder issue

        Console.WriteLine("\nAttempting to withdraw £70:");
        handler50.Dispense(70);

        Console.WriteLine("\nAttempting to withdraw £5:");
        handler50.Dispense(5); // Example below smallest denomination
        
                                /* Proxy Pattern */

        IService service = new ServiceProxy(new Service());

        Console.WriteLine("First call");
        var data1 = service.GetData("test");
        Console.WriteLine(data1);

        Console.WriteLine("Second call");
        var data2 = service.GetData("test");
        Console.WriteLine(data2);    

                                /* State Pattern */
        VendingMachine vendingMachine = new VendingMachine();
        vendingMachine.AddProduct(new Product(100, "Coke", 1.50), 5);
        vendingMachine.Start();

        vendingMachine.SelectProduct(102);

        vendingMachine.AddCoin(Coin.Nickel);
        vendingMachine.AddNote(Note.FivePound);
        vendingMachine.DispenseProduct();
    }
}
