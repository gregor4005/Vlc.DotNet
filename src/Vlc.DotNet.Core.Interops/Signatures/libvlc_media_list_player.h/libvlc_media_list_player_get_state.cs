using System;
using System.Runtime.InteropServices;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>Get current libvlc_state of media list player.</summary>
    /// <returns>libvlc_state_t for media list player</returns>
    [LibVlcFunction("libvlc_media_list_player_get_state")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate MediaStates GetMediaListPlayerState(IntPtr mediaListPlayerInstance);
}
