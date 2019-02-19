using Ymf825.Driver;
using Ymf825.JapariOrgel.Jpm;

namespace Ymf825.JapariOrgel
{
    public class JapariOrgelDriver : Ymf825Driver
    {
        public JapariOrgelDriver(IYmf825 soundChip) : base(soundChip)
        {
        }

        public void WriteCharsToLcd(string text)
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            var bytes = JpmLcdChars.GetBytes(text);
            ymf825.WriteCharsToLcd(bytes, 0, text.Length);
        }

        public void WriteCharsToLcd(byte[] chars, int index, int count)
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;
            
            ymf825.WriteCharsToLcd(chars, index, count);
        }

        public void SetLcdPosition(int column, int row)
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            ymf825.SetLcdPosition(column, row);
        }

        public void ClearLcdDisplay()
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            ymf825.ClearLcdDisplay();
        }

        public void SetLcdBacklightColor(byte r, byte g, byte b)
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            ymf825.SetLcdBacklightColor(r, g, b);
        }
        
        public void ScrollLcdToLeft()
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            ymf825.ScrollLcdToLeft();
        }

        public void ScrollLcdToRight()
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            ymf825.ScrollLcdToRight();
        }

        public void SetLcdCursorVisibility(bool visibility)
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            ymf825.SetLcdCursorVisibility(visibility);
        }

        public void SetLcdBlinking(bool blinking)
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            ymf825.SetLcdBlinking(blinking);
        }

        public void CreateLcdChar(int number, byte[] data, int index, int count)
        {
            if (!(SoundChip is ILcdSupport ymf825))
                return;

            ymf825.CreateLcdChar(number, data, index, count);
        }
    }
}
