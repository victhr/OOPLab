// See https://aka.ms/new-console-template for more information
using OOPLab.Asynchronous;
using OOPLab.Delegates;
using OOPLab.LINQ;
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

Console.WriteLine("================Predicate Delegate=======================");

PredicateDelegate.my_delegate obj_predicate = PredicateDelegate.myfun;
Console.WriteLine(obj_predicate("Hello"));

Predicate<string> val = PredicateDelegate.myfun;
Console.WriteLine(val("Hello world!!!!!!!!"));

Console.WriteLine("================Predicate Delegate Anonymous=======================");

Predicate<string> val1 = delegate (string mystring)
{
    if (mystring.Length < 10)
    {
        return true;
    }
    else
    {
        return false;
    }
};

Console.WriteLine( val1("Hola"));
Console.WriteLine(val1("Hola mundo como estas"));

Console.WriteLine("================Predicate Delegate Lambda Expression=======================");

Predicate<string> val2 = mystring => mystring.Equals("Hello");
Console.WriteLine(val2("Hello"));
Console.WriteLine(val2("Hello world"));

Console.WriteLine("================Action Delegate=======================");
Action<int, int> funcVal = ActionDelegate.Sub;
funcVal(10, 7);

Console.WriteLine("================Action Delegate Anonymous=======================");

Action<int, int> ActionAn_val = delegate (int x, int y)
{
    Console.WriteLine(x - y);
};

ActionAn_val(12,7);

Console.WriteLine("================Action Delegate Lambda=======================");
Action<string> ActionLanbdastr = str => Console.WriteLine(str);
ActionLanbdastr("hello");

Console.WriteLine("================Func Delegate=======================");
Func<int, int, int, int, int> funcDelegate = FuncDelegate.MultiplyMethod;
Console.WriteLine(funcDelegate(5,100,23,4));

Console.WriteLine("================Func Delegate Anonymous=======================");
Func<int, int, int, int> FuncAnonymousDelegate = delegate (int x, int y, int z)
{
    return x * y * z;
};

Console.WriteLine(FuncAnonymousDelegate(23, 122, 90));


Console.WriteLine("================Func Delegate Lambda=======================");

Func<int, int, int, int> FuncLambdaDelegate = (int x, int y, int z) => x * y * z;
Console.WriteLine(FuncLambdaDelegate(23, 23, 1));


Console.WriteLine("================LINQ=======================");

GetData getData = new GetData();

Console.WriteLine("================LINQ Query Syntax======================="); 

getData.QueryExtraction(PopulationFake.FillEmployee1(), PopulationFake.FillEmployee2()).ForEach(item =>
{
    Console.WriteLine("Emp In = {0}, Emp Name {1}, Emp Salary = {2}", item.Emp_id, item.Emp_name, item.Emp_Salary);
});

Console.WriteLine("================LINQ Method Syntax=======================");

getData.MethodExtraction(PopulationFake.FillEmployee1(), PopulationFake.FillEmployee2()).ForEach(item =>
{
    Console.WriteLine("Emp In = {0}, Emp Name {1}, Emp Depatment = {2}", item.Emp_id, item.Emp_name, item.Emp_dept);
});

Console.WriteLine("================Sync=======================");

SynchronousTest.SynDemo();

Console.WriteLine("================Async=======================");

Asynchronous.SynDemo();