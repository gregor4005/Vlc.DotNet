namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Stop playing media list.</summary>
    [LibVlcFunction("libvlc_media_list_player_stop")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void StopMediaList(IntPtr mediaListPlayerInstance);
}