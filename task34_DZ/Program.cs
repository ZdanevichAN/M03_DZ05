// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int Prompt(string message){
    int num = 0;
    Console.Write(message);
    try { num = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine($"Число {num} - введено некорректно"); }
    return num;
}

int size = Prompt("Введите количество чисел в массиве: ");
int min = Prompt("Введите минимум для выбора рандомных чисел массива: ");
int max = Prompt("Введите максимум для выбора рандомных переменных: ");

int[] GetArrayPositiveThreeDigit(int size, int min, int max){
    Console.WriteLine("");
    int[] array = new int[size];
    if (100 < min && min <= max) { min = min; } else { Console.WriteLine($"Ваш минимум {min} будет заменен на 100"); min = 100; }
    if (min < max && max  <= 1000) { max = max; } else { Console.WriteLine($"Ваш максимум {max} будет заменен на 1000"); max = 1000; }
    for (int i = 0; i < size;i++){
        array[i] = new Random().Next(min, max);
    }
    Console.WriteLine($"Создан массив [{String.Join("|", array)}],размером {size},с рандомными числами от {min} и до {max}");
    Console.WriteLine("");
    return array;
}

int[] array = GetArrayPositiveThreeDigit(size, min, max);

int AmtPositiveArray(int[] array){
    int num = 0;
    try{
        foreach(var el in array){
            if (el > 0) { num++; }
        }
    }
    catch { Console.WriteLine("Что-то пошло не так при попытчке посчитать положительные числа в массива"); }
    Console.WriteLine($"В массиве [{String.Join("|", array)}], \n количество положительных чисел равно {num} ");
    return num;
}

int num =  AmtPositiveArray(array);