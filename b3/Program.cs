class human{
    protected long id; 
    protected string name, sex, dob; 
    public human(long id, string name, string sex, string dob){
        this.id = id; 
        this.name = name; 
        this.sex = sex;
        this.dob = dob;
    }
    public virtual void xuat(){
        Console.WriteLine($"{id} {name} {sex} {dob} ");
    }
}
class employee : human {
    float salary; 
    int yoe;
    string level; 
    public employee(long id, string name, string sex, string dob) : base(id, name, sex, dob){
    }
    public float getsalry(){
        return salary;
    }
    public void setsalary(float salary){
        this.salary = salary;
    }
    public int getyoe(){
        return yoe;
    }
    public void setyoe(int yoe){
        this.yoe = yoe;
    }
    public string getlevel(){
        return level;
    }
    public void setlevel(string level){
        this.level = level;
    }
    public void updatesalary(float newsalary){
        salary = newsalary;
    }
    public void increaselevel(){
        if(level == "junior"){
            level = "senior";
        }
    }
    public override void xuat(){
        Console.WriteLine($"{id} {name} {sex} {dob} {salary} {yoe} {level}");
    }
}
class Program{ 
    public static void Main(string[] args){
        human hm = new human(456, "ngoc", "nu", "18/12/2003");
        hm.xuat();
        employee emp = new employee(456, "ngoc", "nu", "18/12/2003");
        emp.setsalary(10); 
        emp.setlevel("junior");
        emp.setyoe(1);
        emp.xuat(); 
        emp.updatesalary(30);
        emp.xuat(); 
        emp.increaselevel();
        emp.xuat();  
    }
}
