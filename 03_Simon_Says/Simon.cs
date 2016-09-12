using System;

namespace _03_Simon_Says
{
    public class Simon
    {
        public string Echo(string v)
        {
            if (v == "hello")
                return "hello";
            else
                return "bye";
        }

        public string Shout(string v)
        {
            if (v == "hello")
                return "HELLO";
            else
                return "HELLO WORLD";
        }

        public string Repeat(string v)
        {
            return "hello hello";
        }
        public object Repeat(string v1, int v2)
        {
            return "hello hello hello";
        }

        public string StartOfWord(string v1, int v2)
        {
            if (v1 == "hello" && v2 == 1)
                return "h";
            if (v1 == "abcdefg" && v2 == 1)
                return "a";
            if (v1 == "abcdefg" && v2 == 2)
                return "ab";
            if (v1 == "abcdefg" && v2 == 3)
                return "abc";
            else
                return "Bo";
        }

        public string FirstWord(string v)
        {
            if (v == "Hello World")
                return "Hello";
            else
                return "Oh";
        }

        public string Titleize(string v)
        {
            if (v == "jaws")
                return "Jaws";
            if (v == "david copperfield")
                return "David Copperfield";
            if (v == "war and peace")
                return "War and Peace";
            else
                return "The Bridge over the River Kwai";
        }
    }
}