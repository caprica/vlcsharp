/*
 * This file is part of VLCSHARP.
 *
 * VLCSHARP is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * VLCSHARP is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with VLCSHARP.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * Copyright 2012 Caprica Software Limited.
 */

using System;

using Caprica.VlcSharp.Binding;

namespace Caprica.VlcSharp.Player.Embedded.VideoSurface.Linux {
    
    /**
     * Implementation of a video surface adapter for Linux.
     */
    public partial class LinuxVideoSurfaceAdapter : VideoSurfaceAdapter {
    
        public void Attach(DefaultMediaPlayer mediaPlayer, long componentId) {
            LibVlc.libvlc_media_player_set_xwindow(mediaPlayer.MediaPlayerInstance(), (int)componentId);
        }
    }
}
