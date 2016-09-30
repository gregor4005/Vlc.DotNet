namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Toggle pause (or resume) media list.</summary>
    [LibVlcFunction("libvlc_media_list_player_pause")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TogglePauseMediaList(IntPtr mediaListPlayerInstance);
}