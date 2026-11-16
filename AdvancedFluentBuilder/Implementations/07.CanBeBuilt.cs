using AdvancedFluentBuilder.Dtos.Descriptors;
using AdvancedFluentBuilder.Interfaces;

namespace AdvancedFluentBuilder.Implementations;

internal class CanBeBuilt : ICanBeBuilt
{
    private readonly MemberDescriptor m_Descriptor;

    public CanBeBuilt(MemberDescriptor descriptor)
    {
        m_Descriptor = descriptor;
    }

    public MemberDescriptor Build()
    {
        return m_Descriptor.Clone();
    }
}
