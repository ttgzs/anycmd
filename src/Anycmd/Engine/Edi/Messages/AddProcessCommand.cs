﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class AddProcessCommand : AddEntityCommand<IProcessCreateIo>, IAnycmdCommand
    {
        public AddProcessCommand(IProcessCreateIo input)
            : base(input)
        {

        }
    }
}
