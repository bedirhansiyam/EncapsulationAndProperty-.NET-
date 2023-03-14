namespace EncapsulationAndProperty;
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Bedirhan";
        student.Surname = "Siyam";
        student.No = 54;
        student.Grade = 11;
        student.GetStudentInfos();

        student.SkipGrade();
        student.GetStudentInfos();

        Student student2 = new Student("Cengizhan", "Siyam", 05, 1);
        student2.GetStudentInfos();

        student2.DownGrade();   // Grade cannot be less than 1. Grade = 1
        student2.GetStudentInfos();


    }
}

class Student
{
    private string name;         
    private string surname;
    private int no;
    private int grade;

    public string Name 
    { 
        get => name; 
        set => name = value; 
        }
    public string Surname { get => surname; set => surname = value; }
    public int No { get => no; set => no = value; }
    public int Grade 
    {
        get => grade; 
        set 
        {
            if(value <= 1)
            {
                Console.WriteLine("Grade cannot be less than 1.");
                grade = 1;
            }
            else
            grade = value;
        } 
        }

    public Student(string name, string surname, int no, int grade)
    {
        Name = name;
        Surname = surname;
        No = no;
        Grade = grade;
    }
    public Student()
    {    
    }

    public void GetStudentInfos()
    {
        Console.WriteLine("************Student Information************");
        Console.WriteLine("Student name : " + this.Name);
        Console.WriteLine("Student surname : " + this.Surname);
        Console.WriteLine("Student no : " + this.No);
        Console.WriteLine("Student grade : " + this.Grade);
    }

    public void SkipGrade()
    {
        this.Grade = this.Grade + 1;
    }
    public void DownGrade()
    {
        this.Grade = this.Grade - 1;
    }
}
