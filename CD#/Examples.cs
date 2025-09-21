using System;
//IMPORT FOR BASIC THINGS
using CD_.CDSharp;
//IMPORT IS NEEDED FOR YOOL YES OR NO
using static CD_.CDSharp.YesNo;

namespace CD_
{
    internal class Program
    {
        static void Main()
        {
            yo();
        }
        public void ExamplesBrah()
        {
            //Welcome to CD#. This is C# but just so, so, SO much better.
            //First off, we have yools. It's basically bools, but so much better!
            //yes/true

            yool example = yes;

            //no/false

            yool example2 = no;

            //For printing/Console.WriteLine, we do Hw.HelloWorld.

            Hw.HelloWorld("Yo");

            //To see the value whilst printing, do this to get it!

            Hw.HelloWorld(example2.ToString());
            Hw.HelloWorld(example.ToString());
            //Now, we have lint and ling. These are basically int and string, but SO much better.

            lint yo = 10;
            ling bruh = "BREO";

            //Now we have bobject (object but better), and guble (double but better)

            bobject bob = new bobject(13);
            bobject bruh2 = new bobject("");
            bobject bruh3 = new bobject(13f);
            
            guble bruh5 = 9D + 9D;

            //Now we have bloat (float but better), and hingle (single but better)

            bloat what = 9f;
            hingle bruh6 = 9f;

            //That's it for now! More soon.
        }
        //Now we have goid, which is a method name that can be used instead of void because it's SO much better.
        public static goid yo()
        {
            //You'd put your code here
            //For example, let's do a quick yool thingy
            yool bruh = no;
            if (bruh = no)
            {
                bruh = yes;
            }
            if (bruh = yes)
            {
                while (true)
                {
                    Hw.HelloWorld("No");
                }
            }
            //We do this to return something, it's just going to return itself, but your code still runs after.
            return goid.Value;
        }
    }
}
