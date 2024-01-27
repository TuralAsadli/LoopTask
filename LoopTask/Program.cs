namespace LoopTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }


        public static void Task1()
        {
            int product = 1;

            for (int i = 1; i <= 50; i += 3)
            {
                product *= i;
            }

            Console.WriteLine(product);
        }

        public static void Task2()
        {
            int sumDivisibleBy3And6 = 0;
            int productDivisibleBy5Or2 = 1;
            int countOddNumbers = 0;

            for (int i = -30; i <= 28; i++)
            {
                // Sum of numbers divisible by both 3 and 6
                if (i % 3 == 0 && i % 6 == 0)
                {
                    sumDivisibleBy3And6 += i;
                }

                // Product of numbers divisible by 5 or 2
                if (i % 5 == 0 || i % 2 == 0)
                {
                    productDivisibleBy5Or2 *= i;
                }

                // Counting odd numbers
                if (i % 2 != 0)
                {
                    countOddNumbers++;
                }
            }

            Console.WriteLine("Sum of numbers divisible by both 3 and 6: " + sumDivisibleBy3And6);
            Console.WriteLine("Product of numbers divisible by 5 or 2: " + productDivisibleBy5Or2);
            Console.WriteLine("Number of odd numbers from -30 to 28: " + countOddNumbers);
        }

        public static void Task3(int number)
        {

            int sumPositiveDigits = 0;
            int sumNonNegativeDigits = 0;

            // Convert the number to a string to iterate through its digits
            string numberString = number.ToString();

            foreach (char digitChar in numberString)
            {
                // Convert each digit character back to an integer
                int digit = int.Parse(digitChar.ToString());

                // Sum of positive digits
                if (digit > 0)
                {
                    sumPositiveDigits += digit;
                }

                // Sum of non-negative digits
                sumNonNegativeDigits += digit;
            }

            Console.WriteLine("Sum of positive digits: " + sumPositiveDigits);
            Console.WriteLine("Sum of non-negative digits: " + sumNonNegativeDigits);
        }

        public static void Task4(double number)
        {
            var reversList = number.ToString().Reverse();
            string result = "";
            foreach (char digitChar in reversList)
            {
                result+= digitChar.ToString();
            }
            Console.WriteLine(result); 
        }


        public static void Task5()
        {
            int maxAttempts = 3;
            int attempts = 0;

            string correctLogin = "user123";
            string correctPassword = "pass123";

            while (attempts < maxAttempts)
            {
                Console.Write("Enter login: ");
                string enteredLogin = Console.ReadLine();

                Console.Write("Enter password: ");
                string enteredPassword = Console.ReadLine();

                if (enteredLogin == correctLogin && enteredPassword == correctPassword)
                {
                    Console.WriteLine("Login successful. You are now logged in.");
                    break;
                }
                else
                {
                    if (enteredLogin != correctLogin)
                    {
                        Console.WriteLine("Login is incorrect.");
                    }

                    if (enteredPassword != correctPassword)
                    {
                        Console.WriteLine("Password is incorrect.");
                    }

                    attempts++;

                    if (attempts < maxAttempts)
                    {
                        Console.WriteLine($"You have {maxAttempts - attempts} attempt(s) remaining. Try again.");
                    }
                }
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine("Too many incorrect attempts. Account blocked.");
            }
        }

        ///======================
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Course { get; set; }
        }

        public static void LoopTask1()
        {
            Student[] students = new Student[5];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");

                students[i] = new Student();

                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Age: ");
                students[i].Age = int.Parse(Console.ReadLine());

                Console.Write("Course: ");
                students[i].Course = Console.ReadLine();

                Console.WriteLine();
            }


            DisplayStudentDetails(students);
        }

        static void DisplayStudentDetails(params Student[] students)
        {
            Console.WriteLine("Student Details:");

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Course: {student.Course}");
            }
        }




        static void LoopTask()
        {
            int[] numbers = new int[5];


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            int sumEven = 0;
            int productOdd = 1;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    
                    sumEven += number;
                }
                else
                {
                    
                    productOdd *= number;
                }
            }


            Console.WriteLine($"Sum of even elements: {sumEven}");
            Console.WriteLine($"Product of odd elements: {productOdd}");
        }

        static void LoopTask3()
        {
            int[] NumberA = { 4, 6, -3, 44, -5 };
            int[] NumberB = { 9, 16, 100, 11, -20 };


            int maxA = NumberA[0];
            for (int i = 1; i < NumberA.Length; i++)
            {
                if (NumberA[i] > maxA)
                {
                    maxA = NumberA[i];
                }
            }


            int minB = NumberB[0];
            for (int i = 1; i < NumberB.Length; i++)
            {
                if (NumberB[i] < minB)
                {
                    minB = NumberB[i];
                }
            }


            int indexOfMaxA = Array.IndexOf(NumberA, maxA);
            int indexOfMinB = Array.IndexOf(NumberB, minB);

            int temp = NumberA[indexOfMaxA];
            NumberA[indexOfMaxA] = NumberB[indexOfMinB];
            NumberB[indexOfMinB] = temp;


            Console.WriteLine("NumberA after swapping:");
            foreach (var num in NumberA)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nNumberB after swapping:");
            foreach (var num in NumberB)
            {
                Console.Write(num + " ");
            }
        }

        static void LoopTask4()
        {
            int[,] matrixA = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matrixB = { { 7, 8 }, { 9, 10 }, { 11, 12 } };

            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                Console.WriteLine("Matrices cannot be multiplied.");
                return;
            }


            int[,] productMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];


            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        productMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }


            Console.WriteLine("Product of matrices A and B:");
            for (int i = 0; i < productMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < productMatrix.GetLength(1); j++)
                {
                    Console.Write(productMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}