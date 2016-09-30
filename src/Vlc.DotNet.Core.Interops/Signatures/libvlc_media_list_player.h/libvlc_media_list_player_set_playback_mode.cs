namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Sets the playback mode for the playlist.</summary>
    [LibVlcFunction("libvlc_media_list_player_set_playback_mode")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetPlaybackMode(IntPtr mediaListPlayerInstance, PlaybackModes mode);
}