using homework;

Aquarium aquarium = new Aquarium(
    new Jellyfish(),
    new Shark(),
    new Dolphin(),
    new Whale(),
    new Octopus()
);

Console.WriteLine("Океанариум состоит из: ");
MyIterator<Aquarium> myIteratorAquarium = new MyIterator<Aquarium>(aquarium);
myIteratorAquarium.Print();


FootballTeam footballTeam = new FootballTeam(
    new Participant { Name = "Тибо", LastName = "Куртуа", Age = 31 },
    new Participant { Name = "Давид", LastName = "Алаба", Age = 31 },
    new Participant { Name = "Лука", LastName = "Модрич", Age = 38 },
    new Participant { Name = "Винисиус", LastName = "Жуниор", Age = 23 },
    new Participant { Name = "Федерико", LastName = "Вальверде", Age = 25 }
);

Console.WriteLine("\n\nФутбольная команда состоит из: ");
MyIterator<FootballTeam> myIteratorFootballTeam = new MyIterator<FootballTeam>(footballTeam);
myIteratorFootballTeam.Print();


CoffeeShop coffeeShop = new CoffeeShop(
    new Employee { Name = "Анна", LastName = "Иванова", Age = 28, JobTitle = "Бариста" },
    new Employee { Name = "Максим", LastName = "Петров", Age = 32, JobTitle = "Менеджер зала" },
    new Employee { Name = "Екатерина", LastName = "Сидорова", Age = 26, JobTitle = "Кондитер" },
    new Employee { Name = "Игорь", LastName = "Смирнов", Age = 24, JobTitle = "Бариста" },
    new Employee { Name = "Мария", LastName = "Васильева", Age = 29, JobTitle = "Администратор" }
);

Console.WriteLine("\n\nСотрудники кофейни: ");
MyIterator<CoffeeShop> myIteratorCoffeeShop = new MyIterator<CoffeeShop>(coffeeShop);
myIteratorCoffeeShop.Print(); 