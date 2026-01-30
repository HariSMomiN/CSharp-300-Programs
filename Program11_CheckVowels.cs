using System;
class Program {
    static void Main() {
        char c = 'a';
        if ("aeiouAEIOU".IndexOf(c) >= 0)
            Console.WriteLine("Vowel");
        else
            Console.WriteLine("Consonant");
    }
}
