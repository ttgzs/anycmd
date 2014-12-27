﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class UpdateActionCommand : UpdateEntityCommand<IActionUpdateIo>, IAnycmdCommand
    {
        public UpdateActionCommand(IActionUpdateIo input)
            : base(input)
        {

        }
    }
}
