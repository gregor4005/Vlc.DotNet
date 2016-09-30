namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Play media list item at position index.</summary>
    /// <returns>0 upon success -1 if the item wasn't found</returns>
    [LibVlcFunction("libvlc_media_list_player_play_item_at_index")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int PlayMediaListItemAtIndex(IntPtr mediaListPlayerInstance, int index);
}