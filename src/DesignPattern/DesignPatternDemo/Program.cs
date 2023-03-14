// See https://aka.ms/new-console-template for more information
using DesignPatternDemo.BridgePattern;
using DesignPatternDemo.BuilderPattern;
using DesignPatternDemo.CommandPattern.Barbecues;
using DesignPatternDemo.CommandPattern.Normal;
using DesignPatternDemo.CompositePattern;
using DesignPatternDemo.IteratorPattern;
using DesignPatternDemo.ObserverPattern;
using DesignPatternDemo.ResponsibilityChainPattern;
using DesignPatternDemo.StatePattern;

Console.WriteLine("Hello, World!");

////状态模式
//TestExecuteStatePattern.Execute();

////观察者模式
//TestObserverPattern.Execute();

////建造者模式
//TestBuilderPattern.Execute();

////组合模式
//TestCompositePattern.Execute();

////迭代器模式
//TestIteratorPattern.Execute();

////桥接模式
//TestBridgePattern.Execute();

////命令模式-点餐Demo
//TestCommandOrderDemo.Execute();

////命令模式
//TestCommandPattern.Execute();

//职责链模式
TestResponsibilityChainPattern.Execute();

Console.ReadKey();