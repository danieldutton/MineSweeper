using System;
using MSweeper.Utilities.Interfaces;

namespace MSweeper.Utilities
{
    public class TypeCreator : ITypeCreator
    {
        public object GetTypeInstance(Type typeToCreate)
        {
            return Activator.CreateInstance(typeToCreate);
        }
    }
}
