using practice;

List<Student> students = new List<Student> {
    new Student("John", "Smith", 20, "MIT"),
    new Student("Emily", "Johnson", 21, "Stanford University"),
    new Student("Michael", "Brown", 22, "MIT"),
    new Student("Sophia", "Williams", 19, "University of California, Berkeley"),
    new Student("James", "Jones", 18, "Yale University"),
    new Student("Isabella", "Miller", 23, "MIT"),
    new Student("Ethan", "Davis", 20, "Columbia University"),
    new Student("Olivia", "Garcia", 21, "University of Chicago"),
    new Student("Alexander", "Martinez", 22, "MIT"),
    new Student("Mia", "Hernandez", 19, "California Institute of Technology")
};

// Получить весь массив студентов
var task1 = from student in students
            select student;
foreach (var item in task1) {
    Console.WriteLine($"{item} ");
}
Console.WriteLine("");

task1 = students.Select(student => student);
foreach (var item in task1) {
    Console.WriteLine($"{item} ");
}
Console.WriteLine("");


// Получить студентов с именем James
var task2 = from student in students
            where student._name == "James"
            select student;
foreach (var item in task2) {
    Console.Write($"{item} ");
}
Console.WriteLine("");

task2 = students.Where(student => student._name == "James");
foreach (var item in task2) {
    Console.Write($"{item} ");
}
Console.WriteLine("");


// Получить студентов с фамилией, которая начинается с Jo
var task3 = from student in students
            where student._lastName.ToLower().StartsWith("jo")
            select student;
foreach (var item in task3) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");

task3 = students.Where(student => student._lastName.ToLower().StartsWith("jo"));
foreach (var item in task3) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");


// Получить студентов, которые старше 19 лет
var task4 = from student in students
            where student._age > 19
            select student;
foreach (var item in task4) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");

task4 = students.Where(student => student._age > 19);
foreach (var item in task4) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");


// Получить студентов, которые старше 20 лет и младше 23 лет
var task5 = from student in students
            where student._age > 20 && student._age < 23
            select student;
foreach (var item in task5) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");

task5 = students.Where(student => student._age > 20 && student._age < 23);
foreach (var item in task5) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");


// Получить студентов, которые учатся в MIT
var task6 = from student in students
            where student._nameEducationalInstitution == "MIT"
            select student;
foreach (var item in task6) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");

task6 = students.Where(student => student._nameEducationalInstitution == "MIT");
foreach (var item in task6) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");


// Получить студентов, которые учатся в MIT и их возраст
//старше 18 лет. Результат отсортировать по возрасту по
//убыванию.
var task7 = from student in students
            where student._nameEducationalInstitution == "MIT" &&
                student._age > 18
            orderby student._age descending
            select student;
foreach (var item in task7) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");

task7 = students.Where(
    student => student._nameEducationalInstitution == "MIT" && student._age > 18
).OrderByDescending(student => student._age);
foreach (var item in task7) {
    Console.Write($"{item}\n");
}
Console.WriteLine("");