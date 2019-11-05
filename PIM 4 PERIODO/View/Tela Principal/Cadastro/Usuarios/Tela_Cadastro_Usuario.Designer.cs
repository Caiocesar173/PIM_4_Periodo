namespace PIM_4_PERIODO.View.Tela_Principal.Cadaastro.Usuarios
{
    partial class Tela_Cadastro_Usuario
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
            Bunifu.Framework.UI.BunifuFlatButton btn_cadastrar;
            this.Label_Matricula = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Nome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            //this.customBackground1 = new PIM_4_PERIODO.Model.CustomBackground();
            this.comboBox_Departamento = new System.Windows.Forms.ComboBox();
            this.comboBox_CategoriaCnh = new System.Windows.Forms.ComboBox();
            this.Label_Username = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_Senha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_GUID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_DatadeAdimissao = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Validade = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_CNH = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Celular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_TelefoneFixo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Cpf = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            btn_cadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            //this.customBackground1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Active = false;
            btn_cadastrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_cadastrar.BorderRadius = 0;
            btn_cadastrar.ButtonText = "Cadastrar";
            btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_cadastrar.DisabledColor = System.Drawing.Color.Transparent;
            btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_cadastrar.Iconcolor = System.Drawing.Color.Transparent;
            btn_cadastrar.Iconimage = null;
            btn_cadastrar.Iconimage_right = null;
            btn_cadastrar.Iconimage_right_Selected = null;
            btn_cadastrar.Iconimage_Selected = null;
            btn_cadastrar.IconMarginLeft = 0;
            btn_cadastrar.IconMarginRight = 0;
            btn_cadastrar.IconRightVisible = true;
            btn_cadastrar.IconRightZoom = 0D;
            btn_cadastrar.IconVisible = true;
            btn_cadastrar.IconZoom = 40D;
            btn_cadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btn_cadastrar.IsTab = false;
            btn_cadastrar.Location = new System.Drawing.Point(419, 507);
            btn_cadastrar.Margin = new System.Windows.Forms.Padding(5);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            btn_cadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            btn_cadastrar.OnHoverTextColor = System.Drawing.Color.Gray;
            btn_cadastrar.selected = false;
            btn_cadastrar.Size = new System.Drawing.Size(115, 43);
            btn_cadastrar.TabIndex = 16;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn_cadastrar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            btn_cadastrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Label_Matricula
            // 
            this.Label_Matricula.AutoSize = true;
            this.Label_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Matricula.ForeColor = System.Drawing.Color.White;
            this.Label_Matricula.Location = new System.Drawing.Point(400, 9);
            this.Label_Matricula.Name = "Label_Matricula";
            this.Label_Matricula.Size = new System.Drawing.Size(73, 20);
            this.Label_Matricula.TabIndex = 17;
            this.Label_Matricula.Text = "Matricula";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Nome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Nome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Nome.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.ForeColor = System.Drawing.Color.Silver;
            this.txt_Nome.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Nome.HintText = "Username";
            this.txt_Nome.isPassword = false;
            this.txt_Nome.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Nome.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Nome.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Nome.LineThickness = 4;
            this.txt_Nome.Location = new System.Drawing.Point(17, 24);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.MaxLength = 32767;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(141, 46);
            this.txt_Nome.TabIndex = 15;
            this.txt_Nome.Text = "Nome";
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            /*
            // 
            // customBackground1
            // 
            this.customBackground1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.customBackground1.Controls.Add(this.comboBox_Departamento);
            this.customBackground1.Controls.Add(this.comboBox_CategoriaCnh);
            this.customBackground1.Controls.Add(this.Label_Username);
            this.customBackground1.Controls.Add(this.Label_Senha);
            this.customBackground1.Controls.Add(this.Label_GUID);
            this.customBackground1.Controls.Add(this.txt_DatadeAdimissao);
            this.customBackground1.Controls.Add(this.txt_Validade);
            this.customBackground1.Controls.Add(this.txt_CNH);
            this.customBackground1.Controls.Add(this.txt_Email);
            this.customBackground1.Controls.Add(this.txt_Celular);
            this.customBackground1.Controls.Add(this.txt_TelefoneFixo);
            this.customBackground1.Controls.Add(this.txt_Cpf);
            this.customBackground1.Controls.Add(this.Label_Matricula);
            this.customBackground1.Controls.Add(btn_cadastrar);
            this.customBackground1.Controls.Add(this.txt_Nome);
            this.customBackground1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customBackground1.Location = new System.Drawing.Point(0, 0);
            this.customBackground1.Margin = new System.Windows.Forms.Padding(10);
            this.customBackground1.Name = "customBackground1";
            this.customBackground1.Size = new System.Drawing.Size(548, 564);
            this.customBackground1.TabIndex = 18;
            */
            // 
            // comboBox_Departamento
            // 
            this.comboBox_Departamento.FormattingEnabled = true;
            this.comboBox_Departamento.Location = new System.Drawing.Point(184, 496);
            this.comboBox_Departamento.Name = "comboBox_Departamento";
            this.comboBox_Departamento.Size = new System.Drawing.Size(52, 21);
            this.comboBox_Departamento.TabIndex = 30;
            // 
            // comboBox_CategoriaCnh
            // 
            this.comboBox_CategoriaCnh.FormattingEnabled = true;
            this.comboBox_CategoriaCnh.Location = new System.Drawing.Point(184, 420);
            this.comboBox_CategoriaCnh.Name = "comboBox_CategoriaCnh";
            this.comboBox_CategoriaCnh.Size = new System.Drawing.Size(52, 21);
            this.comboBox_CategoriaCnh.TabIndex = 29;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.ForeColor = System.Drawing.Color.White;
            this.Label_Username.Location = new System.Drawing.Point(400, 135);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(132, 20);
            this.Label_Username.TabIndex = 28;
            this.Label_Username.Text = "Nome de Usuario";
            // 
            // Label_Senha
            // 
            this.Label_Senha.AutoSize = true;
            this.Label_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Senha.ForeColor = System.Drawing.Color.White;
            this.Label_Senha.Location = new System.Drawing.Point(398, 93);
            this.Label_Senha.Name = "Label_Senha";
            this.Label_Senha.Size = new System.Drawing.Size(56, 20);
            this.Label_Senha.TabIndex = 27;
            this.Label_Senha.Text = "Senha";
            // 
            // Label_GUID
            // 
            this.Label_GUID.AutoSize = true;
            this.Label_GUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GUID.ForeColor = System.Drawing.Color.White;
            this.Label_GUID.Location = new System.Drawing.Point(400, 50);
            this.Label_GUID.Name = "Label_GUID";
            this.Label_GUID.Size = new System.Drawing.Size(51, 20);
            this.Label_GUID.TabIndex = 26;
            this.Label_GUID.Text = "GUID";
            // 
            // txt_DatadeAdimissao
            // 
            this.txt_DatadeAdimissao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_DatadeAdimissao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_DatadeAdimissao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_DatadeAdimissao.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_DatadeAdimissao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DatadeAdimissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DatadeAdimissao.ForeColor = System.Drawing.Color.Silver;
            this.txt_DatadeAdimissao.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_DatadeAdimissao.HintText = "Username";
            this.txt_DatadeAdimissao.isPassword = false;
            this.txt_DatadeAdimissao.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_DatadeAdimissao.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_DatadeAdimissao.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_DatadeAdimissao.LineThickness = 4;
            this.txt_DatadeAdimissao.Location = new System.Drawing.Point(17, 481);
            this.txt_DatadeAdimissao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DatadeAdimissao.MaxLength = 32767;
            this.txt_DatadeAdimissao.Name = "txt_DatadeAdimissao";
            this.txt_DatadeAdimissao.Size = new System.Drawing.Size(141, 46);
            this.txt_DatadeAdimissao.TabIndex = 24;
            this.txt_DatadeAdimissao.Text = "Data de Adimissão";
            this.txt_DatadeAdimissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Validade
            // 
            this.txt_Validade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Validade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Validade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Validade.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Validade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Validade.ForeColor = System.Drawing.Color.Silver;
            this.txt_Validade.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Validade.HintText = "Username";
            this.txt_Validade.isPassword = false;
            this.txt_Validade.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Validade.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Validade.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Validade.LineThickness = 4;
            this.txt_Validade.Location = new System.Drawing.Point(17, 404);
            this.txt_Validade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Validade.MaxLength = 32767;
            this.txt_Validade.Name = "txt_Validade";
            this.txt_Validade.Size = new System.Drawing.Size(141, 46);
            this.txt_Validade.TabIndex = 23;
            this.txt_Validade.Text = "Validade";
            this.txt_Validade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_CNH
            // 
            this.txt_CNH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CNH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_CNH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_CNH.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_CNH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CNH.ForeColor = System.Drawing.Color.Silver;
            this.txt_CNH.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_CNH.HintText = "Username";
            this.txt_CNH.isPassword = false;
            this.txt_CNH.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_CNH.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_CNH.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_CNH.LineThickness = 4;
            this.txt_CNH.Location = new System.Drawing.Point(17, 325);
            this.txt_CNH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CNH.MaxLength = 32767;
            this.txt_CNH.Name = "txt_CNH";
            this.txt_CNH.Size = new System.Drawing.Size(141, 46);
            this.txt_CNH.TabIndex = 22;
            this.txt_CNH.Text = "CNH";
            this.txt_CNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Email.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Silver;
            this.txt_Email.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Email.HintText = "Username";
            this.txt_Email.isPassword = false;
            this.txt_Email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Email.LineThickness = 4;
            this.txt_Email.Location = new System.Drawing.Point(17, 249);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.MaxLength = 32767;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(141, 46);
            this.txt_Email.TabIndex = 21;
            this.txt_Email.Text = "Email";
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Celular
            // 
            this.txt_Celular.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Celular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Celular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Celular.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Celular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Celular.ForeColor = System.Drawing.Color.Silver;
            this.txt_Celular.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Celular.HintText = "Username";
            this.txt_Celular.isPassword = false;
            this.txt_Celular.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Celular.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Celular.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Celular.LineThickness = 4;
            this.txt_Celular.Location = new System.Drawing.Point(179, 167);
            this.txt_Celular.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Celular.MaxLength = 32767;
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(126, 46);
            this.txt_Celular.TabIndex = 20;
            this.txt_Celular.Text = "Celular";
            this.txt_Celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_TelefoneFixo
            // 
            this.txt_TelefoneFixo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_TelefoneFixo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_TelefoneFixo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_TelefoneFixo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_TelefoneFixo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TelefoneFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelefoneFixo.ForeColor = System.Drawing.Color.Silver;
            this.txt_TelefoneFixo.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_TelefoneFixo.HintText = "Username";
            this.txt_TelefoneFixo.isPassword = false;
            this.txt_TelefoneFixo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_TelefoneFixo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_TelefoneFixo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_TelefoneFixo.LineThickness = 4;
            this.txt_TelefoneFixo.Location = new System.Drawing.Point(17, 167);
            this.txt_TelefoneFixo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TelefoneFixo.MaxLength = 32767;
            this.txt_TelefoneFixo.Name = "txt_TelefoneFixo";
            this.txt_TelefoneFixo.Size = new System.Drawing.Size(141, 46);
            this.txt_TelefoneFixo.TabIndex = 19;
            this.txt_TelefoneFixo.Text = "Telefone";
            this.txt_TelefoneFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Cpf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Cpf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Cpf.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Cpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cpf.ForeColor = System.Drawing.Color.Silver;
            this.txt_Cpf.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Cpf.HintText = "Username";
            this.txt_Cpf.isPassword = false;
            this.txt_Cpf.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Cpf.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.txt_Cpf.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.txt_Cpf.LineThickness = 4;
            this.txt_Cpf.Location = new System.Drawing.Point(17, 92);
            this.txt_Cpf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cpf.MaxLength = 32767;
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(141, 46);
            this.txt_Cpf.TabIndex = 18;
            this.txt_Cpf.Text = "Cpf";
            this.txt_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Tela_Cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 564);
           // this.Controls.Add(this.customBackground1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Cadastro_Usuario";
            this.Text = "Tela_Cadatro_Usuario";
           // this.customBackground1.ResumeLayout(false);
          //  this.customBackground1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Label_Matricula;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nome;
       // private Model.CustomBackground customBackground1;
        private System.Windows.Forms.ComboBox comboBox_Departamento;
        private System.Windows.Forms.ComboBox comboBox_CategoriaCnh;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Username;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Senha;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_GUID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_DatadeAdimissao;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Validade;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CNH;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Celular;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_TelefoneFixo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Cpf;
    }
}