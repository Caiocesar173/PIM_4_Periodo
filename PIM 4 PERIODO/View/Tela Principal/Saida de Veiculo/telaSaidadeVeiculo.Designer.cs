namespace PIM_4_PERIODO.View.__Tela_Principal__.Saida_de_Veiculo
{
    partial class telaSaidadeVeiculo
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
            Bunifu.Framework.UI.BunifuFlatButton Bnt_Registrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaSaidadeVeiculo));
            this.Label_Usuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxTBox_Placa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxTBox_Horario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bnt_Registrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.Label_Usuario.Location = new System.Drawing.Point(12, 167);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(122, 20);
            this.Label_Usuario.TabIndex = 16;
            this.Label_Usuario.Text = "Placa do veículo";
            // 
            // TxTBox_Placa
            // 
            this.TxTBox_Placa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxTBox_Placa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxTBox_Placa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxTBox_Placa.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxTBox_Placa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTBox_Placa.ForeColor = System.Drawing.Color.Silver;
            this.TxTBox_Placa.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.TxTBox_Placa.HintText = "Informe o placa ";
            this.TxTBox_Placa.isPassword = false;
            this.TxTBox_Placa.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.TxTBox_Placa.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.TxTBox_Placa.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.TxTBox_Placa.LineThickness = 4;
            this.TxTBox_Placa.Location = new System.Drawing.Point(141, 155);
            this.TxTBox_Placa.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_Placa.MaxLength = 32767;
            this.TxTBox_Placa.Name = "TxTBox_Placa";
            this.TxTBox_Placa.Size = new System.Drawing.Size(316, 46);
            this.TxTBox_Placa.TabIndex = 15;
            this.TxTBox_Placa.Text = "Informe a placa";
            this.TxTBox_Placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxTBox_Placa.OnValueChanged += new System.EventHandler(this.TxTBox_Placa_OnValueChanged);
            // 
            // TxTBox_Horario
            // 
            this.TxTBox_Horario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxTBox_Horario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxTBox_Horario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxTBox_Horario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxTBox_Horario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTBox_Horario.ForeColor = System.Drawing.Color.Silver;
            this.TxTBox_Horario.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.TxTBox_Horario.HintText = "Informe o placa ";
            this.TxTBox_Horario.isPassword = false;
            this.TxTBox_Horario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.TxTBox_Horario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.TxTBox_Horario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.TxTBox_Horario.LineThickness = 4;
            this.TxTBox_Horario.Location = new System.Drawing.Point(141, 235);
            this.TxTBox_Horario.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_Horario.MaxLength = 32767;
            this.TxTBox_Horario.Name = "TxTBox_Horario";
            this.TxTBox_Horario.Size = new System.Drawing.Size(183, 45);
            this.TxTBox_Horario.TabIndex = 17;
            this.TxTBox_Horario.Text = "Informe o horário";
            this.TxTBox_Horario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(64, 248);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(61, 20);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Horário";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(172, 82);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(193, 20);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "Informe a saida do veículo";
            // 
            // Bnt_Registrar
            // 
            Bnt_Registrar.Active = false;
            Bnt_Registrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Bnt_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Bnt_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Bnt_Registrar.BorderRadius = 0;
            Bnt_Registrar.ButtonText = "  Registrar";
            Bnt_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            Bnt_Registrar.DisabledColor = System.Drawing.Color.Transparent;
            Bnt_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Bnt_Registrar.Iconcolor = System.Drawing.Color.Transparent;
            Bnt_Registrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Bnt_Registrar.Iconimage")));
            Bnt_Registrar.Iconimage_right = null;
            Bnt_Registrar.Iconimage_right_Selected = null;
            Bnt_Registrar.Iconimage_Selected = null;
            Bnt_Registrar.IconMarginLeft = 0;
            Bnt_Registrar.IconMarginRight = 0;
            Bnt_Registrar.IconRightVisible = true;
            Bnt_Registrar.IconRightZoom = 0D;
            Bnt_Registrar.IconVisible = true;
            Bnt_Registrar.IconZoom = 40D;
            Bnt_Registrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Bnt_Registrar.IsTab = false;
            Bnt_Registrar.Location = new System.Drawing.Point(179, 319);
            Bnt_Registrar.Margin = new System.Windows.Forms.Padding(5);
            Bnt_Registrar.Name = "Bnt_Registrar";
            Bnt_Registrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Bnt_Registrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            Bnt_Registrar.OnHoverTextColor = System.Drawing.Color.Gray;
            Bnt_Registrar.selected = false;
            Bnt_Registrar.Size = new System.Drawing.Size(145, 50);
            Bnt_Registrar.TabIndex = 20;
            Bnt_Registrar.Text = "  Registrar";
            Bnt_Registrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Bnt_Registrar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            Bnt_Registrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // telaSaidadeVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::PIM_4_PERIODO.Properties.Resources.caminhão;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 422);
            this.Controls.Add(Bnt_Registrar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.TxTBox_Horario);
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.TxTBox_Placa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaSaidadeVeiculo";
            this.Text = "telaSaidadeVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Label_Usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_Placa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_Horario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}