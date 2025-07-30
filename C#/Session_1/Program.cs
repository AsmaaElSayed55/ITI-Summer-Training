using System.Globalization;

namespace Session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // duplicate Ctrl +E + V
            Console.WriteLine("Welcom to Sunshine for Software Solutions!");
            Console.WriteLine("Our Services:");
            Console.WriteLine("- Mobile Apps,");
            Console.WriteLine("- Web Development,");
            Console.WriteLine("- Desktop Development , and");
            Console.WriteLine("- Custom DEvelopment");

            // Variables 
            string name;
            name = "Mostafa";
            Console.WriteLine("Hi, " + name);
            name = "Hossam";
            Console.WriteLine("Hi, " + name);
            string company = "Bright Stars";
            Console.WriteLine("Welcome to " + company);

            Console.WriteLine(
                "C# Type\t\t.NET Type\t\tSize (in bytes)\t\tRange\n" +
                "byte\t\t" + typeof(byte) + "\t\t" + sizeof(byte) + "\t\t" + byte.MinValue + " to " + byte.MaxValue + "\n" +
                "sbyte\t\t" + typeof(sbyte) + "\t\t" + sizeof(sbyte) + "\t\t" + sbyte.MinValue + " to " + sbyte.MaxValue + "\n" +
                "short\t\t" + typeof(short) + "\t\t" + sizeof(short) + "\t\t" + short.MinValue + " to " + short.MaxValue + "\n" +
                "ushort\t\t" + typeof(ushort) + "\t\t" + sizeof(ushort) + "\t\t" + ushort.MinValue + " to " + ushort.MaxValue + "\n" +
                "int\t\t" + typeof(int) + "\t\t" + sizeof(int) + "\t\t" + int.MinValue + " to " + int.MaxValue + "\n" +
                "uint\t\t" + typeof(uint) + "\t\t" + sizeof(uint) + "\t\t" + uint.MinValue + " to " + uint.MaxValue + "\n" +
                "long\t\t" + typeof(long) + "\t\t" + sizeof(long) + "\t\t" + long.MinValue + " to " + long.MaxValue + "\n" +
                "ulong\t\t" + typeof(ulong) + "\t\t" + sizeof(ulong) + "\t\t" + ulong.MinValue + " to " + ulong.MaxValue + "\n" +
                "float\t\t" + typeof(float) + "\t\t" + sizeof(float) + "\t\t" + float.MinValue + " to " + float.MaxValue + "\n" +
                "double\t\t" + typeof(double) + "\t\t" + sizeof(double) + "\t\t" + double.MinValue + " to " + double.MaxValue + "\n" +
                "decimal\t\t" + typeof(decimal) + "\t\t" + sizeof(decimal) + "\t\t" + decimal.MinValue + " to " + decimal.MaxValue + "\n" +
                "bool\t\t" + typeof(bool) + "\t\t" + sizeof(bool) + "\t\t" + "\n" +
                "char\t\t" + typeof(char) + "\t\t" + sizeof(char) + "\t\t" + char.MinValue + " to " + char.MaxValue + "\n" +
                "DateTime\t" + typeof(DateTime) + "" + "\t\t" + "\t\t" + char.MinValue + " to " + char.MaxValue + "\n"
                );

            string companyManager = "Wael Mahmoud";
            Console.WriteLine("companyManager.GetType(): " + companyManager.GetType() + "\n");

            string fullName = "Ayman Mostafa Ali";
            char classification = 'A';
            byte penalties = 5;
            float weight = 74.5F;
            double homeDistance = 65000.35D;
            decimal salary = 17500.25M;
            short daysWorked = 2958;
            bool isEgyptian = true;
            DateTime birthDate = new DateTime(1999, 12, 27);
            DateTime hiringDateTime = new DateTime(2022, 11, 29, 10, 49, 57);

            Console.WriteLine(
                "Full Name\t\t: " + fullName + "\n" +
                "Classification\t\t: " + classification + "\n" +
                "Penalties\t\t: " + penalties + "\n" +
                "Weight\t\t\t: " + weight + "\n" +
                "Home Distance\t\t: " + homeDistance + "\n" +
                "Salary\t\t\t: " + salary + "\n" +
                "Days Worked\t\t: " + daysWorked + "\n" +
                "Is Egyptian\t\t: " + isEgyptian + "\n" +
                "Birth Date\t\t: " + birthDate.ToShortDateString() + "\n" +
                "Hiring Date and Time\t: " + hiringDateTime
            );

            // Type Conversion Examples

            // 1. Conversion between compatible types

            // 1-a. Implicit Type Conversion (Widening)
            byte x = 50;
            int y = x;  // byte to int is safe and implicit
            Console.WriteLine("y: " + y);

            // 1-b. Explicit Type Conversion (Narrowing)

            // Using casting
            long no1 = 175;
            int no2 = (int)no1;  // Manual casting from long to int
            Console.WriteLine(nameof(no2) + ": " + no2);

            // Using Convert class
            long no3 = 597;
            int no4 = Convert.ToInt32(no3);  // Safe conversion
            Console.WriteLine(nameof(no4) + " : " + no4);

           // Program.cs
            // 12.8 - Type Conversion Examples

            // Conversion between non - compatible types
            bool isStudent = true;
            byte isUndergraduate = Convert.ToByte(isStudent);
            Console.WriteLine(nameof(isStudent) + ":\t" + isStudent + "/n" +
                             nameof(isUndergraduate) + ":\t" + isUndergraduate);

            // String Conversion
            // (1) Conversion from string to another type
            string distance1 = "2500";
            string distance2 = "1200";

            // 1.1. Convert.ToDoubleDataType(string)
            int totalDistance = Convert.ToInt32(distance1) + Convert.ToInt32(distance2);
            Console.WriteLine(nameof(totalDistance) + ":\t" + totalDistance);

            // 1.2. CSharpDataType.Parse(string)
            int totalDist = int.Parse(distance1) + int.Parse(distance2);
            Console.WriteLine(nameof(totalDist) + ":\t" + totalDist);

            // (2) Conversion to string
            // 2.1. Convert.ToString(variable)
            byte length = 165;
            string len = Convert.ToString(length);
            Console.WriteLine(nameof(len) + ":\t" + len);

            // 2.2. variable.ToString()
            short width = 22500;
            string wdt = width.ToString();
            Console.WriteLine(nameof(wdt) + ":\t" + wdt);
           //  Format Specifiers

            float firstNo = 2.57f;
            Console.WriteLine(
                "firstNo = " + firstNo +
                "\nfirstNo.ToString(\"N\")  = " + firstNo.ToString("N") +
                "\nfirstNo.ToString(\"N1\") = " + firstNo.ToString("N1") +
                "\nfirstNo.ToString(\"N2\") = " + firstNo.ToString("N2") +
                "\nfirstNo.ToString(\"N3\") = " + firstNo.ToString("N3") +
                "\nfirstNo.ToString(\"N4\") = " + firstNo.ToString("N4") +
                "\nfirstNo.ToString(\"N5\") = " + firstNo.ToString("N5") +
                "\nfirstNo.ToString(\"N6\") = " + firstNo.ToString("N6") +
                "\nfirstNo.ToString(\"C\")  = " + firstNo.ToString("C") +
                "\nfirstNo.ToString(\"C1\") = " + firstNo.ToString("C1") +
                "\nfirstNo.ToString(\"C2\") = " + firstNo.ToString("C2") +
                "\nfirstNo.ToString(\"C3\") = " + firstNo.ToString("C3") +
                "\nfirstNo.ToString(\"C4\") = " + firstNo.ToString("C4") +
                "\nfirstNo.ToString(\"C5\") = " + firstNo.ToString("C5") +
                "\nfirstNo.ToString(\"C6\") = " + firstNo.ToString("C6")
            );

            // Culture Locale code --- US vs AR vs GB
            Console.WriteLine(
                "\n" +
                "ar-EG: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("ar-EG")) + "\n" +
                "en-US: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")) + "\n" +
                "en-GB: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("en-GB"))
            );

            float secondNo = 123456.789f;
            Console.WriteLine(
                "\nsecondNo = " + secondNo +
                "\nsecondNo.ToString(\"P\")  = " + secondNo.ToString("P") +
                "\nsecondNo.ToString(\"P1\") = " + secondNo.ToString("P1") +
                "\nsecondNo.ToString(\"P2\") = " + secondNo.ToString("P2") +
                "\nsecondNo.ToString(\"P3\") = " + secondNo.ToString("P3") +
                "\nsecondNo.ToString(\"P4\") = " + secondNo.ToString("P4") +
                "\nsecondNo.ToString(\"P5\") = " + secondNo.ToString("P5") +
                "\nsecondNo.ToString(\"P6\") = " + secondNo.ToString("P6")
            );

            // Constants
            // ALLCaps or Pascal Case
            const string Company = "Lotus Soft";

            Console.WriteLine("WeekDay.Thursday: " + WeekDay.Thursday);
            Console.WriteLine("(byte)WeekDay.Thursday: " + (byte)WeekDay.Thursday);

            WeekDay day3 = WeekDay.Thursday;
            Console.WriteLine("WeekDay3: " + day3);
            Console.WriteLine("WeekDay.Thursday.GetType(): " + WeekDay.Thursday.GetType());

            Console.WriteLine("PrimaryColor.Green: " + PrimaryColor.Green);
            Console.WriteLine("PrimaryColor.Green.GetType(): " + PrimaryColor.Green.GetType());
            Console.WriteLine("(int)PrimaryColor.Green: " + (int)PrimaryColor.Green);

            PrimaryColor color2 = PrimaryColor.Green;
            Console.WriteLine("PrimaryColor2: " + color2);


            // task 6
            byte firstNo = 7;
            byte secondNo = 2;
            byte addition = Convert.ToByte(firstNo + secondNo);
            byte subtraction = Convert.ToByte(firstNo - secondNo);
            byte multiplication = Convert.ToByte(firstNo * secondNo);
            byte division = Convert.ToByte(firstNo / secondNo);
            byte reminder = Convert.ToByte(firstNo % secondNo);
            // byte c = (byte)(firstNo / secondNo);
            float floatdivision = firstNo / secondNo;

            Console.WriteLine("\n" + nameof(firstNo) + ": " + firstNo +
                              "\n" + nameof(secondNo) + ": " + secondNo +
                              "\n" + nameof(addition) + ": " + addition +
                              "\n" + nameof(subtraction) + ": " + subtraction +
                              "\n" + nameof(multiplication) + ": " + multiplication +
                              "\n" + nameof(division) + ": " + division +
                              "\n" + nameof(reminder) + ": " + reminder +
                              "\n" + nameof(floatdivision) + ": " + floatdivision);

            //Task 7
            int firstNo = 7, secondNo = 5;
            Console.WriteLine(nameof(firstNo) + ": " + firstNo + "\n" +
                              nameof(secondNo) + ": " + secondNo + "\n" +
                              "firstNo==secondNo : " + (firstNo == secondNo) + "\n" +
                              "firstNo!=secondNo : " + (firstNo != secondNo) + "\n" +
                              "firstNo>=secondNo : " + (firstNo >= secondNo) + "\n" +
                              "firstNo<=secondNo : " + (firstNo <= secondNo) + "\n" +
                              "firstNo > secondNo : " + (firstNo > secondNo) + "\n" +
                              "firstNo < secondNo : " + (firstNo < secondNo));

            Console.Write("enter your age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("age: " + (age >= 18));

            Console.Write("enter your foreign language(E,F): ");
            char foreignLanguage = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("english foreign language: " + (foreignLanguage == 'E'));
            Console.WriteLine("french foreign language: " + (foreignLanguage == 'F'));

            // Task 8
            Console.WriteLine("prefix increment operator: ");
            int incrementTest1 = 7;
            Console.WriteLine($"incrementTest1: {incrementTest1}");
            Console.WriteLine($"++incrementTest1: {incrementTest1 + 1}"); // simulate increment
            Console.WriteLine($"incrementTest1: {incrementTest1}");

            Console.WriteLine("\npostfix increment operator: ");
            int incrementTest2 = 15;
            Console.WriteLine($"incrementTest2: {incrementTest2}");
            Console.WriteLine($"incrementTest2++: {incrementTest2}"); // simulate before increment
            Console.WriteLine($"incrementTest2: {incrementTest2 + 1}"); // simulate after increment

            Console.WriteLine("\nprefix decrement operator: ");
            int decrementTest1 = 7;
            Console.WriteLine($"decrementTest1: {decrementTest1}");
            Console.WriteLine($"--decrementTest1: {decrementTest1 - 1}"); // simulate decrement
            Console.WriteLine($"decrementTest1: {decrementTest1}");

            Console.WriteLine("\npostfix decrement operator: ");
            int decrementTest2 = 7;
            Console.WriteLine($"decrementTest2: {decrementTest2}");
            Console.WriteLine($"decrementTest2--: {decrementTest2}"); // simulate before decrement
            Console.WriteLine($"decrementTest2: {decrementTest2 - 1}"); // simulate after decrement



            int firstNO = 2000;
            Console.WriteLine($"firstNO = 2000: {firstNO}");
            firstNO = 700;
            Console.WriteLine($"firstNO = 700: {firstNO}");

            int secondNO = 1000;
            Console.WriteLine($"secondNO = 1000: {secondNO}");
            secondNO += 500;
            Console.WriteLine($"secondNO += 500: {secondNO}");
            secondNO += 1000;
            Console.WriteLine($"secondNO += 1000: {secondNO}");
            secondNO -= 100;
            Console.WriteLine($"secondNO -= 100: {secondNO}");
            secondNO *= 2;
            Console.WriteLine($"secondNO *= 2: {secondNO}");
            secondNO /= 4;
            Console.WriteLine("secondNO /= 4: " + secondNO);


        }
    }
}
            // Enumeration
            //enum WeekDay : byte
            //{
            //    Sunday = 1,
            //    Monday = 2,
            //    Tuesday = 3,
            //    Wednesday = 4,
            //    Thursday = 5,
            //    Friday = 6,
            //    Saturday = 7
            //}

            //enum PrimaryColor
            //{
            //    Red,
            //    Green,
            //    Blue
            //}

