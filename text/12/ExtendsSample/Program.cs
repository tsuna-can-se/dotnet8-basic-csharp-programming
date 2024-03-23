using ExtendsSample;

Dog dog = new Dog();
dog.Walk();
dog.Bark();

Cat cat = new Cat();
cat.Walk();

Dachshund dachshund = new Dachshund();
dachshund.BirthDay = new DateTime(2023, 8, 1);
Console.WriteLine(dachshund.ToString());
Console.WriteLine(dachshund);
