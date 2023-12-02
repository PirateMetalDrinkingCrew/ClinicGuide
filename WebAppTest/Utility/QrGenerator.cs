using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;

namespace WebAppTest.Utility
{
    /// <summary>
    /// QR-generator helper class
    /// </summary>
    public class QrGenerator
    {
        /// <summary>
        /// The input to be encoded
        /// </summary>
        public string QRCodeText { get; set; }
        /// <summary>
        /// The Base64 String to be displayed in Frontend
        /// </summary>
        public string QRByte = "";

        public QrGenerator(string stringToBeGenerated)
        {
            QRCodeText = stringToBeGenerated;
        }

        /// <summary>
        /// Sets the QRByte Property which is going to be displayed in frontend
        /// </summary>
        public void GenerateQRCode()
        {
            if (!string.IsNullOrEmpty(QRCodeText))
            {
                using MemoryStream ms = new();
                QRCodeGenerator qrCodeGenerate = new();
                QRCodeData qrCodeData = qrCodeGenerate.CreateQrCode(QRCodeText, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new(qrCodeData);
                using Bitmap qrBitMap = qrCode.GetGraphic(20);
                qrBitMap.Save(ms, ImageFormat.Png);
                string base64 = Convert.ToBase64String(ms.ToArray());
                QRByte = string.Format("data:image/png;base64,{0}", base64);
            }
        }
    }
}
