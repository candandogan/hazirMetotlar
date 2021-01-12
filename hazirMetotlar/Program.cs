using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // string.toCharArray() metodu, input olarak aldığı stringi char dizisine dönüştürür.
            string a = "Turkcell Geleceğe Adını Yazacak Kadın Mühendis Adayları";
            Console.WriteLine("Üzerinde hazır metotları uygulayacağımız ana string: "+a);
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
            //char tipinde bir dizi oluşturup toCharArray() hazır metodunun döndürdüğü değerleri bu dizide tutuyoruz
            char[] charDizisi = a.ToCharArray();

            //dizide tutulan her bir değeri ekrana yazdırıyoruz
            Console.WriteLine("toCharArray() metodu uygulandığında elde edilen sonuç: ");
            foreach (char c in charDizisi)
            {

                Console.Write(c+" ");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("-------------------------------------------------------------------------- \nstring.Contains() metodu uygulandığında elde edilen sonuç: ");

            //string.Contains() metodu, parametre olarak aldığı stringin, çağırıldığı string içinde olup olmadığını kontrol ederek bool değer döndürür.
            // eğer parametre string, çağırıldığı string içinde varsa true yoksa false değeri döndürür
            string[] stringDizisi = new string[] {"Müh","Turkcell","Bilgisayar"};

            foreach (string s in stringDizisi)
            {

                
                if (a.Contains(s))// a stringi s stringini içeriyorsa Contains metodu true değeri döndürür ve bu blok çalışır
                {
                    Console.WriteLine("'" + s + "' stringi, '" + a + "' stringi içinde bulunur.");
                }
                else // a stringi s stringini içeriyormiyorsa Contains metodu false değeri döndürür ve bu blok çalışır
                {
                    Console.WriteLine("'" + s + "' stringi, '" + a + "' stringi içinde bulunmamaktadır.");
                }

            }
            
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------- \nstring.StartsWith() metodu uygulandığında elde edilen sonuç: ");

            //string.StartsWith() yöntemi, parametre olarak aldığı stringin, çağrıldığı stringin başlangıcı ile eşleşip eşleşmediğini kontrol eder
            // eşleşiyorsa true, eşleşmiyorsa false değerini döndürür

            foreach (string s in stringDizisi)
            {

                
                if (a.StartsWith(s)) // a stringi s stringi ile başlıyorsa StartsWith metodu true değeri döndürür ve bu blok çalışır
                {
                    Console.WriteLine("'" + a + "' stringi, '" + s + "' stringi ile başlamaktadır.");
                }
                else // a stringi s stringi ile başlamıyorsa StartsWith metodu false değeri döndürür ve bu blok çalışır
                {
                    Console.WriteLine("'" + a + "' stringi, '" + s + "' stringi ile başlamaz.");
                }

            }

            Console.WriteLine("-------------------------------------------------------------------------- \nstring.Split() metodu uygulandığında elde edilen sonuç: ");

            //string.Split() yöntemi, uygulandığı stringi parçalamak için kullanılır. 
            // bu metot verilen stringi parçalara bölerken bölünme kriteri olarak parametre olarak gönderilen karakter ya da karakterleri baz alır
            // eğer bu metoda parametre olarak herhangi bir değer gönderilmezse boşluk karakterine göre bölme işlemi yapar
            //yapılan işlemler sonucu elde edilen string parçalarını bir diziye aktarır
            string[] kelimeler = a.Split();
            foreach (string ad in kelimeler)
                Console.WriteLine(ad);

            Console.WriteLine("-------------------------------------------------------------------------- \nchar.CompareTo() METODU ");

            // char.CompareTo() metodu, parametre olarak aldığı char değerinin çağrıldığı char değerinden sıralama düzeninde 
            // önce mi sonra mı ya da eşit pozisyonda mı srularını yanıtlar. 
            //Bu metot çağrıldığında negatif, pozitif ya da 0 değerini döndürür. 
            // döndürdüğü değerlere göre elde edilen sonuçlar aşağıdaki gibidir.
            
            char[] degerler = {'a','d','m' };
            char d = 'd';
            foreach (char deger in degerler)
            {
                if (d.CompareTo(deger) < 0)
                {
                    Console.WriteLine("'" + d + "' değeri '" + deger + "' değerinden öncedir.");
                }
                else if (d.CompareTo(deger) == 0)
                {
                    Console.WriteLine("'" + deger + "' değeri '" + d + "' değeri ile aynı pozisyondadır.");
                }
                else
                {
                    Console.WriteLine("'" + d + "' değeri '" + deger + "' değerini takip eder.");
                   
                }
            }


            Console.ReadKey();
        }
    }
}
