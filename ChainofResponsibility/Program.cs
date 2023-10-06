using ChainofResponsibility.Implementation;
using ChainofResponsibility;

var manager = new Manager(new Director(new Ceo()));

var purchase1 = new Purchase("Laptop", 900);
var purchase2 = new Purchase("Projector", 5500);
var purchase3 = new Purchase("Company Car", 15000);

manager.ProcessRequest(purchase1);
manager.ProcessRequest(purchase2);
manager.ProcessRequest(purchase3);

Console.ReadKey();