﻿
namespace Anycmd.Engine.Ac.Catalogs
{
    using InOuts;

    public class UpdateCatalogCommand : UpdateEntityCommand<ICatalogUpdateIo>, IAnycmdCommand
    {
        public UpdateCatalogCommand(IAcSession acSession, ICatalogUpdateIo input)
            : base(acSession, input)
        {

        }
    }
}
