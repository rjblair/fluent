using AdvancedFluentBuilder.Dtos.Descriptors;
using AdvancedFluentBuilder.Dtos;
using AdvancedFluentBuilder.Interfaces;

namespace AdvancedFluentBuilder.Implementations;

internal class AmTeaching : IAmTeaching
{
    private readonly TeacherDescriptor m_Descriptor;

    public AmTeaching(TeacherDescriptor descriptor)
    {
        m_Descriptor = descriptor;
    }

    public IHasTeachingSchedule Teaching(Subject subject)
    {
        var clone = new TeacherDescriptor(m_Descriptor) { Subject = new Subject(subject) };
        return new HasTeachingSchedule(clone);
    }
}
