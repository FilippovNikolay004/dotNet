using EmployeeAndAirplane;

Employee employee = new Employee();
employee.DataEntry();
employee.DataPrint();

Airplane airplane = new Airplane("F-35А", "Lockheed Martin Corporation", 2011, "Истребитель");
airplane.DataPrint();

airplane = new Airplane("F-35А", "Lockheed Martin Corporation", 2011);
airplane.DataPrint();