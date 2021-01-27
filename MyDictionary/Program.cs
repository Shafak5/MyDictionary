using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> words = new MyDictionary<string, string>();
            words.Add("Run"," Koşmak");
            words.Add("Walk"," Yürümek");
            words.Add("Skip"," Atlamak");
            words.Print();


        }
    }
}
