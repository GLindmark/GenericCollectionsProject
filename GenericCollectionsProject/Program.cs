using System;
using System.Collections.Generic;

namespace GenericCollectionsProject {
    class Program {
        static void Main(string[] args) {

            List<string> names = new List<string>()

            var integers = new List<int>();
            integers.Add(7);
            integers.Add(4);
            integers.Add(13);

            integers.Remove(4);//by removing the 4, the 13 becomes the second number in the list

            integers.AddRange(new int[] { 4, 44, 444, 4444});

            integers[3] = 99;//this removed the 44 from its position and replaced it with '99'

            foreach(var i in integers) {
                Console.WriteLine($"i= {i}");
            }
        } 
    }
}
