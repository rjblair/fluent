using AdvancedFluentBuilder.Dtos.Descriptors;
using AdvancedFluentBuilder.Interfaces;

namespace AdvancedFluentBuilder.Implementations;

public class MemberBuilder : IMemberBuilder
{
    public IHuman New => new Human(new MemberDescriptor());
}
