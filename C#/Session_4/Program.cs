#region Task 1
// String Initialization and Continuance Condition
//string allProducts = "";
//Console.WriteLine("Enter a product name (When finished enter done):");

//while (true)
//{
//    string product = Console.ReadLine();

//    if (product == "done")
//        break;

//    allProducts += "\n- " + product;
//}

//Console.WriteLine("\nAll Products:" + allProducts);

#endregion

#region Assignment 1

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"welcome {i}");
//}

//Console.WriteLine(); 

//for (int i = 5; i >= 1; i--)
//{
//    Console.WriteLine($"hi, {i}");
//}

//Console.WriteLine(); 

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"i: {i}");
//    if (i == 3)
//        break;
//}

#endregion

#region Assignment 2
// Print odd numbers from 1 to 10
//Console.WriteLine("Odd Numbers:");
//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 == 0)
//        continue;
//    Console.WriteLine(i);
//}

//Console.WriteLine(); // Spacer

//// Print even numbers from 1 to 10
//Console.WriteLine("Even Numbers:");
//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 != 0)
//        continue;
//    Console.WriteLine(i);
//}

//Console.WriteLine(); // Spacer

//// Multiple initializations in a single loop
//Console.WriteLine("Multiple Initializations:");
//for (int i = 0, j = 10; i <= j && j <= 20; i++, j++)
//{
//    Console.WriteLine($"i: {i}, j: {j} => i + j = {i + j}");
//}

#endregion

#region Assignment 3
//for (int i = 1; i <= 12; i++)
//{ 
//    Console.WriteLine($"{i} Multiplication Table:");

//    for (int j = 1; j <= 12; j++)
//    {
//        Console.WriteLine($"{j} * {i} = {j * i}");
//    }
//    Console.WriteLine();
//}
#endregion

#region Task 2
//Console.Write("Enter the number of departments: ");
//byte departmentCount = byte.Parse(Console.ReadLine());
//string departmentSummary = "";

//for (int i = 0; i < departmentCount; i++)
//{
//    Console.Write($"Enter name for department #{i + 1}: ");
//    string departmentName = Console.ReadLine();

//    Console.Write($"Enter number of employees in {departmentName}: ");
//    short employeeCount = short.Parse(Console.ReadLine());

//    string employeeNames = "";
//    for (int j = 0; j < employeeCount; j++)
//    {
//        Console.Write($"Enter name for employee #{j + 1}: ");
//        string employeeName = Console.ReadLine();
//        employeeNames += $"\t- {employeeName}\n";
//    }

//    departmentSummary += $"\n{i + 1}- {departmentName}:\n{employeeNames}";
//}
//Console.WriteLine("\nAll Departments:" + departmentSummary);
#endregion

#region Task 3
// do .. While loop
//char answer='\0';
//do
//{
//    Console.WriteLine("Trying to connect to the server...");
//    Thread.Sleep(5000);
//    Console.WriteLine("Connection failed. Do you want to retry? (y/n)");

//    answer = char.Parse(Console.ReadLine());
//}
//while (answer == 'y' || answer=='Y');

#endregion

#region Assignment 4
// foreach
//string iti = "MCIT ITI";
//foreach (var item in iti)
//{
//    Console.WriteLine("\t|" + item + "|");
//}

//// while
//while (DateTime.Now.Hour == 12 && DateTime.Now.Minute == 11)
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Welcome to while. It's 11:57 AM ");
//}

//byte repitition = 1;
//while (repitition <= 10)
//{
//    Thread.Sleep(2000);
//    Console.WriteLine(repitition + ". Welcome to Sunshine");
//    repitition++;
//}


#endregion

#region Task 4
// Array (fixed-size)
//int[] weekProduction = new int[5];
//weekProduction[0] = 12;
//weekProduction[1] = 15;
//weekProduction[2] = 20;
//weekProduction[3] = 25;
//weekProduction[4] = 32;

//// Initialization
//int[] weekProduction1 = new int[] { 12, 15, 20, 25, 32 };
//int[] weekProduction2 = { 12, 15, 20, 25, 32 };
//int[] weekProduction3 = new int[5] { 12, 15, 20, 25, 32 };

//Console.WriteLine("weekProduction[0]: " + weekProduction[0]);
//Console.WriteLine("weekProduction[1]: " + weekProduction[1]);
//Console.WriteLine("weekProduction[2]: " + weekProduction[2]);
//Console.WriteLine("weekProduction[3]: " + weekProduction[3]);
//Console.WriteLine("weekProduction[4]: " + weekProduction[4]);

//Console.WriteLine("weekProduction.Length: " + weekProduction.Length);

//for (int i = 0; i < weekProduction.Length; ++i)
//{
//    Console.WriteLine("weekProduction[" + i + "]: " + weekProduction[i]);
//}

//Console.WriteLine("weekProduction:");
//foreach (int item in weekProduction)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("weekProduction.Contains(72): " + weekProduction.Contains(72)); // False
//Console.WriteLine("weekProduction.Contains(32): " + weekProduction.Contains(32)); // True

//Console.WriteLine("Array.IndexOf(weekProduction, 72): " + Array.IndexOf(weekProduction, 72)); // -1
//Console.WriteLine("Array.IndexOf(weekProduction, 32): " + Array.IndexOf(weekProduction, 32)); // 4

//Console.WriteLine("Array.LastIndexOf(weekProduction, 72): " + Array.LastIndexOf(weekProduction, 72)); // -1
//Console.WriteLine("Array.LastIndexOf(weekProduction, 32): " + Array.LastIndexOf(weekProduction, 32)); // 4

#endregion

#region Task 5
//int[] week1Production = { 21, 11, 51, 41, 31 };
//int[] week2Production = new int[5] { 22, 12, 52, 42, 32 };
//int[] week3Production = new int[5] { 23, 13, 53, 43, 33 };
//int[] week4Production = { 24, 14, 54, 44, 34 };
//var week5Production = new int[] { 25, 15, 55, 45, 35 };

//int[] month1Production = new int[20];

//Array.Copy(week1Production, 0, month1Production, 0, 5);
//Array.Copy(week2Production, 0, month1Production, 5, 5);
//Array.Copy(week3Production, 0, month1Production, 10, 5);
//Array.Copy(week4Production, 0, month1Production, 15, 5);

//foreach (int item in month1Production)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Task 6
//int[] week5Production = new int[] { 25, 15, 55, 35, 15, 35 };
//Console.WriteLine("\nBefore Array.Sort():");
//foreach (var item in week5Production)
//{
//    Console.Write(item + " ");
//}
//Array.Sort(week5Production);
//Console.WriteLine("\nAfter Array.Sort():");
//foreach (var item in week5Production)
//{
//    Console.Write(item + " ");
//}
//Array.Reverse(week5Production);
//Console.WriteLine("\nAfter Array.Reverse():");
//foreach (var item in week5Production)
//{
//    Console.Write(item + " ");
//}
//int[] week3Production = new int[] { 23, 13, 15, 43, 33 };

//Console.WriteLine("\n\nBefore Array.Sort():");
//foreach (var item in week3Production)
//{
//    Console.Write(item + " ");
//}
//Array.Sort(week3Production, 1, 3);
//Console.WriteLine("\nAfter Array.Sort(week3Production, 1, 3):");
//foreach (var item in week3Production)
//{
//    Console.Write(item + " ");
//}
//Array.Reverse(week3Production, 1, 3);
//Console.WriteLine("\nAfter Array.Reverse(week3Production, 1, 3):");
//foreach (var item in week3Production)
//{
//    Console.Write(item + " ");
//}


#endregion

#region Task 7
//class program
//{
//    static float SumUsingArrayParameter(float[] numbers)
//    {
//        float sum = 0f;
//        foreach (var item in numbers)
//        {
//            sum += item;
//        }
//        return sum;
//    }
//    static float SumUsingParams(params float[] numbers)
//    {
//        float sum = 0f;
//        foreach (var item in numbers)
//        {
//            sum += item;
//        }
//        return sum;
//    }
//    static void Main()
//    {
//        float[] student1Scores = { 30.5f, 29f, 48.2f, 35f };
//        float student1TotalScore = SumUsingArrayParameter(student1Scores);
//        Console.WriteLine("student1TotalScore: " + student1TotalScore);

//        float student2TotalScore = SumUsingParams(30.5f, 29f, 48.2f, 35f);
//        Console.WriteLine("student2TotalScore: " + student2TotalScore);
//    }
//}
#endregion

#region Task 8
// ArrayList
//using System.Collections;

//// (1) Arrays require uniform types, while ArrayLists allow mixed types
//ArrayList scores = new ArrayList() { 75, 98, "Eighty-two" };
//Console.WriteLine("scores.Count: " + scores.Count);
//Console.WriteLine("scores[1]: " + scores[1]);
//scores[1] = 93;
//Console.WriteLine("scores[1]: " + scores[1]);

//Console.WriteLine("\nscores:");
//for (int i = 0; i < scores.Count; i++)
//{
//    Console.WriteLine("scores[" + i + "]: " + scores[i]);
//}

//// (2) Arrays have fixed sizes, while ArrayLists grow dynamically
//ArrayList branches = new ArrayList() { "Egypt", "Oman", "Kuwait", "Bahrain" };
//branches.Add("KSA");
//branches.Add("UAE");
//branches.Add("Qatar");
//branches.Add("Morocco");

//Console.WriteLine("\nbranches:");
//for (int i = 0; i < branches.Count; i++)
//{
//    Console.WriteLine("branches[" + i + "]: " + branches[i]);
//}

// (3) Arrays are generally faster than ArrayLists due to boxing/unboxing overhead

#endregion

