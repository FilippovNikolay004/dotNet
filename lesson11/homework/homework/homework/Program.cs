abstract class Herbivore {
    public double Weight { get; set; }
    public bool Life { get; set; }

    public void Print() {
        Console.WriteLine("\tWeight: " + Weight);
        Console.WriteLine("\tLife: " + Life);
    }
    public abstract void EatGrass();
}
class Wildebeest : Herbivore {
    public Wildebeest() {
        Weight = 50; Life = true;
        Console.WriteLine($"\tCreate Wildebeest");
        Print();
    }

    public override void EatGrass() {
        Console.WriteLine($"Before: Wildebeest eat, weight: {Weight}");
        Weight += 10;
        Console.WriteLine($"After: Wildebeest eat, weight: {Weight}");
    }
}
class Bison : Herbivore {
    public Bison() { 
        Weight = 550; Life = true;
        Console.WriteLine($"\tCreate Bison");
        Print();
    }

    public override void EatGrass() {
        Console.WriteLine($"Before: Bison eat, weight: {Weight}");
        Weight += 15;
        Console.WriteLine($"After: Bison eat, weight: {Weight}");
    }
}
class Kangaroo :Herbivore {
    public Kangaroo() {
        Weight = 250; Life = true;
        Console.WriteLine($"\tCreate Kangaroo");
        Print();
    }

    public override void EatGrass() {
        Console.WriteLine($"Before: Kangaroo eat, weight: {Weight}");
        Weight += 15;
        Console.WriteLine($"After: Kangaroo eat, weight: {Weight}");
    }
}

abstract class Carnivore {
    protected int Power { get; set; }
    
    public abstract void EatHerbivore(Herbivore herbivore);
}
class Lion : Carnivore {
    public Lion() {
        Power = 100;
        Console.WriteLine($"\tCreate Lion, power: {Power}");
    }

    public override void EatHerbivore(Herbivore herbivore) {
        Console.WriteLine($"Before: Lion eat, power: {Power}");

        if (Power > herbivore.Weight && herbivore.Life) {
            Power += 10;
        } else { Power -= 10; }
        herbivore.Life = false;

        Console.WriteLine($"After: Lion eat, power: {Power}");
    }
}
class Wolf : Carnivore {
    public Wolf() {
        Power = 50;
        Console.WriteLine($"\tCreate Wolf, power: {Power}");
    }

    public override void EatHerbivore(Herbivore herbivore) {
        Console.WriteLine($"Before: Wolf eat, power: {Power}");

        if (Power > herbivore.Weight && herbivore.Life) {
            Power += 10;
        } else { Power -= 10; }
        herbivore.Life = false;

        Console.WriteLine($"After: Wolf eat, power: {Power}");
    }
}
class AustralianWolf: Carnivore {
    public AustralianWolf() {
        Power = 60;
        Console.WriteLine($"\tCreate Australian Wolf, power: {Power}");
    }

    public override void EatHerbivore(Herbivore herbivore) {
        Console.WriteLine($"Before: Australian Wolf eat, power: {Power}");

        if (Power > herbivore.Weight && herbivore.Life) {
            Power += 10;
        } else { Power -= 10; }
        herbivore.Life = false;

        Console.WriteLine($"After: Australian Wolf eat, power: {Power}");
    }
}

abstract class Continent {
    protected Herbivore herbivore;
    protected Carnivore carnivore;

    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}
class Africa : Continent {
    public Africa () { Console.WriteLine("Create Africa"); }
    public override Herbivore CreateHerbivore() { return new Wildebeest(); }
    public override Carnivore CreateCarnivore() { return new AustralianWolf(); }

}
class NorthAmerica : Continent {
    public NorthAmerica() { Console.WriteLine("Create North America"); }
    public override Herbivore CreateHerbivore() { return new Bison(); }
    public override Carnivore CreateCarnivore() { return new Wolf(); }
}
class Australia : Continent {
    public Australia() { Console.WriteLine("Create Australia"); }
    public override Herbivore CreateHerbivore() { return new Kangaroo(); }
    public override Carnivore CreateCarnivore() { return new AustralianWolf(); }
}

class AnimalWorld {
    private Herbivore herbivore;
    private Carnivore carnivore;
    public AnimalWorld(Continent continent) {
        herbivore = continent.CreateHerbivore();
        carnivore = continent.CreateCarnivore();
    }
    public void HerbivoreEat() { herbivore.EatGrass(); }
    public void CarnivoreEat() { carnivore.EatHerbivore(herbivore); }
}

class main {
    public static void Main() {
        Continent continent = new NorthAmerica();
        AnimalWorld animalWorld = new AnimalWorld(continent);
        animalWorld.HerbivoreEat();
        animalWorld.CarnivoreEat();

        Console.WriteLine("");

        continent = new Africa();
        animalWorld = new AnimalWorld(continent);
        animalWorld.HerbivoreEat();
        animalWorld.CarnivoreEat();

        Console.WriteLine("");

        continent = new Australia();
        animalWorld = new AnimalWorld(continent);
        animalWorld.HerbivoreEat();
        animalWorld.CarnivoreEat();
    }
}
