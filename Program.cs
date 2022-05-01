using System;

namespace enumm
{
    class Program
    {
        static void Main(string[] args)
        {
           object[] dizi = new object[7];
           dizi[0]=Gunler.Pazartesi;
           dizi[1]=Gunler.Salı;
           dizi[2]=Gunler.Carsamba;
           dizi[3]=Gunler.Perşembe;
           dizi[4]=Gunler.Cuma;
           dizi[5]=Gunler.Cumartesi;
           dizi[6]=Gunler.Pazar;

           DateTime dateTime = new DateTime();
           object weekDay = (object)dateTime.DayOfWeek;
           System.Console.WriteLine("Lütfen bulunduğunuz günün sayısını giriniz:\n1-Pazartesi 2-Salı 3-Çarşamba 4-Perşembe 5-Cuma 6-Cumartesi 7-Pazar");
           Int32 y =Int32.Parse(Console.ReadLine());


           System.Console.WriteLine(".... gün sonra hangi gündür? Lütfen ....'lı kısma sayi giriniz:");

           Int32 x =Int32.Parse(Console.ReadLine());

           System.Console.WriteLine(x + " gün sonraki gün: " + dizi[Math.Abs(x%7)+(y-1)]);
           
           }


        
         enum Gunler
            {
                Pazartesi,Salı,Carsamba,Perşembe,Cuma,Cumartesi,Pazar

            };
    
    }
}
