using System;
using lab_git;
class Program
{
    static void Main(string[] args)
    {
        Person p = new Person("nafnas", "лес");
        p.LeaveHome();
        p.GotHere();
        p.LightLamp();
        p.Condition();
    }
}