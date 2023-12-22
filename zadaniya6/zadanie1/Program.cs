/* Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива. */

char[,] array = new char[,] { { '1', '2', '3'}, { 'a', 'b', 'c' } };
string ending = Changing();
Console.WriteLine(ending);

string Changing() {
    string ending = "";
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            ending = ending + array[i, j];
        }
    }
    return ending;
}