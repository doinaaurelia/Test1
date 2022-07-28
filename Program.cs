/* Написать программу, которая из имеющегося 
массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться к
оллекциями, лучше обойтись исключительно массивами. */


string[] array = new string[5] {"wazzaaap", "u2", "cu", "fyi", "nooooooo"};
string[] array2 = new string[array.Length];
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        array2[index] = array[i];
        index++; 
    }
}

for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine($"{array2[i]} ");
}