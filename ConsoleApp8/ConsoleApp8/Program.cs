using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public interface ICalisanad
    {
        string Ad { get; set; }
    }
    public interface ICalisansoyad
    {
        string Soyad { get; set; }
    }
    abstract class Personel
    {
        public abstract void PrstipiYaz();
    }
    class Mudur : Personel, ICalisanad, ICalisansoyad
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public override void PrstipiYaz()
        {
            Console.WriteLine("Personel Tipi: Müdür");
        }
        public void mesaiYap()
        {
            Console.WriteLine(" Mesai Yapmayacak");
        }
    }
    class Sef : Personel, ICalisanad, ICalisansoyad
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public override void PrstipiYaz()
        {
            Console.WriteLine("Personel Tipi: Şef");
        }
        public void mesaiYap()
        {
            Console.WriteLine(" Mesai Yapmayacak");
        }
    }

    class Memur : Personel, ICalisanad, ICalisansoyad
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public override void PrstipiYaz()
        {
            Console.WriteLine("Personel Tipi: Memur");
        }
        public void mesaiYap()
        {
            Console.WriteLine(" Mesai Yapmayacak");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mudur burak=new Mudur();
            Console.WriteLine("İsim: {0} ",burak.Ad = "Burak");
            Console.WriteLine("Soyisim: {0}",burak.Soyad = "Kürkçü");
            burak.PrstipiYaz();
            burak.mesaiYap();
            Console.ReadKey();
            
        }
    }
}
