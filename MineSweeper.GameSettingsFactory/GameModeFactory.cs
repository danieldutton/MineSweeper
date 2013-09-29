using MineSweeper.GameModeFactory.GameModes;
using MineSweeper.GameModeFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MineSweeper.GameModeFactory
{
    public class GameModeFactory : IGameModeFactory
    {
        private Dictionary<string, Type> _gameModes;

        public GameModeFactory()
        {
            LoadTypesICanReturn();
        }

        public IGameMode CreateInstance(string gameModeName)
        {
            Type type = GetTypeToCreate(gameModeName);

            if(type == null)
                return new NullSettings();

            return Activator.CreateInstance(type) as IGameMode;
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
