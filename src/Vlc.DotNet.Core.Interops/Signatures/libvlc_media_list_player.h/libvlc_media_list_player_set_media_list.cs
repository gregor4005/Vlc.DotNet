namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Set the media list associated with the player.
    /// </summary>
    [LibVlcFunction("libvlc_media_list_player_set_media_list")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMediaListToMediaListPlayer(IntPtr mediaListPlayerInstance, IntPtr mediaListInstance);
}