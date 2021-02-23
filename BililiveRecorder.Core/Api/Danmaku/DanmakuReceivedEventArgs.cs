﻿using System;

namespace BililiveRecorder.Core.Api.Danmaku
{
    public class DanmakuReceivedEventArgs : EventArgs
    {
        public readonly DanmakuModel Danmaku;

        public DanmakuReceivedEventArgs(DanmakuModel danmaku)
        {
            this.Danmaku = danmaku ?? throw new ArgumentNullException(nameof(danmaku));
        }
    }
}
