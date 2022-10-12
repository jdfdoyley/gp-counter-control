﻿/******************************************************************************\
 * Name: Jason D. F. D'Oyley
 * Date: Oct. 12, 2022
 * Assignment CIS214 Week 2 GP - Counter Controlled Loops
 *
 * Main application (program) class.
 * In this application we will demonstrate the use of counter-controlled
 * loops and increment/decrement operators by showing several examples
 * of counted operations.
\******************************************************************************/
public class CounterControlledLoops
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "\nJason D'Oyley - Week 2 GP Counter Controlled Loops\n"
        );

        // Prefix increment & decrement operators
        int c = 5;
        Console.WriteLine("Value of c before prefix increment: {0}", c);
        Console.WriteLine("Value of c with prefix increment (++c): {0}", ++c);
        Console.WriteLine("Value of c after prefix increment: {0}\n", c);

        c = 5;
        Console.WriteLine("Value of c before prefix increment: {0}", c);
        Console.WriteLine("Value of c with prefix increment (--c): {0}", --c);
        Console.WriteLine("Value of c after prefix increment: {0}\n", c);

        // Suffix increment (postincrement) & decrement operators
        c = 5;
        Console.WriteLine("Value of c before suffix increment: {0}", c);
        Console.WriteLine("Value of c with suffix increment (c++): {0}", c++);
        Console.WriteLine("Value of c after suffix increment: {0}\n", c);

        c = 5;
        Console.WriteLine("Value of c before suffix increment: {0}", c);
        Console.WriteLine("Value of c with suffix increment (c--): {0}", c--);
        Console.WriteLine("Value of c after suffix increment: {0}\n", c);

        // Counter-controlled while loop
        Console.WriteLine("Counter-Controlled while loop demonstration");
        int wcnt1 = 1;

        while (wcnt1 <= 10)
        {
            Console.Write("{0} ", wcnt1);
            wcnt1++;
        }
    }
}