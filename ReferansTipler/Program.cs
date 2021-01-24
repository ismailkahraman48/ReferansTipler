using System;

namespace ReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("sayi1: "+ sayi1);
            //Console.WriteLine("sayi2: " + sayi2); //int float decimal gibi tipler değer tip olduğu için referans oluşturmaz

            //int[] sayilar = new int[] { 1, 2, 3 };  
            //int[] sayilar2 = new int[] { 5, 6, 7 };

            //sayilar = sayilar2;
            //sayilar2[0] = 10;  // Arrayler referans tiplerdir ve değişiklikleri kaydeder.

            //Console.WriteLine(sayilar[0]); // 10 değerini alırız

            Person person1 = new Person();
            Person person2 = new Person();
            
            person1.FirstName = "ismail";
            person2.FirstName = "Gül";
            person2 = person1;
            person1.FirstName = "Mehmet";  //mehmet çıktısını alırız çünkü bu sınıflar da referans tutar ve dinamiktir.

            //Console.WriteLine(person2.FirstName);

            // Person sınıfı tanımlıyorum ama bir customerın kredi kartı nuamrasına erişemiyorum nasıl erişirim??  

            
        

            Customer customer1 = new Customer();        // Her bir sınıfı main de newleyip değer atıyoruz.
            customer1.FirstName = "Ali";
            customer1.CreditCartNumber = "182598129124";
            //Console.WriteLine(customer1.FirstName);
          
            Employee employee = new Employee();
            employee.FirstName = "Şinasi";
            //Console.WriteLine(employee.FirstName);

            Person person3 = customer1;    
            customer1.FirstName = "Sıdıka";
            //Console.WriteLine(((Customer)person3).CreditCartNumber); // Customer sınıfı person sınıfından kalıtım aldığı için
            // personu customer olarak tanımlayabilirim ve person üzerinden customer sınıfı özniteliği olan kredi kartı
            // numarasına erişebilirim. (Boxing)

            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);
            personManager.Add(employee);   // 3 farklı sınıf içinde base class sayesinde fonksiyonu kullanabilyorum.
            personManager.Add(person1);


        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string Lastname { get; set; }
        }

        class Customer : Person   //customer person özniteliklerinide içerir inheretance yani kalıtım var
        {
            public string CreditCartNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person) //fonskiyon içine person parametresi beklediğinde customerı ve employee de yönetebilirim.
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
