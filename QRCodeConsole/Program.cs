using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using QRCodeConsole.Common;
using System.Drawing;

namespace QRCodeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  測試一、生成中間沒有LOGO的二維碼
            //需要生成二維碼的內容
            //string content = "https://www.pchome.com.tw";
            //Bitmap bitmap = QRCodeHelper.Create(content, 300);
            //string filename = DateTime.Now.ToFileTime().ToString();
            //string saveFileUrl = string.Format(@"D:\RQCode\{0}.png", filename);
            //bitmap.Save(saveFileUrl, System.Drawing.Imaging.ImageFormat.Png);
            //bitmap.Dispose(); //釋放資源 
            #endregion

            #region 測試二、生成帶有LOGO二維碼

            //string qrFileUrl = @"D:\RQCode\131983000614535443.png";
            //string headerFileUrl = @"D:\RQCode\YFP.jpg";
            //string filename = DateTime.Now.ToFileTime().ToString();
            //string saveFileUrl = string.Format(@"D:\RQCode\{0}.png", filename);
            //Bitmap qrCodeBitmap = new Bitmap(qrFileUrl);
            //Bitmap headerBitmap = new Bitmap(headerFileUrl);
            //Bitmap qrAndHeaderBitmap = QRCodeHelper.MergeQrImg(qrCodeBitmap, headerBitmap);
            //qrAndHeaderBitmap.Save(saveFileUrl, System.Drawing.Imaging.ImageFormat.Png);
            //qrAndHeaderBitmap.Dispose(); //釋放資源  
            //qrCodeBitmap.Dispose();
            //headerBitmap.Dispose();
            #endregion

            #region 測試三、生成無LOGO和有LOGO的二維碼
            string content = "http://www.yfp.com.tw/";
            Bitmap bitmap = QRCodeHelper.Create(content, 400);
            string qrCodefilename = DateTime.Now.ToFileTime().ToString();
            string qrCodeSaveFileUrl = string.Format(@"D:\RQCode\{0}.png", qrCodefilename);
            bitmap.Save(qrCodeSaveFileUrl, System.Drawing.Imaging.ImageFormat.Png);

            string headerFileUrl = @"D:\RQCode\YFP.jpg";
            string filename = DateTime.Now.ToFileTime().ToString();
            string saveFileUrl = string.Format(@"D:\RQCode\{0}.png", filename);


            Bitmap headerBitmap = new Bitmap(headerFileUrl);
            Bitmap qrAndHeaderBitmap = QRCodeHelper.MergeQrImg(bitmap, headerBitmap);
            qrAndHeaderBitmap.Save(saveFileUrl, System.Drawing.Imaging.ImageFormat.Png);
            qrAndHeaderBitmap.Dispose(); //釋放資源  
            bitmap.Dispose();
            headerBitmap.Dispose();
            #endregion

           // Console.ReadLine();
        }
    }
}
