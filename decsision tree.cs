using System.ComponentModel.Design;
using System.Timers;

int m = 2;
int b = 1;

if (m > b)
    Console.WriteLine( "Real Madrid wins");
else if ( b> m)
    Console.WriteLine( " Barcelona wins");
else if ( m == b )
    Console.WriteLine( "the match is drawn");
else if ( m == 0 && b == 0)
    Console.WriteLine( " the match is nil.nil");
else 
    Console.WriteLine( "the match has been postponed");