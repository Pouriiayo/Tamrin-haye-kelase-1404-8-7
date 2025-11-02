//پوریا یوسفی
//تمرین 2

int number1;
int number2;
bool IsValid = false;
Console.WriteLine("adad aval ra vared konid: ");
string input1 = Console.ReadLine();

while (!IsValid)
{
    if (input1 != null && int.TryParse(input1, out number1) && int.Parse(input1) > 0)
    {
        IsValid = true;
    }
    else
    {
        Console.WriteLine("lotfan adad dorost vared konid");
        input1 = Console.ReadLine();
        IsValid = false;
    }
}

number1 = int.Parse(input1);

IsValid = false;
Console.WriteLine("adad dovom ra vared konid: ");
string input2 = Console.ReadLine();

while (!IsValid)
{
    if (input2 != null && int.TryParse(input2, out number2) && int.Parse(input2) > 0)
    {
        IsValid = true;
    }
    else
    {
        Console.WriteLine("lotfan adad dorost vared konid");
        input2 = Console.ReadLine();
        IsValid = false;
    }
}

number2 = int.Parse(input2);

if (number1 > number2)
{
    int num1 = number1;
    int num2 = number2;
    number1 = num2;
    number2 = num1;
}

if (number1 == number2)
{
    Console.WriteLine("adady beyn in do adad vojood nadarad");
}

for (int i = number1 + 1; i < number2; i++)
{
    if (IsPrime(i))
    {
        Console.WriteLine($"{i} aval ast");
    }
}

for (int i = number1 + 1 ; i < number2; i++)
{
    if (i % 2 == 0 && i > 2)
    {
        for (int x = 2 ; x <= i / 2; x++)
        {
            int j = i - x;
            if (IsPrime(x) && IsPrime(j))
            {
                Console.WriteLine($"({x} + {j} = {i} Goldbakh)");
            }
        }
    }
    else if (i % 2 != 0 && i > 5)
    {
        for (int y = 2; y <= i; y++)
        {
            int z = i - 2*y;
            if (IsPrime(y) && IsPrime(z))
            {
                Console.WriteLine($"({y} + 2({z}) = {i} Lemoin)");
            }
        }
    }
}
bool IsPrime(int n)
{
    if (n > 1)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
    }
    else
    {
        return false;
    }
    return true;
}