using System;

namespace Wojack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }

    public class Wojack
    {
        public string name;
        public bool sex; //true is male and false is female
        public bool trans; //self explanatory
        public int zoomer_boomer; //zoomer boomer axis, negative means zoomer and positive means boomer, 0 value means born in 1980
        public int doomer_bloomer; //doomer bloomer axis
        public int coomer_trad; //coomer trad axis
        public int lies_truth; //negative means pathological liar, positive means speaks truth, 

        public Wojack(string name, bool sex, bool trans, int zoomer_boomer, int doomer_bloomer, int coomer_trad, int lies_truth)
        {
            this.name = name;
            this.sex = sex;
            this.trans = trans;
            this.zoomer_boomer = zoomer_boomer;
            this.doomer_bloomer = doomer_bloomer;
            this.coomer_trad = coomer_trad;
            this.lies_truth = lies_truth;
        }

        public conversation(string speak)
        {

        }
    }
}
