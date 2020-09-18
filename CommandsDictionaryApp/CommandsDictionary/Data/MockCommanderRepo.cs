using CommandsDictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsDictionary.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and pan" },
                new Command { Id = 0, HowTo = "Make a cake", Line = "Mix ingrediants", Platform = "Bowl and spoon" },
                new Command { Id = 0, HowTo = "Grill a steak", Line = "Heat grill", Platform = "Grill" }
        };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and pan" };

        }
    }
}
