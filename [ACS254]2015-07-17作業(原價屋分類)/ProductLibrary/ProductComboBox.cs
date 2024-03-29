﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductLibrary
{
    public class ProductComboBox : ComboBox
    {
        public ProductComboBox()
            : base()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (e.Index < 0)
            {
                return;
            }
            e.DrawBackground();
            if (this.Items[e.Index] is Product)
            {
                Product product = this.Items[e.Index] as Product;
                Font font = new Font(FontFamily.GenericMonospace, 14, FontStyle.Bold);
                Brush brush = new SolidBrush(product.ForeColor);
                e.Graphics.DrawString(product.ToString(), font, brush, e.Bounds.X, e.Bounds.Y);
            }
        }
    }
}