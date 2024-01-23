class BAIVIET
{
    string id, nd;
    DateTime ngaydang;
    public BAIVIET(string id, string nd, DateTime ngaydang)
    {
        this.id = id;
        this.nd = nd;
        this.ngaydang = ngaydang;
    }
    public static BAIVIET Update(BAIVIET BV1)
    {
        Console.WriteLine("Nhập vào nội dung mới ");
        Console.Write("Nội dung mới: ");
        BV1.nd=Console.ReadLine();
        return new BAIVIET(BV1.id,BV1.nd,BV1.ngaydang);
    }
    public void Xuat()
    {
        Console.WriteLine($"ID: {id}, nội dung: {nd}, ngày đăng: {ngaydang}");
    }
}
    class Program
{
    static void Main(string[] args)
    {
        BAIVIET BV1=new BAIVIET("1","2",DateTime.Now);
        BAIVIET.Update(BV1);
        BV1.Xuat();
    }
}