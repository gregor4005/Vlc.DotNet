namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Play media list.</summary>
    [LibVlcFunction("libvlc_media_list_player_play")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void PlayMediaList(IntPtr mediaListPlayerInstance);
}