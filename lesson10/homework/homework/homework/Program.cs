using homework;

Student[] students = {
    new Student("Ivan", "Ivanov", 20, "768473860", 25.0, 2),
    new Student("Petr", "Petrov", 19, "761377874", 21.0, 2),
    new Student("Antonio", "Banderas", 22, "3847563", 28.0, 3)
};

AcademyGroup academyGroup = new AcademyGroup(students);
academyGroup.Print();
Console.WriteLine("=============");

academyGroup.Add(new Student("test", "test", 20, "3874653", 22.0, 2));
academyGroup.Print();
Console.WriteLine("=============");

academyGroup.Remove("test");
academyGroup.Print();
Console.WriteLine("=============");

academyGroup.Edit("Banderas", new Student("test", "test", 19, "34675435", 28.1, 2));
academyGroup.Print();
