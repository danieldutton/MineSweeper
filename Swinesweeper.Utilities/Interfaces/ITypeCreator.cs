using System;

namespace Swinesweeper.Utilities.Interfaces
{
    public interface ITypeCreator
    {
        object GetTypeInstance(Type typeToCreate);
    }
}
