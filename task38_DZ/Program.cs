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

int[] GetArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size;i++){
        array[i] = new Random().Next(min, max+1);
    }
    Console.WriteLine($"Создан массив [{String.Join("|", array)}],размером {size},с рандомными числами от {min} и до {max}");
    return array;
}

int[] array = GetArray(size, min, max);