# Задача

Написать программу, которая из имеющегося 
массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться к
оллекциями, лучше обойтись исключительно массивами.

## Пример:

* ["hello", "2", ";-)"] -> ["2", ";-)"]
* ["1234", "1567", "-2", "computer secience"] -> ["-2"]
* ["Russia", "Denmark", "Kazan"] -> []

## Алгоритм решения:

1. Создаем два массива одинаковой длины;

2. Открываем цикл, где задаем условие, что, если элемент первого массива равен или меньше 3, то он записывается во второй массив;

3. Открываем цикл, чтобы по одному элементу выводить второй массив в консоль.

