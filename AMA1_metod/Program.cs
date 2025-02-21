// See https://aka.ms/new-console-template for more information
using AMA1_metod.Classes;

Console.WriteLine("Hello, World!");


Insan i = new Insan();
i.age = 19;
i.name = "rumeysa";
i.gender = true;
i.surname = "varlı0";
i.uyu();

Araba a = new Araba();
a.CarName = "Broadway";
a.Color = "mavi";
a.backBagaj = true;
a.DoorAccount = 4;
a.git("Broadway"," medine ");
a.git("Porche ", "911 ");

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

Mercedes m = new Mercedes();
m.git("mercedes", "x1");
m.vites("mercedes", "otomatik vites");

Porche t = new Porche();
t.git("porche", "carrera");
t.vites("porche ", "otomatik vites");

AkilliCocuk k = new AkilliCocuk();
k.name = "hakan ";
k.surname = "yılmaz ";
k.durum="akıllı";
k.cocukYazdırma(k.name,k.surname,k.durum);

UsluCocuk u = new UsluCocuk();
u.cocukYazdırma("mehmet " , "yıldız " , "uslu");

TOGG o = new TOGG();
o.vites("togg ", "otomatik vites");

Audi d = new Audi();
d.vites("audi ", "düz vites");

