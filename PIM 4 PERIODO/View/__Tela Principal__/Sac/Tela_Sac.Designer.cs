namespace PIM_4_PERIODO.View.__Tela_Principal__.Sac
{
    partial class Tela_Sac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuFlatButton Atendimento_Btn;
            this.Elipse_Atentimendo_Btn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Atendimento_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // Atendimento_Btn
            // 
            Atendimento_Btn.Active = false;
            Atendimento_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Atendimento_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Atendimento_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Atendimento_Btn.BorderRadius = 0;
            Atendimento_Btn.ButtonText = "Atendimento  ";
            Atendimento_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            Atendimento_Btn.DisabledColor = System.Drawing.Color.Transparent;
            Atendimento_Btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Atendimento_Btn.Iconcolor = System.Drawing.Color.Transparent;
            Atendimento_Btn.Iconimage = global::PIM_4_PERIODO.Properties.Resources.ATENDIMENTO_SEM_CIRCULO;
            Atendimento_Btn.Iconimage_right = null;
            Atendimento_Btn.Iconimage_right_Selected = null;
            Atendimento_Btn.Iconimage_Selected = null;
            Atendimento_Btn.IconMarginLeft = 0;
            Atendimento_Btn.IconMarginRight = 0;
            Atendimento_Btn.IconRightVisible = true;
            Atendimento_Btn.IconRightZoom = 0D;
            Atendimento_Btn.IconVisible = true;
            Atendimento_Btn.IconZoom = 70D;
            Atendimento_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Atendimento_Btn.IsTab = false;
            Atendimento_Btn.Location = new System.Drawing.Point(141, 326);
            Atendimento_Btn.Margin = new System.Windows.Forms.Padding(5);
            Atendimento_Btn.Name = "Atendimento_Btn";
            Atendimento_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Atendimento_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            Atendimento_Btn.OnHoverTextColor = System.Drawing.Color.Gray;
            Atendimento_Btn.selected = false;
            Atendimento_Btn.Size = new System.Drawing.Size(261, 82);
            Atendimento_Btn.TabIndex = 10;
            Atendimento_Btn.Text = "Atendimento  ";
            Atendimento_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Atendimento_Btn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            Atendimento_Btn.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Atendimento_Btn.Click += new System.EventHandler(this.Atendimento_Btn_Click);
            // 
            // Elipse_Atentimendo_Btn
            // 
            this.Elipse_Atentimendo_Btn.ElipseRadius = 80;
            this.Elipse_Atentimendo_Btn.TargetControl = Atendimento_Btn;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 248);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(548, 46);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "                     Ligue: 0800 666 1313, ou se preferir,\r\nclique no botão a bai" +
    "xo pra iniciar um novo Atendimento.\r\n";
            // 
            // Tela_Sac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(548, 657);
            this.Controls.Add(Atendimento_Btn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Sac";
            this.Text = "Tela_Sac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse Elipse_Atentimendo_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}