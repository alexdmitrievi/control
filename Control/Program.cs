/* Написать программу, котороая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.*/

string[] array = {"Hello","25","father","1994","hi"};
int len = array.Length;
string[] newarray = new string[len];
int j = 0;
for (int i = 0; i < len; i++){
    if (array[i].Length <= 3){
        newarray[j] = array[i];
        j = j + 1;
    }
}
Console.Write("[");
for (int i = 0; i < j; i++){
    Console.Write($"'{newarray[i]}'");
    if (i != j-1){
        Console.Write(",");
    }
}
Console.Write("]");

