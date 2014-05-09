using System;

namespace Swinesweeper.Utilities.Interfaces
{
    public interface ITypeInstanceCreator
    {
        object GetTypeInstance(Type typeToCreate);
    }
}
