using System;

public class Class1
{
	public int name;
    public int surname;
    public enum gender
    {
        male,
        female,
        trans,
        lezbi,
        bi,
        geterosexual,
        Karen,
        Tiko,
        other
    }
    private int YearlySalary{ get; set; }
    private int YearStarted { get; set; }
    private int Manager;

    public string GetFullName()
    {
        Console.WriteLine(gender + "  " + name + "  " + surname);
        Console.WriteLine();
    }
    public GetAmountPaid(int CurrentYear)
    {
        int paid = (CurrentYear - YearStarted - 1) * YearStarted;  
        Console.WriteLine(paid);
    }
    public int GetMaxVacationAmount(int CurrentYear) 
    {
        int amount = (CurrentYear - YearStarted - 1) * 28;
        Console.WriteLine(amount);
    }
    public string GetManegerFullname { get; };
}
