using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    //new'lemeye gerek kalmadan direk Messages. diye erişmek için static yaptık. belli değişmeyen constant veriler için yapmak uygun olur
    public static class Messages
    {
        public const string UserRegistered = "Kayıt olundu";
        public const string UserNotFound = "Kullanıcı bulunamadı";
        public const string PasswordError = "Parola hatası";
        public const string SuccessfulLogin = "Giriş başarılı";
        public const string UserAlreadyExists = "Bu kullanıcızaten mevcut";
        public const string AccessTokenCreated = "Token oluşturuldu";
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProdcutCountOfCategoryError = "İlgili kategorideki ürün sınırını aştınız";
        public static string ProductNameExistsError = "Aynı isimde ürün mevcut";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
