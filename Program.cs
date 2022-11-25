// task1
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(n * 2);



// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(n > 10);



// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(n % 2 ==0);



// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(n % 2 !=0);



/*
Напишите программу, которая принимает на входе число и
проверяет кратно ли оно 2 и 3, если кратно, то вывести
"yes", вывести "no".
*/

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 2 == 0 && n % 3 == 0)
//     Console.Write("yes");
// else
//     Console.Write("no");



// task2
/*
Напишите программу, которая на входе принимает два числа и
проверяет, является ли перевое число квадратом второго.
*/

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (m * m == n)
//    Console.Write("yes");
// else
//    Console.Write("no");



// task3
/*
Напишите программу, которая будет выдавать название дня недели
по заданному номеру.
*/

// Console.Clear();
// Console.Write("Введите день недели: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 7)
// {
//    Console.Write("Вы ошиблись!\nВведите день недели: ");
//    n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
//    Console.Write("Понедельник");
// else if (n == 2)
//    Console.Write("Вторник");
// else if (n == 3)
//    Console.Write("Среда");
// else if (n == 4)
//    Console.Write("Четверг");
// else if (n == 5)
//    Console.Write("Пятница");
// else if (n == 6)
//    Console.Write("Суббота");
// else
//    Console.Write("Воскресенье");



// task 5
/*
Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа от -N до N.
*/
// через while

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = n * (-1);
// while (i <= n)
// {
//    // Console.Write(i + " ");  // !!! 
//    Console.Write($"{i} "); // в данном примере использовалась интерполяция строк: ($"текст {i}")
//    i = i + 1; // i++, i += 1
// }

// через for

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = (-1) * n; i <= n; i++)
//    Console.Write(i + " ");



// task 7
/*
Напишите программу, которая на вход принимает число
и навыходе показывает последнюю цифру числа
*/

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()); // |2 147 000 000|
// Console.Write(n % 10);