using AdvancedFluentBuilder.Dtos;

namespace AdvancedFluentBuilder.Interfaces;

public interface IAmTeaching
{
    IHasTeachingSchedule Teaching(Subject subject);
}