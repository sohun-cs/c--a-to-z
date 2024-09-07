/*Console.WriteLine("Welcome to CSharp!");

Console.WriteLine("This is Programming Language");

// Variable

int x;
x = 71;
int y = 24;
double age = 23;
char symbol = '@';
bool alive = true;
String name = "Asad";
const double pi = 3.1416;

Console.WriteLine(x + y);
Console.WriteLine("Your age is " + age);
Console.WriteLine("Your symbol is " + symbol);
Console.WriteLine("You are " + alive);
Console.WriteLine("Your name is " + name);
Console.WriteLine("Pie value is " + pi);*/

// -----------------------------------------------------------

/*double a = 3.123;
int b = Convert.ToInt32(a);

int c = 321;
double d = Convert.ToDouble(c);

int e = 123;
String f = Convert.ToString(e);

Console.WriteLine(b + " " + b.GetType());
Console.WriteLine(d + " " + d.GetType());
Console.WriteLine(f + " " + f.GetType());*/


// ------------------------------------------------------------

/*int i = 18;
int j = 6;

double m = 24.50;
double n = 8.25;

int add = i + j;
int sub = i - j;
int mul = i * j;
int div = i / j;
int rem = i % j;

double add1 = m + n;
double sub1 = m - n;
double mul1 = m * n;
double div1 = m / n;
double rem1 = m % n;

Console.WriteLine("add: " + add);
Console.WriteLine("sub: " + sub);
Console.WriteLine("mul: " + mul);
Console.WriteLine("div: " + div);
Console.WriteLine("rem: " + rem);

Console.WriteLine("add: " + add1);
Console.WriteLine("sub: " + sub1);
Console.WriteLine("mul: " + mul1);
Console.WriteLine("div: " + div1);
Console.WriteLine("rem: " + rem1);*/


// ------------------------------------------------------------

/*int x = 4;
double y = 3.14;
double z = 5.67;

double a = Math.Max(x, z);
double b = Math.Min(x, z);
double c = Math.Pow(x, 3);
double d = Math.Sqrt(x);
double e = Math.Round(y);
double f = Math.Ceiling(y);
double g = Math.Floor(z);


Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);*/


// ------------------------------------------------------------

/*Random random = new Random();

int num1 = random.Next(1, 20);
int num2 = random.Next(1, 20);
int num3 = random.Next(1, 20);

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);
*/


// ------------------------------------------------------------

/*Console.WriteLine("Enter side A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt((a * a) + (b * b));

Console.WriteLine("The hypotenuse is: " + c);
*/




/*String fullName = "Bro Code";
String phoneNumber = "123-456-789";

fullName = fullName.ToUpper();
Console.WriteLine(fullName);

fullName = fullName.ToLower();
Console.WriteLine(fullName);

phoneNumber = phoneNumber.Replace("-", "");
Console.WriteLine(phoneNumber);

phoneNumber = phoneNumber.Replace("-", "/");
Console.WriteLine(phoneNumber);
*/




// ------------------------------------------------------------

/*Console.WriteLine("Please enter your name: ");
int age = Convert.ToInt32(Console.ReadLine());

if(age >= 18)
{
    Console.WriteLine("You are now signed up!");
}
else if(age > 100)
{
    Console.WriteLine("You are too old to sign up");
}
else if(age < 0)
{
    Console.WriteLine("You haven't born yet");
}
else
{
    Console.WriteLine("You must be 18+ to sign up");
}*/



// ------------------------------------------------------------

/*Console.WriteLine("What day is it today");
String day = Console.ReadLine();

switch (day)
{
    case "Monday":
        Console.WriteLine("Today is Monday");
        break;

    case "Tuesday":
        Console.WriteLine("Today is Tuesday");
        break;

    case "Wednesday":
        Console.WriteLine("Today is Wednesday");
        break;

    case "Thusday":
        Console.WriteLine("Today is Thusday");
        break;

    case "Friday":
        Console.WriteLine("Today is Friday");
        break;

    case "Satureday":
        Console.WriteLine("Today is Satureday");
        break;

    case "Sunday":
        Console.WriteLine("Today is Sunday");
        break;

    default:
        Console.WriteLine(day + " is not a day");
        break;
}*/



// ------------------------------------------------------------

/*Console.WriteLine("What is the temperature outside: (C)");
double temp = Convert.ToDouble(Console.ReadLine());

if(temp >= 10 && temp <= 25)
{
    Console.WriteLine("Weather is good");
}

else if(temp <= -50 || temp >= 50)
{
    Console.WriteLine("Do not go outside");
}
*/


// ------------------------------------------------------------

/*for(int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

*/


// ------------------------------------------------------------

/*class Program
{
    static void Main(string[] args)
    {
        Human human = new Human();

        human.name = "Sohun";
        human.age = 23;
        human.Eat();
        human.Sleep();

    }
}

class Human
{
    public String name;
    public int age;

    public void Eat()
    {
        Console.WriteLine(name + " is eating");
    }
    public void Sleep()
    {
        Console.Write(name + " is eating");
    }
}*/



// ------------------------------------------------------------

/*class Program
{
    static void Main(string[] args)
    {
        Human human = new Human("Asad", 24);
        Human human1 = new Human("Sohun", 23);
        human.Eat();
        human.Sleep();

        human1.Eat();
        human1.Sleep();

        Car car = new Car("Jeep", "Wrangler", 2010, "white");
        Car car1 = new Car("Ford", "Mustang", 2002, "Blue");

        car.Drive();
        car1.Drive();

    }
}

class Human
{
    public String name;
    public int age;

    public Human(String name, int age)
    {
        this.name = name;
        this.age = age;
    


    public void Eat()
    {
        Console.WriteLine(name + " is eating");
    }
    public void Sleep()
    {
        Console.Write(name + " is eating");
    }
}

class Car
{
    String make;
    String model;
    int year;
    String color;

    public Car(String make, String model, int year, String color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public void Drive()
    {
        Console.WriteLine("You drive the " + make + " " + model);
    }

}*/



// ------------------------------------------------------------

class Program
{
    static void Main(string[] args)
    {

        Car car = new Car("Wrangler");
        Car car1 = new Car("Mustang");
        Car car2 = new Car("Ferari");
        Car car3 = new Car("Lamborgini");

        Console.WriteLine(Car.numberOfCars);

    }
}

class Car
{
    String model;
    public static int numberOfCars;

    public Car(String model)
    {
        this.model = model;
        numberOfCars++;
    }

}
