class nhanvien{
    protected string ten, ngaysinh, gioitinh; 
    protected float luong = 10; 
    public nhanvien(string ten, string ngaysinh, string gioitinh) {
        this.ten = ten; 
        this.ngaysinh = ngaysinh;
        this.gioitinh = gioitinh;
    }
    public virtual void nhanluong(){
        Console.WriteLine($"Nhận lương: {luong}");
    }
    public virtual void lamviec(){
        Console.WriteLine("Làm việc được giao");
    }
}
class quanly : nhanvien{
    int trocap = 2; 
    public quanly(string ten, string ngaysinh, string gioitinh) : base(ten, ngaysinh, gioitinh){
    }
    public override void nhanluong(){
        Console.WriteLine($"Nhận lương: {luong + trocap}");
    }
    public override void lamviec(){
        Console.WriteLine("Giao việc cho người khác");
    }
}
class Program{
    public static void Main(string[] args){
        nhanvien nv = new nhanvien("khoa", "06/06/2004", "Nam");
        nv.nhanluong();
        nv.lamviec();
        nhanvien ql = new quanly("ngoc", "18/12/2003", "Nu");
        ql.nhanluong();
        ql.lamviec();
    }
}