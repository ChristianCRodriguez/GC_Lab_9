using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, studentSelected = 0, studentIndex = 0;
            string userInput;
            bool continueApp = true, repeatApp = true;

            List<StudentInfo> studentList = new List<StudentInfo>()
            {
                new StudentInfo("Christian R","Broccoli Cheddar Soup","Long Beach", "Blue"),
                new StudentInfo("Guadalupe R","Apple Pie","Long Beach", "Navy Blue"),
                new StudentInfo("Andrea M","Mexican Food","Grand Blanc", "Red")
            };
            
            do
            {
                Console.WriteLine("Welcome to our class!\n");

                DisplayStudentList(studentList);

                Console.WriteLine("Which student would you like to learn about?");

                do
                {
                    if (continueApp == false)
                    {
                        Console.Write("\nThat student does not exist. Please enter the number next to the Student you would like to learn about: ");
                    }

                    userInput = GetUserInput();

                    studentIndex = GetIndex(userInput);

                    studentSelected = studentIndex + 1;

                    continueApp = DoesStudentExist(studentList, studentIndex);
                } while (continueApp == false);
                
                Console.Write($"\nStudent {studentSelected} is {studentList[studentIndex].Name}. What would you like to know about {studentList[studentIndex].Name}?\n(Enter \"hometown\" or \"favorite food\" or \"favorite color\"): ");
                userInput = Console.ReadLine();

                while (userInput.ToLower() != "hometown" && userInput.ToLower() != "favorite food" && userInput.ToLower() != "favorite color")
                {
                    Console.Write("\nThat data does not exist. Please try again.\n(Enter \"hometown\" or \"favorite food\" or \"favorite color\"): ");
                    userInput = Console.ReadLine();
                }

                if (userInput.ToLower() == "hometown")
                {
                    Console.Write($"\n{studentList[studentIndex].Name} is from {studentList[studentIndex].Hometown}. Would you like to know another fact about {studentList[studentIndex].Name}?\n(Enter \"yes\" or \"no\"): ");
                    userInput = Console.ReadLine();

                    while (userInput.ToLower() != "yes" && userInput.ToLower() != "no")
                    {
                        Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\"): ");
                        userInput = Console.ReadLine();
                    }

                    if (userInput.ToLower() == "yes")
                    {
                        Console.WriteLine($"\n{studentList[studentIndex].Name}'s favorite food is {studentList[studentIndex].Food}. Would you like to know another fact about {studentList[studentIndex].Name}?\n(Enter \"yes\" or \"no\"): ");
                        userInput = Console.ReadLine();

                        while (userInput.ToLower() != "yes" && userInput.ToLower() != "no")
                        {
                            Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\"): ");
                            userInput = Console.ReadLine();
                        }

                        if (userInput.ToLower() == "yes")
                        {
                            Console.WriteLine($"\n{studentList[studentIndex].Name}'s favorite color is {studentList[studentIndex].Color}.");
                        }
                    }

                    Console.Write("\nWould you like to learn about or add another student? (Enter \"yes\" or \"no\" or \"add\"): ");
                    userInput = Console.ReadLine();

                    while (userInput.ToLower() != "yes" && userInput.ToLower() != "no" && userInput.ToLower() != "add")
                    {
                        Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\" or \"add\"): ");
                        userInput = Console.ReadLine();
                    }

                    if (userInput.ToLower() == "yes")
                    {
                        repeatApp = true;
                    }
                    else if (userInput.ToLower() == "no")
                    {
                        repeatApp = false;
                    }
                    else
                    {
                        List<StudentInfo> tempList = AddNewStudent();
                        foreach (var student in tempList)
                        {
                            studentList.Add(student);
                        }
                        repeatApp = true;
                    }
                }
                else if (userInput.ToLower() == "favorite food")
                {
                    Console.WriteLine($"\n{studentList[studentIndex].Name}'s favorite food is {studentList[studentIndex].Food}. Would you like to know another fact about {studentList[studentIndex].Name}?\n(Enter \"yes\" or \"no\"): ");

                    userInput = Console.ReadLine();

                    while (userInput.ToLower() != "yes" && userInput.ToLower() != "no")
                    {
                        Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\"): ");
                        userInput = Console.ReadLine();
                    }

                    if (userInput.ToLower() == "yes")
                    {
                        Console.Write($"\n{studentList[studentIndex].Name} is from {studentList[studentIndex].Hometown}. Would you like to know another fact about {studentList[studentIndex].Name}?\n(Enter \"yes\" or \"no\"): ");
                        userInput = Console.ReadLine();

                        while (userInput.ToLower() != "yes" && userInput.ToLower() != "no")
                        {
                            Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\"): ");
                            userInput = Console.ReadLine();
                        }

                        if (userInput.ToLower() == "yes")
                        {
                            Console.WriteLine($"\n{studentList[studentIndex].Name}'s favorite color is {studentList[studentIndex].Color}.");
                        }
                    }

                    Console.Write("\nWould you like to learn about or add another student? (Enter \"yes\" or \"no\" or \"add\"): ");
                    userInput = Console.ReadLine();

                    while (userInput.ToLower() != "yes" && userInput.ToLower() != "no" && userInput.ToLower() != "add")
                    {
                        Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\" or \"add\"): ");
                        userInput = Console.ReadLine();
                    }

                    if (userInput.ToLower() == "yes")
                    {
                        repeatApp = true;
                    }
                    else if (userInput.ToLower() == "no")
                    {
                        repeatApp = false;
                    }
                    else
                    {
                        List<StudentInfo> tempList = AddNewStudent();
                        foreach (var student in tempList)
                        {
                            studentList.Add(student);
                        }
                        repeatApp = true;
                    }
                }
                else
                {
                    Console.WriteLine($"\n{studentList[studentIndex].Name}'s favorite color is {studentList[studentIndex].Color}. Would you like to know another fact about {studentList[studentIndex].Name}?\n(Enter \"yes\" or \"no\"): ");

                    userInput = Console.ReadLine();

                    while (userInput.ToLower() != "yes" && userInput.ToLower() != "no")
                    {
                        Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\"): ");
                        userInput = Console.ReadLine();
                    }

                    if (userInput.ToLower() == "yes")
                    {
                        Console.Write($"\n{studentList[studentIndex].Name} is from {studentList[studentIndex].Hometown}. Would you like to know another fact about {studentList[studentIndex].Name}?\n(Enter \"yes\" or \"no\"): ");
                        userInput = Console.ReadLine();

                        while (userInput.ToLower() != "yes" && userInput.ToLower() != "no")
                        {
                            Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\"): ");
                            userInput = Console.ReadLine();
                        }

                        if (userInput.ToLower() == "yes")
                        {
                            Console.WriteLine($"\n{studentList[studentIndex].Name}'s favorite food is {studentList[studentIndex].Food}.");
                        }
                    }

                    Console.Write("\nWould you like to learn about or add another student? (Enter \"yes\" or \"no\" or \"add\"): ");
                    userInput = Console.ReadLine();

                    while (userInput.ToLower() != "yes" && userInput.ToLower() != "no" && userInput.ToLower() != "add")
                    {
                        Console.Write("\nThat input is not valid. Please try again.\n(Enter \"yes\" or \"no\" or \"add\"): ");
                        userInput = Console.ReadLine();
                    }

                    if (userInput.ToLower() == "yes")
                    {
                        repeatApp = true;
                    }
                    else if (userInput.ToLower() == "no")
                    {
                        repeatApp = false;
                    }
                    else
                    {
                        List<StudentInfo> tempList = AddNewStudent();
                        foreach (var student in tempList)
                        {
                            studentList.Add(student);
                        }
                        repeatApp = true;
                    }
                }
            } while (repeatApp == true);
            Console.WriteLine("\nGoodbye!");
            #region inclass
            //StudentInfo angelo = new StudentInfo("Angelo", "Detroit","Chicken");
            //studentList.Add(angelo);

            //Console.WriteLine("Add new student");

            //bool repeat = true;

            //while (repeat)
            //{
            //    Console.WriteLine("Give me a new student name");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Give me their hometown");
            //    string hometown = Console.ReadLine();
            //    Console.WriteLine("Give me their favorite food");
            //    string food = Console.ReadLine();

            //    //StudentInfo newStudent = new StudentInfo(name, hometown, food);
            //    //var newStudent = new StudentInfo(name, hometown, food);

            //    studentList.Add(new StudentInfo(name, hometown, food));

            //    Console.WriteLine("Continue?");
            //    string input = Console.ReadLine();
            //    repeat = bool.Parse(input);
            //}

            //foreach(StudentInfo student in studentList)
            //{
            //    Console.WriteLine($"{student.Name} is from {student.Hometown} and their favorite food is0 {student.Food}");
            //}
            #endregion
        }

        public static string GetUserInput()
        {
            Console.Write("\nPlease enter the number next to the Student you would like to learn about: ");
            return Console.ReadLine();
        }

        public static void DisplayStudentList(List<StudentInfo> studentList)
        {
            studentList.Sort((x, y) => x.Name.CompareTo(y.Name));
            int i = 1;
            foreach (StudentInfo student in studentList)
            {
                Console.WriteLine($"{i}.) {student.Name}");
                i++;
            }
        }

        public static int GetIndex(string input)
        {
            int index = 0;
            bool repeat = true;

            do
            {
                try
                {
                    index = int.Parse(input);
                    repeat = false;
                }
                catch (FormatException)
                {
                    Console.Write("\nInput is not valid, please try again: ");
                    input = GetUserInput();
                }
                catch (OverflowException)
                {
                    Console.Write("\nThat number is too large, please try again: ");
                    input = GetUserInput();
                }
                catch (Exception)
                {
                    Console.Write("\nThere was an error with your input, please try again: ");
                    input = GetUserInput();
                }
            } while (repeat);
            return --index;
        }
        public static bool DoesStudentExist(List<StudentInfo> list, int index)
        {
            try
            {
                string student = list[index].Name;
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<StudentInfo> AddNewStudent()
        {
            List<StudentInfo> newList = new List<StudentInfo>();
            string temp;
            bool addAnother = false;
            do
            {
                StudentInfo student = new StudentInfo();
                do
                {
                    Console.WriteLine("Please enter the new students name");
                    temp = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(temp));

                student.Name = temp;

                do
                {
                    Console.WriteLine("Please enter the new students hometown");
                    temp = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(temp));

                student.Hometown = temp;

                do
                {
                    Console.WriteLine("Please enter the new students favorite food");
                    temp = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(temp));

                student.Food = temp;

                do
                {
                    Console.WriteLine("Please enter the new students favorite color");
                    temp = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(temp));

                student.Color = temp;

                newList.Add(student);

                Console.WriteLine("Would you like to add another student? y or n");
                temp = Console.ReadLine();
                
                while(temp.ToLower() != "y" && temp.ToLower() != "n")
                {
                    Console.WriteLine("That input is not valid. Please try again");
                    temp = Console.ReadLine();
                }
                addAnother = temp.ToLower() == "y" ? true : false;
            } while (addAnother == true);
            return newList;
        }
    }
}
