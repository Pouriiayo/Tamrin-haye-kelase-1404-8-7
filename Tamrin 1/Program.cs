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

    Console.WriteLine("yeki az mavared zir ra entekhab konid:");
    Console.WriteLine("a : zoj ya fard boodan adad.");
    Console.WriteLine("b : aval boodan adad");
    Console.WriteLine("c : Aeene boodan adad");
    Console.WriteLine("d : kamel boodan adad");

    string user = Console.ReadLine();
    bool TrueInput = false;
    while (!TrueInput)
    {
        if (user == "a")
        {
            if (number1 % 2 == 0)
            {
                Console.WriteLine(number1 + " zoj ast" + "\n******************");
            }
            else
            {
                Console.WriteLine(number1 + " fard ast" + "\n******************");
            }
            
            if (number2 % 2 == 0)
            {
                Console.WriteLine(number2 + " zoj ast" + "\n******************");
            }
            else
            {
                Console.WriteLine(number2 + " fard ast" + "\n******************");
            }

            TrueInput = true;
        }
        else if (user == "b")
        {
            if (IsPrime(number1))
            {
                Console.WriteLine(number1 + " aval ast" + "\n******************");
            }
            else
            {
                Console.WriteLine(number1 + " aval nist" + "\n******************");
            }

            if (IsPrime(number2))
            {
                Console.WriteLine(number2 + " aval ast" + "\n******************");
            }
            else
            {
                Console.WriteLine(number2 + " aval nist" + "\n******************");
            }
            TrueInput = true;
        }
        else if (user == "c")
        {
            if (IsAeene(number1))
            {
                Console.WriteLine(number1 + " Aeenei ast" + "\n******************");
            }
            else
            {
                Console.WriteLine(number1 + " Aeenei nist" + "\n******************");
            }

            if (IsAeene(number2))
            {
                Console.WriteLine(number2 + " Aeenei ast" + "\n******************");
            }
            else
            {
                Console.WriteLine(number2 + " Aeenei nist" + "\n******************");
            }
            TrueInput = true;
        }
        else if (user == "d")
        {
            if (IsKamel(number1))
            {
                Console.WriteLine(number1 + " kamel ast" + "\n******************");
            }
            else
            {
                Console.WriteLine(number1 + " kamel nist" + "\n******************");
            }

            if (IsKamel(number2))
            {
                Console.WriteLine(number2 + " kamel ast" + "\n******************");
            }
            else
            {
                Console.WriteLine(number2 + " kamel nist" + "\n******************");
            }
            TrueInput = true;
        }
        else
        {
            TrueInput = false;
            Console.WriteLine("yeki az mavared zir ra entekhab konid:");
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