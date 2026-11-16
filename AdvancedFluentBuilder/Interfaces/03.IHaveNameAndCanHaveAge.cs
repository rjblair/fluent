namespace AdvancedFluentBuilder.Interfaces;

public interface IHaveNameAndCanHaveAge
{
    IHasRole WithAge(int age);
}
