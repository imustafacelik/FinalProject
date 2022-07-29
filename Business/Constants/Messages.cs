using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bu kategoride maximum ürün sayısına ulaşıldı";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün mevcuttur";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}
