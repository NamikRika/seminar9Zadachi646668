// // Урок 9. Как не нужно писать код. Часть 3

// // Задача 64: Задайте значение N.
// // Напишите программу, которая выведет все натуральные числа \n 
// // в промежутке от N до 1. Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// //---Решение Задачи 64 ---------------

// Console.WriteLine("Задача 64: \n Задайте значение N. \n" +
//                "Напишите программу, которая выведет все натуральные числа \n" + 
//                "в промежутке от N до 1. Выполнить с помощью рекурсии. \n");

// void  naturalNumbetweenNaOne(int n)
// {
//     if (n > 0)
//     {
//         Console.Write(n);
//         naturalNumbetweenNaOne(n - 1);
//     }
// }

// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// naturalNumbetweenNaOne( numberN);

// //---Задача 64 ------Завершена---------


// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// //---Решение Задачи 66 ---------------

// Console.WriteLine("Задача 66: \n Задайте значения M и N. Напишите программу, которая \n" + 
//                   " найдёт сумму натуральных элементов в промежутке от M до N. \n");


// int sumNaturalElements(int numberM, int numberN, int summ)
// {

//      summ += numberN;   
//      if (numberN != numberM)     
//      {         
//          return sumNaturalElements(numberM, numberN - 1, summ);                                       
//      }

//      return summ;
      
// }    

// Console.Write("Введите число M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// Console.Write("Cумма натуральных элементов в промежутке от " + numberM + " до "  + numberN + " равна ");
// Console.Write(sumNaturalElements(numberM, numberN, 0));

// //---Задачи 66 ---Завершена------------

// ---Задача 68

// int AkkermanFunction(int m, int n)
// {
//   if (m == 0)
//    {
//       return n + 1; 
//    }
//       else if (n == 0 && m > 0)
//        {
//           return AkkermanFunction(m - 1, 1);
//        }
//       else
//          {
//            return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//          }
// }
 
// Console.Write(AkkermanFunction(1, 1));