using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BasicHesapMakinesi


            #region BasicHesapMakinesiWithIf

            Console.WriteLine("***Hesap Makinesi***");
            Console.Write("1.Sayıyı giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlem Türünü giriniz:");
            string islemTuru = Console.ReadLine();
            double sonuc = 0;

            if (islemTuru == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islemTuru == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islemTuru == "*")
                sonuc = sayi1 * sayi2;

            else if (islemTuru == "/")
            {
                sonuc = sayi1 / sayi2;
            }
            Console.WriteLine("Islem sonucu: " + sayi1 + islemTuru + sayi2 + "=" + sonuc);

            #endregion


            #region BasicHesapMakinesiWithSwitch

            Console.WriteLine("***Hesap Makinesi2***");
            Console.Write("1.Sayıyı giriniz:");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz:");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlem Türünü giriniz:");
            string islemTuru2 = Console.ReadLine();
            double sonuc2 = 0;

            switch (islemTuru2)
            {
                case "+":
                    sonuc2 = s1 + s2;
                    Console.WriteLine("Islem sonucu: " + s1 + islemTuru2 + s2 + "=" + sonuc2);
                    break;
                case "-":
                    sonuc2 = s1 - s2;
                    Console.WriteLine("Islem sonucu: " + s1 + islemTuru2 + s2 + "=" + sonuc2);
                    break;
                case "*":
                    sonuc2 = s1 * s2;
                    Console.WriteLine("Islem sonucu: " + s1 + islemTuru2 + s2 + "=" + sonuc2);
                    break;
                case "/":
                    sonuc2 = s1 / s2;
                    Console.WriteLine("Islem sonucu: " + s1 + islemTuru2 + s2 + "=" + sonuc2);
                    break;
            }



            #endregion
            #endregion

            #region HesapMakinesiWithMethodsWithSwitch
            Console.WriteLine("***HESAP MAKİNESİ***");
            Console.Write("1.Sayi: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Sayi: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlemTürü: ");
            string turu = Console.ReadLine();
            double result = Islem(number1, number2, turu);
            Console.WriteLine(number1 + " " + turu + " " + number2 + " = " + result);

            #endregion

            #region HesapMakinesiWithMethodsWithIf
            Console.WriteLine("***Hesap Makinesi***");
            Console.Write("Number1: ");
            double number11 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number2: ");
            double number22 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İslemCinsi: ");
            string İslemCinsi = Console.ReadLine();
            //double sonucref = 0;
            Islem2(number11, number22, İslemCinsi);//ref sonucref);
            //Console.WriteLine(number11 +""+ number22+ ""+ İslemCinsi + "=" + sonucref);

            #endregion


            Console.ReadLine();

        }

        static double Islem(double number1, double number2, string turislem)
        {
            double result = 0;
            switch (turislem)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            return result;
        }

        static void Islem2(double number1, double number2, string islemturu)//ref double result)
        {
            double result = 0;

            if (islemturu == "+")
            {
                result = number1 + number2;
            }
            else if (islemturu == "-")
            {
                result = number1 - number2;
            }
            else if (islemturu == "*")
                result = number1 * number2;

            else if (islemturu == "/")
            {
                result = number1 / number2;
            }
            Console.WriteLine(number1 + " " + islemturu + " " + number2 + " =" + result);
        }

    }
}
