using System.Drawing;
using System.Windows.Forms;



namespace PIM_4_PERIODO.Model
{
    class CustomBackground : Panel
    {
        
        PictureBox Picture_BG = new PictureBox();
        Custom_DragControl Drag_Control = new Custom_DragControl();

        public CustomBackground()
        {
            Control mycontrol = this;
            Panel Panel_Image = new Panel();
            Picture_BG.Image = Properties.Resources.caminhão;

            this.BackColor = Color.FromArgb(37, 44, 54);

            Picture_BG.Name = "Background Image";
            Picture_BG.BackColor = Color.Transparent;
            Picture_BG.BorderStyle = BorderStyle.None;
            Picture_BG.Padding = new Padding((this.Size.Width /4),this.Size.Height - (this.Size.Height / 2),0,0);
            Picture_BG.Location = new Point(Picture_BG.Image.Width - this.Size.Width, Picture_BG.Height - this.Height);
            Picture_BG.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_BG.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Picture_BG.Size = Picture_BG.Image.Size;
            Picture_BG.Dock = DockStyle.Fill;
            Drag_Control.Select_Control = Picture_BG;

            this.Margin = new Padding(10);
            //this.Padding = 
            this.SendToBack();
            this.Controls.Add(Picture_BG);
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;


            //Console.WriteLine(this.FindForm().ClientRectangle.Size);
            //this.AdjustFormScrollbars(false);
            //this.Size = this.ClientRectangle.Size;
            //Point locationOnForm = this.FindForm().PointToClient(this.Parent.PointToScreen(this.Location));
            //Console.WriteLine(locationOnForm);
            this.Dock = DockStyle.Fill;
        }
    }
}
