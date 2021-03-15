using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Yeni araba markası eklendi.";
        public static string BrandNameInvalid = "Hata: Marka ismi çok uzun!";
        public static string BrandDeleted = "Marka Silindi!";
        public static string BrandUpdated = "Marka Güncellendi!";
        public static string BrandsListed = "Markalar Listelendi.";

        public static string CarAdded = "Yeni araba eklendi.";
        public static string CarNameInvalid = "Hata: Marka ismi 2 harften kısa olamaz," +
            " ürün fiyatı ise 0' dan fazla olmalıdır.";
        public static string CarDeleted = "Araba silindi!";
        public static string CarUpdated = "Araba güncellendi!";
        public static string CarsListed = "Arabalar Listelendi.";

        public static string ColorAdded = "Yeni araba rengi eklendi.";
        public static string ColorDeleted = "Renk Silindi!";
        public static string ColorUpdated = "Renk Güncellendi!";
        public static string ColorsListed = "Renkler Listelendi.";

        public static string MaintenanceTime = "Sistem bakımda.";
    }
}
