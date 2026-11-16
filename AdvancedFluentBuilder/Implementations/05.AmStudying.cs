using AdvancedFluentBuilder.Dtos.Descriptors;
using AdvancedFluentBuilder.Dtos;
using AdvancedFluentBuilder.Interfaces;

namespace AdvancedFluentBuilder.Implementations;

internal class AmStudying : IAmStudying
{
    private readonly StudentDescriptor m_Descriptor;

    public AmStudying(StudentDescriptor descriptor)
    {
        m_Descriptor = descriptor;
    }

    public IHasStudyingSchedule Studying(params Subject[] subjects)
    {
        var clone = new StudentDescriptor(m_Descriptor) { Subjects = subjects.AsEnumerable().Clone().ToList() };
        return new HasStudyingSchedule(clone);
    }
}
