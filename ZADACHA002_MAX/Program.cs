/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int NumberA=int.Parse(Console.ReadLine());
int NumberB = int.Parse(Console.ReadLine());
int NumberC = int.Parse(Console.ReadLine());

int max=NumberA;
if (NumberB>max) {
    max = NumberB;

}

if (NumberC>max) {
    max=NumberC;
}

Console.WriteLine(max);
