// Console.ForegroundColor = ConsoleColor.Green;

// display Output
Console.WriteLine("Welcome C#. It's a amazing programming language");

string name = "Asaduzzaman Sohun";
int age = 23;
string profession = "Web Developer";

Console.WriteLine("Hi, I'm " + name + ". I'm " + age + " years old. I'm a " + profession + ".");
Console.WriteLine($"Hi, I'm {name}. I'm {age} years old. I'm a {profession}.");
Console.WriteLine("Hi, I'm {0}. I'm {1} years old. I'm a {2}.", name, age, profession);
Console.WriteLine(string.Concat("Hi, I'm ", name, ". I'm ", age, " years old. I'm a ", profession + "."));


string str1 = "message";
string str2 = "message";

if (str1.Equals(str2))
{
    Console.WriteLine("Same str");
}
else
{
    Console.WriteLine("Diff str");
}

/*if (str1 == str2)
{
    Console.WriteLine("Same");
}
else
{
    Console.WriteLine("Diff");
}
*/


// Empty String

Console.Write("Your name is: ");
string yourName = Console.ReadLine();

if (yourName != string.Empty)
{
    Console.WriteLine($"Your name is {yourName}.");
}
else
{
    Console.WriteLine($"Your name is empty.");
}

/*if (yourName != "")
{
    Console.WriteLine($"Your name is {yourName}");
}
else
{
    Console.WriteLine($"Your name is empty.");
}*/


