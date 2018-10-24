﻿namespace BililiveRecorder.Core
{
    public interface IRecordInfo
    {
        string SavePath { get; set; }
        string StreamFilePrefix { get; set; }
        string ClipFilePrefix { get; set; }
        string StreamName { get; set; }
        string GetStreamFilePath();
        string GetClipFilePath();
    }
}
