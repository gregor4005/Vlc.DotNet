namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Play previous item from media list.</summary>
    /// <returns>0 upon success -1 if there is no previous item</returns>
    [LibVlcFunction("libvlc_media_list_player_previous")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PreviousMediaListItem(IntPtr mediaListPlayerInstance);
}