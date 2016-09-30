namespace Vlc.DotNet.Core.Interops.Signatures
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Get the Event Manager from which the media list player send event.
    /// </summary>
    /// <returns>Return the event manager associated with media list player.</returns>
    [LibVlcFunction("libvlc_media_list_player_event_manager")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetMediaListPlayerEventManager(IntPtr mediaListPlayerInstance);
}