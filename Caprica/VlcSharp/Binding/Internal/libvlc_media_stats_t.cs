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
using System.Runtime.InteropServices;

namespace Caprica.VlcSharp.Binding.Internal {

    /**
     *
     */
    [StructLayout(LayoutKind.Sequential)]
    public class libvlc_media_stats_t {
    
        /* Input */
        public int         i_read_bytes;
        public float       f_input_bitrate;
    
        /* Demux */
        public int         i_demux_read_bytes;
        public float       f_demux_bitrate;
        public int         i_demux_corrupted;
        public int         i_demux_discontinuity;
    
        /* Decoders */
        public int         i_decoded_video;
        public int         i_decoded_audio;
    
        /* Video Output */
        public int         i_displayed_pictures;
        public int         i_lost_pictures;
    
        /* Audio output */
        public int         i_played_abuffers;
        public int         i_lost_abuffers;
    
        /* Stream output */
        public int         i_sent_packets;
        public int         i_sent_bytes;
        public float       f_send_bitrate;
    }
}
