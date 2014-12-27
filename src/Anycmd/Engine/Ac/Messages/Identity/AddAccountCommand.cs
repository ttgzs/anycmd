﻿
namespace Anycmd.Engine.Ac.Messages.Identity
{
    using Commands;
    using InOuts;
    using Model;

    public class AddAccountCommand : AddEntityCommand<IAccountCreateIo>, IAnycmdCommand
    {
        public AddAccountCommand(IAccountCreateIo input)
            : base(input)
        {
        }
    }
}
