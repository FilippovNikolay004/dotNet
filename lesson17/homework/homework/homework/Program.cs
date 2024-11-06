using homework;

VoidSourceEvent v = new VoidSourceEvent();
BoolSourceEvent b = new BoolSourceEvent();

CreditCard creditCard = new CreditCard("4149567823645978", "Иван", "Иванов", 1234, 50000, 10000);

v.Event += creditCard.Print;
b.Event += creditCard.EnterPin;
v.Event += creditCard.ChangePin;
b.Event += creditCard.EnterPin;

v.GeneratorEvent();
b.GeneratorEvent();