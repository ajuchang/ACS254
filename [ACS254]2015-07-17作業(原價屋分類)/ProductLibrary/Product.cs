using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductLibrary
{
    public class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Color ForeColor { get; set; }

        public string Grouptype { get; set; } //商品群組

        public override string ToString()
        {
            if (this.Name != null)
            {
                string s = string.Format("{0},今日價格：{1},產品分類：{2}", this.Name, this.Price, this.Grouptype);
                return s;
            }
            else
            {
                string s = string.Format("{0}", this.Grouptype);
                return s;
            }
        }
    }
}