﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Clear ();

 try
 {
    Console.WriteLine ("введите первое число: ");
    int number1 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine ("введите второе число: ");
    int number2 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine ("введите третье число: ");
    int number3 = Convert.ToInt32 (Console.ReadLine ());
   
        if (number1 >= number2) 
            if (number1 >= number3) 
                Console.WriteLine ("max = " + number1);
            else
                Console.WriteLine ("max = " + number3); 

        else 
            if (number2 >= number3) 
                Console.WriteLine ("max = " + number2);
            else
                Console.WriteLine ("max = " + number3);     
 
}

catch 
{
  Console.WriteLine ("вы ввели не целое число");
}