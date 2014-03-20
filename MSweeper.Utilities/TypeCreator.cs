using MSweeper.Utilities.Interfaces;
using System;

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
