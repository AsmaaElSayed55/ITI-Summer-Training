#region Task 1
// Queue (FIFO)
//Queue<string> waitingCustomers = new Queue<string>();
//waitingCustomers.Enqueue("United Trade");
//waitingCustomers.Enqueue("Nile Hospitals");
//waitingCustomers.Enqueue("Future University");

//foreach (var customer in waitingCustomers)
//    Console.WriteLine(customer);

//waitingCustomers.Dequeue();
//Console.WriteLine("\nwaitingCustomers after Dequeue():");

//foreach (var customer in waitingCustomers)
//    Console.WriteLine(customer);

//Console.WriteLine("--------------------");

//// Stack (LIFO)
//Stack<string> calls = new Stack<string>();
//calls.Push("1. Khalid Ahmed");
//calls.Push("2. Osama Ashraf");
//calls.Push("3. Moal Omar");

//foreach (var call in calls)
//    Console.WriteLine(call);

//calls.Pop();
//Console.WriteLine("\ncalls after Pop():");

//foreach (var call in calls)
//    Console.WriteLine(call);
#endregion

#region Task 2
// <List<T> (Generic Type) [resizable]>
//List<string> allProducts = new List<string>() { "SIS", "ERP", "HRMS" };
//allProducts.Add("CRM");
//allProducts.Add("HIS");

//List<string> mayProducts = new List<string>() { "ABC", "DEF" };
//allProducts.AddRange(mayProducts);

//string[] juneProducts = new string[] { "GHI", "JKL" };
//allProducts.AddRange(juneProducts);

//allProducts.AddRange(new string[] { "MNO", "PQR" });
//allProducts.AddRange(new List<string>() { "STU", "VWX" });

//Console.WriteLine("allProducts[2]: " + allProducts[2]);
//allProducts[2] = "HRIS";
//Console.WriteLine("allProducts[2]: " + allProducts[2]);

//Console.WriteLine("allProducts.Count: " + allProducts.Count);
//Console.WriteLine("allProducts.Count(): " + allProducts.Count());

//for (int i = 0; i < allProducts.Count; i++)
//{
//    Console.WriteLine("allProducts[" + i + "]: " + allProducts[i]);
//}

//Console.WriteLine();
//foreach (string product in allProducts)
//{
//    Console.WriteLine(product);
//}

#endregion

#region Task 3
// Convert List to Array
//string[] productArray = allProducts.ToArray();
//Console.WriteLine("MyproductArray is:");
//foreach (string product in productArray)
//{
//    Console.WriteLine(" - " + product);
//}

//// Convert Array to List
//string[] continentsArray = new string[] { "Africa", "Asia", "Europe", "North America", "South America", "Antarctica" };

//List<string> continentsList = continentsArray.ToList();
//Console.WriteLine("\ncontinentList is:");
//foreach (var continent in continentsList)
//{
//    Console.WriteLine(continent);
//}

#endregion

#region Task 4
// Convert Array to List
//string[] continentsArray = new string[6] { "Africa", "Asia", "Europe", "North America", "South America", "Antarctica" };

//List<string> continentList = continentsArray.ToList();

//continentsArray = null;

//Console.WriteLine("\ncontinentList.Contains(\"Europe\"): " + continentList.Contains("Europe"));
//Console.WriteLine("\ncontinentList.Contains(\"Red Sea\"): " + continentList.Contains("Red Sea"));

//Console.WriteLine("\ncontinentList.IndexOf(\"Europe\"): " + continentList.IndexOf("Europe"));
//Console.WriteLine("\ncontinentList.IndexOf(\"Red Sea\"): " + continentList.IndexOf("Red Sea"));

//Console.WriteLine("\ncontinentList.LastIndexOf(\"Europe\"): " + continentList.LastIndexOf("Europe"));
//Console.WriteLine("\ncontinentList.LastIndexOf(\"Red Sea\"): " + continentList.LastIndexOf("Red Sea"));

//continentList.Remove("North America");
//continentList.RemoveAt(1);
//continentList.RemoveRange(1, 2);

//foreach (string continent in continentList)
//{
//    Console.WriteLine(continent);
//}

#endregion

#region Task 5
//Dictionary<int, string> branches = new Dictionary<int, string>()
//{
//    { 1010,"kuwiat"},
//    { 1020,"bahrain"},
//    { 2010,"thailand"},
//    { 2020,"china"}
//};
//branches.Add(3010, "England");
//branches.Add(3020, "france");

//Console.WriteLine("branches[1020]: ", branches[1020]);
//branches[1020] = "oman";
//Console.WriteLine("branches[1020]: ", branches[1020]);
//Console.WriteLine("all branches: ");

//foreach (var branch in branches)
//    Console.WriteLine(branch);

//foreach (var branch in branches)
//    Console.WriteLine(branch.Key + ": " + branch.Value);

//Console.WriteLine("branches.ContainsKey(1020): " + branches.ContainsKey(1020));
//Console.WriteLine("branches.ContainsKey(1030): " + branches.ContainsKey(1030));
//Console.WriteLine("branches.ContainsKey(\"thailand\"): " + branches.ContainsValue("thailand"));
//Console.WriteLine("branches.ContainsValue(\"japan\"): " + branches.ContainsValue("japan"));
//branches.Remove(3010);
//Console.WriteLine("\nafter remove(3010): ");

//foreach (var branch in branches)
//    Console.WriteLine(branch.Key + ": " + branch.Value);

#endregion

#region Task 6
//char character = '.';

//Console.WriteLine($"Character: '{character}'");
//Console.WriteLine($"Is WhiteSpace        : {char.IsWhiteSpace(character)}");
//Console.WriteLine($"Is Uppercase         : {char.IsUpper(character)}");
//Console.WriteLine($"Is Lowercase         : {char.IsLower(character)}");
//Console.WriteLine($"Is Letter            : {char.IsLetter(character)}");
//Console.WriteLine($"Is Digit             : {char.IsDigit(character)}");
//Console.WriteLine($"Is LetterOrDigit     : {char.IsLetterOrDigit(character)}");
//Console.WriteLine($"Is Number            : {char.IsNumber(character)}");
//Console.WriteLine($"Is Punctuation       : {char.IsPunctuation(character)}");
//Console.WriteLine($"Is Separator         : {char.IsSeparator(character)}");

#endregion

#region Assignment 1
// string
//string firstName = "Ahmed";
//string lastName = "Omar";

//// 1. String Concatenation
//Console.WriteLine("\n1. String Concatenation:");
//string fullName1 = firstName + " " + lastName;
//Console.WriteLine(fullName1);

//// 2. String Interpolation
//Console.WriteLine("\n2. String Interpolation:");
//string fullName2 = $"Full Name: {firstName} {lastName}";
//Console.WriteLine(fullName2);

//// 3. Verbatim String
//string normalStringPath1 = "E:\\Projects\\Documents\\Reports\\report\"52\".pdf";
//Console.WriteLine("\nnormalStringPath1:");
//Console.WriteLine(normalStringPath1);

//string verbatimPath = @"E:\Projects\Documents\Reports\report""52"".pdf";
//Console.WriteLine("\nverbatimPath:");
//Console.WriteLine(verbatimPath);

//// 4. Raw String
//string rawStringPath = """
//E:\Projects\Documents\Reports\report"52".pdf
//""";
//Console.WriteLine("\nrawStringPath:");
//Console.WriteLine(rawStringPath);

#endregion

#region Assignment 2

//string iti = "Information Technology Institute";
//Console.WriteLine(
//    "\niti.StartsWith('I')\t: " + iti.StartsWith('I') +
//    "\niti.StartsWith('In')\t: " + iti.StartsWith("In") +
//    "\niti.StartsWith('Tech')\t: " + iti.StartsWith("Tech") +
//    "\niti.EndsWith('gy')\t: " + iti.EndsWith("gy") +
//    "\niti.Contains('Tech')\t: " + iti.Contains("Tech") +
//    "\niti.Contains('cs')\t: " + iti.Contains("cs") +
//    "\niti.IndexOf('o')\t: " + iti.IndexOf('o') +
//    "\niti.IndexOf('z')\t: " + iti.IndexOf('z') +
//    "\niti.IndexOf('o')\t: " + iti.IndexOf('o') +
//    "\niti.IndexOf('ti')\t: " + iti.IndexOf("ti") +
//    "\niti.IndexOf('web')\t: " + iti.IndexOf("web") +
//    "\niti.LastIndexOf('o')\t: " + iti.LastIndexOf('o') +
//    "\niti.LastIndexOf('z')\t: " + iti.LastIndexOf('z') +
//    "\niti.LastIndexOf('o')\t: " + iti.LastIndexOf('o') +
//    "\niti.LastIndexOf('ti')\t: " + iti.LastIndexOf("ti") +
//    "\niti.LastIndexOf('web')\t: " + iti.LastIndexOf("web")
//);

#endregion

#region Task 7

//string cs = " Computer Science ";
//Console.WriteLine(
//    "cs\t\t\t: '" + cs + "'\n" +
//    "\ncs.TrimStart()\t\t: '" + cs.TrimStart() + "'\n" +
//    "\ncs.TrimEnd()\t\t: '" + cs.TrimEnd() + "'\n" +
//    "\ncs.TrimStart().TrimEnd()\t: '" + cs.TrimStart().TrimEnd() + "'\n" +
//    "\ncs.Trim()\t\t: '" + cs.Trim() + "'");

//string strNull = null;
//string strEmpty = string.Empty;
//string strSpaces = " ";
//string strSharp = "C#";

//Console.WriteLine(
//    "\nstring.IsNullOrEmpty(strNull)\t\t: " + string.IsNullOrEmpty(strNull) + "\n" +
//    "\nstring.IsNullOrEmpty(strEmpty)\t\t: " + string.IsNullOrEmpty(strEmpty) + "\n" +
//    "\nstring.IsNullOrEmpty(strSpaces)\t\t: " + string.IsNullOrEmpty(strSpaces) + "\n" +
//    "\nstring.IsNullOrEmpty(strSpaces.Trim())\t: " + string.IsNullOrEmpty(strSpaces.Trim()) + "\n" +
//    "\nstring.IsNullOrEmpty(strSharp)\t\t: " + string.IsNullOrEmpty(strSharp));

//Console.WriteLine(
//    "\nstring.IsNullOrWhiteSpace(strNull)\t\t: " + string.IsNullOrWhiteSpace(strNull) + "\n" +
//    "\nstring.IsNullOrWhiteSpace(strEmpty)\t\t: " + string.IsNullOrWhiteSpace(strEmpty) + "\n" +
//    "\nstring.IsNullOrWhiteSpace(strSpaces)\t\t: " + string.IsNullOrWhiteSpace(strSpaces) + "\n" +
//    "\nstring.IsNullOrWhiteSpace(strSharp)\t\t: " + string.IsNullOrWhiteSpace(strSharp));

#endregion