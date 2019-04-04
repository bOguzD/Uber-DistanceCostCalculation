using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uber_Fiyat_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int ride_time;
            int ride_distance;
            float[] cost_per_minutes = new float[4];
            cost_per_minutes[0] = 0.2f;
            cost_per_minutes[1] = 0.35f;
            cost_per_minutes[2] = 0.4f;
            cost_per_minutes[3] = 0.45f;
            float[] cost_per_mile = { 1.1f, 1.8f, 2.3f, 3.5f };
            float sonuc;
            float[] tahmini_sonuclar = new float[4];
            bool x = false;
            do
            {
                Console.WriteLine("Süre giriniz:");
                ride_time = Convert.ToInt32(Console.ReadLine());
                if (ride_time >= 10 && ride_time <= 50)
                {
                    do
                    {
                        Console.WriteLine("Mesafe giriniz:");
                        ride_distance = Convert.ToInt32(Console.ReadLine());

                        if (ride_distance >= 5 && ride_distance <= 20)
                        {

                            for (int i = 0; i < cost_per_mile.Length; i++)
                            {
                                sonuc = Hesapla(ride_time, ride_distance, cost_per_minutes[i], cost_per_mile[i]);
                                tahmini_sonuclar[i] = sonuc;

                            }
                            x = true;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış mesafe aralığı tekrar değer giriniz");
                            x = false;
                        }
                    } while (x == false);
                    
                }
                else
                {
                    Console.WriteLine("Yanlış zaman aralığı tekrar değer giriniz");
                    x = false;
                }
            } while (x == false);
            
            Console.Write("[  ");
            for (int i = 0; i < tahmini_sonuclar.Length; i++)
            {
                
                Console.Write(tahmini_sonuclar[i]);
                Console.Write("  ");
            }
            Console.Write("]");
            Console.ReadKey();

        }

        public static float Hesapla(int rt, int rd, float cpmin, float cpmil)
        {
            return (cpmin * rt) + (cpmil * rd);
        }
    }
}
