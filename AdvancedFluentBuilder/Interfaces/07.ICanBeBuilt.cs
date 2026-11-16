using AdvancedFluentBuilder.Dtos.Descriptors;

namespace AdvancedFluentBuilder.Interfaces;

public interface ICanBeBuilt
{
    MemberDescriptor Build();
}
