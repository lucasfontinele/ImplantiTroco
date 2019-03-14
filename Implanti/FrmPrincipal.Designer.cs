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
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrOculta = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTroco = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTroco = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.toolBarStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.ContextMenuStrip = this.toolBarStrip;
            this.toolBar.Text = "toolBar";
            this.toolBar.Visible = true;
            this.toolBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // toolBarStrip
            // 
            this.toolBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.toolBarStrip.Name = "contextMenuStrip1";
            this.toolBarStrip.Size = new System.Drawing.Size(102, 48);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.testeToolStripMenuItem.Text = "Teste";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quanto foi pago?";
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
            this.panel2.Controls.Add(this.btnTroco);
            this.panel2.Controls.Add(this.txtTroco);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 295);
            this.panel2.TabIndex = 3;
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
            this.btnTroco.Location = new System.Drawing.Point(170, 181);
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
            this.txtTroco.HintText = "";
            this.txtTroco.isPassword = false;
            this.txtTroco.LineFocusedColor = System.Drawing.SystemColors.GrayText;
            this.txtTroco.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.txtTroco.LineMouseHoverColor = System.Drawing.SystemColors.GrayText;
            this.txtTroco.LineThickness = 3;
            this.txtTroco.Location = new System.Drawing.Point(170, 76);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(296, 44);
            this.txtTroco.TabIndex = 4;
            this.txtTroco.Text = "Digite o valor pago";
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.toolBarStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon toolBar;
        private System.Windows.Forms.ContextMenuStrip toolBarStrip;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer tmrOculta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTroco;
        private Bunifu.Framework.UI.BunifuFlatButton btnTroco;
    }
}

