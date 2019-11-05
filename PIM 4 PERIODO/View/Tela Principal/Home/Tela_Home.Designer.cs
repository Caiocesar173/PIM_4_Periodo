namespace PIM_4_PERIODO.View.Tela_Principal.Home
{
    partial class Tela_Home
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
            this.custom_Card1 = new PIM_4_PERIODO.Model.Custom_Card();
            this.custom_Card2 = new PIM_4_PERIODO.Model.Custom_Card();
            this.customBackground1 = new PIM_4_PERIODO.Model.CustomBackground();
            this.SuspendLayout();
            // 
            // custom_Card1
            // 
            this.custom_Card1.BackColor = System.Drawing.Color.Transparent;
            this.custom_Card1.Icone = global::PIM_4_PERIODO.Properties.Resources.icone_mapa;
            this.custom_Card1.Location = new System.Drawing.Point(12, 9);
            this.custom_Card1.Name = "custom_Card1";
            this.custom_Card1.Size = new System.Drawing.Size(501, 268);
            this.custom_Card1.SubTitulo_Card = "Notificações - ";
            this.custom_Card1.TabIndex = 0;
            this.custom_Card1.Texto_Card = "";
            this.custom_Card1.Titulo_Card = "";
            // 
            // custom_Card2
            // 
            this.custom_Card2.BackColor = System.Drawing.Color.Transparent;
            this.custom_Card2.Icone = global::PIM_4_PERIODO.Properties.Resources.icone_calendario;
            this.custom_Card2.Location = new System.Drawing.Point(12, 287);
            this.custom_Card2.Name = "custom_Card2";
            this.custom_Card2.Size = new System.Drawing.Size(501, 268);
            this.custom_Card2.SubTitulo_Card = "Notificações - ";
            this.custom_Card2.TabIndex = 1;
            this.custom_Card2.Texto_Card = "";
            this.custom_Card2.Titulo_Card = "";
            // 
            // customBackground1
            // 
            this.customBackground1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.customBackground1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackground1.Location = new System.Drawing.Point(0, 0);
            this.customBackground1.Margin = new System.Windows.Forms.Padding(10);
            this.customBackground1.Name = "customBackground1";
            this.customBackground1.Size = new System.Drawing.Size(548, 565);
            this.customBackground1.TabIndex = 2;
            // 
            // Tela_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(548, 565);
            this.Controls.Add(this.custom_Card2);
            this.Controls.Add(this.custom_Card1);
            this.Controls.Add(this.customBackground1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Tela_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Model.Custom_Card custom_Card1;
        private Model.Custom_Card custom_Card2;
        private Model.CustomBackground customBackground1;
    }
}