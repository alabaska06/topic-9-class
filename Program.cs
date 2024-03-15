namespace topic_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student person = new Student("Alanna", "Smith");
            Student person2 = new Student("Jordyna", "Jones");
            Student person3 = new Student("Cole", "Smith");
            Student person4 = new Student("Domenic", "Maniacco");
            Student person5 = new Student("Ryker", "Ostrander");

            List<Student> students = new List<Student>();

            students.Add(person);
            students.Add(person2);
            students.Add(person3);
            students.Add(person4);
            students.Add(person5);

            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Welcome to my menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Display Students");
                Console.WriteLine("2 - Student Details");
                Console.WriteLine("3 - Add a Student");
                Console.WriteLine("4 - Remove a Student");
                Console.WriteLine("5 - Search for a Student");
                Console.WriteLine("6 - Edit a Student");
                Console.WriteLine("7 - Sort Students");
                Console.WriteLine("8 - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose: Display Students\n");

                    Console.WriteLine("Here is the current list of Students: \n");

                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose: Student Details\n");
                    Console.WriteLine("Here is the current list of students along with their details:\n");

                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                        Console.WriteLine($"Student Number: {student.studentNum}");
                        Console.WriteLine($"Email: {student.Email}");
                        Console.WriteLine();
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    int add;

                    Console.WriteLine("You chose: Add a Student\n");

                    Console.WriteLine("How many students would you like to add?\n");
                    add = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < add; i++)
                    {
                        Console.WriteLine($"Enter details for the student:\n");
                        Console.WriteLine("First Name:\n");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("\nLast Name:\n");
                        string lastName = Console.ReadLine();

                        Student newStudent = new Student(firstName, lastName);
                        students.Add(newStudent);
                    }

                    Console.WriteLine("\nHere is the new list of students:\n");

                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    string remove;
                    Console.WriteLine("You chose: Remove a Student\n");

                    Console.WriteLine("Please type the full name of the student you'd like to remove below:\n");
                    remove = Console.ReadLine();

                    students.RemoveAll(student => $"{student.FirstName} {student.LastName}" == remove);

                    Console.WriteLine($"{remove} has been removed, here is the revised list:\n");

                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    string search;

                    Console.WriteLine("You chose: Search for a Student\n");

                    Console.WriteLine("Please type the full name of the student you'd like to find.\n");
                    search = Console.ReadLine();

                    Student lostStudent = students.Find(student => $"{student.FirstName} {student.LastName}" == search);

                    if (lostStudent != null)
                    {
                        Console.WriteLine($"\n{lostStudent} is in the list. Here is their information:\n");
                        Console.WriteLine(lostStudent);
                        Console.WriteLine($"Student Number: {lostStudent.studentNum}");
                        Console.WriteLine($"Email: {lostStudent.Email}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nStudent not found.\n");
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "6")
                {
                    string edit;

                    Console.WriteLine("You chose: Edit a Student\n");

                    Console.WriteLine("Please type the full name of the studnt you'd like to edit.\n");
                    edit = Console.ReadLine();

                    Student studentToEdit = students.Find(student => $"{student.FirstName} {student.LastName}" == edit);

                    if (studentToEdit != null)
                    {
                        Console.WriteLine($"Student found: {studentToEdit.FirstName} {studentToEdit.LastName}");
                        Console.WriteLine("Please enter new details for the student:");

                        Console.Write("New First Name: ");
                        string newFirstName = Console.ReadLine();
                        Console.Write("New Last Name: ");
                        string newLastName = Console.ReadLine();

                        studentToEdit.FirstName = newFirstName;
                        studentToEdit.LastName = newLastName;

                        Console.WriteLine($"\n{studentToEdit} has been edited. Here is their new information:\n");
                        Console.WriteLine(studentToEdit);
                        Console.WriteLine($"Student Number: {studentToEdit.studentNum}");
                        Console.WriteLine($"Email: {studentToEdit.Email}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nStudent not found.\n");
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "7")
                {
                    Console.WriteLine("You chose: Sort Students\n");
                    Console.WriteLine("Here is the revised list (sorted alpahbetically by first name): \n");

                    students.Sort((student1, student2) => string.Compare($"{student1.FirstName} {student1.LastName}", $"{student2.FirstName} {student2.LastName}"));

                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else
                {
                    choice = "q";
                    Console.WriteLine("Thank you.");
                }
            }
        }
    }
}
