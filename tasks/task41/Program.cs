// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++){
    Console.Write($"Введите число {i + 1}: ");
    int current = Convert.ToInt32(Console.ReadLine());
    if (current > 0){
        count++;
    } 
}
Console.Write($"Количество чисел больших 0: {count}");