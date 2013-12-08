﻿using Abot.Core;
using Commoner.Core.Testing;
using NUnit.Framework;
using System;

namespace Abot.Tests.Unit.Core
{
    [TestFixture]
    public class InMemoryCrawledUrlRepositoryTest : CrawledUrlRepositoryTest
    {
        public override ICrawledUrlRepository GetInstance()
        {
            return new InMemoryCrawledUrlRepository();
        }
    }
}