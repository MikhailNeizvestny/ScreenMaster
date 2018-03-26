using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMaster
{
    class Screenshot
    {
        private Bitmap screen;

        public Screenshot()
        { }

        public Bitmap MakeScreenshot(Rectangle bounds)
        {
            screen = new Bitmap(bounds.Width, bounds.Height);
            Graphics graphic = Graphics.FromImage(screen);
            graphic.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size);
            return screen;
        }

        public Rectangle GetNewBounds(Rectangle bounds)
        {
            double coef = GetSystemDpi();
            int height = (int)Math.Round(bounds.Height * coef);
            int width = (int)Math.Round(bounds.Width * coef);
            Rectangle rect = new Rectangle(bounds.X,bounds.Y, width, height);
            return rect;
        }

        private static double GetSystemDpi()
        {
            using (Graphics screen = Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr hdc = screen.GetHdc();

                int virtualWidth = GetDeviceCaps(hdc, DeviceCaps.HORZRES);
                int physicalWidth = GetDeviceCaps(hdc, DeviceCaps.DESKTOPHORZRES);
                screen.ReleaseHdc(hdc);
                double coef = (double)physicalWidth / virtualWidth;
                return coef;
            }
        }
        private enum DeviceCaps
        {
            /// <summary>
            /// Logical pixels inch in X
            /// </summary>
            LOGPIXELSX = 88,

            /// <summary>
            /// Horizontal width in pixels
            /// </summary>
            HORZRES = 8,

            /// <summary>
            /// Horizontal width of entire desktop in pixels
            /// </summary>
            DESKTOPHORZRES = 118
        }

        /// <summary>
        /// Retrieves device-specific information for the specified device.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="nIndex">The item to be returned.</param>
        [DllImport("gdi32.dll")]
        private static extern int GetDeviceCaps(IntPtr hdc, DeviceCaps nIndex);
    }
}
