namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Play next item from media list.</summary>
    /// <returns>0 upon success -1 if there is no next item</returns>
    [LibVlcFunction("libvlc_media_list_player_next")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int NextMediaListItem(IntPtr mediaListPlayerInstance);
}