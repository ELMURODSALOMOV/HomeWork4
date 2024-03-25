System.Console.Write("Enter the minutes: ");
int minut = Convert.ToInt32(Console.ReadLine());
int hour = minut / 60;
int minutes = minut % 60;
System.Console.WriteLine($"{hour}:{minutes}");

System.Console.Write("Enter the user's age: ");
int age = Convert.ToInt32(Console.ReadLine());
if(age >= 0 && age <= 12)
{
    System.Console.WriteLine("This is a young boy");
}
else if(age >= 13 && age <= 19)
{
    System.Console.WriteLine("This is a teenage boy");
}
else if(age >= 20 && age <= 59)
{
    System.Console.WriteLine("These are young adults");
}
else
{
    System.Console.WriteLine("the oldest age");
}
Console.Write("Birinchi fan bo'yicha baho kiriting (0 dan 100 gacha): ");
        int baho1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ikkinchi fan bo'yicha baho kiriting (0 dan 100 gacha): ");
        int baho2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Uchinchi fan bo'yicha baho kiriting (0 dan 100 gacha): ");
        int baho3 = Convert.ToInt32(Console.ReadLine());

        double oRtachaBall = (baho1 + baho2 + baho3) / 3.0;

        string natija = oRtachaBall >= 80 ? "A'lo" :
                         oRtachaBall >= 60 ? "Yaxshi" :
                         oRtachaBall >= 40 ? "Qoniqarli" : "Qoniqarsiz";

        Console.WriteLine($"Sizning o'rtacha ballingiz: {oRtachaBall}. Bu {natija}.");

Random random = new Random();
int sirliRaqam = random.Next(1, 101);
int taxmin = 0;
System.Console.WriteLine("Men 1 dan 100 gacha son o'yladim, uni topishga harakat qilib ko'ring");
while(sirliRaqam != taxmin)
{
    System.Console.Write("O'ylagan soningizni kiriting: ");
    taxmin = Convert.ToInt32(Console.ReadLine());
    string Natija = taxmin > sirliRaqam ? "Katta. Yana harakat qilib ko'ring":
                    taxmin < sirliRaqam ? "Kichik. Yana harakat qilib ko'ring":
                    "To'g'ri. Siz sonni topdingiz";
    System.Console.WriteLine(Natija);
    if(taxmin == sirliRaqam) break;
}
System.Console.WriteLine("Qoyil sizga aqlli ekansiz!");
