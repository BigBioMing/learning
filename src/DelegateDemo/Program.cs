// See https://aka.ms/new-console-template for more information
using DelegateDemo;

Console.WriteLine("Hello, World!");


CustomDelegate customDelegate = name => $"{name}走来了";
customDelegate += name => $"{name}跑来了";
customDelegate += name => $"{name}飞来了";

var result = customDelegate("张三");
Console.WriteLine(result);

foreach(var item in customDelegate.GetInvocationList())
{
    Console.WriteLine(item.DynamicInvoke("李四"));
}


Console.ReadKey();