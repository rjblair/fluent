using AdvancedFluentBuilder.Dtos;

namespace AdvancedFluentBuilder.Interfaces;

public interface IAmStudying
{
    IHasStudyingSchedule Studying(params Subject[] subjects);
}
