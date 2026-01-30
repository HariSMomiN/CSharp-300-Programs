using System;
class Program {
    static void Main() {
        int n = 153, sum = 0, temp = n;
        while (n > 0) {
            int d = n % 10;
            sum += d * d * d;
            n /= 10;
        }
        Console.WriteLine(sum == temp ? "Armstrong" : "Not Armstrong");
    }
}
