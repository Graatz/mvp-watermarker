using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPMarker.Model;
using MVPMarker.Presenter;
using System.Drawing.Text;
using System.IO;

namespace MVPMarker
{
    public partial class MarkerForm : Form, IMarkerForm
    {
        MarkerPresenter presenter;

        private ImageModel model;
        public ImageModel Model
        {
            get
            {
                model.Image = imageControl.Image;
                model.Opacity = (byte)opacityControl.Value;
                model.WaterMark = textControl.Text;
                model.WaterMarkFont = fontControl.SelectedItem.ToString();
                model.WaterMarkSize = (int)sizeControl.Value;

                return model;
            }
            set
            {
                model = value;

                imageControl.Size = model.Image.Size;
                imageControl.Location = PositionImage(model);
                imageControl.Image = model.Image;
                opacityControl.Value = model.Opacity;
                textControl.Text = model.WaterMark;
                fontControl.SelectedItem = model.WaterMarkFont;
                sizeControl.Value = model.WaterMarkSize;
            }
        }

        public MarkerForm()
        {
            InitializeComponent();
            imageControl.AllowDrop = true;
            imageControl.DragEnter += new DragEventHandler(imageControl_DragEnter);
            imageControl.DragDrop += new DragEventHandler(imageControl_DragDrop);
            imageControl.DragLeave += new EventHandler(imageControl_DragLeave);

            InstalledFontCollection installedFonts = new InstalledFontCollection();
            FontFamily[] fonts = installedFonts.Families;
            foreach(var font in fonts)
            {
                fontControl.Items.Add(font.Name);
            }
            fontControl.SelectedItem = fontControl.Items[0];

            presenter = new MarkerPresenter(this);
            model = new ImageModel();
        }

        private void imageControl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;

            panel1.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
        }

        private void imageControl_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
            {
                presenter.UpdateImage(files[0], "WaterMark", "Tahoma", 11, 255);
                panel1.BackColor = Color.White;
                label5.Visible = false;

                textControl.TextChanged += new EventHandler(textControl_TextChanged);
                fontControl.SelectedValueChanged += new EventHandler(fontControl_SelectedValueChanged);
                sizeControl.ValueChanged += new EventHandler(sizeControl_ValueChanged);
                opacityControl.ValueChanged += new EventHandler(opacityControl_ValueChanged);
                applyControl.Click += new EventHandler(applyControl_Click);
            }
            else
            {
                MessageBox.Show("Choose only one file!");
            }
        }

        private void imageControl_DragLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            label5.BackColor = Color.White;
        }

        public Point PositionImage(ImageModel mdl)
        {
            if ((mdl.Image.Size.Width < panel1.Size.Width) && (mdl.Image.Size.Height < panel1.Size.Height))
            {
                Point location = new Point((panel1.Width / 2) - (mdl.Image.Size.Width / 2),
                                           (panel1.Height / 2) - (mdl.Image.Size.Height / 2));
                return location;
            }
            else if ((mdl.Image.Size.Width < panel1.Size.Width) && (mdl.Image.Size.Height > panel1.Size.Height))
            {
                Point location = new Point((panel1.Width / 2) - (mdl.Image.Size.Width / 2), 0);
                return location;
            }
            else if ((mdl.Image.Size.Width > panel1.Size.Width) && (mdl.Image.Size.Height < panel1.Size.Height))
            {
                Point location = new Point(0, (panel1.Height / 2) - (mdl.Image.Size.Height / 2));
                return location;
            }
            else
            {
                Point location = new Point(0, 0);
                mdl.Position = location;
                return location;
            }
        }

        private void textControl_TextChanged(object sender, EventArgs e)
        {
            presenter.UpdateImage(Model.FilePath, textControl.Text, Model.WaterMarkFont, Model.WaterMarkSize, Model.Opacity);
        }

        private void fontControl_SelectedValueChanged(object sender, EventArgs e)
        {
            presenter.UpdateImage(Model.FilePath, Model.WaterMark, fontControl.SelectedItem.ToString(), Model.WaterMarkSize, Model.Opacity);
        }

        private void sizeControl_ValueChanged(object sender, EventArgs e)
        {
            presenter.UpdateImage(Model.FilePath, Model.WaterMark, Model.WaterMarkFont, (int)sizeControl.Value, Model.Opacity);
        }

        private void opacityControl_ValueChanged(object sender, EventArgs e)
        {
            presenter.UpdateImage(Model.FilePath, Model.WaterMark, Model.WaterMarkFont, Model.WaterMarkSize, (byte)opacityControl.Value);
        }

        private void applyControl_Click(object sender, EventArgs e)
        {
            presenter.ApplyWaterMark();
        }
    }
}
