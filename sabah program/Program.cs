using System;
using System.IO;
using System.Threading;


class Program
{

    static void Main(string[] args)
    {
        // 


        int chose = 0;
        do
        {
            Console.WriteLine("1.\tRead All Acounts");
            Console.WriteLine("2.\tRead Students' Acounts");
            Console.WriteLine("3.\tRead Teachers' Acounts");
            Console.WriteLine("4.\tCreate a Student Acount");
            Console.WriteLine("5.\tCreate a Teacher Acount");
            Console.WriteLine("6.\tTo quit");
            Console.Write("Please Enter a Number from (1 - 5)\n");
            try
            {

                chose = Int32.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.Write("Please Enter a Number");
            }

            string name;
            string lastname;
            string studentsID;
            string teacherID;
            string email;
            string address;
            long phoneNumber = 0;
            int control = 0;
            string DataToFile = "";

            switch (chose)
            {

                case 1:

                    Console.WriteLine("\nStudents     ::\n");

                    try
                    {   // Open the text file using a stream reader.
                        using (StreamReader sr = new StreamReader("Students.txt"))
                        {
                            // Read the stream to a string, and write the string to the console.
                            String line = sr.ReadToEnd();
                            Console.WriteLine(line);
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }


                    Console.WriteLine("\nTeachers     ::\n");

                    try
                    {   // Open the text file using a stream reader.
                        using (StreamReader sr = new StreamReader("Teachers.txt"))
                        {
                            // Read the stream to a string, and write the string to the console.
                            String line = sr.ReadToEnd();
                            Console.WriteLine(line);
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 2:

                    try
                    {   // Open the text file using a stream reader.
                        using (StreamReader sr = new StreamReader("Students.txt"))
                        {
                            // Read the stream to a string, and write the string to the console.
                            String line = sr.ReadToEnd();
                            Console.WriteLine(line);
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 3:

                    try
                    {   // Open the text file using a stream reader.
                        using (StreamReader sr = new StreamReader("Teachers.txt"))
                        {
                            // Read the stream to a string, and write the string to the console.
                            String line = sr.ReadToEnd();
                            Console.WriteLine(line);
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 4:


                    Console.Write("Please Enter the Student's Name\n");
                    name = Console.ReadLine();

                    Console.Write("Please Enter the Student's LastName\n");
                    lastname = Console.ReadLine();

                    Console.Write("Please Enter student's ID\n");
                    studentsID = Console.ReadLine();

                    Console.Write("Please Enter the Student's email\n");
                    email = Console.ReadLine();

                    Console.Write("Please Enter the Student's address\n");
                    address = Console.ReadLine();

                    Console.Write("Please Enter the Student's phoneNumber\n");
                    try
                    {

                        phoneNumber = Int64.Parse(Console.ReadLine());
                        Console.Write("if you are sure from your inputs to be saved Enter 1 if you will not press another number\n");
                        control = Int32.Parse(Console.ReadLine());


                    }
                    catch (FormatException)
                    {
                        Console.Write("Please Enter a Number\n");
                    }



                    if (control == 1)
                    {
                        DataToFile = name + "\t" + lastname + "\t" + studentsID + "\t" + email + "\t" + address + "\t" + phoneNumber;
                        if (File.Exists("Students.txt"))
                        {
                            // This text is always added, making the file longer over time
                            // if it is not deleted.
                            using (StreamWriter sw = File.AppendText("Students.txt"))
                            {
                                sw.WriteLine(DataToFile);

                            }

                            Thread.Sleep(2000);
                            Console.WriteLine("Data Saved...");
                        }
                        else
                        {
                            System.IO.File.WriteAllText("Students.txt", "name\t\tlastname\tStudentsID\temail\t\taddress\t\tphoneNumber\n");

                            using (StreamWriter sw = File.AppendText("Students.txt"))
                            {
                                sw.WriteLine(DataToFile);

                            }
                            Console.WriteLine("File has been created...");
                            //Sleep for 2 seconds.

                            Thread.Sleep(2000);

                            Console.WriteLine("Data saved ..!");

                        }
                        control = 0;

                    }


                    break;

                case 5:

                    Console.Write("Please Enter the teacher's Name\n");
                    name = Console.ReadLine();

                    Console.Write("Please Enter the teacher's LastName\n");
                    lastname = Console.ReadLine();

                    Console.Write("Please Enter teacher's ID\n");
                    teacherID = Console.ReadLine();

                    Console.Write("Please Enter the teacher's email\n");
                    email = Console.ReadLine();

                    Console.Write("Please Enter the teacher's address\n");
                    address = Console.ReadLine();

                    Console.Write("Please Enter the teacher's phoneNumber\n");
                    try
                    {

                        phoneNumber = Int64.Parse(Console.ReadLine());
                        Console.Write("if you are sure from your inputs to be saved Enter 1 if you will not press another number\n");
                        control = Int32.Parse(Console.ReadLine());


                    }
                    catch (FormatException)
                    {
                        Console.Write("Please Enter a Number\n");
                    }

                    if (control == 1)
                    {
                        DataToFile = name + "\t" + lastname + "\t" + teacherID + "\t" + email + "\t" + address + "\t" + phoneNumber;
                        if (File.Exists("Teachers.txt"))
                        {
                            // This text is always added, making the file longer over time
                            // if it is not deleted.
                            using (StreamWriter sw = File.AppendText("Teachers.txt"))
                            {
                                sw.WriteLine(DataToFile);

                            }

                            Thread.Sleep(2000);
                            Console.WriteLine("Data Saved...");
                        }
                        else
                        {
                            System.IO.File.WriteAllText("Teachers.txt", "name\t\tlastname\tteacherID\temail\t\taddress\t\tphoneNumber\n");

                            using (StreamWriter sw = File.AppendText("Teachers.txt"))
                            {
                                sw.WriteLine(DataToFile);

                            }
                            Console.WriteLine("File has been created...");
                            //Sleep for 2 seconds.

                            Thread.Sleep(2000);

                            Console.WriteLine("Data saved ..!");

                        }
                        control = 0;

                    }

                    break;
            }
        } while (chose != 6);
    }



}