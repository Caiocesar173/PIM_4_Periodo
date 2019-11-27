using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public class Custom_Circurlar_Button : Button
    {
        public Custom_Circurlar_Button()
        {
            this.Size = new Size(26, 26);
            this.FlatStyle = FlatStyle.Flat;
            
            //this.BackgroundImage.Size = new Size(ClientSize.Width -2 , ClientSize.Height -2 );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(1, 1, ClientSize.Width - 3, ClientSize.Height - 3);
            this.Region = new Region(grPath);
            this.BackColor = Color.Green;
            base.OnPaint(e);
        }
    }
}