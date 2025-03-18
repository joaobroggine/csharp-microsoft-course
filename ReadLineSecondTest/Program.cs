string? read;
bool check = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    read = Console.ReadLine()?.Trim().ToLower();
    if (read.Contains("administrator") || read.Contains("manager") || read.Contains("user")) {
        Console.WriteLine($"Your input value {read} has been accepted.");
        check = true;
    } else {
        Console.WriteLine($"The role name that you entered, A {read} is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (check == false);