﻿
namespace Anycmd.Engine.Ac.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class UpdateSsdSetCommand: UpdateEntityCommand<ISsdSetUpdateIo>, IAnycmdCommand
    {
        public UpdateSsdSetCommand(ISsdSetUpdateIo input)
            : base(input)
        {

        }
    }
}
