using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri mus_ekle)
        {
            Console.WriteLine("Müsteri başarıyla kaydedildi : " + mus_ekle.Adi + " " + mus_ekle.Soyadi);
        }

        public void Listele(Musteri mus_listele)
        {
            Console.WriteLine("Müşteri bilgileri : " + mus_listele.Adi + " " + mus_listele.Soyadi + " " + mus_listele.Yas + " " + mus_listele.Sehir + " " + mus_listele.Telefon);
        }

        public void Sil(Musteri mus_sil)
        {
            Console.WriteLine("Müşteri başarıyla silindi : " + mus_sil.Adi + " " + mus_sil.Soyadi + " " + mus_sil.Yas + " " + mus_sil.Sehir);
        }

        
        
        
    }
}
