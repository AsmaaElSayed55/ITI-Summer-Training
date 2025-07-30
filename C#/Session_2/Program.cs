#region Task 10
// switch expression
for (; ; )
{
    Console.Write("Where are you from? ");
    string country = Console.ReadLine();

    float discountRatio = country switch
    {
        "Egypt" => 0.30f,
        "Kuwait" => 0.25f,
        "Libya" or "Mauritania" or "Algeria" or "Tunisia" or "Morocco" => 0.20f,
        _ => 0.10f
    };

    Console.WriteLine("Discount Ratio: " + discountRatio.ToString("P0"));
}

#endregion
