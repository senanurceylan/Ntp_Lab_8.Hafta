using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml5
{
    public class Transaction
    {
        // id: int -> İşlem kimliği
        public int Id { get; set; }
        // name: string -> İşlem adı
        public string Name { get; set; }
        // date: string -> İşlem tarihi
        public string Date { get; set; }
        // address: string -> İşlem adresi
        public string Address { get; set; }

        // update() -> İşlemi güncellemek için kullanılan metod
        public void Update()
        {
            Console.WriteLine("Transaction has been updated.");
        }
    }

    // Customer sınıfı -> Müşterileri temsil eder
    public class Customer
    {
        // id: int -> Müşteri kimliği
        public int Id { get; set; }
        // name: string -> Müşteri adı
        public string Name { get; set; }
        // contact: string -> İletişim bilgisi
        public string Contact { get; set; }
        // address: string -> Müşteri adresi
        public string Address { get; set; }
        // payment: int -> Ödeme miktarı
        public int Payment { get; set; }

        // update() -> Müşteri bilgilerini güncellemek için metod
        public void Update()
        {
            Console.WriteLine($"{Name}'s information has been updated.");
        }
    }

    // Car sınıfı -> Kiralanan arabaları temsil eder
    public class Car
    {
        // id: int -> Araba kimliği
        public int Id { get; set; }
        // details: string -> Araba detayları
        public string Details { get; set; }
        // ordertype: string -> Sipariş türü
        public string OrderType { get; set; }

        // processDebit() -> Ödeme işleme metodunu simgeler
        public void ProcessDebit()
        {
            Console.WriteLine("Debit has been processed for the car.");
        }
    }

    // Payment sınıfı -> Ödeme bilgilerini temsil eder
    public class Payment
    {
        // id: int -> Ödeme kimliği
        public int Id { get; set; }
        // cardnumber: int -> Kart numarası
        public int CardNumber { get; set; }
        // amount: string -> Ödeme miktarı
        public string Amount { get; set; }

        // add() -> Yeni ödeme eklemek için metod
        public void Add()
        {
            Console.WriteLine("Payment has been added.");
        }

        // update() -> Ödemeyi güncellemek için metod
        public void Update()
        {
            Console.WriteLine("Payment has been updated.");
        }
    }

    // Rentals sınıfı -> Kiralama bilgilerini temsil eder
    public class Rentals
    {
        // id: int -> Kiralama kimliği
        public int Id { get; set; }
        // names: string -> Kiralama adı veya açıklaması
        public string Names { get; set; }
        // price: string -> Fiyat bilgisi
        public string Price { get; set; }

        // add() -> Yeni kiralama eklemek için metod
        public void Add()
        {
            Console.WriteLine("Rental has been added.");
        }

        // update() -> Kiralamayı güncellemek için metod
        public void Update()
        {
            Console.WriteLine("Rental has been updated.");
        }
    }

    // RentingOwner sınıfı -> Araç sahibini temsil eder
    public class RentingOwner
    {
        // id: int -> Araç sahibi kimliği
        public int Id { get; set; }
        // name: string -> Araç sahibinin adı
        public string Name { get; set; }
        // age: int -> Yaş
        public int Age { get; set; }
        // contactnum: string -> İletişim numarası
        public string ContactNum { get; set; }
        // username: string -> Kullanıcı adı
        public string Username { get; set; }
        // password: string -> Şifre
        public string Password { get; set; }

        // verifyAccount() -> Hesap doğrulama işlemi
        public void VerifyAccount()
        {
            Console.WriteLine("Account has been verified.");
        }
    }

    // Reservation sınıfı -> Rezervasyonları temsil eder
    public class Reservation
    {
        // id: int -> Rezervasyon kimliği
        public int Id { get; set; }
        // details: string -> Rezervasyon detayları
        public string Details { get; set; }
        // list: string -> Rezervasyon listesi
        public string List { get; set; }

        // confirmation() -> Rezervasyon onayı işlemi
        public void Confirmation()
        {
            Console.WriteLine("Reservation has been confirmed.");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek bir müşteri oluştur
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Ali",
                Contact = "555-1234",
                Address = "Ankara",
                Payment = 500
            };

            // Örnek bir araba oluştur
            Car car = new Car
            {
                Id = 1,
                Details = "Toyota Corolla",
                OrderType = "Daily"
            };

            // Örnek bir rezervasyon oluştur
            Reservation reservation = new Reservation
            {
                Id = 1,
                Details = "Reservation for a car",
                List = "Toyota Corolla, Ford Focus"
            };

            // Müşteri bilgilerini yazdır
            Console.WriteLine($"Customer Name: {customer.Name}, Contact: {customer.Contact}, Address: {customer.Address}");

            // Rezervasyonu onayla
            reservation.Confirmation();

            // Araba bilgilerini yazdır
            Console.WriteLine($"Car Details: {car.Details}, Order Type: {car.OrderType}");

            // Ödeme işlemi ekle
            Payment payment = new Payment
            {
                Id = 1,
                CardNumber = 123456789,
                Amount = "500 TL"
            };
            payment.Add();

            // Araç sahibini doğrula
            RentingOwner owner = new RentingOwner
            {
                Id = 1,
                Name = "Ahmet",
                Age = 35,
                ContactNum = "555-9876",
                Username = "ahmet_owner",
                Password = "securepassword"
            };
            owner.VerifyAccount();
        }
    }
}