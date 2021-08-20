using Core.Entities.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi.";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarDPInvalid = "Araç günlük ücreti geçersiz.";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarsListed = "Araçlar listelendi";
        public static string MaintenanceTime = "Bakım arası";
        public static string CarRemoved = "Araç silindi";
        public static string CarAgeTooOld = "Araç çok eski.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandRemoved = "Marka silindi";
        public static string ColourAdded = "Renk eklendi.";
        public static string ColourUpdated = "Renk güncellendi";
        public static string ColoursListed = "Renkler listelendi";
        public static string ColourRemoved = "Renk silindi";
        public static string RentalAdded = "Kiralık araç eklendi.";
        public static string RentalUpdated = "Kiralık araç güncellendi";
        public static string RentalsListed = "Kiralık araçlar listelendi";
        public static string RentalRemoved = "Kiralık araç silindi";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcı listelendi";
        public static string UserRemoved = "Kullanıcı silindi";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteri listelendi";
        public static string CustomerRemoved = "Müşteri silindi";
        public static string UCanRent = "Kiralayabilirsiniz";
        public static string UCannotRent = "Kiralayamazsınız";
        public static string WrongValidationType = "Yanlış Doğrulama tipi";

        public static string CarImageAdded = "Araç resmi eklendi.";
        public static string CarImageUpdated = "Araç resmi güncellendi.";
        public static string CarImageRemoved = "Araç resmi silindi.";
        public static string CarImageNotFound = "Araç resmi bulunamadı.";
        public static string CarImagesListed = "Araç resimleri Listelendi";

        public static string CarImageLimitExceeded = "Araç resimleri limiti aşıldı.";

        public static string CarImageCannotRemoved = "Araç resmi silinemedi.";

        public static List<CarImage> Error { get; internal set; }
        public static string UserRegistered = "Kullanıcı kaydedildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre Hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Giriş jetonu oluşturuldu.";

        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
