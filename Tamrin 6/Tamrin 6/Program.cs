float sumAV = 0;
float sumV = 0;
while (true)
{
    float number;
    float Vazn;
    Console.WriteLine("adad vared konid :");
    string input = Console.ReadLine();
    if (input.ToLower() == "q")
    {
        break;
    }
    number = float.Parse(input);

    Console.WriteLine("Vazne adad ra vared konid :");
    string inputV = Console.ReadLine();

    if (inputV.ToLower() == "q")
    {
        break;
    }

    Vazn = float.Parse(inputV);


    sumAV += (number * Vazn);
    sumV += Vazn;
}
float AverageBaVazn = sumAV / sumV;

if (AverageBaVazn != 0)
{
    Console.WriteLine($"miangin barabar ast ba = {AverageBaVazn}");
}
else
{
    Console.WriteLine("nashod");
}
