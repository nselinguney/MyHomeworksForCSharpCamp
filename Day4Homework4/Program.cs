using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> kelimeler = new MyDictionary<string, string>();
            kelimeler.Add("kalem", "pencil");
            kelimeler.Add("kitap","book");
            kelimeler.Add("elma", "apple");
            kelimeler.Add("türkçe", "turkish");
            kelimeler.Add("harita", "map");
            kelimeler.List();

        }
    }
}
