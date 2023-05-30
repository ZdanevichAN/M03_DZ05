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

double[] GetArrayReal(int size,int min, int max){
    double[] array = new double[size];
    for (int i = 0; i < size;i++){
        array[i] = Math.Round(((new Random().NextDouble())*max),2);
    }
    Console.WriteLine($"\n Создан массив [{String.Join(" | ", array)}],размером {size},с рандомными числами от {min} и до {max}");
    return array;
}

double[] array = GetArrayReal(size, min, max);

void DifMaxMin(double[] array){
    double max = array[0];
    double min = array[0];
    foreach(var el in array){
        if (el > max) { max = el; }
        else if (el < min) { min = el; }
    }
    Console.WriteLine($"\n В массиве [{String.Join(" | ", array)}] \n минимальное число равно {min} \n максимальное число равно {max} \n их разница равна {max - min}");
}

DifMaxMin(array);