//پوریا یوسفی
//تمرین 4

Console.WriteLine("In barname barresi mikone ke 3 noghte rooye yek khat hastand ya na.\n lotfan be in soorat vared konid : x,y = 2.3,1.4");
Console.WriteLine("Mokhtasat noghte aval ra vared konid , P1 : (x1,y1) ");
string[] input1 = Console.ReadLine().Split(",");
double p1x1  = double.Parse(input1[0]);
Console.WriteLine(p1x1);
double p1y1 = double.Parse(input1[1]);
Console.WriteLine(p1y1);

Console.WriteLine("Mokhtasat noghte aval ra vared konid , P2 : (x2,y2) ");
string[] input2 = Console.ReadLine().Split(",");
double p2x2 = double.Parse(input2[0]);
Console.WriteLine(p2x2);
double p2y2 = double.Parse(input2[1]);
Console.WriteLine(p2y2);

Console.WriteLine("Mokhtasat noghte aval ra vared konid , P3 : (x3,y3) ");
string[] input3 = Console.ReadLine().Split(",");
double p3x3 = double.Parse(input3[0]);
Console.WriteLine(p3x3);
double p3y3 = double.Parse(input3[1]);
Console.WriteLine(p3y3);

if ((p2x2 - p1x1) * (p3y3 - p1y1) == (p3x3 - p1x1) * (p2y2 - p1y1))
{
    Console.WriteLine("Noghte P3 rooye khaty ke az P1 va P2 oboor mikonad gharar darad.");
}
else
{
    Console.WriteLine("Noghte P3 rooye khaty ke az P1 va P2 oboor mikonad gharar nadarad.");
}