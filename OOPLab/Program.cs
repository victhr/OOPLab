// See https://aka.ms/new-console-template for more information
using OOPLab.Delegates;
using OOPLab.OOP;
using OOPLab.ServiceImplementation;
using static OOPLab.Delegates.MulticastingDelegate;
using static OOPLab.Delegates.SimpleDelegate;

Console.WriteLine("Hello, World!");

Console.WriteLine("================Encapsulation=======================");

Encapsulation encapsulaion = new Encapsulation();

encapsulaion.X = 2;
encapsulaion.Y = 3;
//Due it is readonly, write is not allowed
//encapsulaion.Z = 4;

Console.WriteLine("================Abstraction, Derived Class, Inheritance, Polymorphism =======================");

derivedClass absclass = new derivedClass();

Console.WriteLine("Add Result");
Console.WriteLine(absclass.AddTwoNumbes(encapsulaion.X,encapsulaion.Y));
Console.WriteLine("Multiply Result abstract");
Console.WriteLine(absclass.MultiplyTwoNumbers(encapsulaion.X, encapsulaion.Y));
Console.WriteLine("AnyOperation Result Virtual");
Console.WriteLine(absclass.MakeAnyOperation(encapsulaion.X, encapsulaion.Y));


Console.WriteLine("================Bad Practice=======================");
AbstractClass baseClass = (AbstractClass)absclass;
Console.WriteLine("AnyOperation Result baseClass");
Console.WriteLine(baseClass.MakeAnyOperation(encapsulaion.X, encapsulaion.Y));



Console.WriteLine("================Interfaces=======================");

Bicycle bicycle = new Bicycle();
bicycle.changeGear(2);
bicycle.speedUp(3);
bicycle.applyBrakes(1);

Console.WriteLine("Bicycle current state");
bicycle.printStates();

Bike bike = new Bike();
bike.changeGear(1);
bike.speedUp(4);
bike.applyBrakes(3);

Console.WriteLine("Bike current state");
bike.printStates();

Console.WriteLine("================Simple Delegate=======================");

SimpleDelegate obj = new SimpleDelegate();

addnum del_obj1 = new addnum(obj.Sum);
subnum del_obj2 = new subnum(obj.Subtract);

del_obj1(100, 40);
del_obj2(100, 60);

Console.WriteLine("================Simple Delegate with Invoke=======================");

del_obj1.Invoke(100, 40);
del_obj2.Invoke(100, 60);


Console.WriteLine("================Multicasting Delegate=======================");

MulticastingDelegate multicast = new MulticastingDelegate();

rectRectangle rectdelegate = new rectRectangle(multicast.perimeter);

rectdelegate += multicast.area;

Console.WriteLine("Area & Perimeter Exec 1");

rectdelegate.Invoke(6.1, 5.0);

Console.WriteLine("Area & Perimeter Exec 2");

rectdelegate -= multicast.area;

rectdelegate.Invoke(10.1, 23.0);