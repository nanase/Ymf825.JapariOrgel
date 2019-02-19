namespace Ymf825.JapariOrgel
{
    public interface ILcdSupport : IYmf825
    {
        void WriteCharsToLcd(byte[] chars, int index, int count);
        void SetLcdPosition(int column, int row);
        void ClearLcdDisplay();
        void SetLcdBacklightColor(byte r, byte g, byte b);
        void ScrollLcdToLeft();
        void ScrollLcdToRight();
        void SetLcdCursorVisibility(bool visibility);
        void SetLcdBlinking(bool blinking);
        void CreateLcdChar(int number, byte[] data, int index, int count);
    }
}
