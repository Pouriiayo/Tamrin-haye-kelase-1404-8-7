// پوریا یوسفی 
// تمرین 1 

while (true)
{
    int number1;
    int number2;
    bool IsValid = false;
    Console.WriteLine("adad aval ra vared konid: ");
    string input1 = Console.ReadLine();

    while (!IsValid)
    {
        if (input1 != null && int.TryParse(input1, out number1) && int.Parse(input1) > 0){
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

    Console.WriteLine("Baraye adad beyn yeki az mavared zir ra entekhab konid:");
    Console.WriteLine("a : zoj ya fard boodan adad.");
    Console.WriteLine("b : aval boodan adad");
    Console.WriteLine("c : Aeene boodan adad");
    Console.WriteLine("d : kamel boodan adad");

    string user = Console.ReadLine();
    bool TrueInput = false;

    if (number1 > number2)
    {
        int num1 = number1;
        int num2 = number2;
        number1 = num2;
        number2 = num1;
    }

    while (!TrueInput)
    {
        if (number1 == number2)
        {
            Console.WriteLine("adady beyn in do vojood nadarad");
            TrueInput = true;
        }

        if (user == "a")
        {
            for (int i = number1 + 1; i < number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " zoj ast.");
                }
                else
                {
                    Console.WriteLine(i + " fard ast.");
                }
            }

            TrueInput = true;
        }
        else if (user == "b")
        {
            for (int i = number1 + 1; i < number2; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " Aval ast.");
                }
            }
                TrueInput = true;
        }
        else if (user == "c")
        {
            for (int i = number1 + 1; i < number2; i++)
            {
                if (IsAeene(i))
                {
                    Console.WriteLine(i + " Aeene ast.");
                }
                
            }
                TrueInput = true;
        }
        else if (user == "d")
        {
            for (int i = number1 + 1; i < number2; i++)
            {
                if (IsKamel(i)){
                    Console.WriteLine(i + " Kamel ast.");
                }
            }
                TrueInput = true;
        }
        else
        {
            TrueInput = false;
            Console.WriteLine("Baraye adad beyn yeki az mavared zir ra entekhab konid:");
            Console.WriteLine("a : zoj ya fard boodan adad.");
            Console.WriteLine("b : aval boodan adad");
            Console.WriteLine("c : Aeene boodan adad");
            Console.WriteLine("d : kamel boodan adad");

            user = Console.ReadLine();
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

bool IsAeene(int m)
{
    int t = m;
    int ans = 0;
    if (m > 10)
    {
        while (m > 0)
        {
            int ragham = m % 10;
            ans = ans * 10 + ragham;
            m /= 10;
        }
    }
        return ans == t;
}

bool IsKamel(int x)
{
    if (x == 0)
    {
        return false;
    }
    int sum = 0;
    for (int i = 1; i < x; i++)
    {
        if (x % i == 0)
        {
            sum += i;
        }
    }
    return x == sum;
}
