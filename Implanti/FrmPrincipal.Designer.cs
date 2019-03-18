namespace Implanti
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolBar = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolBarStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTroco = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTroco = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tmrRegistro = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblValor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolBarStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.ContextMenuStrip = this.toolBarStrip;
            this.toolBar.Text = "Implanti";
            this.toolBar.Visible = true;
            this.toolBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // toolBarStrip
            // 
            this.toolBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.toolBarStrip.Name = "contextMenuStrip1";
            this.toolBarStrip.Size = new System.Drawing.Size(94, 26);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qual foi o valor pago?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblValor);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnTroco);
            this.panel2.Controls.Add(this.txtTroco);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 295);
            this.panel2.TabIndex = 3;
            this.panel2.VisibleChanged += new System.EventHandler(this.panel2_VisibleChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Implanti.Properties.Resources.logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnTroco
            // 
            this.btnTroco.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTroco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTroco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTroco.BorderRadius = 5;
            this.btnTroco.ButtonText = "Confirmar";
            this.btnTroco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTroco.DisabledColor = System.Drawing.Color.Gray;
            this.btnTroco.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTroco.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTroco.Iconimage")));
            this.btnTroco.Iconimage_right = null;
            this.btnTroco.Iconimage_right_Selected = null;
            this.btnTroco.Iconimage_Selected = null;
            this.btnTroco.IconMarginLeft = 0;
            this.btnTroco.IconMarginRight = 0;
            this.btnTroco.IconRightVisible = true;
            this.btnTroco.IconRightZoom = 0D;
            this.btnTroco.IconVisible = true;
            this.btnTroco.IconZoom = 90D;
            this.btnTroco.IsTab = false;
            this.btnTroco.Location = new System.Drawing.Point(170, 206);
            this.btnTroco.Name = "btnTroco";
            this.btnTroco.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTroco.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTroco.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTroco.selected = false;
            this.btnTroco.Size = new System.Drawing.Size(296, 48);
            this.btnTroco.TabIndex = 5;
            this.btnTroco.Text = "Confirmar";
            this.btnTroco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroco.Textcolor = System.Drawing.Color.White;
            this.btnTroco.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroco.Click += new System.EventHandler(this.btnTroco_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTroco.HintForeColor = System.Drawing.Color.Empty;
            this.txtTroco.HintText = "Digite o valor";
            this.txtTroco.isPassword = false;
            this.txtTroco.LineFocusedColor = System.Drawing.SystemColors.GrayText;
            this.txtTroco.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.txtTroco.LineMouseHoverColor = System.Drawing.SystemColors.GrayText;
            this.txtTroco.LineThickness = 3;
            this.txtTroco.Location = new System.Drawing.Point(168, 118);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(296, 44);
            this.txtTroco.TabIndex = 4;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTroco.OnValueChanged += new System.EventHandler(this.txtTroco_OnValueChanged);
            // 
            // tmrRegistro
            // 
            this.tmrRegistro.Interval = 5000;
            this.tmrRegistro.Tick += new System.EventHandler(this.tmrRegistro_Tick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(167, 47);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(139, 25);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "O troco é: R$";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(312, 47);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 25);
            this.lblValor.TabIndex = 8;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.toolBarStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon toolBar;
        private System.Windows.Forms.ContextMenuStrip toolBarStrip;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTroco;
        private Bunifu.Framework.UI.BunifuFlatButton btnTroco;
        private System.Windows.Forms.Timer tmrRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblValor;
    }
}

