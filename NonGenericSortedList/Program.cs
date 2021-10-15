using System;
using System.Collections;

namespace NonGenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList obj = new SortedList();
            obj.Add("Vishal", "Bangalore");
            obj.Add("Abhay", "Chennai");
            obj.Add("Rahul", "Hyderabad");
            obj.Add("Ravi", "Pune");
            foreach (string s in obj.Keys)
            {
                Console.Write(s + " " + obj[s] + " ");
                Console.WriteLine();
            }
        }
    }
}
