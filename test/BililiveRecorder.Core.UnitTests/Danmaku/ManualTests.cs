using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BililiveRecorder.Core.Api;
using BililiveRecorder.Core.Api.Danmaku;
using BililiveRecorder.Core.Api.Http;
using Newtonsoft.Json.Linq;
using Xunit;

namespace BililiveRecorder.Core.UnitTests.Danmaku
{
    public class ManualTests
    {
        [Fact]
        public async Task TestAsync()
        {
            var client = new DanmakuClient(new HttpApiClient(null!), null);

            client.StatusChanged += this.Client_StatusChanged;
            client.DanmakuReceived += this.Client_DanmakuReceived;

            await Task.Yield();

            throw new NotImplementedException();
            // await client.ConnectAsync().ConfigureAwait(false);

            // await Task.Delay(TimeSpan.FromMinutes(5)).ConfigureAwait(false);
        }

        private void Client_DanmakuReceived(object sender, DanmakuReceivedEventArgs e)
        {
        }

        private void Client_StatusChanged(object sender, StatusChangedEventArgs e)
        {
        }
    }
}
