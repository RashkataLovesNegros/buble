namespace buble
{
    internal class Program
    {
        
            static void BubbleSort(List<Student> students)
            {
                int n = students.Count;
                bool swapped;

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (students[j].Age > students[j + 1].Age)
                        {
                            Student temp = students[j];
                            students[j] = students[j + 1];
                            students[j + 1] = temp;
                            swapped = true;
                        }
                    }


                    if (!swapped)
                        break;
                }
            }
        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student("Иван", 17),
            new Student("Мария", 16),
            new Student("Петър", 18),
            new Student("Анна", 15)
        };

            Console.WriteLine("Списък преди сортиране:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Age}");
            }

            BubbleSort(students);

            Console.WriteLine("\nСписък след сортиране по възраст:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Age}");
            }
        }
    }
}
    
    
