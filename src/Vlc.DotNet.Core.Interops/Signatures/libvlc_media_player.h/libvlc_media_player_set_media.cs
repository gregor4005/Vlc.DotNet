﻿using System;
using System.Runtime.InteropServices;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set the media that will be used by the media_player. If any, previous media will be released.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_set_media")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMediaToMediaPlayer(IntPtr mediaPlayerInstance, IntPtr mediaInstance);
}