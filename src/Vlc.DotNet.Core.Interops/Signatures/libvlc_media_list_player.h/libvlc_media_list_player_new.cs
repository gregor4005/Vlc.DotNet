namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;
    
    /// <summary>
    /// Create an empty Media List Player object.
    /// </summary>
    /// <returns>Return a new media list player object, or NULL on error.</returns>
    [LibVlcFunction("libvlc_media_list_player_new")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr CreateMediaListPlayer(IntPtr instance);
}