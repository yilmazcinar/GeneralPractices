
//1- Consola "Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?" yazdırıyoruz. 
/* 

Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");

*/

//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
/*
string selam = " selam ";
int x = 7;

Console.WriteLine(selam + x);
*/


//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
/*
Random rnd = new Random();
int sayi = rnd.Next(1,101);

Console.WriteLine(sayi);

*/


//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.


/*
Random rnd = new Random();
int sayi = rnd.Next(1,765) % 3;
Console.WriteLine(sayi);
*/

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

/*

Console.WriteLine("Yaşınızı giriniz");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas > 18)
 Console.WriteLine("+");
else
Console.WriteLine("-");
*/


//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen vodafone gibi anı yaşarken, ben türkcell gibi seni her yerde çekemem.");

}
*/

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.


/*
Console.WriteLine("Bir isim giriniz");
string name1 = Console.ReadLine();
Console.WriteLine("İkinci ismi giriniz");
string name2 = Console.ReadLine();

string changer;

changer = name1;
name1 = name2;
name2 = changer;

Console.WriteLine($"İsimlerin yerleri değiştirildi {name1} {name2}");

*/

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.



/*

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok , beni değişkene atamaya çalışma.");

}

BenDegerDondurmem();

*/

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

/*

int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}

Topla(543, 755);

Console.WriteLine(Topla(543, 755));

 */

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.


/*
bool Validation(bool isValid)
{
    return isValid ? true : false;

}

bool isValid;
Console.WriteLine("True/False degerlerinden birini giriniz!");
isValid = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine(Validation(isValid));

*/

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

/*
int Elder(int age1, int age2, int age3)
{
    return Math.Max(Math.Max(age1, age2), age3 );

}
Console.WriteLine("1. yaşı giriniz");
int age1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. yaşı giriniz");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. yaşı giriniz");
int age3 = Convert.ToInt32(Console.ReadLine());

int elder = Elder(age1, age2, age3);

Console.WriteLine($"En yaşlı kişi {elder} yaşındadır");

*/


//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

/*
int FindMaxNumber()
{
    List<int> numbers = new List<int>(); // Bunu araştırarak buldum burada integer Numbers adında yeni bir liste oluşturuyoruz. 

    while (true) // Burada çıkış için string e harfini atadık ve koşula bağladık. 
    {
        string x = Console.ReadLine();
        
        if (x.ToLower() == "e")
        {
            break;
        }

        if (int.TryParse(x, out int number)) // x 'i string olarak atadığımız için burada x' in integer' a dönüşü mümkünse number değişkenine ata diyoruz.
        {
            numbers.Add(number); // int dönen input numbers listesine ekleniyor. 
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı giriniz veya çıkmak için 'e' tuşuna basınız. "); 
        }
    }
    return numbers.Max();
}

Console.WriteLine("Dilediğiniz kadar sayı giriniz ve en büyüğünü görmek için 'e' tuşuna basınız. ");
int maxNumber = FindMaxNumber();
Console.WriteLine($"Girdiğiniz sayıların en büyüğü {maxNumber} dır.");

*/

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

/*
void NameChanger(ref string name1, ref string name2)
{
    string changer = name1;
    name1 = name2;
    name2 = changer;
}

Console.WriteLine("Bir isim giriniz");
string name1 = Console.ReadLine();
Console.WriteLine("İkinci ismi giriniz");
string name2 = Console.ReadLine();

NameChanger(ref name1, ref name2);

Console.WriteLine($"İsimlerin yerleri değiştirildi {name1} {name2}");

*/

//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.


/*
bool CiftMi(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int num;

Console.Write("Bir sayi giriniz: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CiftMi(num));
*/

//5 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

/*
double YolHesaplama(double hiz, double zaman)
{
    return hiz * zaman;

}

Console.WriteLine("Hızını km/saat olarak giriniz. ");
double hiz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Zamanı saat cinsinden giriniz");
double zaman = Convert.ToDouble(Console.ReadLine());

double km = YolHesaplama(hiz, zaman);

Console.WriteLine($"Katedilen mesafe {km} dir.");
*/

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

/*

double DaireninAlanı(double pi, double r)
{
    return pi * Math.Pow(r, 2); // Matematik metodlarında bir sayının üssünü almak için bu metodu kullanıyoruz. 
}

double pi = 3.14; //matematik metodu olarak var ama ben 3.14 ' e eşitledim. 

Console.WriteLine("Hesaplamak istediğiniz dairenin yarı çapını giriniz.");

double r = Convert.ToDouble(Console.ReadLine());

double area = DaireninAlanı(pi, r);

Console.WriteLine($"Dairenin alanı {area} 'dir." );

 */

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

/*
 
string word = "Zaman bir GeRi SayIm";
Console.WriteLine(word.ToLower());
Console.WriteLine(word.ToUpper());

 */

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

/*
string word = "    Selam    ";

Console.WriteLine(word);
Console.WriteLine(word.Trim());

*/



