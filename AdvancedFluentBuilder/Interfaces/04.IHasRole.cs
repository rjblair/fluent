namespace AdvancedFluentBuilder.Interfaces;

public interface IHasRole
{
    IAmTeaching AsTeacher { get; }
    IAmStudying AsStudent { get; }
}
