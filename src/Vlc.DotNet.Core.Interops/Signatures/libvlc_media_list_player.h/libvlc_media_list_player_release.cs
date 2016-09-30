namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// It will release the media list player object. If the media list player object has been released, then it should not be used again.
    /// </summary>
    [LibVlcFunction("libvlc_media_list_player_release")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ReleaseMediaListPlayer(IntPtr mediaListPlayerInstance);
}