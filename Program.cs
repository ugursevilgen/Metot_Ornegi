namespace Metot_Ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir başlangıç değeri girin:");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir bitiş değeri girin:");
            int bitis = Convert.ToInt32(Console.ReadLine());

            
            int[] dizi = SayiUret(baslangic, bitis);

            DiziYazdır(dizi);

            int enBuyuk = EnBuyukDeger(dizi);
            int enKucuk = EnKucukDeger(dizi);

            Console.WriteLine($"En büyük değer: {enBuyuk}");
            Console.WriteLine($"En küçük değer: {enKucuk}");
        }

        static int[] SayiUret(int baslangic, int bitis)
        {
            Random r = new Random();
            int[] dizi = new int[10];

            if (baslangic>bitis)
            {
                int a = baslangic;
                baslangic = bitis;
                bitis = a; ;
            }
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = r.Next(baslangic, bitis + 1);
            }
            return dizi;
        }

        static void DiziYazdır(int[] dizi)
        {
            Console.WriteLine("Dizi Elemanları:");
            foreach (var eleman in dizi)
            {
                Console.Write(eleman + "\n");
            }
           
        }

        static int EnBuyukDeger(int[] dizi)
        {
            int enBuyuk = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
            }
            return enBuyuk;
        }

        static int EnKucukDeger(int[] dizi)
        {
            int enKucuk = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < enKucuk)
                {
                    enKucuk = dizi[i];
                }
            }
            return enKucuk;
        }
    }
}