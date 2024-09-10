// display Output
Console.WriteLine("Welcome C#. It's a amazing programming language");

// input data and display
/*string name = Console.ReadLine();
Console.WriteLine($"Hello, I'm {name}");*/

// Variable
/*bool canICode = true;
Console.WriteLine(canICode);

Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
Console.WriteLine("Smallest Integer : {0}", int.MinValue);

Console.WriteLine("Biggest Double : {0}", Double.MaxValue);
Console.WriteLine("Smallest Double : {0}", Double.MinValue);

Console.WriteLine("Biggest Float : {0}", float.MaxValue);
Console.WriteLine("Smallest Float : {0}", float.MinValue);

Console.WriteLine("Biggest Long : {0}", long.MaxValue);
Console.WriteLine("Smallest Long : {0}", long.MinValue);

decimal decPiVal = 3.14159265358979323846264338327950M;
decimal decBigNum = 3.0000000000000000000000000121212M;

Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);
*/

/*Console.WriteLine("Currency : {0:c}", 23.455);
Console.WriteLine("Pad with 0s : {0:d4}", 23);
Console.WriteLine("3 Decimals : {0:f3}", 23.45555);
Console.WriteLine("Commas : {0:n4}");*/


string randomString = "This is a string";
Console.WriteLine("String Length : {0}", randomString.Length);
Console.WriteLine("String Contains is : {0}", randomString.Contains("is"));
Console.WriteLine("Index of is : {0}", randomString.IndexOf("is"));
Console.WriteLine("Remove String : {0}", randomString.Remove(10, 6));
Console.WriteLine("Insert String : {0}", randomString.Insert(10, "short "));
Console.WriteLine("Replace String : {0}", randomString.Replace("string", "sentence"));
Console.WriteLine("Compare A tp B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("-----------------------------------------------------------------------------------");

Console.WriteLine("A = a : {0}", String.Equals("A", "a"), StringComparison.OrdinalIgnoreCase);
Console.WriteLine("Pad left : {0}", randomString.PadLeft(20, '.'));
Console.WriteLine("Pad Right : {0}", randomString.PadRight(20, '.'));
Console.WriteLine("Trim : {0}", randomString.Trim());
Console.WriteLine("Uppercase : {0}", randomString.ToUpper());
Console.WriteLine("Lowercase : {0}", randomString.ToLower());

string newString = String.Format("{0} saw a {1} {2} in the {3}",
    "Paul", "rabbit", "eating", "field");
Console.WriteLine(newString + "\n");

Console.WriteLine(@"Exactly what I typed");


