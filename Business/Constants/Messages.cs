using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductCountofCategoryError="Ürün sayısı maksimum!";
        public static string ProductNameAlreadyExist = "Bu isimli bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti";
    }
}
