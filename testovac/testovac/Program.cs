using testovac;
double a = Double.Parse(Console.ReadLine());
double b = Double.Parse(Console.ReadLine());
double c = Double.Parse(Console.ReadLine());
Kvadr testObjekt = new Kvadr(a, b, c);

Console.WriteLine(testObjekt.Objem());
Console.WriteLine(testObjekt.Povrch());
Console.WriteLine(testObjekt.Uhlop());
Console.WriteLine(testObjekt.Uhlopricky());