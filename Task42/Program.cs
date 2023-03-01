System.Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberSaved = number;
string str = string.Empty;

while (number != 0)
{
    str = str + number % 2;
    number = number / 2;
}

GetBinNumber(str);
void GetBinNumber(string strMeth)
{
    System.Console.Write($"Число {numberSaved} в двоичной сиситеме равно ");
    for (int i = str.Length - 1; i >= 0; i--)
    {
        System.Console.Write(strMeth[i]);
    }
}
