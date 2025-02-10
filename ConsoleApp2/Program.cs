using ConsoleApp2;

//Excercise1();
//Excercise2();
Excercire3();

//i++ vs ++i
//int broj = i++;

//broj = i;
//i = i + 1;
//broj = ++i;

//i = i + 1;
//broj = i;

static void Excercise1()
{
    // TODO: Ask for student's name (string)
    // TODO: Ask for student's age (int)
    // TODO: Ask for student's grade average (double)
    // TODO: Display all information in a formatted way
    // TODO: Display all information in a formatted way


    // TODO: Ask for student's name (string)
    Console.WriteLine("Enter student name: ");
    string name = Console.ReadLine();

    // TODO: Ask for student's age (int)
    Console.WriteLine("Enter student age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    // TODO: Ask for student's grade average (double)

    Console.WriteLine("Enter student grade average: ");
    double grade = Convert.ToDouble(Console.ReadLine());

    // TODO: Display all information in a formatted way
    Console.WriteLine("Entered student details:");
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Grade: {grade}");
}

static void Excercise2()
{
    // TODO: Ask for student's name
    Console.WriteLine("Enter student name: ");
    string name = Console.ReadLine();

    // TODO: Create an array to store 5 grades
    double[] grades = new double[5];

    // TODO: Use a loop to input the grades
    for(int i=0;i<grades.Length;i++)
    {
        Console.WriteLine("Enter grade: ");
        grades[i] = Convert.ToDouble(Console.ReadLine());
    }


    // TODO: Display student's name and calculated average
    Console.WriteLine($"Student {name}");

    double prosek = CalculateAverage(grades);
    Console.WriteLine($"Average grade: {prosek}");

    Console.WriteLine($"Average grade: {CalculateAverage(grades)}");
}

    // TODO: Create a method to calculate average
static double CalculateAverage(double[] ocenki)
{
    double suma = 0;

    foreach (var ocenka in ocenki)
    {
        suma += ocenka;
    }

    return suma / ocenki.Length;
}

// TODO: Create Student class with properties:
// - Name (string)
// - Age (int)
// - Grades (List<double>)
// TODO: Add constructor
// TODO: Add method to add grades
// TODO: Add method to calculate average
static void Excercire3()
{
    Console.WriteLine("Enter student name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter student age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    
    // TODO: Create student instance
    Student student = new Student(name, age);

    // TODO: Add grades
    student.AddGrades();

    // TODO: Display student information
    student.DisplayStudentInfo();

}

