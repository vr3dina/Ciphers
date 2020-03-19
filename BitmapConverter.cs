using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SymmetricBlockCiphers
{
    public class BitmapConverter
    {

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public byte[] ImageToBytes(Bitmap bmp)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = bmpData.Stride * bmpData.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            bmp.UnlockBits(bmpData);
            return rgbValues;

            //byte[] bytes = new byte[3 * bmp.Height * 3 * bmp.Width];
            //for (int i = 0; i < bmp.Height; i++)
            //{
            //    for (int j = 0; j < bmp.Width; j++)
            //    {
            //        bytes[i * bmp.Width + j + 0] = bmp.GetPixel(j, i).R;
            //        bytes[i * bmp.Width + j + 1] = bmp.GetPixel(j, i).G;
            //        bytes[i * bmp.Width + j + 2] = bmp.GetPixel(j, i).B;
            //    }
            //}
            //return bytes;
        }

        public Bitmap BytesToImage(byte[] rgb, Size size)
        {
            //Bitmap bmp = new Bitmap(size.Width, size.Height, PixelFormat.Format24bppRgb);
            Bitmap bmp = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);
            System.Runtime.InteropServices.Marshal.Copy(rgb, 0, bmpData.Scan0, rgb.Length);
            bmp.UnlockBits(bmpData);
            return bmp;

            //for (int i = 0; i < size.Height; i++)
            //{
            //    for (int j = 0; j < size.Width; j++)
            //    {
            //        int R = bytes[i * bmp.Width + j];
            //        int G = bytes[i * bmp.Width + j + 1];
            //        int B = bytes[i * bmp.Width + j + 2];
            //        bmp.SetPixel(j, i, Color.FromArgb(R,G,B));
            //    }
            //}
            //return bmp;
        }
    }
}
