Console.Clear();

Console.Write("Введите через пробел элементы вашего массива: ");
string[] array1 = Console.ReadLine().Split(' ');
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array1)}]"); 

int length2 = 0;  // Определим длину массива, включающего в себя только элементы, длина которых меньше или равна трем символам 
for (int i = 0; i < array1.Length; i++)
    if (array1[i].Length <= 3) 
        length2++; 

string[] array2 = new string[length2];
int k = 0;
for (int i = 0; i < array1.Length; i++)  // Заполним новый массив элементами, длина которых меньше или равна трем символам 
    if (array1[i].Length <= 3) 
    {
        array2[k] = array1[i];
        k++;
    }

Console.WriteLine($"Массив с элементами не длиннее трех символов: [{string.Join(", ", array2)}]"); 