class Phanso{
    int tuso, mauso; 
    public int Tuso{
        get{return tuso;}
        set{tuso = value;}
    }
    public int Mauso{
        get{return mauso;}
        set{mauso = value;}
    }
    public Phanso(){}
    public void nhap(){
        Console.Write("tuso: ");
        tuso = int.Parse(Console.ReadLine());
        do{
            Console.Write("mauso: ");
            mauso = int.Parse(Console.ReadLine());
            if(mauso != 0){
                break;
            }
            else{
                Console.WriteLine("mauso phai khac 0");
            }
        }while (true);
    }
    public static void Xuat(Phanso a, Phanso b){
        Phanso result = new Phanso();   
        Console.WriteLine($"Cong: {result.Cong(a, b).Tuso}/{result.Cong(a, b).Mauso}");
        Console.WriteLine($"Tru: {result.Tru(a, b).Tuso}/{result.Tru(a, b).Mauso}");
        Console.WriteLine($"Nhan: {result.Nhan(a, b).Tuso}/{result.Nhan(a, b).Mauso}");
        Console.WriteLine($"Chia: {result.Chia(a, b).Tuso}/{result.Chia(a, b).Mauso}");
    }
    public Phanso Cong(Phanso a, Phanso b){
        Phanso c = new Phanso();
        c.Tuso = a.Tuso*(BCNN(a.Mauso,b.Mauso)/a.Mauso)+b.Tuso*(BCNN(a.Mauso,b.Mauso)/b.Mauso);
        c.Mauso = BCNN(a.Mauso,b.Mauso);
        return c;
    }
    public Phanso Tru(Phanso a, Phanso b){
        Phanso c = new Phanso();
        c.Tuso =a.Tuso*(BCNN(a.Mauso,b.Mauso)/a.Mauso)-b.Tuso*(BCNN(a.Mauso,b.Mauso)/b.Mauso);
        c.Mauso = BCNN(a.Mauso,b.Mauso);
        return c;
    }
    public Phanso Nhan(Phanso a, Phanso b){
        Phanso c = new Phanso();
        c.Tuso = (a.Tuso*b.Tuso)/UCLN(a.Tuso*b.Tuso,a.Mauso*b.Mauso);
        c.Mauso = (a.Mauso*b.Mauso)/UCLN(a.Tuso*b.Tuso,a.Mauso*b.Mauso);
        return c;
    }
    public Phanso Chia(Phanso a, Phanso b){
        Phanso c = new Phanso();
        c.Tuso = (a.Tuso*b.Mauso)/UCLN(a.Tuso*b.Mauso,a.Mauso*b.Tuso);
        c.Mauso = (a.Mauso*b.Tuso)/UCLN(a.Tuso*b.Mauso,a.Mauso*b.Tuso);
        return c;
    }
    static int UCLN(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static int BCNN(int a, int b){
        return (a * b) / UCLN(a, b);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Phanso a = new Phanso();
        a.nhap();
        Phanso b= new Phanso();
        b.nhap();
        Phanso.Xuat(a, b);
        Console.Read();
    }
}