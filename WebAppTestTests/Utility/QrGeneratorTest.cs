using WebAppTest.Utility;

namespace WebAppTestTests.Utility
{
    public class QrGeneratorTest
    {
        public static void ShouldGenerateAQrCode()
        {
            // Arrange
            string toBeGenerated = "Pirate Metal Drinking Crew";
            QrGenerator qrGenerator = new(toBeGenerated);
            // Act
            qrGenerator.GenerateQRCode();
            // Assert
            Assert.IsNotNull(qrGenerator.QRByte);
        }
    }
}
