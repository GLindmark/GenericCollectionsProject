using System;
using System.Collections.Generic;

namespace GenericCollectionsProject {
    class Program {
        static void Main(string[] args) {


            List<int> frames = new List<int>(10);

            Random rnd = new Random();// used to generate random number and can be used many times


            for (var idx = 0; idx < 10; idx++) {// load 10 scores
                var score = rnd.Next(0, 31);
                frames.Add(score);
            }

            rnd.Next(0, 30);

            int total = 0;
            foreach (var frame in frames) {
                total += frame;
            }
            Console.WriteLine($"Game score is {total}");



    


            /*
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
            }*/
        } 
    }
}
