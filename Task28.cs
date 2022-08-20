// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите кол-во элементов массива");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
int sum = 1;
int n = 1;
for (int count = 0; count < i;) {
Console.WriteLine($"Введите {count + 1} элемент массива");
array[count] = Convert.ToInt32(Console.ReadLine());
count += 1;
}
for (int count = 0; count < i;){
while (n <= array[count]){
sum = sum * n;
n += 1;
}
array[count] = sum;
sum = 1;
n = 1;
count += 1;
}
for (int count = 0; count < i;) {
Console.Write(array[count]+ " ");
count += 1;
}