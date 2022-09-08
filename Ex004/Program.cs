// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear ();
try 
{
    Console.WriteLine ("Введите число");
    int number = Convert.ToInt32 (Console.ReadLine());
    int curent = (number / 2); // считаем сколько раз надо выполнить цикл до достижения number с шагом 2 т,к выводиться будут четные цифры начиная с 2
    int result = 2;
    int i = 1; // счетчик
    if (number > 2 )
    {      
     while ( i < curent)
        {
            Console.Write(result + ",");
            result = (result + 2); 
            i++;
        }
    Console.Write (result); // выводим последнюю цифру без запятой 
    }
    else 
        Console.WriteLine ("введите целое число больше 2"); // проверка вводимого числа на нижний порог значения
 }

catch 
{
    Console.WriteLine ("Введите целое число"); // общее сообщение, если пользователь вчто-то кроме целого числа
}