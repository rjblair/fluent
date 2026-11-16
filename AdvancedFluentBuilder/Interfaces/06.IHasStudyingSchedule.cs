using AdvancedFluentBuilder.Dtos;

namespace AdvancedFluentBuilder.Interfaces;

public interface IHasStudyingSchedule
{
    ICanBeBuilt WithSchedule(params SubjectSchedule[] subjectsSchedules);
}
