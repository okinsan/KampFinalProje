using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt Oldu";
        public static string UserNotFound="Kullancı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı zaten var";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
