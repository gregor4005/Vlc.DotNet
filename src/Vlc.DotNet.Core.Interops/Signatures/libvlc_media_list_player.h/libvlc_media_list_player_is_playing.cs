namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>Check if media list player is playing.</summary>
    /// <returns>true for playing and false for not playing</returns>
    [LibVlcFunction("libvlc_media_list_player_is_playing")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int MediaListIsPlaying(IntPtr mediaListPlayerInstance);
}
