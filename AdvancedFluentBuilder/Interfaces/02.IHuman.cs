namespace AdvancedFluentBuilder.Interfaces;

public interface IHuman
{
    IHaveAgeAndCanHaveName WithAge(int age);
    IHaveNameAndCanHaveAge WithName(string name);
}
