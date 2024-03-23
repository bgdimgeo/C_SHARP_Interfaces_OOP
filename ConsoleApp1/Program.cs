using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstraction + Encapsulation are working toghether
            //Interface e public side of our class 
            //Interface define public visibility of our class, t.e kakvo trqbva da dava tozi klas na ostanalite 
            //Name convention begins with "I" 
            //By convention interfaces are public 
            // Ako imam set v interface toi e public i v nasledqvashtie klasove trqbbva da sa public, ako iskame da ne e public togava 
            // ne definirame setter v interface 
            // Po definiciq interface vsichko trqbva da e public 
            // interface is implemented not inherited !!!
            // Class can be inherited
            // Izpolzvamer go ako edin klas iska da izpolzva dva drugi klasa 
            // Vsichko ot interface-a trqbva da se implemtira 
            // Best practice build heirarchy of interfaces 
            //Abstraction -> from the interfaces, means abstrction level increasment 
            // Abstraction is in the business logic of the application 
            // Work with interfaces without knowing the concrete implematation 
            // Intercaes can be intilized and then you can downcast to the classes which implements the interface 
            // Interfaces got only properties, constants, methods ! 
            // Const in the interface are better to be properties 
            //Interface data sagregation search in web - means sagreagte the interfaces to the smallest possible entries 











        }
    }
}
