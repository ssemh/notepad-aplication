namespace NotepadApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private ToolStripSeparator separator1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripSeparator separator2;
        private ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private ToolStripMenuItem biçimToolStripMenuItem;
        private ToolStripMenuItem yazıTipiToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private TextBox textBoxContent;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip = new MenuStrip();
            this.dosyaToolStripMenuItem = new ToolStripMenuItem();
            this.yeniToolStripMenuItem = new ToolStripMenuItem();
            this.açToolStripMenuItem = new ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
            this.separator1 = new ToolStripSeparator();
            this.çıkışToolStripMenuItem = new ToolStripMenuItem();
            this.düzenToolStripMenuItem = new ToolStripMenuItem();
            this.kesToolStripMenuItem = new ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new ToolStripMenuItem();
            this.separator2 = new ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new ToolStripMenuItem();
            this.biçimToolStripMenuItem = new ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new ToolStripMenuItem();
            this.yardımToolStripMenuItem = new ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new ToolStripMenuItem();
            this.textBoxContent = new TextBox();
            this.statusStrip = new StatusStrip();
            this.statusLabel = new ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new ToolStripItem[] {
                this.dosyaToolStripMenuItem,
                this.düzenToolStripMenuItem,
                this.biçimToolStripMenuItem,
                this.yardımToolStripMenuItem
            });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            // dosyaToolStripMenuItem
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.yeniToolStripMenuItem,
                this.açToolStripMenuItem,
                this.kaydetToolStripMenuItem,
                this.farklıKaydetToolStripMenuItem,
                this.separator1,
                this.çıkışToolStripMenuItem
            });
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";

            // yeniToolStripMenuItem
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);

            // açToolStripMenuItem
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.açToolStripMenuItem.Text = "Aç...";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);

            // kaydetToolStripMenuItem
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);

            // farklıKaydetToolStripMenuItem
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S)));
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet...";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);

            // separator1
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(197, 6);

            // çıkışToolStripMenuItem
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);

            // düzenToolStripMenuItem
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.kesToolStripMenuItem,
                this.kopyalaToolStripMenuItem,
                this.yapıştırToolStripMenuItem,
                this.separator2,
                this.tümünüSeçToolStripMenuItem
            });
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";

            // kesToolStripMenuItem
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);

            // kopyalaToolStripMenuItem
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);

            // yapıştırToolStripMenuItem
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);

            // separator2
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(197, 6);

            // tümünüSeçToolStripMenuItem
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);

            // biçimToolStripMenuItem
            this.biçimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.yazıTipiToolStripMenuItem
            });
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.biçimToolStripMenuItem.Text = "Biçim";

            // yazıTipiToolStripMenuItem
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi...";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);

            // yardımToolStripMenuItem
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.hakkındaToolStripMenuItem
            });
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";

            // hakkındaToolStripMenuItem
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);

            // textBoxContent
            this.textBoxContent.Dock = DockStyle.Fill;
            this.textBoxContent.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContent.Location = new System.Drawing.Point(0, 24);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = ScrollBars.Both;
            this.textBoxContent.Size = new System.Drawing.Size(800, 426);
            this.textBoxContent.TabIndex = 1;
            this.textBoxContent.TextChanged += new System.EventHandler(this.textBoxContent_TextChanged);
            this.textBoxContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxContent_MouseUp);
            this.textBoxContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxContent_KeyUp);

            // statusStrip
            this.statusStrip.Items.AddRange(new ToolStripItem[] {
                this.statusLabel
            });
            this.statusStrip.Location = new System.Drawing.Point(0, 450);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";

            // statusLabel
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(785, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Not Defteri";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Event handlers
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e) => NewFile();
        private void açToolStripMenuItem_Click(object sender, EventArgs e) => OpenFile();
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile();
        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e) => SaveFileAs();
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) => ExitApplication();
        private void kesToolStripMenuItem_Click(object sender, EventArgs e) => textBoxContent.Cut();
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e) => textBoxContent.Copy();
        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e) => textBoxContent.Paste();
        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e) => textBoxContent.SelectAll();
        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e) => SelectFont();
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e) => ShowAbout();
    }
}

