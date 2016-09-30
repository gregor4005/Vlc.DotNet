namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Replace media player in media_list_player with this instance.
    /// </summary>
    [LibVlcFunction("libvlc_media_list_player_set_media_player")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMediaPlayerToMediaListPlayer(IntPtr mediaListPlayerInstance, IntPtr mediaPlayerInstance);
}