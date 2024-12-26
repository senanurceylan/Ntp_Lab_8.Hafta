using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml2
{
    public interface Identifiable
    {
        Guid Id { get; } // Her nesne için benzersiz bir UUID (Universal Unique Identifier) gereklidir.
    }

    // Experienced protokolü (interface) -> Sahipler için özel bir yetenek belirtmek için kullanılır.
    public interface Experienced
    {
        void TrainPet(); // Sahiplerin evcil hayvanları eğitme kabiliyetini temsil eder.
    }

    // Pet sınıfı -> Tüm evcil hayvanların temel sınıfı. Identifiable arayüzünü uygular.
    public class Pet : Identifiable
    {
        // Benzersiz bir kimlik (UUID) -> Her evcil hayvan için otomatik oluşturulur.
        public Guid Id { get; } = Guid.NewGuid();
        // Evcil hayvanın adı
        public string Name { get; set; }
        // Yaşı
        public int Age { get; set; }
        // Evcil hayvanın sahibi (Owner türünde)
        public Owner Owner { get; set; }
        // Evcil hayvanın türü (Animal türünde)
        public Animal Type { get; set; }
        // Evcil hayvanın detaylı bilgileri
        public PetInformation PetInfo { get; set; }

        // feed() -> Evcil hayvanın beslenip beslenemeyeceğini kontrol eder.
        public bool Feed(bool isHerbivore)
        {
            // Eğer hayvan otçul ise otla beslenir, değilse beslenemez.
            return isHerbivore;
        }
    }

    // Owner sınıfı -> Evcil hayvan sahiplerini temsil eder. Experienced arayüzünü uygular.
    public class Owner : Experienced
    {
        // Sahip adı
        public string Name { get; set; }

        // TrainPet() -> Evcil hayvanı eğitme yeteneği (Experienced'den gelir)
        public void TrainPet()
        {
            Console.WriteLine($"{Name} is training their pet.");
        }
    }

    // Animal sınıfı -> Evcil hayvanın türünü temsil eder.
    public class Animal
    {
        // Hayvan türü (örneğin: Köpek, Kedi)
        public string Type { get; set; }
        // Hayvan ırkı (örneğin: Golden Retriever)
        public string Breed { get; set; }
        // Hayvan etçil mi? (true = etçil, false = otçul)
        public bool Carnivore { get; set; }
    }

    // PetInformation sınıfı -> Evcil hayvanın detaylı bilgilerini tutar.
    public class PetInformation
    {
        // Evcil hayvanın özellikleri (örneğin: sadık, hızlı)
        public List<string> Traits { get; set; } = new List<string>();
        // Evcil hayvanın aşı bilgileri
        public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
    }

    // Vaccine sınıfı -> Aşı bilgilerini temsil eder.
    public class Vaccine
    {
        // Aşının adı (örneğin: Kuduz aşısı)
        public string Name { get; set; }
        // Aşının türü (örneğin: Viral, Bakteriyel)
        public string Type { get; set; }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek bir sahibi oluştur
            Owner owner = new Owner
            {
                Name = "Ahmet"
            };

            // Evcil hayvan türü oluştur
            Animal animal = new Animal
            {
                Type = "Dog",
                Breed = "Golden Retriever",
                Carnivore = true
            };

            // Aşı bilgisi ekle
            Vaccine rabiesVaccine = new Vaccine
            {
                Name = "Rabies",
                Type = "Viral"
            };

            // Evcil hayvan bilgisi oluştur
            PetInformation petInfo = new PetInformation();
            petInfo.Traits.Add("Loyal");
            petInfo.Vaccines.Add(rabiesVaccine);

            // Evcil hayvan oluştur
            Pet pet = new Pet
            {
                Name = "Buddy",
                Age = 3,
                Owner = owner,
                Type = animal,
                PetInfo = petInfo
            };

            // Evcil hayvan bilgilerini yazdır
            Console.WriteLine($"Pet Name: {pet.Name}");
            Console.WriteLine($"Owner: {pet.Owner.Name}");
            Console.WriteLine($"Animal Type: {pet.Type.Type}, Breed: {pet.Type.Breed}");
            Console.WriteLine($"Vaccines: {pet.PetInfo.Vaccines[0].Name}");
            Console.WriteLine($"Is Carnivore: {pet.Type.Carnivore}");

            // Evcil hayvanı besle
            bool canFeed = pet.Feed(!pet.Type.Carnivore); // Otçul değilse otla beslenemez
            Console.WriteLine($"Can Feed: {canFeed}");
        }
    }
}
