
Console.WriteLine("Enter Number");

char keyboard;

do
{ 
    keyboard = Console.ReadKey(true).KeyChar;

} while (keyboard != '5' && keyboard != '6');
Console.WriteLine();
int x = Convert.ToInt32(keyboard.ToString());
Console.WriteLine(x);




