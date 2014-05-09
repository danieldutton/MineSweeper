using Swinesweeper.GameModeFactory.GameModes;
using Swinesweeper.GameModeFactory.Interfaces;
using Swinesweeper.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Swinesweeper.GameModeFactory
{
    public class GameModeFactory : IGameModeFactory
    {
        private readonly ITypeInstanceCreator _typeInstanceCreator;
        
        private Dictionary<string, Type> _gameModes;

        
        public GameModeFactory(ITypeInstanceCreator typeInstanceCreator)
        {
            _typeInstanceCreator = typeInstanceCreator;
            
            LoadTypesICanReturn();
        }

        public IGameMode CreateInstance(string gameModeName)
        {
            if(string.IsNullOrEmpty(gameModeName)) throw new ArgumentException("gameModeName");

            Type type = GetTypeToCreate(gameModeName);

            if(type == null)
                return new Null();

            return _typeInstanceCreator.GetTypeInstance(type) as IGameMode;
        }

        private Type GetTypeToCreate(string gameModeName)
        {
            foreach (var gameMode in _gameModes)
            {
                if (gameMode.Key.Contains(gameModeName))
                {
                    return _gameModes[gameMode.Key];
                }
            }
            return null;
        }

        private void LoadTypesICanReturn()
        {
            _gameModes = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IGameMode).ToString()) != null)
                {
                    _gameModes.Add(type.Name, type);
                }
            }
        }
    }
}
