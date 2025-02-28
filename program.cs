using System;


abstract class Member
{
    public string Name{get;set;}
    public int ID{get;set;}
    public int Age{get;set;}
    
    
    
    public Member(int memberID, int memberAge, string memberName)
    {
        ID = memberID;
        Age = memberAge;
        Name = memberName;
        
    }
    public abstract double calculateMonthlyfees();
    public abstract void DisplayDetails();
    
}

class RegularMember : Member
{
    public double WorkoutPlanfee{get;set;}
    private const double basefees = 50.0;

    public RegularMember(int memberID, int memberAge, string memberName ,double wpf) : base( memberID, memberAge, memberName)
    {
        WorkoutPlanfee = wpf;
    }

    public override double calculateMonthlyfees()
    {
        return basefees + WorkoutPlanfee;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Regular member: {Name} , Age: {Age} , Workout plan fee: {calculateMonthlyfees()}");
    }
    
}

class PremiumMember : Member
{
    public double PersonalTrainingfees { get; set; }
    public double Dietplanfee { get; set; }
    private const double basefees = 100.0;


    public PremiumMember(int memberID, string name, int age, double personalTrainerFee, double dietPlanFee) : base(
        memberID, age, name)
    {
        PersonalTrainingfees = personalTrainerFee;
        Dietplanfee = dietPlanFee;
    }
    public override double calculateMonthlyfees()
    {
        return basefees + PersonalTrainingfees + Dietplanfee;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Premium member: {Name} , Age : {Age} , Personal trainer fees: {PersonalTrainingfees} , Dietplan fee: {Dietplanfee}");
    }
    
}

interface IGymManagement
{
    void AddMember(Member member);
    void Displayallmembers();
}

class Gym : IGymManagement
{
    private List<Member> members = new List<Member>();

    public void AddMember(Member member)
    {
        members.Add(member);
    }

    public void Displayallmembers()
    {
        for (int i = 0; i < members.Count; i++)
        {
            members[i].DisplayDetails();
        }
    }
}

class program
{
    static void Main()
    {
        Gym gym = new Gym();
        //regular members
        gym.AddMember(new RegularMember(1, 25, "Rama", 25.0));
        gym.AddMember(new RegularMember(2, 21, "Rana", 10.0));

        //premium members
        gym.AddMember(new PremiumMember(3, "Ali", 30, 45.0, 32.0));
        gym.AddMember(new PremiumMember(4, "wesal", 31, 25.0, 70.0));

        gym.Displayallmembers();
    }
}
