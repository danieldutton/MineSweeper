using System;

namespace MSweeper.Utilities.Interfaces
{
    public interface ITypeCreator
    {
        object GetTypeInstance(Type typeToCreate);
    }
}
