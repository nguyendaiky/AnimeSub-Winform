using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    class cv2
    {
        public static Image resize(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, size);
            return (Image)bm;
        }
        public static Image imread(string path)
        {
            Image result = Image.FromFile(path);

            return result;
        }
        public static Image resize_width(Image img, int width)
        {
            int w = width;
            Double ratio = Convert.ToDouble(w) / img.Width;
            int h = Convert.ToInt32(ratio * img.Height);

            Image result = resize(img, new Size(w, h));

            return result;
        }
        public static Image resize_height(Image img, int height)
        {
            int h = height;
            Double ratio = Convert.ToDouble(h) / img.Height;
            int w = Convert.ToInt32(ratio * img.Width);

            Image result = resize(img, new Size(w, h));

            return result;
        }

        public static Film filmread(DataRow row)
        {
            Film result = new Film();
            result.lbName.Text = row["Name"].ToString();
            result.lbView.Text = row["View"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif";
            Image img = Image.FromFile(path);
            result.pctImage.BackgroundImage = img;
            result.lbView.Text = row["View"].ToString();

            return result;
        }

    }
}
