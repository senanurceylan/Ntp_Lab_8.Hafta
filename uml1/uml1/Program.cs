using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml1
{


    public class Person
    {
        // name: string -> İsim
        public string Name { get; set; }
        // phoneNumber: string -> Telefon numarası
        public string PhoneNumber { get; set; }
        // emailAddress: string -> E-posta adresi
        public string EmailAddress { get; set; }

        // purchaseParkingPass() -> Otopark geçişi satın alma işlemi
        public void PurchaseParkingPass()
        {
            Console.WriteLine($"{Name} has purchased a parking pass.");
        }
    }
    // Class for Address (Adres sınıfı)
    public class Address
    {
        // street: string -> Sokak
        public string Street { get; set; }
        // city: string -> Şehir
        public string City { get; set; }
        // state: string -> Eyalet
        public string State { get; set; }
        // postalCode: int -> Posta kodu
        public int PostalCode { get; set; }
        // country: string -> Ülke
        public string Country { get; set; }

        // validate() -> Adres doğrulama
        public bool Validate()
        {
            return !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City) &&
                   !string.IsNullOrEmpty(State) && PostalCode > 0 && !string.IsNullOrEmpty(Country);
        }

        // outputAsLabel() -> Etiket olarak adres çıktısı
        public string OutputAsLabel()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }

    // Subclass for Student (Öğrenci alt sınıfı)
    public class Student : Person
    {
        // studentNumber: int -> Öğrenci numarası
        public int StudentNumber { get; set; }
        // averageMark: int -> Ortalama not
        public int AverageMark { get; set; }

        // isEligibleToEnroll(string) -> Derse kaydolabilir mi?
        public bool IsEligibleToEnroll(string course)
        {
            return AverageMark >= 50; // Örnek mantık: Ortalama 50'nin üstündeyse kaydolabilir
        }

        // getSeminarsTaken() -> Alınan seminer sayısı
        public int GetSeminarsTaken()
        {
            return 5; // Örnek bir değer döndürülüyor
        }
    }

    // Subclass for Professor (Profesör alt sınıfı)
    public class Professor : Person
    {
        // salary: int -> Maaş
        public int Salary { get; set; }
        // staffNumber: int -> Personel numarası
        public int StaffNumber { get; set; }
        // yearsOfService: int -> Hizmet yılı
        public int YearsOfService { get; set; }
        // numberOfClasses: int -> Ders sayısı
        public int NumberOfClasses { get; set; }

        // supervises(Student) -> Öğrenciyi denetleme
        public void Supervises(Student student)
        {
            Console.WriteLine($"{Name} supervises {student.Name}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Address nesnesi oluşturma
            Address address = new Address
            {
                Street = "123 Main St",
                City = "Ankara",
                State = "TR",
                PostalCode = 10101,
                Country = "Turkey"
            };

            if (address.Validate())
            {
                Console.WriteLine("Valid Address: " + address.OutputAsLabel());
            }

            // Student nesnesi oluşturma
            Student student = new Student
            {
                Name = "Ali",
                PhoneNumber = "555-1234",
                EmailAddress = "ali@example.com",
                StudentNumber = 12345,
                AverageMark = 80
            };

            Console.WriteLine($"{student.Name} eligible to enroll: {student.IsEligibleToEnroll("Math")}");

            // Professor nesnesi oluşturma
            Professor professor = new Professor
            {
                Name = "Dr. Ahmet",
                PhoneNumber = "555-5678",
                EmailAddress = "ahmet@example.com",
                Salary = 50000,
                StaffNumber = 98765,
                YearsOfService = 10,
                NumberOfClasses = 3
            };

            professor.Supervises(student);
            professor.PurchaseParkingPass();
        }
    }
}

