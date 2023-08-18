// See https://aka.ms/new-console-template for more information
//Aufgabe 1
/*for (int i = 50; i >= 0; i--) 
{ Console.WriteLine(i); }

Aufgabe 2
for (int i = 1; i <= 50; i++) 
{ Console.WriteLine("Ich muss immer meine Hausaufgaben machen"); }

Aufgabe 3
for (int i = 1; i <= 10; i++) 
{ Console.WriteLine($"Das Quadrat von {i} ist {i*i}"); }

Aufgabe 4
for (int i = 100; i >= 10; i -= 10) 
{ Console.Write($"{i} "); }

Aufgabe 5
Console.WriteLine("Geben Sie eine Zahl ein:");
string y = Console.ReadLine();
int x = Convert.ToInt32(y);
for (int i = -x; i <= x; i+=2 ) 
{ Console.WriteLine(i); }

Aufgabe 6
int x;
do
{
    Console.WriteLine("Geben Sie eine Zahl ein:");
    string y = Console.ReadLine();
     x = Convert.ToInt32(y);
}
while (x != 0);

Aufgabe 7
Console.WriteLine("Geben Sie eine Zahl ein:");
string y = Console.ReadLine();
int n = Convert.ToInt32(y);
int summe = 0;
for (int i = 0; i <= n; i++)
{
    summe += i;  
}
Console.WriteLine($"Die Summe der Zahlen von 0 bis {n} beträgt: {summe}");

Aufgabe 8
int x;
int i = -1;
do
{
    Console.WriteLine("Geben Sie eine Zahl ein:");
    string y = Console.ReadLine();
    x = Convert.ToInt32(y);
    i++;
}
while (x != 1234);
Console.WriteLine($"{i}");

Aufgabe 9
Console.Write("Kapital:");
double K = double.Parse(Console.ReadLine());
Console.Write("ZinssatzProzent: ");
double Z = double.Parse(Console.ReadLine());
double Z2 = Z / 100;
double K2 = K * 2;
int j = 0;
while (K < K2)
{
    K += K * Z2;
    j++;
}

Console.WriteLine($"{j}");

Aufgabe 10
Console.Write("Gib die Höhe des Weihnachtsbaums ein: ");
int höhe = int.Parse(Console.ReadLine());

for (int i = 1; i <= höhe; i++)
{
    string y = new string(' ', höhe - i);
    string x = new string('*', 2 * i - 1);
    Console.WriteLine(y + x );
}
*/