using AdvancedFluentBuilder.Dtos.Descriptors;
using AdvancedFluentBuilder.Interfaces;

namespace AdvancedFluentBuilder.Implementations;

internal class HaveAgeAndCanHaveName : IHaveAgeAndCanHaveName
{
    private readonly MemberDescriptor m_Descriptor;

    public HaveAgeAndCanHaveName(MemberDescriptor descriptor)
    {
        m_Descriptor = descriptor;
    }

    public IHasRole WithName(string name)
    {
        var clone = new MemberDescriptor(m_Descriptor) { Name = name };
        return new HasRole(clone);
    }
}
