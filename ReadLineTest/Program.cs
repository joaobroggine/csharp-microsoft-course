string? read;
int numeric = 0;
bool alright = false;
bool finish = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    read = Console.ReadLine();
    alright = int.TryParse(read, out numeric);
    if ((alright == true) && (numeric >= 5) && (numeric <= 10) ){
        Console.WriteLine($"Your input value {numeric} has been accepted.");
        finish = true;
    } else if ((alright == true) && (numeric < 5) || (numeric > 10)) {
        Console.WriteLine($"You entered {numeric}. Please enter a number between 5 and 10.");
    } else {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
    
} while (finish == false);