using static System.Runtime.InteropServices.JavaScript.JSType;

interface ITransport {
    double Weight { get; set; }
    double MaxWeight { get; set; }
    int MaxSpeed { get; set; }
    int MaximumDistance { get; set; }
    int MaximumNumberPassengers { get; set; }

    void Move();
    void Stop();

    void Print();
}

// Наземный
interface IGroundTr : ITransport {
}

// Водный
interface IWaterTr : ITransport {
}

// Воздушный
interface IAirTr : ITransport {
    int MaximumHeight { get; set; }

    void TakeOff();
    void ItWillLand();
    void PerformAction(string action);
}


// Наземный транспорт
class Auto : IGroundTr {
    private int NumberDoors { get; set; }
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public Auto() : this(0, 0, 0, 0, 0) {}
    public Auto(int numberDoors, double weight, double maxWeight, int maximumDistance, int maximumNumberPassengers) {
        NumberDoors = numberDoors;
        Weight = weight;
        MaxWeight = maxWeight;
        MaximumDistance = maximumDistance;
        MaximumNumberPassengers = maximumNumberPassengers;
    }

    public void Move() {
        Console.WriteLine("Машина начала движение");
    }
    public void Stop() {
        Console.WriteLine("Машина остановилась");
    }

    public void Print() {
        Console.WriteLine($"Auto:\n" +
            $"Doors: {NumberDoors}\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}

class Railway : IWaterTr {
    private int NumberWagons { get; set; }
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public Railway() : this(0, 0, 0, 0, 0) { }
    public Railway(int numberWagons, double weight, double maxWeight, int maximumDistance, int maximumNumberPassengers) {
        NumberWagons = numberWagons;
        Weight = weight;
        MaxWeight = maxWeight;
        MaximumDistance = maximumDistance;
        MaximumNumberPassengers = maximumNumberPassengers;
    }

    public void Move() {
        Console.WriteLine("Поезд начала движение");
    }
    public void Stop() {
        Console.WriteLine("Поезд остановился");
    }

    public void Print() {
        Console.WriteLine($"Railway:\n" +
            $"Number Wagons: {NumberWagons}\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}

class HorseDrawn : IGroundTr {
    private int NumberHorses { get; set; }
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public HorseDrawn() : this(0, 0, 0, 0, 0) { }
    public HorseDrawn(int numberHorses, double weight, double maxWeight, int maximumDistance, int maximumNumberPassengers) {
        NumberHorses = numberHorses;
        Weight = weight;
        MaxWeight = maxWeight;
        MaximumDistance = maximumDistance;
        MaximumNumberPassengers = maximumNumberPassengers;
    }

    public void Move() {
        Console.WriteLine("Гужевой начал движение");
    }
    public void Stop() {
        Console.WriteLine("Гужевой остановился");
    }

    public void Print() {
        Console.WriteLine($"HorseDrawn:\n" +
            $"Number Horses: {NumberHorses}\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}


// Водный транспорт
class Tanker : IWaterTr {
    private int MaxCargoQuantity { get; set; }
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public Tanker() : this(0, 0, 0, 0, 0, 0) { }
    public Tanker(int maxCargoQuantity, double weight, double maxWeight, int maxSpeed, int maximumDistance, int maximumNumberPassengers) {
        MaxCargoQuantity = maxCargoQuantity;
        Weight = weight;
        MaxWeight = maxWeight;
        MaxSpeed = maxSpeed;
        MaximumDistance = maximumDistance;
        MaximumNumberPassengers = maximumNumberPassengers;
    }

    public void Move() {
        Console.WriteLine("Танкер начал движение");
    }
    public void Stop() {
        Console.WriteLine("Танкер остановился");
    }

    public void Print() {
        Console.WriteLine($"Tanker:\n" +
            $"Max Cargo Quantity: {MaxCargoQuantity}\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}

class Boat : IWaterTr {
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public Boat() : this(0, 0, 0, 0, 0) { }
    public Boat (double weight, double maxWeight, int maxSpeed, int maximumDistance, int maximumNumberPassengers) {
        Weight = weight;
        MaxWeight = maxWeight;
        MaxSpeed = maxSpeed;
        MaximumDistance = maximumDistance;
        MaximumNumberPassengers= maximumNumberPassengers;
    }

    public void Move() {
        Console.WriteLine("Лодка начала движение");
    }
    public void Stop() {
        Console.WriteLine("Лодка остановилась");
    }

    public void Print() {
        Console.WriteLine($"Boat:\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}

class Ship : IWaterTr {
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public Ship() : this(0, 0, 0, 0, 0) { }
    public Ship(double weight, double maxWeight, int maxSpeed, int maximumDistance, int maximumNumberPassengers) {
        Weight = weight;
        MaxWeight = maxWeight;
        MaxSpeed = maxSpeed;
        MaximumDistance = maximumDistance;
        MaximumNumberPassengers = maximumNumberPassengers;
    }

    public void Move() {
        Console.WriteLine("Теплоход начал движение");
    }
    public void Stop() {
        Console.WriteLine("Теплоход остановился");
    }

    public void Print() {
        Console.WriteLine($"Ship:\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}


// Воздушный транспорт
class Plane : IAirTr {
    public int MaximumHeight { get; set; }
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public Plane() : this(0, 0, 0, 0, 0, 0) { }
    public Plane(int maximumHeight, double weight, double maxWeight, int maxSpeed, int maximumDistance, int maximumNumberPassengers) {
        MaximumHeight = maximumHeight;
        Weight = weight;
        MaxWeight = maxWeight;
        MaxSpeed = maxSpeed;
        MaximumDistance= maximumDistance;
        MaximumNumberPassengers = maximumNumberPassengers;
    }

    public void TakeOff() {
        Console.WriteLine("Самолёт начал набирать высоту");
    }
    public void ItWillLand() {
        Console.WriteLine("Самолёт начал приземляться");
    }
    public void Move() {
        Console.WriteLine("Самолёт начал движение");
    }
    public void Stop() {
        Console.WriteLine("Самолёт остановился");
    }

    public void PerformAction(string action) {
        switch (action.ToLower()) {
        case "takeoff":
            TakeOff();
            break;
        case "land":
            ItWillLand();
            break;
        case "move":
            Move();
            break;
        case "stop":
            Stop();
            break;
        case "print":
            Print();
            break;
        default:
            throw new Exception("Некорректный выбор!");
        }
    }

    public void Print() {
        Console.WriteLine($"Plane:\n" +
            $"Maximum Height: {MaximumHeight}\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}

class Helicopter : IAirTr {
    public int MaximumHeight { get; set; }
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public Helicopter() : this(0, 0, 0, 0, 0, 0) { }
    public Helicopter(int maximumHeight, double weight, double maxWeight, int maxSpeed, int maximumDistance, int maximumNumberPassengers) {
        MaximumHeight = maximumHeight;
        Weight = weight;
        MaxWeight = maxWeight;
        MaxSpeed = maxSpeed;
        MaximumDistance = maximumDistance;
        MaximumNumberPassengers = maximumNumberPassengers;
    }

    public void TakeOff() {
        Console.WriteLine("Вертолёт начал набирать высоту");
    }
    public void ItWillLand() {
        Console.WriteLine("Вертолёт начал приземляться");
    }
    public void Move() {
        Console.WriteLine("Вертолёт начал движение");
    }
    public void Stop() {
        Console.WriteLine("Вертолёт остановился");
    }

    public void PerformAction(string action) {
        switch (action.ToLower()) {
        case "takeoff":
            TakeOff();
            break;
        case "land":
            ItWillLand();
            break;
        case "move":
            Move();
            break;
        case "stop":
            Stop();
            break;
        case "print":
            Print();
            break;
        default:
            throw new Exception("Некорректный выбор!");
        }
    }
    public void Print() {
        Console.WriteLine($"Helicopter:\n" +
            $"Maximum Height: {MaximumHeight}\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}

class Airship : IAirTr {
    public int MaximumHeight { get; set; }
    public double Weight { get; set; }
    public double MaxWeight { get; set; }
    public int MaxSpeed { get; set; }
    public int MaximumDistance { get; set; }
    public int MaximumNumberPassengers { get; set; }

    public Airship() : this(0, 0, 0, 0, 0, 0) { }
    public Airship(int maximumHeight, double weight, double maxWeight, int maxSpeed, int maximumDistance, int maximumNumberPassengers) {
        MaximumHeight = maximumHeight;
        Weight = weight;
        MaxWeight = maxWeight;
        MaxSpeed = maxSpeed;
        MaximumDistance = maximumDistance;
        MaximumNumberPassengers = maximumNumberPassengers;
    }

    public void TakeOff() {
        Console.WriteLine("Дерижабыль начал набирать высоту");
    }
    public void ItWillLand() {
        Console.WriteLine("Дерижабыль начал приземляться");
    }
    public void Move() {
        Console.WriteLine("Дерижабыль начал движение");
    }
    public void Stop() {
        Console.WriteLine("Дерижабыль остановился");
    }
    public void PerformAction(string action) {
        switch (action.ToLower()) {
        case "takeoff":
            TakeOff();
            break;
        case "land":
            ItWillLand();
            break;
        case "move":
            Move();
            break;
        case "stop":
            Stop();
            break;
        case "print":
            Print();
            break;
        default:
            throw new Exception("Некорректный выбор!");
        }
    }
    public void Print() {
        Console.WriteLine($"Airship:\n" +
            $"Maximum Height: {MaximumHeight}\n" +
            $"Weight: {Weight}\n" +
            $"Max Weight: {MaxWeight}\n" +
            $"Max Distance: {MaximumDistance}\n" +
            $"Max Passengers: {MaximumNumberPassengers}"
        );
    }
}


class MainClass {
    public static void Main() {
        // Наземный транспорт
        ITransport transport = new Auto(4, 1500.0, 2000.0, 500, 5);
        transport.Move();

        transport = new Railway(10, 50000.0, 60000.0, 2000, 300);
        transport.Move();

        transport = new HorseDrawn(2, 1000.0, 1200.0, 50, 4);
        transport.Move();


        // Водный транспорт
        transport = new Tanker(20000, 30000.0, 50000.0, 40, 10000, 30);
        transport.Move();

        transport = new Boat(500.0, 1000.0, 60, 200, 5);
        transport.Move();

        transport = new Ship(20000.0, 30000.0, 25, 15000, 1000);
        transport.Move();


        // Воздушный транспорт
        transport = new Plane(12000, 50000.0, 80000.0, 900, 15000, 300);
        transport.Move();

        transport = new Helicopter(6000, 5000.0, 8000.0, 250, 600, 5);
        transport.Move();

        transport = new Airship(3000, 15000.0, 25000.0, 120, 5000, 50);
        transport.Move();

        if (transport is IAirTr airTransport) {
            airTransport.TakeOff();
            airTransport.PerformAction("move");
            airTransport.ItWillLand();
        }
    }
}