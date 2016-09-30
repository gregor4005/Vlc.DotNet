namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Play the given media item.</summary>
    /// <returns>0 upon success, -1 if the media is not part of the media list</returns>
    [LibVlcFunction("libvlc_media_list_player_play_item")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PlayMediaListItem(IntPtr mediaListPlayerInstance, IntPtr mediaInstance);
}