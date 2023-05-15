using System;

class MainClass {
  public static void Main (string[] args) {
    double balance1, balance2, balance3;

    // รับค่ายอดเบ็ดเตล็ดทั้ง 3 ยอด
    Console.Write("Enter balance 1: ");
    balance1 = double.Parse(Console.ReadLine());
    Console.Write("Enter balance 2: ");
    balance2 = double.Parse(Console.ReadLine());
    Console.Write("Enter balance 3: ");
    balance3 = double.Parse(Console.ReadLine());

    double amount;
    double remainingBalance1 = balance1;
    double remainingBalance2 = balance2;
    double remainingBalance3 = balance3;

    do {
      Console.Write("Enter payment amount (0 or negative number to exit): ");
      amount = double.Parse(Console.ReadLine());

      // หักยอดชำระออกจากยอดเบ็ดเตล็ดตามลำดับ
      if (remainingBalance1 >= amount) {
        remainingBalance1 -= amount;
      } else if (remainingBalance2 >= amount) {
        remainingBalance2 -= amount;
      } else if (remainingBalance3 >= amount) {
        remainingBalance3 -= amount;
      } else {
        Console.WriteLine("Left : {0}", amount);
        break;
      }

      Console.WriteLine("Balance 1: {0}, Balance 2: {1}, Balance 3: {2}", remainingBalance1, remainingBalance2, remainingBalance3);
    } while (amount > 0);
  }
}
    