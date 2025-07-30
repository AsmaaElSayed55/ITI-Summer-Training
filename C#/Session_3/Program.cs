#region Task 1
//for (; ; )
//{
//    Console.Write("\nEnter your Name: ");
//    string applicantName = Console.ReadLine();
//    Console.WriteLine("Hi, " + applicantName);

//    Console.Write("Enter your age: ");
//    byte age = Convert.ToByte(Console.ReadLine());
//    Console.WriteLine("Age: " + (age >= 18 && age <= 45));

//    Console.Write("Enter your foreign language first letter: ");
//    char foreignLanguage = Convert.ToChar(Console.ReadLine().ToUpper());
//    Console.WriteLine("Foreign Language: " + (foreignLanguage == 'E' || foreignLanguage == 'S'));

//    Console.Write("Have you ever applied for this job before? (y/n): ");
//    char appliedBefore = Convert.ToChar(Console.ReadLine().ToLower());
//    Console.WriteLine("New Applicant: " + !(appliedBefore == 'y'));
//}

#endregion

#region Task 2
// Function / Method
// Method Definition        // Method Signature
// Return_Data_Type Method_Name(param_1_Type param_1_Name, param_2_Type param_2_Name)
//float SumTwoNumbers(float firstNo, float secondNo) // Pascal Case & Verb
//{   // Method Body/Implementation
//    return firstNo + secondNo;
//}
//Console.WriteLine("SumTwoNumbers(12.5F, 9.3F): " + SumTwoNumbers(12.5F, 9.3F));

//// 1. Re-usability        2. Maintainability
//decimal CalculatPrice(decimal cost, decimal profitRatio)
//{
//    return cost + cost * profitRatio + cost * 0.20m;
//}

//Console.WriteLine("CalculatPrice(1000m, 0.30m): " + CalculatPrice(1000m, 0.30m));
//Console.WriteLine("CalculatPrice(2000m, 0.20m): " + CalculatPrice(2000m, 0.20m));
//Console.WriteLine("CalculatPrice(6000m, 0.10m): " + CalculatPrice(6000m, 0.10m));

//// No return data type
//void RemindUpdatePassword(string name)
//{
//    Console.WriteLine("\nHi " + name + "\nPlease update your password.");
//}

//RemindUpdatePassword("Ahmed Mostafa");
//RemindUpdatePassword("Hossam Mahmoud");

#endregion

#region Task 3
//Optional Parameters
//void ShowDetails(string fullName, string nationality = "Egyptian")
//{
//    Console.WriteLine("\nFull Name : " + fullName + "\nNationality : " + nationality);
//}

//ShowDetails("Ayman Osama");
//ShowDetails("Ahmed Mostafa", "Kuwaiti");
//ShowDetails("Wael Omar", "Egyptian");

////Named Arguments
//ShowDetails(nationality: "Omani", fullName: "Hassan Othman");

//Console.WriteLine("-------------------- Math Common Methods --------------------");
//Console.WriteLine("Math.Pow(4, 3): " + Math.Pow(4, 3));
//Console.WriteLine("Math.Sqrt(81): " + Math.Sqrt(81));
//Console.WriteLine("Math.Cbrt(64): " + Math.Cbrt(64));
//Console.WriteLine("Math.PI: " + Math.PI);
//Console.WriteLine("Math.Abs(-57): " + Math.Abs(-57));
//Console.WriteLine("Math.Round(8.5): " + Math.Round(8.5));
//Console.WriteLine("Math.Round(8.51): " + Math.Round(8.51));
//Console.WriteLine("(byte)8.5: " + (byte)8.5);
//Console.WriteLine("Convert.ToByte(8.5): " + Convert.ToByte(8.5));
//Console.WriteLine("Math.Ceiling(3.1): " + Math.Ceiling(3.1));
//Console.WriteLine("Math.Floor(5.9): " + Math.Floor(5.9));
//Console.WriteLine("Math.Max(2, 7): " + Math.Max(2, 7));
//Console.WriteLine("Math.Min(3, 5): " + Math.Min(3, 5));
//Console.WriteLine("Math.Sin(90 * Math.PI / 180): " + Math.Sin(90 * Math.PI / 180));
//Console.WriteLine("Math.Cos(90 * Math.PI / 180): " + Math.Cos(90 * Math.PI / 180));
//Console.WriteLine("Math.Tan(90 * Math.PI / 180): " + Math.Tan(90 * Math.PI / 180));

#endregion

#region Task 4
// Expression Bodied Methods
//float SumTwoNumbers(float firstNo, float secondNo) => firstNo + secondNo;

//Console.WriteLine("SumTwoNumbers(10.2f, 5.4f): " + SumTwoNumbers(10.2f, 5.4f));

//void GreetVisitor() => Console.WriteLine("Welcome to Sunshine!");
//GreetVisitor();

//void RemindUpdatePassword(string name) => Console.WriteLine("Hi, " + name + "\nPlease update your password");
//RemindUpdatePassword("Ahmed Osama");

//string TellCompanyName() => "Sunshine Co.";
//Console.WriteLine("TellCompanyName(): " + TellCompanyName());

#endregion

#region Task 5
//Passing arguments by reference
//int totalSales = 250;

//void addNewSales(ref int totalSales, int newSales)
//{
//    totalSales += newSales;
//}

//addNewSales(ref totalSales, 70);

//Console.WriteLine("totalSales: " + totalSales);

#endregion

#region Task 6
//for (; ; )
//{
//    Console.WriteLine("Enter score: ");
//    float score = float.Parse(Console.ReadLine());

//    if (score >= 95)
//    {
//        Console.WriteLine("Excellence Gift: 2000 EGP");
//    }

//    Console.WriteLine("\nStatus: ");
//    if (score >= 50)
//    {
//        Console.WriteLine("Passed");
//    }
//    else
//    {
//        Console.WriteLine("Failed");
//    }

//    Console.WriteLine("\nGrade: ");
//    if (score >= 90)
//    {
//        Console.WriteLine("Perfect");
//    }
//    else if (score >= 80)
//    {
//        Console.WriteLine("Very Good");
//    }
//    else if (score >= 65)
//    {
//        Console.WriteLine("Good");
//    }
//    else if (score >= 50)
//    {
//        Console.WriteLine("Passed");
//    }
//    else if (score >= 40)
//    {
//        Console.WriteLine("Poor");
//    }
//    else
//    {
//        Console.WriteLine("Very Poor");
//    }
//}

#endregion

#region Task 7
// int hour = DateTime.Now.Hour;
//void GreetUser(int hour)
//{
//    if (hour >= 5 && hour < 13)
//    {
//        Console.WriteLine("Good morning");
//    }
//    else if (hour >= 13 && hour < 20)
//    {
//        Console.WriteLine("Good afternoon");
//    }
//    else
//    {
//        Console.WriteLine("Good evening");
//    }
//}

//Console.Write("GreetUser(DateTime.Now.Hour): ");
//GreetUser(DateTime.Now.Hour);

//Console.Write("GreetUser(7): ");
//GreetUser(7);

//Console.Write("GreetUser(15): ");
//GreetUser(15);

//Console.Write("GreetUser(21): ");
//GreetUser(21);

#endregion

#region Assignment
// Without Nested If
//for (; ; )
//{
//    Console.Write("\nEnter the first number: ");
//    float firstNo = Convert.ToSingle(Console.ReadLine());

//    Console.Write("Enter the second number: ");
//    float secondNo = Convert.ToSingle(Console.ReadLine());

//    if (firstNo > secondNo)
//    {
//        Console.WriteLine("The first number is greater than the second number.");
//    }
//    else if(firstNo < secondNo)
//    {
//        Console.WriteLine("The second number is greater than the first number.");
//    }
//    else
//    {
//        Console.WriteLine("The first number is equal to the second number.");
//    }
//}

#endregion

#region Task 8
// Ternary/Conditional Operator ?:
//for (; ; )
//{
//    Console.Write("\nEnter score: ");
//    float score = Convert.ToSingle(Console.ReadLine());

//    string studentStatus = score >= 50 ? "Passed" : "Failed";
//    Console.WriteLine(nameof(studentStatus) + ": " + studentStatus);

//    string studentGrade = score >= 90 ? "Perfect" :
//                          score >= 80 ? "Very Good" :
//                          score >= 65 ? "Good" :
//                          score >= 50 ? "Passed" :
//                          score >= 40 ? "Poor" : "Very Poor";

//    Console.WriteLine(nameof(studentGrade) + ": " + studentGrade);
//}

#endregion

#region Task 9
// switch..case
//for (; ; )
//{
//    Console.Write("Where are you from? ");
//    string country = Console.ReadLine();
//    float discountRatio;

//    switch (country)
//    {
//        case "Egypt":
//        case "Libya":
//        case "Mauritania":
//        case "Tunisia":
//        case "Algeria":
//            discountRatio = 0.30f;
//            break;
//        case "Morocco":
//            discountRatio = 0.20f;
//            break;
//        default:
//            discountRatio = 0.10f;
//            break;
//    }

//    Console.WriteLine("Discount Ratio: " + discountRatio.ToString("P0"));
//}

#endregion

#region Task 10
// switch expression
//for (; ; )
//{
//    Console.Write("Where are you from? ");
//    string country = Console.ReadLine();

//    float discountRatio = country switch
//    {
//        "Egypt" => 0.30f,
//        "Kuwait" => 0.25f,
//        "Libya" or "Mauritania" or "Algeria" or "Tunisia" or "Morocco" => 0.20f,
//        _ => 0.10f
//    };

//    Console.WriteLine("Discount Ratio: " + discountRatio.ToString("P0"));
//}

#endregion