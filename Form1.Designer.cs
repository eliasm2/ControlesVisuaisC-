namespace Controles_Visuais
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRótulo = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.chkOp = new System.Windows.Forms.CheckBox();
            this.cboOpções = new System.Windows.Forms.ComboBox();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.scrMudaCor = new System.Windows.Forms.VScrollBar();
            this.btnSelecionaItem = new System.Windows.Forms.Button();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.pnlOpões = new System.Windows.Forms.Panel();
            this.rdoOpcC = new System.Windows.Forms.RadioButton();
            this.rdoOpcB = new System.Windows.Forms.RadioButton();
            this.rdoOpcA = new System.Windows.Forms.RadioButton();
            this.mtxtTexto = new System.Windows.Forms.MaskedTextBox();
            this.calCalendário = new System.Windows.Forms.MonthCalendar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbarContagem = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.trkRolagem = new System.Windows.Forms.TrackBar();
            this.txtRolagem = new System.Windows.Forms.TextBox();
            this.lnkPUCMinas = new System.Windows.Forms.LinkLabel();
            this.BarraMenus = new System.Windows.Forms.MenuStrip();
            this.menuAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçãoA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçãoA2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçãoA21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçãoA22ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.opçãoA3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçãoB1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçãoB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraFerramentas = new System.Windows.Forms.MenuStrip();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.pnlOpões.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRolagem)).BeginInit();
            this.BarraMenus.SuspendLayout();
            this.BarraFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRótulo
            // 
            this.lblRótulo.AutoSize = true;
            this.lblRótulo.Location = new System.Drawing.Point(16, 97);
            this.lblRótulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRótulo.Name = "lblRótulo";
            this.lblRótulo.Size = new System.Drawing.Size(88, 17);
            this.lblRótulo.TabIndex = 0;
            this.lblRótulo.Text = "Label/Rótulo";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(20, 117);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(375, 22);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.Text = "Caixa de Texto";
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(404, 117);
            this.btnMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(100, 28);
            this.btnMensagem.TabIndex = 2;
            this.btnMensagem.Text = "Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // chkOp
            // 
            this.chkOp.AutoSize = true;
            this.chkOp.Location = new System.Drawing.Point(560, 122);
            this.chkOp.Margin = new System.Windows.Forms.Padding(4);
            this.chkOp.Name = "chkOp";
            this.chkOp.Size = new System.Drawing.Size(150, 21);
            this.chkOp.TabIndex = 3;
            this.chkOp.Text = "Selecione a Opção";
            this.chkOp.UseVisualStyleBackColor = true;
            this.chkOp.CheckedChanged += new System.EventHandler(this.chkOp_CheckedChanged);
            // 
            // cboOpções
            // 
            this.cboOpções.FormattingEnabled = true;
            this.cboOpções.Items.AddRange(new object[] {
            "Opção de Seleção I",
            "Opção de Seleção II",
            "Opção de Seleção III",
            "Opção de Seleção IV",
            "Opção de Seleção V",
            "Opção de Seleção VI",
            "Opção de Seleção VII",
            "Opção de Seleção VIII",
            "Opção de Seleção IX",
            "Opção de Seleção X"});
            this.cboOpções.Location = new System.Drawing.Point(560, 320);
            this.cboOpções.Margin = new System.Windows.Forms.Padding(4);
            this.cboOpções.Name = "cboOpções";
            this.cboOpções.Size = new System.Drawing.Size(203, 24);
            this.cboOpções.TabIndex = 4;
            this.cboOpções.Text = "Selecione...";
            this.cboOpções.SelectedIndexChanged += new System.EventHandler(this.cmbOpções_SelectedIndexChanged);
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.ItemHeight = 16;
            this.lstItens.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5",
            "Item 6",
            "Item 7",
            "Item 8",
            "Item 9",
            "Item 10"});
            this.lstItens.Location = new System.Drawing.Point(560, 166);
            this.lstItens.Margin = new System.Windows.Forms.Padding(4);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(203, 84);
            this.lstItens.TabIndex = 5;
            // 
            // scrMudaCor
            // 
            this.scrMudaCor.LargeChange = 1;
            this.scrMudaCor.Location = new System.Drawing.Point(20, 166);
            this.scrMudaCor.Maximum = 9;
            this.scrMudaCor.Name = "scrMudaCor";
            this.scrMudaCor.Size = new System.Drawing.Size(18, 298);
            this.scrMudaCor.TabIndex = 6;
            this.scrMudaCor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // btnSelecionaItem
            // 
            this.btnSelecionaItem.Location = new System.Drawing.Point(560, 258);
            this.btnSelecionaItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionaItem.Name = "btnSelecionaItem";
            this.btnSelecionaItem.Size = new System.Drawing.Size(204, 28);
            this.btnSelecionaItem.TabIndex = 7;
            this.btnSelecionaItem.Text = "Seleciona Item";
            this.btnSelecionaItem.UseVisualStyleBackColor = true;
            this.btnSelecionaItem.Click += new System.EventHandler(this.btnSelecionaItem_Click);
            // 
            // pctImagem
            // 
            this.pctImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pctImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImagem.Image = ((System.Drawing.Image)(resources.GetObject("pctImagem.Image")));
            this.pctImagem.Location = new System.Drawing.Point(48, 166);
            this.pctImagem.Margin = new System.Windows.Forms.Padding(4);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(455, 297);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImagem.TabIndex = 8;
            this.pctImagem.TabStop = false;
            // 
            // pnlOpões
            // 
            this.pnlOpões.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlOpões.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpões.Controls.Add(this.rdoOpcC);
            this.pnlOpões.Controls.Add(this.rdoOpcB);
            this.pnlOpões.Controls.Add(this.rdoOpcA);
            this.pnlOpões.Location = new System.Drawing.Point(560, 378);
            this.pnlOpões.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOpões.Name = "pnlOpões";
            this.pnlOpões.Size = new System.Drawing.Size(203, 86);
            this.pnlOpões.TabIndex = 9;
            // 
            // rdoOpcC
            // 
            this.rdoOpcC.AutoSize = true;
            this.rdoOpcC.Location = new System.Drawing.Point(4, 60);
            this.rdoOpcC.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOpcC.Name = "rdoOpcC";
            this.rdoOpcC.Size = new System.Drawing.Size(84, 21);
            this.rdoOpcC.TabIndex = 2;
            this.rdoOpcC.TabStop = true;
            this.rdoOpcC.Text = "Opção C";
            this.rdoOpcC.UseVisualStyleBackColor = true;
            this.rdoOpcC.CheckedChanged += new System.EventHandler(this.rdoOpcC_CheckedChanged_1);
            // 
            // rdoOpcB
            // 
            this.rdoOpcB.AutoSize = true;
            this.rdoOpcB.Location = new System.Drawing.Point(4, 32);
            this.rdoOpcB.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOpcB.Name = "rdoOpcB";
            this.rdoOpcB.Size = new System.Drawing.Size(84, 21);
            this.rdoOpcB.TabIndex = 1;
            this.rdoOpcB.TabStop = true;
            this.rdoOpcB.Text = "Opção B";
            this.rdoOpcB.UseVisualStyleBackColor = true;
            this.rdoOpcB.CheckedChanged += new System.EventHandler(this.rdoOpcB_CheckedChanged);
            // 
            // rdoOpcA
            // 
            this.rdoOpcA.AutoSize = true;
            this.rdoOpcA.Location = new System.Drawing.Point(4, 4);
            this.rdoOpcA.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOpcA.Name = "rdoOpcA";
            this.rdoOpcA.Size = new System.Drawing.Size(84, 21);
            this.rdoOpcA.TabIndex = 0;
            this.rdoOpcA.TabStop = true;
            this.rdoOpcA.Text = "Opção A";
            this.rdoOpcA.UseVisualStyleBackColor = true;
            this.rdoOpcA.CheckedChanged += new System.EventHandler(this.rdoOpcA_CheckedChanged);
            // 
            // mtxtTexto
            // 
            this.mtxtTexto.Location = new System.Drawing.Point(821, 186);
            this.mtxtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTexto.Mask = "(99) 0000.0000";
            this.mtxtTexto.Name = "mtxtTexto";
            this.mtxtTexto.Size = new System.Drawing.Size(159, 22);
            this.mtxtTexto.TabIndex = 10;
            // 
            // calCalendário
            // 
            this.calCalendário.Location = new System.Drawing.Point(821, 265);
            this.calCalendário.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calCalendário.Name = "calCalendário";
            this.calCalendário.TabIndex = 11;
            this.calCalendário.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calCalendário_DateChanged);
            this.calCalendário.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calCalendário_DateSelected);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(821, 122);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(821, 225);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(159, 22);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Masked TextBox";
            // 
            // pbarContagem
            // 
            this.pbarContagem.Location = new System.Drawing.Point(128, 510);
            this.pbarContagem.Margin = new System.Windows.Forms.Padding(4);
            this.pbarContagem.Name = "pbarContagem";
            this.pbarContagem.Size = new System.Drawing.Size(376, 28);
            this.pbarContagem.Step = 1;
            this.pbarContagem.TabIndex = 15;
            this.pbarContagem.UseWaitCursor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(20, 510);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 28);
            this.btnIniciar.TabIndex = 16;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // trkRolagem
            // 
            this.trkRolagem.Location = new System.Drawing.Point(560, 482);
            this.trkRolagem.Margin = new System.Windows.Forms.Padding(4);
            this.trkRolagem.Maximum = 100;
            this.trkRolagem.Name = "trkRolagem";
            this.trkRolagem.Size = new System.Drawing.Size(204, 56);
            this.trkRolagem.TabIndex = 17;
            this.trkRolagem.Scroll += new System.EventHandler(this.trkRolagem_Scroll);
            // 
            // txtRolagem
            // 
            this.txtRolagem.Location = new System.Drawing.Point(565, 513);
            this.txtRolagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtRolagem.Name = "txtRolagem";
            this.txtRolagem.Size = new System.Drawing.Size(197, 22);
            this.txtRolagem.TabIndex = 18;
            this.txtRolagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnkPUCMinas
            // 
            this.lnkPUCMinas.AutoSize = true;
            this.lnkPUCMinas.Location = new System.Drawing.Point(817, 522);
            this.lnkPUCMinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkPUCMinas.Name = "lnkPUCMinas";
            this.lnkPUCMinas.Size = new System.Drawing.Size(77, 17);
            this.lnkPUCMinas.TabIndex = 19;
            this.lnkPUCMinas.TabStop = true;
            this.lnkPUCMinas.Text = "PUC Minas";
            this.lnkPUCMinas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPUCMinas_LinkClicked);
            // 
            // BarraMenus
            // 
            this.BarraMenus.AutoSize = false;
            this.BarraMenus.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BarraMenus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.BarraMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAToolStripMenuItem,
            this.menuBToolStripMenuItem});
            this.BarraMenus.Location = new System.Drawing.Point(0, 0);
            this.BarraMenus.Name = "BarraMenus";
            this.BarraMenus.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.BarraMenus.Size = new System.Drawing.Size(1144, 39);
            this.BarraMenus.TabIndex = 22;
            this.BarraMenus.Text = "menuStrip1";
            // 
            // menuAToolStripMenuItem
            // 
            this.menuAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçãoA1ToolStripMenuItem,
            this.opçãoA2ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.opçãoA3ToolStripMenuItem});
            this.menuAToolStripMenuItem.Name = "menuAToolStripMenuItem";
            this.menuAToolStripMenuItem.Size = new System.Drawing.Size(72, 35);
            this.menuAToolStripMenuItem.Text = "Menu A";
            this.menuAToolStripMenuItem.Click += new System.EventHandler(this.menuAToolStripMenuItem_Click);
            // 
            // opçãoA1ToolStripMenuItem
            // 
            this.opçãoA1ToolStripMenuItem.Name = "opçãoA1ToolStripMenuItem";
            this.opçãoA1ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.opçãoA1ToolStripMenuItem.Text = "Opção a1";
            // 
            // opçãoA2ToolStripMenuItem
            // 
            this.opçãoA2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçãoA21ToolStripMenuItem,
            this.opçãoA22ToolStripMenuItem});
            this.opçãoA2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opçãoA2ToolStripMenuItem.Image")));
            this.opçãoA2ToolStripMenuItem.Name = "opçãoA2ToolStripMenuItem";
            this.opçãoA2ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.opçãoA2ToolStripMenuItem.Text = "Opção a2";
            // 
            // opçãoA21ToolStripMenuItem
            // 
            this.opçãoA21ToolStripMenuItem.Name = "opçãoA21ToolStripMenuItem";
            this.opçãoA21ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.opçãoA21ToolStripMenuItem.Text = "Opção a21";
            this.opçãoA21ToolStripMenuItem.Click += new System.EventHandler(this.opçãoA21ToolStripMenuItem_Click);
            // 
            // opçãoA22ToolStripMenuItem
            // 
            this.opçãoA22ToolStripMenuItem.Name = "opçãoA22ToolStripMenuItem";
            this.opçãoA22ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.opçãoA22ToolStripMenuItem.Text = "Opção a22";
            this.opçãoA22ToolStripMenuItem.Click += new System.EventHandler(this.opçãoA22ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // opçãoA3ToolStripMenuItem
            // 
            this.opçãoA3ToolStripMenuItem.Name = "opçãoA3ToolStripMenuItem";
            this.opçãoA3ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.opçãoA3ToolStripMenuItem.Text = "Opção a3";
            // 
            // menuBToolStripMenuItem
            // 
            this.menuBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçãoB1ToolStripMenuItem,
            this.opçãoB2ToolStripMenuItem});
            this.menuBToolStripMenuItem.Name = "menuBToolStripMenuItem";
            this.menuBToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.menuBToolStripMenuItem.Text = "Menu B";
            // 
            // opçãoB1ToolStripMenuItem
            // 
            this.opçãoB1ToolStripMenuItem.Name = "opçãoB1ToolStripMenuItem";
            this.opçãoB1ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.opçãoB1ToolStripMenuItem.Text = "Opção b1";
            // 
            // opçãoB2ToolStripMenuItem
            // 
            this.opçãoB2ToolStripMenuItem.Name = "opçãoB2ToolStripMenuItem";
            this.opçãoB2ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.opçãoB2ToolStripMenuItem.Text = "Opção b2";
            // 
            // BarraFerramentas
            // 
            this.BarraFerramentas.AutoSize = false;
            this.BarraFerramentas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BarraFerramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.BarraFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaToolStripMenuItem,
            this.bbbToolStripMenuItem,
            this.toolStripMenuItem2});
            this.BarraFerramentas.Location = new System.Drawing.Point(0, 39);
            this.BarraFerramentas.Name = "BarraFerramentas";
            this.BarraFerramentas.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.BarraFerramentas.Size = new System.Drawing.Size(1144, 41);
            this.BarraFerramentas.TabIndex = 24;
            this.BarraFerramentas.Text = "menuStrip1";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aaToolStripMenuItem.Image")));
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(28, 37);
            // 
            // bbbToolStripMenuItem
            // 
            this.bbbToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bbbToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bbbToolStripMenuItem.Image")));
            this.bbbToolStripMenuItem.Name = "bbbToolStripMenuItem";
            this.bbbToolStripMenuItem.Size = new System.Drawing.Size(28, 37);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 37);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1144, 551);
            this.Controls.Add(this.BarraFerramentas);
            this.Controls.Add(this.BarraMenus);
            this.Controls.Add(this.lnkPUCMinas);
            this.Controls.Add(this.txtRolagem);
            this.Controls.Add(this.trkRolagem);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pbarContagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.calCalendário);
            this.Controls.Add(this.mtxtTexto);
            this.Controls.Add(this.pnlOpões);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnSelecionaItem);
            this.Controls.Add(this.scrMudaCor);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.cboOpções);
            this.Controls.Add(this.chkOp);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblRótulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Título do Formulário";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.pnlOpões.ResumeLayout(false);
            this.pnlOpões.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRolagem)).EndInit();
            this.BarraMenus.ResumeLayout(false);
            this.BarraMenus.PerformLayout();
            this.BarraFerramentas.ResumeLayout(false);
            this.BarraFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRótulo;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.CheckBox chkOp;
        private System.Windows.Forms.ComboBox cboOpções;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.VScrollBar scrMudaCor;
        private System.Windows.Forms.Button btnSelecionaItem;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Panel pnlOpões;
        private System.Windows.Forms.RadioButton rdoOpcC;
        private System.Windows.Forms.RadioButton rdoOpcB;
        private System.Windows.Forms.RadioButton rdoOpcA;
        private System.Windows.Forms.MaskedTextBox mtxtTexto;
        private System.Windows.Forms.MonthCalendar calCalendário;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbarContagem;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TrackBar trkRolagem;
        private System.Windows.Forms.TextBox txtRolagem;
        private System.Windows.Forms.LinkLabel lnkPUCMinas;
        private System.Windows.Forms.MenuStrip BarraMenus;
        private System.Windows.Forms.ToolStripMenuItem menuAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçãoA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçãoA2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçãoA21ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçãoA22ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opçãoA3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçãoB1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçãoB2ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip BarraFerramentas;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bbbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

