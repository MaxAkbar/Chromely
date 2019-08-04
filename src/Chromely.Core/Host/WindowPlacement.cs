﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Chromely.Core.Host
{
    public class WindowPlacement
    {
        public WindowPlacement()
        {
            Left = 0;
            Top = 0;
            Width = 800;
            Height = 600;
            CenterScreen = true;
            NoResize = false;
            NoMinMaxBoxes = false;
            Frameless = false;
            KioskMode = false;
            State = WindowState.Normal;
        }

        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool NoResize { get; set; }
        public bool NoMinMaxBoxes { get; set; }
        public bool Frameless { get; set; }
        public bool CenterScreen { get; set; }
        public bool KioskMode { get; set; }

        /// <summary>
        /// Gets or sets the host state.
        /// </summary>
        public WindowState State { get; set; }

        public Size WindowSize
        {
            get
            {
                return new Size(Width, Height);
            }
        }
    }
}
