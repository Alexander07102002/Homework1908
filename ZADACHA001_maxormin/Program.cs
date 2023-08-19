using System.ComponentModel.DataAnnotations;

int NumberA=int.Parse(Console.ReadLine());
int NumberB=int.Parse(Console.ReadLine());

int min =0;
int max =0;

if (NumberA>NumberB) {
    max = NumberA;
    min = NumberB;
}
else {
    max=NumberB;
    min=NumberA;
}

Console.WriteLine("Максимальное значение = "+max);
Console.WriteLine("Минимальное значение = "+min);