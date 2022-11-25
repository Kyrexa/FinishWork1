﻿// Итоговая проверочная работа 1 блок
//Например:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
string[] array = AskArray();
string[] result = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
string[] FindLessThan(string[] input, int c) {
    string[] output = new string[CountLessThan(input, c)];
    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= c) {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}
int CountLessThan(string[] input, int c) {
    int count = 0;
    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= c) {
            count++;
        }
    }
    return count;
}
string[] AskArray() {
    Console.Write("Вводите через пробел: ");
    return Console.ReadLine().Split(" ");
}
