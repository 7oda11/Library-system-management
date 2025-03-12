using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public class QRCodeService
{
    public static Bitmap GenerateQRCode(string data)
    {
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q))
            {
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    return qrCode.GetGraphic(10);
                }
            }
        }
    }

    public static void SaveQRCode(Bitmap qrCodeImage, string filePath)
    {
        qrCodeImage.Save(filePath, ImageFormat.Png);
    }
}
