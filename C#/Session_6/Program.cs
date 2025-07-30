#region Assignment 1
// Escape Sequence
using System.Text;

//string newLineTest = "A: Hi! \nB: Hello!";
//Console.WriteLine(newLineTest);

//// Manual tab example
//string tabTest = "Name\t\tAge\t\tCity\nAhmed Omar\t29\tCairo\nAyman Osama\t23\tGiza";
//Console.WriteLine(tabTest);

//Console.WriteLine();

//string backslashTest = "D:\\Projects";
//Console.WriteLine(backslashTest);

//Console.WriteLine();
//Console.WriteLine("مرحبا بكم في نهاية المطاف");

//string doubleQuotesQuotationMarks = "\"I opened 'the' radio. \"Turn off the radio\", Ali said.\"";
//Console.WriteLine(doubleQuotesQuotationMarks);
//Console.WriteLine();
//Console.WriteLine("Single Quote' isn't a escape sequence");

//string iti = "MCIT Information Technology Institute";
//string strMorning1 = "Good Morning";
//string strMorning2 = "good morning";
//Console.WriteLine();

//Console.WriteLine(iti + "\t\t\t\t" + iti + "\t\t\t\t" + iti.ToUpper() + "\t\t\t\t" + iti.ToLower() + "\t\t\t\t" + strMorning1 + "\t\t\t\t" + strMorning2);
//Console.WriteLine(strMorning1.Equals(strMorning2) + "\t\t\t\t" + strMorning1.ToLower().Equals(strMorning2) + "\t\t\t\t" + strMorning1.ToUpper().Equals(strMorning2.ToUpper()));
//Console.WriteLine(strMorning1.Equals(strMorning2) + "\t\t\t\t" + strMorning1.ToLower().Equals(strMorning2.ToLower()) + "\t\t\t\t" + strMorning1.ToUpper().Equals(strMorning2.ToUpper()));
//Console.WriteLine(iti.Replace("o", "O") + "\t\t\t\t" + iti.Replace("n", "IN") + "\t\t\t\t" + iti.Replace(" ", "-") + "\t\t\t\t" + iti.Replace(" ", "-") + "\t\t\t\t" + iti.Substring(0, 9) + "\t\t\t\t" + iti.Substring(17, 4));

//// Split string into words
//string[] splittedIti = iti.Split(' ');
//Console.WriteLine("\nsplittedIti:");
//foreach (string item in splittedIti)
//{
//    Console.WriteLine(item);
//}

//// Split string into characters
//char[] itiChars = iti.ToCharArray();
//Console.WriteLine("\nitiChars:");
//foreach (var item in itiChars)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Task 1
//StringBuilder sbABC = new StringBuilder();
//sbABC.Append("A");
//sbABC.Append("B");
//sbABC.Append("C");
//Console.WriteLine("sbabc " + sbABC);

//StringBuilder sbAboutCompany = new StringBuilder();
//sbAboutCompany.Append('(', 5);
//sbAboutCompany.Append('*', 10);
//sbAboutCompany.Append("sunshine tech");
//sbAboutCompany.Append('*', 10);
//sbAboutCompany.Append(')', 5);
//sbAboutCompany.AppendLine();
//sbAboutCompany.AppendLine("Our Services");
//sbAboutCompany.AppendLine("= Web Development");
//sbAboutCompany.AppendLine("= Mobile Apps");
//Console.WriteLine(sbAboutCompany);

//sbAboutCompany.Replace('=', '-');
//Console.WriteLine(sbAboutCompany);

//sbAboutCompany.Insert(15, ' ');
//sbAboutCompany.Insert(29, ' ');
//Console.WriteLine(sbAboutCompany);

//sbAboutCompany.Remove(10, 5);
//sbAboutCompany.Remove(25, 5);
//Console.WriteLine(sbAboutCompany);

//Console.WriteLine("sbAboutCompany[14]: " + sbAboutCompany[14]);
//sbAboutCompany[14] = 'S';
//Console.WriteLine("sbAboutCompany[14]: " + sbAboutCompany[14]);

//sbAboutCompany.Clear();
//Console.WriteLine("sbAboutCompany.Clear(): " + sbAboutCompany);

#endregion

#region Task 2
//// Date and Time 
//using System.Globalization;
//DateTime dateTime1 = new DateTime(2001, 12, 30, 10, 25, 49);
//Console.WriteLine("dateTime1: " + dateTime1);
//Console.WriteLine("dateTime1.Date: " + dateTime1.Date);
//Console.WriteLine("dateTime1.Year: " + dateTime1.Year);
//Console.WriteLine("dateTime1.Month: " + dateTime1.Month);
//Console.WriteLine("dateTime1.Day: " + dateTime1.Day);
//Console.WriteLine("dateTime1.DayOfWeek: " + dateTime1.DayOfWeek);
//Console.WriteLine("dateTime1.DayOfYear: " + dateTime1.DayOfYear);

//Console.WriteLine("dateTime1.Hour: " + dateTime1.Hour);
//Console.WriteLine("dateTime1.Minute: " + dateTime1.Minute);
//Console.WriteLine("dateTime1.Second: " + dateTime1.Second);

//Console.WriteLine("dateTime1.TimeOfDay: " + dateTime1.TimeOfDay);

//DateTime dateTime2 = dateTime1.AddDays(-15);
//Console.WriteLine("dateTime2: " + dateTime2);

//DateTime dateTime3 = new DateTime(1998, 12, 29, 15, 30, 57, DateTimeKind.Local);
//Console.WriteLine("en-GB: "+ dateTime3.ToString(CultureInfo.CreateSpecificCulture("en-GB")));
//Console.WriteLine("en-US: "+ dateTime3.ToString(CultureInfo.CreateSpecificCulture("en-US")));
//Console.WriteLine("en-EG: "+ dateTime3.ToString(CultureInfo.CreateSpecificCulture("en-EG")));

//Console.WriteLine("\ndateTime3.ToLongDateString(): " + dateTime3.ToLongDateString());
//Console.WriteLine("\ndateTime3.ToLongTimeString(): " + dateTime3.ToLongTimeString());
//Console.WriteLine("\ndateTime3.ToShortDateString(): " + dateTime3.ToShortDateString());
//Console.WriteLine("\ndateTime3.ToShortTimeString(): " + dateTime3.ToShortTimeString());

//Console.WriteLine("\ndateTime3.ToString(\"d\"): " + dateTime3.ToString("d"));
//Console.WriteLine("\ndateTime3.ToString(\"D\"): " + dateTime3.ToString("D"));
//Console.WriteLine("\ndateTime3.ToString(\"t\"): " + dateTime3.ToString("t"));
//Console.WriteLine("\ndateTime3.ToString(\"T\"): " + dateTime3.ToString("T"));
//Console.WriteLine("\ndateTime3.ToString(\"f\"): " + dateTime3.ToString("f"));
//Console.WriteLine("\ndateTime3.ToString(\"F\"): " + dateTime3.ToString("F"));

//Console.WriteLine("DateTime.Now.Ticks: " + DateTime.Now.Ticks);
//Console.WriteLine("dateTime3.Ticks: " + dateTime3.Ticks);
//Console.WriteLine("dateTime3.Kind: " + dateTime3.Kind);

//Console.WriteLine("DateTime.IsLeapYear(2020): " + DateTime.IsLeapYear(2020));
//Console.WriteLine("DateTime.IsLeapYear(2021): " + DateTime.IsLeapYear(2021));

//Console.WriteLine("DateTime.DaysInMonth(2020,2): " + DateTime.DaysInMonth(2020, 2));
//Console.WriteLine("DateTime.DaysInMonth(2021,2): " + DateTime.DaysInMonth(2021, 2));
#endregion

#region Task 3
//TimeSpan timeSpanFiveDays = TimeSpan.FromDays(5);
//Console.WriteLine("timeSpanFiveDays\t\t: " + timeSpanFiveDays);
//TimeSpan timeSpanFromHours = TimeSpan.FromHours(3);
//Console.WriteLine("timeSpanFrom3Hours\t\t: " + timeSpanFromHours);

//TimeSpan timeSpanFrom600MillionTicks = TimeSpan.FromTicks(650_000_000);
//Console.WriteLine("timeSpanFrom600MillionTicks\t: " + timeSpanFrom600MillionTicks);

//TimeSpan timeSpan1 = new TimeSpan(25, 20, 40, 30, 900);
//TimeSpan timeSpan2 = new TimeSpan(10, 6, 30, 15, 200);
//Console.WriteLine("timeSpan1\t\t\t: " + timeSpan1);
//Console.WriteLine("timeSpan2\t\t\t: " + timeSpan2);
//TimeSpan timeSpanSubtraction = timeSpan1.Subtract(timeSpan2);
//Console.WriteLine("timeSpanSubtraction\t\t: " + timeSpanSubtraction);

//TimeSpan timeSpanAddition = timeSpan1.Add(timeSpan2);
//Console.WriteLine("timeSpanAddition\t\t: " + timeSpanAddition);

//DateTime dateTime1 = new DateTime(2024, 12, 28, 22, 50, 55, 300, DateTimeKind.Utc);
//DateTime dateTime2 = new DateTime(2019, 10, 25, 20, 40, 45, 200, DateTimeKind.Utc);

//TimeSpan timespanSubtraction1 = dateTime1.Subtract(dateTime2);
//Console.WriteLine("timespanSubtraction1\t\t: " + timespanSubtraction1);
//TimeSpan timeSpanSubtraction1 = dateTime1 - dateTime2;
//Console.WriteLine("timeSpanSubtraction1\t\t: " + timeSpanSubtraction1);
//TimeSpan timeSpan3 = new TimeSpan(370, 12, 4, 10, 50);
//DateTime dateTime3 = dateTime1.Add(timeSpan3);
//Console.WriteLine("dateTime3\t\t\t: " + dateTime3);
#endregion

#region Task 4
//time span
//DateTime dateTime1 = new DateTime(2001, 12, 30, 10, 25, 49);
//DateTime dateTime2 = new DateTime(2001, 12, 30, 10, 25, 49);

//long dayTicks = 864000_000_000;
//Console.WriteLine("dayTicks / 24 / 60 / 60 / 10_000_000\t: " + dayTicks / 24 / 60 / 60 / 10_000_000);

//long hourTicks = 36_000_000_000;
//Console.WriteLine("hourTicks / 10_000_000 / 60 / 60\t\t: " + hourTicks / 10_000_000 / 60 / 60);
//long minutTicks = 600_000_000;
//Console.WriteLine("minutTicks / 10_000_000 / 60\t\t: " + minutTicks / 10_000_000 / 60);
//long secondTicks = 10_000_000;
//Console.WriteLine("secondTicks / 10_000_000\t\t: " + secondTicks / 10_000_000);

//TimeSpan timeSpan1 = new TimeSpan();
//Console.WriteLine("timeSpan1\t\t\t: " + timeSpan1);
//TimeSpan timeSpan2 = new TimeSpan(36_000_000_000);
//Console.WriteLine("timeSpan2\t\t\t: " + timeSpan2);
//TimeSpan timeSpan3 = new TimeSpan(15, 15, 30);
//Console.WriteLine("timeSpan3\t\t\t: " + timeSpan3);
//TimeSpan timeSpan4 = new TimeSpan(10, 0, 0, 0);
//Console.WriteLine("timeSpan4\t\t\t: " + timeSpan4);
//TimeSpan timeSpan5 = new TimeSpan(7, 15, 29, 41, 250);
//Console.WriteLine("timeSpan5\t\t\t: " + timeSpan5);

//DateTime managerBirthDate = new DateTime(1980, 3, 5, 10, 30, 10);
//var manager1 = DateTime.Now.Subtract(managerBirthDate);
//Console.WriteLine("manager1\t\t\t: " + manager1);
//Console.WriteLine("manager1.GetType()\t\t: " + manager1.GetType());

//Console.WriteLine("manager1Age.days\t\t: " + manager1.Days);
//Console.WriteLine("manager1Age.totalDays\t\t: " + manager1.TotalDays);
//Console.WriteLine("manager1Age.Hours\t\t: " + manager1.Hours);
//Console.WriteLine("manager1Age.totalHours\t\t: " + manager1.TotalHours);
#endregion

#region Task 5
//task 5
File.Create("D:\\Projects\\2023\\Abc.png").Dispose();
File.Create("D:\\Projects\\2023\\Ghi.pdf");
byte[] imageABytes = File.ReadAllBytes("\"C:\\Users\\Asmaa\\Desktop\\My Photo.jpg\"");
foreach (var image in imageABytes)
{
    Console.Write(image + " ");
}

File.WriteAllBytes("C:\\Users\\mr\\Pictures\\Saved Pictures\\img.jpeg", imageABytes);
#endregion
