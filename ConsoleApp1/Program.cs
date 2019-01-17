using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void Main(string[] args)
    {
        //Create an empty List of type object
        List<object> myList = new List<object>(); //We can use only object not var

        //Add 101, -90, "Hello", "World", "Git Community"
        myList.Add(101);
        myList.Add(-90);
        myList.Add("Hello");
        myList.Add("World");
        myList.Add("Git Community");
        myList.Add("false");

        //Loop through the list
        
        foreach (var str in myList)
        {


      
            if ( str is string)
            {
                Console.WriteLine("The String  in the list are {0}", str);
            }
        }
       
        Console.ReadLine();
    }

}
