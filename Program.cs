// Task1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//     int CutNumber(int num1)
//     {
//       int udaleniepervoi = num1 / 10;
//       int udalenieposlednei = udaleniepervoi % 10;
//       return udalenieposlednei;
//     }


// Console.Write("Input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int result = CutNumber(num1);

// if(num1>99 && num1<1000)
// {
//   Console.WriteLine("New version is: " + result);
// }
// else
// {
//   Console.WriteLine("Повторите попытку, введя трехзначное число");
// }

//************************************************************************************************************************************************************************
// Task2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int CutNumber(int num)
//   { 
//     while(num >= 1000)
//     {
//      num = num / 10;
//     }
//     return num = num % 10;
//   }
// if (num < 100)
//     {
//         Console.Write ("The third number is missing, try again with another number");
//     }
//         else 
//     {   
//         Console.WriteLine(CutNumber(num));
//     }

// Task3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.WriteLine("Enter the day of the week");
// int num = Convert.ToInt32(Console.ReadLine());

// bool IsNotTheDayOfWeek(int num)
//     {
//         if (num < 1 || num > 7)
//         {
//             return true;
//         }
//         else 
//         {
//           return false;
//         }
//     }
// bool IsDayOff(int num)
//     {
//         if (num >= 1 && num <= 5)
//         {
//           return true;
//         }
//         else
//         {
//           return false;
//         }
//     }
// if(IsNotTheDayOfWeek(num))
// {
//     System.Console.WriteLine("Enter the day of the week from 1 to 7");
// }
// else if(IsDayOff(num))
// {
//     Console.WriteLine("Workday!");
// }
// else
// {
//     System.Console.WriteLine("Day Off");
// }
