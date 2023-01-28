// // Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // -1, -7, 567, 89, 223-> 3

// Console.Clear();

    
// Console.Write($"Введи число М(количество чисел): ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] massiveNumbers = new int[m];

// void InputNumbers(int m){
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введи {i+1} число: ");
//     massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }


// int Comparison(int[] massiveNumbers)
// {
//   int count = 0;
//   for (int i = 0; i < massiveNumbers.Length; i++)
//   {
//     if(massiveNumbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");

int[] myArray = GetArray();
SortInAscendingOrder(myArray);
Console.Write("Для завершения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();

int[] GetArray(){//------------------------МЕТОД СОЗДАЮЩИЙ МАССИВ НЕ МЕНЕЕ 6ти ЭЛЕМЕНТОВ
    int[] myArray = new int[new Random().Next(6, 12)];
    for(int i = 0; i < myArray.Length; i++){
        myArray[i] = new Random().Next(100);
    }
    return myArray;
}


void PrintArray(int[] array){//----------------МЕТОД ВЫВОДЯЩИЙ ЭЛЕМЕНТЫ МАССИВА НА ЭКРАН
    Console.WriteLine($"[{String.Join(",", array)}]");
}


void SortInAscendingOrder(int[] array){//-МЕТОД СОРТИРУЮЩИЙ МАССИВ В ПОРЯДКЕ ВОЗРАСТАНИЯ
    Console.Write("Массив до сортировки ==> ");
    PrintArray(array);
    int count = 1;
    for(int i = 0; i < array.Length; i++){
        for(int j = 0; j <= array.Length - count; j++){
            if(array[j] > array[array.Length - count]){//ставлю максимальный элемент в конец
                int boofer = array[array.Length - count];
                array[array.Length - count] = array[j];
                array[j] = boofer;
            }
        }
        count++;
    }
    Console.Write("Массив после сортировки ==> ");
    PrintArray(array);
}