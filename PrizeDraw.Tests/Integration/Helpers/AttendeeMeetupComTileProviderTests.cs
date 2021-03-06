﻿using System.Threading.Tasks;
using NUnit.Framework;
using PrizeDraw.Helpers;
using PrizeDraw.Properties;

namespace PrizeDraw.Tests.Integration.Helpers
{
    [TestFixture, Category("Integration")]
    public class AttendeeMeetupComTileProviderTests
    {
        [Test]
        public async Task GivenAMeetupEventId_WithRSVPs_ThenResultsShouldHaveValues()
        {
            var sut = new AttendeeMeetupComTileProvider(Settings.Default);
            var tiles = await sut.GetTilesAsync();

            Assert.That(tiles.Count, Is.GreaterThan(0));
        }
    }
}
