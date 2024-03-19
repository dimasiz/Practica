using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class ColorEvent
    {
        public string Color { get; set; }
        public ColorEvent(string color)
        {
            Color = color;
        }
    }
    public class ColorProvider
    {
        public event EventHandler<ColorEvent> ColorGenerated;
        public string GetRedColor()
        {
            string color = "Red";
            OnColorGenerated(color);

            return color;
        }


        public string GetGreenColor()
        {
            string color = "Green";
            OnColorGenerated(color);

            return color;
        }

        public string GetBlueColor()
        {
            string color = "Blue";
            OnColorGenerated(color);

            return color;
        }

        public string GetColors()
        {
            string result = "";
            result += GetRedColor() + " ";
            result += GetGreenColor() + " ";
            result += GetBlueColor();

            return result;
        }
        protected void OnColorGenerated(string color)
        {
            ColorGenerated.Invoke(this, new ColorEvent(color));
        }
    }
}
