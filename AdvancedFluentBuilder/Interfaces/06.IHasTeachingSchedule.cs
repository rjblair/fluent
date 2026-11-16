using AdvancedFluentBuilder.Dtos;

namespace AdvancedFluentBuilder.Interfaces;

public interface IHasTeachingSchedule
{
    ICanBeBuilt WithSchedule(params Schedule[] schedules);
}
