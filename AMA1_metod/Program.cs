// See https://aka.ms/new-console-template for more information
using AMA1_metod.Abstract;
using AMA1_metod.Classes;
using AMA1_metod.ŞirketÇalışanMaaşları;
using System.Diagnostics;
using static AMA1_metod.Classes.Calısans;

Console.WriteLine("Hello, World!");


Insan i = new Insan();
i.age = 19;
i.name = "rumeysa";
i.gender = true;
i.surname = "varlı0";
i.uyu();
Console.WriteLine("yaşınız: " + i.yaşBulma(2005));
i.YaşDurum(20);

Araba a = new Araba();
a.CarName = "\nBroadway";
a.Color = "mavi";
a.backBagaj = true;
a.DoorAccount = 4;
a.git("Broadway"," medine ");
a.git("Porche ", "911 ");
a.arabaYaşı(12);


Anne an = new Anne();
an.name = " fahriye ";
an.surname = " gökyar ";
an.ekranaYaz(an.name,an.surname);
an.oku(an.name);

Baba b = new Baba();
b.ekranaYaz(" kasım ", " gökyar ");
b.oku("kenan");

Çocuk c = new Çocuk();
b.ekranaYaz(" ibrahim ", " gökyar ");

Bmw r = new Bmw();
r.git("bmw", "x5");
r.vites("bmw ", "düz vites");
Console.Write("\n Bmw");
r.hızlıyım();
r.uçabilerem();
r.yüzebilirim();



Mercedes m = new Mercedes();
m.git("mercedes", "x1");
m.vites("mercedes", "otomatik vites");
Console.Write("\n Mercedes: ");
m.uçabilerem();
m.yüzebilirim();


Porche t = new Porche();
t.git("porche", "carrera");
t.vites("porche ", "otomatik vites");
Console.Write(" \n Porche");
t.uçabilerem();


AkilliCocuk k = new AkilliCocuk();
k.name = "hakan ";
k.surname = "yılmaz ";
k.durum="akıllı";
k.cocukYazdırma(k.name,k.surname,k.durum);
k.asker(k.name);
k.kulüp(k.name);
k.ehliyet(k.name);

UsluCocuk u = new UsluCocuk();
u.cocukYazdırma("mehmet " , "yıldız " , "uslu");
u.asker(u.name);
u.ehliyet(u.name);


TOGG o = new TOGG();
o.vites("togg ", "otomatik vites");

Audi d = new Audi();
d.vites("audi ", "düz vites");

Genel_Müdür g =new Genel_Müdür();
Müdür ü = new Müdür();
Programcı z =new Programcı();
Stajyer j =new Stajyer();


double ToplamMaaş = 0.0;
ToplamMaaş += g.maasinizNedir();
ToplamMaaş += z.maasinizNedir();
ToplamMaaş += ü.maasinizNedir();
ToplamMaaş += j.maasinizNedir();

Console.WriteLine("\n toplamda " + ToplamMaaş + "tl maaş alıyorlar");

double ToplamYakıt = 0.0;
ToplamYakıt += r.ArabaYakıt();
ToplamYakıt += t.ArabaYakıt();
ToplamYakıt += m.ArabaYakıt();
Console.WriteLine("\n toplamda " + ToplamYakıt + "L yakıyorlar");


string[] gunler = new string[7];
gunler[0] = "pazartesi";
gunler[1] = "salı";
gunler[2] = "çarşamba";
gunler[3] = "perşembe";
gunler[4] = "cuma";
gunler[5] = "cumartesi";
gunler[6] = "pazar";

int[] sayilar = { 3, 5, 6, 7, 85, 154, 86, 5, 46, 15, 489, 96, 154 };
for(int q =0; q<gunler.Length; q++)
{
    Console.WriteLine(gunler[q]);
    
}
int toplam = 0;
for(int q =0; q<sayilar.Length; q++)
{
    toplam += sayilar[q];
    
}
Console.WriteLine("sayılar dizisinin elemanları toplamı: "+ toplam);



//Tür belirtmek için köşeli parantezler (<>) kullanılır.
//Bu sayede, listeye yalnızca Araba nesneleri eklenebilir.
//foreach çalış

List<Araba> arabalar = new List<Araba>
{
    new Araba { CarName = "BMW", BenzinTüketimi = 6.6 },
    new Araba { CarName = "Mercedes", BenzinTüketimi = 7.5 },
    new Araba { CarName = "Porche", BenzinTüketimi = 5.9 }
};

double ToplamYakıts = 0.0;
foreach (var arabas in arabalar)
{
    Console.WriteLine($"Araba:{arabas.CarName}, BenzinTüketimi:{arabas.BenzinTüketimi}");
    ToplamYakıts += arabas.BenzinTüketimi;
}

Console.WriteLine("\n toplamda " + ToplamYakıts + "L yakıyorlar");




List<Calisans> calisanlar = new List<Calisans>
{
    new Calisans("Ali Yılmaz", 15000, "Genel Müdür", "Yönetim"),
    new Calisans("Ayşe Kara", 12000, "Müdür", "Pazarlama"),
    new Calisans ("Mehmet Demir",8000, "Programcı","IT" ),
    new Calisans ( "Elif Çelik", 3000, "Stajyer", "Muhasebe" )
};

double ToplamMaaşs = 0.0;
foreach (var calisan in calisanlar)
{
    Console.WriteLine($"AdıSoyadı: {calisan.AdiSoyadi}, Mesleği: {calisan.Meslegi}, Maaşı: {calisan.Maas}, Departmanı: {calisan.Departmani}");
    ToplamMaaşs += calisan.Maas;
}

Console.WriteLine("\n toplamda " + ToplamMaaşs + "TL");


