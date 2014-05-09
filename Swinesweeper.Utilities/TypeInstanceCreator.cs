using Swinesweeper.Utilities.Interfaces;
using System;

namespace Swinesweeper.Utilities
{
    public class TypeInstanceCreator : ITypeInstanceCreator
    {
        public object GetTypeInstance(Type typeToCreate)
        {
            return Activator.CreateInstance(typeToCreate);
        }
    }
}
