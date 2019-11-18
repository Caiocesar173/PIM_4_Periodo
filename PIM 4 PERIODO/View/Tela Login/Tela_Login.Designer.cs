namespace PIM_4_Periodo.View
{
    partial class Tela_Login
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
            Bunifu.Framework.UI.BunifuFlatButton Entrar_Btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.Exit_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Senha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_Usuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_Senha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DragCtrl_Logo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Picture_Logo = new System.Windows.Forms.PictureBox();
            this.Elipse_TelaLogin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_LoginImg = new System.Windows.Forms.Panel();
            this.Elipse_Entrar_btn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label_Error = new System.Windows.Forms.Label();
            Entrar_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrar_Btn
            // 
            Entrar_Btn.Active = false;
            Entrar_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Entrar_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Entrar_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Entrar_Btn.BorderRadius = 0;
            Entrar_Btn.ButtonText = "  Entrar";
            Entrar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            Entrar_Btn.DisabledColor = System.Drawing.Color.Transparent;
            Entrar_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Entrar_Btn.Iconcolor = System.Drawing.Color.Transparent;
            Entrar_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Entrar_Btn.Iconimage")));
            Entrar_Btn.Iconimage_right = null;
            Entrar_Btn.Iconimage_right_Selected = null;
            Entrar_Btn.Iconimage_Selected = null;
            Entrar_Btn.IconMarginLeft = 0;
            Entrar_Btn.IconMarginRight = 0;
            Entrar_Btn.IconRightVisible = true;
            Entrar_Btn.IconRightZoom = 0D;
            Entrar_Btn.IconVisible = true;
            Entrar_Btn.IconZoom = 40D;
            Entrar_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Entrar_Btn.IsTab = false;
            Entrar_Btn.Location = new System.Drawing.Point(111, 491);
            Entrar_Btn.Margin = new System.Windows.Forms.Padding(5);
            Entrar_Btn.Name = "Entrar_Btn";
            Entrar_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Entrar_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            Entrar_Btn.OnHoverTextColor = System.Drawing.Color.Gray;
            Entrar_Btn.selected = false;
            Entrar_Btn.Size = new System.Drawing.Size(114, 50);
            Entrar_Btn.TabIndex = 3;
            Entrar_Btn.Text = "  Entrar";
            Entrar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Entrar_Btn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            Entrar_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Entrar_Btn.Click += new System.EventHandler(this.Entra_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Active = false;
            this.Exit_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(228)))), ((int)(((byte)(253)))));
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_Button.BorderRadius = 0;
            this.Exit_Button.ButtonText = "x";
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Exit_Button.Iconcolor = System.Drawing.Color.WhiteSmoke;
            this.Exit_Button.Iconimage = null;
            this.Exit_Button.Iconimage_right = null;
            this.Exit_Button.Iconimage_right_Selected = null;
            this.Exit_Button.Iconimage_Selected = null;
            this.Exit_Button.IconMarginLeft = 0;
            this.Exit_Button.IconMarginRight = 0;
            this.Exit_Button.IconRightVisible = true;
            this.Exit_Button.IconRightZoom = 0D;
            this.Exit_Button.IconVisible = true;
            this.Exit_Button.IconZoom = 90D;
            this.Exit_Button.IsTab = false;
            this.Exit_Button.Location = new System.Drawing.Point(297, 0);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Exit_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.Exit_Button.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.Exit_Button.selected = false;
            this.Exit_Button.Size = new System.Drawing.Size(47, 23);
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.Text = "x";
            this.Exit_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Button.Textcolor = System.Drawing.Color.Gainsboro;
            this.Exit_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Usuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.txt_Usuario.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Usuario.HintText = "Username";
            this.txt_Usuario.isPassword = false;
            this.txt_Usuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Usuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Usuario.LineThickness = 2;
            this.txt_Usuario.Location = new System.Drawing.Point(13, 336);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.MaxLength = 32767;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(319, 46);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Usuario.OnValueChanged += new System.EventHandler(this.Txt_Usuario_OnValueChanged);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Senha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Senha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Senha.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_Senha.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.ForeColor = System.Drawing.Color.Silver;
            this.txt_Senha.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Senha.HintText = "Password";
            this.txt_Senha.isPassword = true;
            this.txt_Senha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Senha.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Senha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Senha.LineThickness = 2;
            this.txt_Senha.Location = new System.Drawing.Point(13, 404);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Senha.MaxLength = 32767;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(319, 46);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Senha.OnValueChanged += new System.EventHandler(this.Txt_Senha_OnValueChanged);
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.Label_Usuario.Location = new System.Drawing.Point(9, 311);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(146, 21);
            this.Label_Usuario.TabIndex = 14;
            this.Label_Usuario.Text = "Nome de Usuário:";
            this.Label_Usuario.Click += new System.EventHandler(this.Label_Usuario_Click);
            // 
            // Label_Senha
            // 
            this.Label_Senha.AutoSize = true;
            this.Label_Senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Senha.ForeColor = System.Drawing.Color.Silver;
            this.Label_Senha.Location = new System.Drawing.Point(9, 386);
            this.Label_Senha.Name = "Label_Senha";
            this.Label_Senha.Size = new System.Drawing.Size(63, 21);
            this.Label_Senha.TabIndex = 15;
            this.Label_Senha.Text = "Senha:";
            // 
            // DragCtrl_Logo
            // 
            this.DragCtrl_Logo.Fixed = true;
            this.DragCtrl_Logo.Horizontal = true;
            this.DragCtrl_Logo.TargetControl = this.Picture_Logo;
            this.DragCtrl_Logo.Vertical = true;
            // 
            // Picture_Logo
            // 
            this.Picture_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Logo.Image")));
            this.Picture_Logo.Location = new System.Drawing.Point(19, 31);
            this.Picture_Logo.Name = "Picture_Logo";
            this.Picture_Logo.Size = new System.Drawing.Size(299, 200);
            this.Picture_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Logo.TabIndex = 0;
            this.Picture_Logo.TabStop = false;
            // 
            // Elipse_TelaLogin
            // 
            this.Elipse_TelaLogin.ElipseRadius = 5;
            this.Elipse_TelaLogin.TargetControl = this;
            // 
            // Panel_LoginImg
            // 
            this.Panel_LoginImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_LoginImg.BackgroundImage")));
            this.Panel_LoginImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_LoginImg.Location = new System.Drawing.Point(-1, 239);
            this.Panel_LoginImg.Name = "Panel_LoginImg";
            this.Panel_LoginImg.Size = new System.Drawing.Size(345, 53);
            this.Panel_LoginImg.TabIndex = 16;
            // 
            // Elipse_Entrar_btn
            // 
            this.Elipse_Entrar_btn.ElipseRadius = 3;
            this.Elipse_Entrar_btn.TargetControl = Entrar_Btn;
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.BackColor = System.Drawing.Color.Transparent;
            this.Label_Error.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Error.ForeColor = System.Drawing.Color.Firebrick;
            this.Label_Error.Location = new System.Drawing.Point(47, 460);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(244, 23);
            this.Label_Error.TabIndex = 17;
            this.Label_Error.Text = "Login ou Senha Incorretos";
            this.Label_Error.Visible = false;
            this.Label_Error.Click += new System.EventHandler(this.Label_Error_Click);
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(345, 573);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.Panel_LoginImg);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(Entrar_Btn);
            this.Controls.Add(this.Label_Senha);
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.Picture_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tela_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Login1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Tela_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Logo;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_Button;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Senha;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Usuario;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Senha;
        private Bunifu.Framework.UI.BunifuDragControl DragCtrl_Logo;
        private Bunifu.Framework.UI.BunifuElipse Elipse_TelaLogin;
        private System.Windows.Forms.Panel Panel_LoginImg;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Entrar_btn;
        private System.Windows.Forms.Label Label_Error;
    }
}