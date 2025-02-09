﻿using System.Threading.Tasks;
using Nimbus.Handlers;
using Nimbus.IntegrationTests.Tests.SimpleCommandSendingTests.MessageContracts;
using Nimbus.Tests.Common;
using Nimbus.Tests.Common.TestUtilities;

#pragma warning disable 4014

namespace Nimbus.IntegrationTests.Tests.SimpleCommandSendingTests.CommandHandlers
{
    public class SomeCommandHandler : IHandleCommand<SomeCommand>
    {
        public async Task Handle(SomeCommand busCommand)
        {
            MethodCallCounter.RecordCall<SomeCommandHandler>(ch => ch.Handle(busCommand));
        }
    }
}