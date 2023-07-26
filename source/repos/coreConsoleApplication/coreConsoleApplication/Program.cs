//See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Lets Learn C# Programing");

// string name = "King Kochar";
// int age = 23;
// float discount = 1000.50F;
// double contactNumber = 1234567890;
// char gender = 'M';
// Boolean isValid = true;

// Console.WriteLine("Name:" + name);
// Console.WriteLine("Age:" + age);
// Console.WriteLine("Discount:" + discount);
// Console.WriteLine("Contact Number:" + contactNumber);
// Console.WriteLine("Gender:" + gender);
// Console.WriteLine("Is Valid:" + isValid);

//using System.Text;
//using System.Xml.Serialization;

//int[] marks = new int[5] { 45, 56, 65, 67, 78 };
// marks[0] = 25;
// marks[1] = 50;
// marks[2] = 55;
// marks[3] = 60;
// marks[4] = 40;

// foreach (int mark in marks)
//     Console.WriteLine(mark);

// int[,]multiArray = new int [3,4]{{1,2,3,4}, {1,2,3,4}, {1,2,3,4}};

// for (int i = 0; i < 2; i++){
//     for (int j = 0; j<=3; j++){
//         Console.Write(multiArray[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// int [][]aggedArray = new int[2][];
// aggedArray[0] = new int[2];
// aggedArray[1] = new int [3];

//string str1 = "Hello World";
//string str2 = "C# Programing";
//Console.WriteLine(str1.Length);
//string str3 = string.Concat(str1, str2);
//Console.WriteLine(str3);
//Console.WriteLine(str1.Equals(str2));

////Immutable String
//StringBuilder stringBuilder = new StringBuilder();
//stringBuilder.Append("C# Programing");
//stringBuilder.Append("Java Programing");
//Console.WriteLine(stringBuilder);

using coreConsoleApplication;

student student =  new student();
student.acceptDetails();
student.displayDetails();