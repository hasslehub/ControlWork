**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

#
# Решение задачи

Согласно заданию, первоначальный массив вводися либо с клавиатуры, либо он задан на старте.
 
* При старте пограммы первоначальный массив **mainArray** имеет значение:
**["hello", "2", "world", ":-)"]**


* С помощью метода **FindFromArray** 
перебираем элементы массива и проверям есть ли среди существующих элементов, элементы длина которых меньше либо равна 3 символам.
* Результат, удовлетворяющий условию записывается в массив строк **finalArray**.


При выполнении програмы с помощью метода **PrintArray** выводим на экран первоначальный массив **mainArray** и  заполненный массив строк **finalArray** с результатом решения задачи .
