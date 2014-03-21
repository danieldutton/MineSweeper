using Swinesweeper.Utilities.Interfaces;
using System;

namespace Swinesweeper.Utilities
{
    public class TypeCreator : ITypeCreator
    {
        public object GetTypeInstance(Type typeToCreate)
        {
            return Activator.CreateInstance(typeToCreate);
        }
    }
}
