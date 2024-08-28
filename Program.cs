// toq sonlar yigindisi
int equal = 0;
int allNumber = 0;

while (equal <= 1000)
{
    if (equal % 2 != 0)
    {
        allNumber += equal;
    }
    equal++;
}
Console.WriteLine(allNumber);



// katta va kichik sonlar kopaytmasi
Console.WriteLine("raqamlar kiriting misol uchun '1, 3, 23, ...': ");
string inputNumber = Console.ReadLine();


 int[] numbers = inputNumber.Split(',').Select(int.Parse).ToArray();
 Array.Sort(numbers);
int little = 0;
int max = 0;

for (int i = 0; i < numbers.Length; i++)
{
    little = numbers[0];
    if(i == numbers.Length -1){
        max = numbers[i];
    }
}

Console.WriteLine($"katta va kichik raqamlar kopaytmasi {little} * {max} = {little * max} ga teng");




// Faktorialni hisoblash
Console.WriteLine("Butun son kiriting:");
int x = int.Parse(Console.ReadLine());

int factorial = 1;

for (int i = 1; i <= x; i++)
{
    factorial *= i;
}

Console.WriteLine(x + "! = " + factorial);