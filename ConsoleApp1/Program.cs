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
        List<object> myList = new List<object>();// We Use here only object not var

        //Add 101, -90, "Hello", "World", "Git Community"
        myList.Add(101);
        myList.Add(-90);
        myList.Add("Hello");
        myList.Add("World");
        myList.Add("Git Community");
        myList.Add("false");
        //Loop through the list, display all values and add all those that are type interface int
        int sum = 0;
        foreach (var obj in myList)
        {
            Console.WriteLine(obj);
            if (obj is int)
            {
                sum += (int)obj;
            }
        }
        Console.WriteLine("The sum of all the integers in the list is {0}", sum);
        Console.ReadLine();
    }

}
