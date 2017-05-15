using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPMarker.Model;
using System.Drawing;
using System.IO;

namespace MVPMarker.Presenter
{
    class MarkerPresenter
    {
        IMarkerForm view;

        public MarkerPresenter(IMarkerForm view)
        {
            this.view = view;

            
        }

        public void UpdateImage(string filePath, string text, string font, int size, byte opacity)
        {
            if (view.Model.Image != null)
                view.Model.Image.Dispose();

            if (File.Exists(filePath))
            {
                Image image = new Bitmap(filePath);
                Control Label = new Label();
                Control TextBox = new TextBox();

                ImageModel model = new ImageModel()
                {
                    Image = image,
                    FilePath = filePath,
                    Opacity = opacity,
                    Position = new Point(0, 0),
                    WaterMark = text,
                    WaterMarkFont = font,
                    WaterMarkSize = size
                };

                using (Graphics g = Graphics.FromImage(model.Image))
                {
                    g.DrawString(model.WaterMark,
                                new Font(font, model.WaterMarkSize),
                                new SolidBrush(Color.FromArgb(model.Opacity, Color.White)),
                                model.Position);
                }

                view.Model = model;
            }
        }

        public void ApplyWaterMark()
        {
            Bitmap temp = new Bitmap(view.Model.Image);
            view.Model.Image.Dispose();

            if (File.Exists(view.Model.FilePath))
                File.Delete(view.Model.FilePath);

            view.Model.Image = temp;
            temp.Save(view.Model.FilePath);

            UpdateImage(view.Model.FilePath, "WaterMark", "Tahoma", 11, 255);
        }
    }
}
