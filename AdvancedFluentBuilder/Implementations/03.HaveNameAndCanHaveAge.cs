using AdvancedFluentBuilder.Dtos.Descriptors;
using AdvancedFluentBuilder.Interfaces;

namespace AdvancedFluentBuilder.Implementations;

internal class HaveNameAndCanHaveAge : IHaveNameAndCanHaveAge
{
    private readonly MemberDescriptor m_Descriptor;

    public HaveNameAndCanHaveAge(MemberDescriptor descriptor)
    {
        m_Descriptor = descriptor;
    }

    public IHasRole WithAge(int age)
    {
        var clone = new MemberDescriptor(m_Descriptor) { Age = age };
        return new HasRole(clone);
    }
}
