﻿using Grimoire.Game;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdIntGreaterThan : StatementCommand, IBotCommand
    {
        public CmdIntGreaterThan()
        {
            Tag = "Misc";
            Text = "Int Greater Than";
        }

        public Task Execute(IBotEngine instance)
        {
            if (Configuration.Tempvalues[Value1] < int.Parse(Value2))
            {
                instance.Index++;
            }
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return $"{Value1} > {Value2}";
        }
    }
}