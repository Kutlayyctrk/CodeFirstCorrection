using CodeFirstCorrection.Dal;
using CodeFirstCorrection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CodeFirstCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(); // context classından nesne oluşturuldu
            void listele()
            { 
            
            var values = c.Customers.ToList(); // customers tablosundaki verileri listeledik
            foreach (var item in values)  // listelediğimiz verileri döngü ile yazdırdık
            {
                Console.WriteLine(item.CustomerName);  // customername alanını yazdırdık
            }
           
            }


            //Customer customer = new Customer(); // customer classından nesne oluşturuldu
            //customer.CustomerName = "Ali Yücetürk"; // customername alanına ali yazıldı
            //customer.CustomerCity = "İstanbul"; // customercity alanına istanbul yazıldı
            //c.Customers.Add(customer); // customers tablosuna customer nesnesi eklendi
            //c.SaveChanges(); // değişiklikleri kaydettik
            //listele(); // listele fonksiyonunu çağırdık

            //var values2 = c.Customers.Where(x => x.CustomerID == 7).FirstOrDefault(); // customers tablosundan customerid si 7 olan veriyi seçtik
            //c.Customers.Remove(values2); // seçilen veriyi sildik
            //c.SaveChanges(); // değişiklikleri kaydettik
            //listele(); // listele fonksiyonunu çağırdık

            var values3=c.Customers.Where(x=>x.CustomerID==6).FirstOrDefault(); // customers tablosundan customerid si 6 olan veriyi seçtik
            values3.CustomerName = "Nergis Aşçı Yücetürk"; // seçilen verinin customername alanını değiştirdik
            c.SaveChanges(); // değişiklikleri kaydettik
            listele(); // listele fonksiyonunu çağırdık


            Console.ReadLine();



        }
    }
}
