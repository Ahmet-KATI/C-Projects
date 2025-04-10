using System;

class Sayi
{
    private int deger;

  
    public Sayi()
    {
        deger = 0;
    }

    
    public Sayi(int deger)
    {
        this.deger = deger;
    }

    // Function Overloading
    public void Topla(int sayi)
    {
        deger += sayi;
    }

    public void Topla(double sayi)
    {
        deger += (int)sayi;
    }

    // Operatör Overloading (+)
    public static Sayi operator +(Sayi s1, Sayi s2)
    {
        return new Sayi(s1.deger + s2.deger);
    }

   
}

class Program
{
    static void Main(string[] args)
    {
        // Constructor Overloading
        Sayi sayi1 = new Sayi();
        sayi1.Yazdir(); // Deger: 0

        Sayi sayi2 = new Sayi(5);
        sayi2.Yazdir(); // Deger: 5

        // Function Overloading kullanımı
        sayi1.Topla(3);
        sayi1.Yazdir(); // Deger: 3

        sayi2.Topla(2.5);
        sayi2.Yazdir(); // Deger: 7

        // Operatör Overloading kullanımı
        Sayi sayi3 = sayi1 + sayi2;
        sayi3.Yazdir(); // Deger: 10
    }
}



//////////////////////////////////////////////////////////////////////////////////////
using System;

class Sayi
{
    private int deger;

    // Parametre almayan yapıcı fonksiyon
    public Sayi()
    {
        deger = 0;
    }

    // Tam sayı değeri alan yapıcı fonksiyon
    public Sayi(int deger)
    {
        this.deger = deger;
    }

    // Function Overloading
    public void Topla(int sayi)
    {
        deger += sayi;
    }

    public void Topla(double sayi)
    {
        deger += (int)sayi;
    }

    // Operatör Overloading (+)
    public static Sayi operator +(Sayi s1, Sayi s2)
    {
        return new Sayi(s1.deger + s2.deger);
    }

    // Yazdır metodu
    public void Yazdir()
    {
        Console.WriteLine("Deger: " + deger);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Constructor Overloading
        Sayi sayi1 = new Sayi();
        sayi1.Yazdir(); // Deger: 0

        Sayi sayi2 = new Sayi(5);
        sayi2.Yazdir(); // Deger: 5

        // Function Overloading kullanımı
        sayi1.Topla(3);
        sayi1.Yazdir(); // Deger: 3

        sayi2.Topla(2.5);
        sayi2.Yazdir(); // Deger: 7

        // Operatör Overloading kullanımı
        Sayi sayi3 = sayi1 + sayi2;
        sayi3.Yazdir(); // Deger: 10
    }
}
//
using System;
class Program
{
    static void Main(string[] args)
    {
        // Constructor Overloading
        Sayi sayi1 = new Sayi();
        sayi1.Yazdir(); // Değer: 0

        Sayi sayi2 = new Sayi(5);
        sayi2.Yazdir(); // Değer: 5

        // Function Overloading kullanımı
        sayi1.Topla(3);
        sayi1.Yazdir(); // Değer: 3

        sayi2.Topla(2.5);
        sayi2.Yazdir(); // Değer: 7

        // Operatör Overloading kullanımı
        Sayi sayi3 = sayi1 + sayi2;
        sayi3.Yazdir(); // Değer: 10
    }
}
class Sayi
{
    private int a;
    private double b;

    // Propertyler
    public int A
    {
        get { return a; }
        set { a = value; }
    }
    public double B
    {
        get { return b; }
        set { b = value; }
    }



    
    // Yazdir fonksiyonu
    public void Yazdir()
    {
        Console.WriteLine("Değer: " + (this.a + this.b));
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program başladı.");

        // Child sınıfı örneği oluşturma
        Child child = new Child();

        // Child ve Base sınıfından bazı işlemler
        child.PublicMethod();
        child.CallProtectedMethod();

        Console.WriteLine("Program bitti.");
    }
}

using System;
class Program
class Base      //base sınıf
{
    public int a;
    private int b;
    protected int c;

    // base Constructor
    public Base()
    {
        Console.WriteLine("Base sınıfı construct edildi.");
    }
// Child sınıf
class Child : Base
{
    // Constructor
    public Child()
    {
        Console.WriteLine("Child  sınıfı construct edildi.");
    }
    // Child Destructor
    ~Child()
    {
        Console.WriteLine("Child sınıfı destruct edildi. ");
    }
     // Base Destructor
      ~Base()
      {
         Console.WriteLine("Base sınıfı destruct edildi.");
      }