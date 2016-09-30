namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Get media player of the media_list_player instance.
    /// </summary>
    /// <returns>Return the media player instance associated with p_mlp, or NULL if no media player is associated.</returns>
    [LibVlcFunction("libvlc_media_list_player_get_media_player")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetMediaPlayerFromMediaListPlayer(IntPtr mediaListPlayerInstance);
}