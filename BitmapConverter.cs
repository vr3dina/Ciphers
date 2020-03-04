using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace SymmetricBlockCiphers
{
    public class BitmapConverter
    {
        public byte[] ImageToBytes(Bitmap bmp)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width,
            bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite,
            bmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = bmpData.Stride * bmpData.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            bmp.UnlockBits(bmpData);
            return rgbValues;
        }

        public Bitmap BytesToImage(byte[] rgb, Size size)
        {
            Bitmap bmp = new Bitmap(size.Width, size.Height, PixelFormat.Format24bppRgb);
            BitmapData bmpData = bmp.LockBits(
            new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.WriteOnly, bmp.PixelFormat);
            System.Runtime.InteropServices.Marshal.Copy(rgb, 0, bmpData.Scan0, rgb.Length);
            bmp.UnlockBits(bmpData);
            return bmp;
        }
    }
}
