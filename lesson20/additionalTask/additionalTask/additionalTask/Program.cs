using additionalTask;

// Создание паспортов
Passport passport1 = new Passport("US", "A1234567", new DateTime(2015, 8, 14), "USA Government", new DateTime(2025, 8, 14));
Passport passport2 = new Passport("DE", "B7654321", new DateTime(2017, 5, 23), "German Authorities", new DateTime(2027, 5, 23));
Passport passport3 = new Passport("GB", "C9876543", new DateTime(2018, 1, 30), "UK Government", new DateTime(2028, 1, 30));
Passport passport4 = new Passport("FR", "D1122334", new DateTime(2019, 3, 15), "French Government", new DateTime(2029, 3, 15));
Passport passport5 = new Passport("IT", "E5566778", new DateTime(2020, 7, 10), "Italian Authorities", new DateTime(2030, 7, 10));

// Создание студентов
Student student1 = new Student("Smith", "John", "Male", passport1, "New York", new List<Parent>());
Student student2 = new Student("Müller", "Anna", "Female", passport2, "Berlin", new List<Parent>());
Student student3 = new Student("Johnson", "Emily", "Female", passport3, "London", new List<Parent>());
Student student4 = new Student("Lemoine", "Pierre", "Male", passport4, "Paris", new List<Parent>());
Student student5 = new Student("Rossi", "Marco", "Male", passport5, "Rome", new List<Parent>());

// Создание родителей
Parent parent1 = new Parent("Smith", "Jennifer", "Female", passport1, "New York", new List<Student> { student1 });
Parent parent2 = new Parent("Müller", "Heinz", "Male", passport2, "Berlin", new List<Student> { student2 });
Parent parent3 = new Parent("Johnson", "David", "Male", passport3, "London", new List<Student> { student3 });
Parent parent4 = new Parent("Lemoine", "Marie", "Female", passport4, "Paris", new List<Student> { student4 });
Parent parent5 = new Parent("Rossi", "Giovanna", "Female", passport5, "Rome", new List<Student> { student5 });

// Обновим студентов с родителями
student1.Parents.Add(parent1);
student2.Parents.Add(parent2);
student3.Parents.Add(parent3);
student4.Parents.Add(parent4);
student5.Parents.Add(parent5);