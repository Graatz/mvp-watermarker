using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPMarker.Model
{
    public class ImageModel
    {
        public Image Image { get; set; }
        public string WaterMark { get; set; }
        public string WaterMarkFont { get; set; }
        public int WaterMarkSize { get; set; }
        public byte Opacity { get; set; }
        public Point Position { get; set; }
        public string FilePath { get; set; }
    }
}
