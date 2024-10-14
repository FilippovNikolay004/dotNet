using System;

class Student 
{
	int age;
	string name;
	string surname;
    private readonly int id_code;
    double avg = 12;

    static int counter = 0;
    public Student()
    {
        id_code = ++counter;
    }

    public int Age 
    {
        get{
            return age;
        }
        set{
            if (value > 0)
                age = value;
            }
    }

    /*
    public int Code
    {
        get
        {
            return id_code;
        }
    }
    */

    public int Code => id_code;


    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value != "")
                name = value;
        }
    }

    public string Surname 
    {
        get
        {
            return surname;
        }
        set
        {
            if (value != "")
                surname = value;
        }
    }

    public double Average
    {
        get
        {
            return avg;
        }
        set
        {
            if (value >= 0 && value <= 12)
                avg = value;
        }
    }
}

class MainClass {
	static void Main ()
    {
        Student []st = new Student[2];
        for (int i = 0; i < st.Length; i++)
        {
            st[i] = new Student();
            Console.WriteLine("Введите имя: ");
            st[i].Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            st[i].Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            st[i].Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите средний балл: ");
            st[i].Average = Convert.ToDouble(Console.ReadLine());
            //st[i].Code = 100; // свойство Code только для чтения
        }
        for (int i = 0; i < st.Length; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", st[i].Code, st[i].Name, st[i].Surname, st[i].Age, st[i].Average);
        }
	}
}
