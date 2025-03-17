#pragma warning disable

string permission = "Admin|Manager";
int level = 55;

Console.WriteLine($"{permission}\n");
Console.WriteLine("What you are?");
permission = Console.ReadLine().Trim().ToUpper();
Console.WriteLine("What's your level?");
level = int.Parse(Console.ReadLine().Trim());

if (permission.Contains("ADMIN"))
{
    Console.WriteLine((permission.Contains("ADMIN")) && (level >= 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}

if (!permission.Contains("ADMIN"))
{
    Console.WriteLine((permission.Contains("MANAGER")) && (level >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
}

else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

