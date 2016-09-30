namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;

    public enum MediaStates
    {
        NothingSpecial = 0,
        Opening,
        [Obsolete("Check the MediaPlayerBuffering event to know the buffering state of a MediaPlayer")]
        Buffering,
        Playing,
        Paused,
        Stopped,
        Ended,
        Error
    }
}
