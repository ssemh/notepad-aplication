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
        private ToolStripMenuItem geriAlToolStripMenuItem;
        private ToolStripMenuItem yineleToolStripMenuItem;
        private ToolStripSeparator separatorUndo;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripSeparator separator2;
        private ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private ToolStripSeparator separator3;
        private ToolStripMenuItem bulToolStripMenuItem;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ToolStripSeparator separator4;
        private ToolStripMenuItem tarihSaatToolStripMenuItem;
        private ToolStripMenuItem resimEkleToolStripMenuItem;
        private ToolStripSeparator separator5;
        private ToolStripMenuItem büyükHarfToolStripMenuItem;
        private ToolStripMenuItem küçükHarfToolStripMenuItem;
        private ToolStripMenuItem başlıkHarfToolStripMenuItem;
        private ToolStripMenuItem biçimToolStripMenuItem;
        private ToolStripMenuItem yazıTipiToolStripMenuItem;
        private ToolStripMenuItem yazıRengiToolStripMenuItem;
        private ToolStripSeparator separator7;
        private ToolStripMenuItem temaToolStripMenuItem;
        private ToolStripMenuItem açıkTemaToolStripMenuItem;
        private ToolStripMenuItem koyuTemaToolStripMenuItem;
        private ToolStripMenuItem maviTemaToolStripMenuItem;
        private ToolStripMenuItem yeşilTemaToolStripMenuItem;
        private RichTextBox textBoxContent;
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
            this.geriAlToolStripMenuItem = new ToolStripMenuItem();
            this.yineleToolStripMenuItem = new ToolStripMenuItem();
            this.separatorUndo = new ToolStripSeparator();
            this.kesToolStripMenuItem = new ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new ToolStripMenuItem();
            this.separator2 = new ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new ToolStripMenuItem();
            this.separator3 = new ToolStripSeparator();
            this.bulToolStripMenuItem = new ToolStripMenuItem();
            this.gitToolStripMenuItem = new ToolStripMenuItem();
            this.separator4 = new ToolStripSeparator();
            this.tarihSaatToolStripMenuItem = new ToolStripMenuItem();
            this.resimEkleToolStripMenuItem = new ToolStripMenuItem();
            this.separator5 = new ToolStripSeparator();
            this.büyükHarfToolStripMenuItem = new ToolStripMenuItem();
            this.küçükHarfToolStripMenuItem = new ToolStripMenuItem();
            this.başlıkHarfToolStripMenuItem = new ToolStripMenuItem();
            this.biçimToolStripMenuItem = new ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new ToolStripMenuItem();
            this.separator7 = new ToolStripSeparator();
            this.temaToolStripMenuItem = new ToolStripMenuItem();
            this.açıkTemaToolStripMenuItem = new ToolStripMenuItem();
            this.koyuTemaToolStripMenuItem = new ToolStripMenuItem();
            this.maviTemaToolStripMenuItem = new ToolStripMenuItem();
            this.yeşilTemaToolStripMenuItem = new ToolStripMenuItem();
            this.textBoxContent = new RichTextBox();
            this.statusStrip = new StatusStrip();
            this.statusLabel = new ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip.Items.AddRange(new ToolStripItem[] {
                this.dosyaToolStripMenuItem,
                this.düzenToolStripMenuItem,
                this.biçimToolStripMenuItem,
                this.temaToolStripMenuItem
            });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

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

            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);

            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.açToolStripMenuItem.Text = "Aç...";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);

            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);

            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S)));
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet...";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);

            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(197, 6);

            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);

            this.düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.geriAlToolStripMenuItem,
                this.yineleToolStripMenuItem,
                this.separatorUndo,
                this.kesToolStripMenuItem,
                this.kopyalaToolStripMenuItem,
                this.yapıştırToolStripMenuItem,
                this.separator2,
                this.tümünüSeçToolStripMenuItem,
                this.separator3,
                this.bulToolStripMenuItem,
                this.gitToolStripMenuItem,
                this.separator4,
                this.tarihSaatToolStripMenuItem,
                this.resimEkleToolStripMenuItem,
                this.separator5,
                this.büyükHarfToolStripMenuItem,
                this.küçükHarfToolStripMenuItem,
                this.başlıkHarfToolStripMenuItem
            });
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";

            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);

            this.yineleToolStripMenuItem.Name = "yineleToolStripMenuItem";
            this.yineleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.yineleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yineleToolStripMenuItem.Text = "Yinele";
            this.yineleToolStripMenuItem.Click += new System.EventHandler(this.yineleToolStripMenuItem_Click);

            this.separatorUndo.Name = "separatorUndo";
            this.separatorUndo.Size = new System.Drawing.Size(197, 6);

            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);

            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);

            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);

            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(197, 6);

            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);

            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(197, 6);

            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.bulToolStripMenuItem.Text = "Bul...";
            this.bulToolStripMenuItem.Click += new System.EventHandler(this.bulToolStripMenuItem_Click);

            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.gitToolStripMenuItem.Text = "Satıra Git...";
            this.gitToolStripMenuItem.Click += new System.EventHandler(this.gitToolStripMenuItem_Click);

            this.separator4.Name = "separator4";
            this.separator4.Size = new System.Drawing.Size(197, 6);

            this.tarihSaatToolStripMenuItem.Name = "tarihSaatToolStripMenuItem";
            this.tarihSaatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.F5)));
            this.tarihSaatToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tarihSaatToolStripMenuItem.Text = "Tarih/Saat";
            this.tarihSaatToolStripMenuItem.Click += new System.EventHandler(this.tarihSaatToolStripMenuItem_Click);

            this.resimEkleToolStripMenuItem.Name = "resimEkleToolStripMenuItem";
            this.resimEkleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.resimEkleToolStripMenuItem.Text = "Resim Ekle...";
            this.resimEkleToolStripMenuItem.Click += new System.EventHandler(this.resimEkleToolStripMenuItem_Click);

            this.separator5.Name = "separator5";
            this.separator5.Size = new System.Drawing.Size(197, 6);

            this.büyükHarfToolStripMenuItem.Name = "büyükHarfToolStripMenuItem";
            this.büyükHarfToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.büyükHarfToolStripMenuItem.Text = "Büyük Harfe Çevir";
            this.büyükHarfToolStripMenuItem.Click += new System.EventHandler(this.büyükHarfToolStripMenuItem_Click);

            this.küçükHarfToolStripMenuItem.Name = "küçükHarfToolStripMenuItem";
            this.küçükHarfToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.küçükHarfToolStripMenuItem.Text = "Küçük Harfe Çevir";
            this.küçükHarfToolStripMenuItem.Click += new System.EventHandler(this.küçükHarfToolStripMenuItem_Click);

            this.başlıkHarfToolStripMenuItem.Name = "başlıkHarfToolStripMenuItem";
            this.başlıkHarfToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.başlıkHarfToolStripMenuItem.Text = "Başlık Harfine Çevir";
            this.başlıkHarfToolStripMenuItem.Click += new System.EventHandler(this.başlıkHarfToolStripMenuItem_Click);

            this.biçimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.yazıTipiToolStripMenuItem,
                this.yazıRengiToolStripMenuItem,
                this.separator7
            });
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.biçimToolStripMenuItem.Text = "Biçim";

            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi...";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);

            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi...";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);

            this.separator7.Name = "separator7";
            this.separator7.Size = new System.Drawing.Size(149, 6);

            this.temaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.açıkTemaToolStripMenuItem,
                this.koyuTemaToolStripMenuItem,
                this.maviTemaToolStripMenuItem,
                this.yeşilTemaToolStripMenuItem
            });
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.temaToolStripMenuItem.Text = "Tema";

            this.açıkTemaToolStripMenuItem.CheckOnClick = true;
            this.açıkTemaToolStripMenuItem.Name = "açıkTemaToolStripMenuItem";
            this.açıkTemaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.açıkTemaToolStripMenuItem.Text = "Açık Tema";
            this.açıkTemaToolStripMenuItem.Click += new System.EventHandler(this.açıkTemaToolStripMenuItem_Click);

            this.koyuTemaToolStripMenuItem.CheckOnClick = true;
            this.koyuTemaToolStripMenuItem.Name = "koyuTemaToolStripMenuItem";
            this.koyuTemaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.koyuTemaToolStripMenuItem.Text = "Koyu Tema";
            this.koyuTemaToolStripMenuItem.Click += new System.EventHandler(this.koyuTemaToolStripMenuItem_Click);

            this.maviTemaToolStripMenuItem.CheckOnClick = true;
            this.maviTemaToolStripMenuItem.Name = "maviTemaToolStripMenuItem";
            this.maviTemaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.maviTemaToolStripMenuItem.Text = "Mavi Tema";
            this.maviTemaToolStripMenuItem.Click += new System.EventHandler(this.maviTemaToolStripMenuItem_Click);

            this.yeşilTemaToolStripMenuItem.CheckOnClick = true;
            this.yeşilTemaToolStripMenuItem.Name = "yeşilTemaToolStripMenuItem";
            this.yeşilTemaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.yeşilTemaToolStripMenuItem.Text = "Yeşil Tema";
            this.yeşilTemaToolStripMenuItem.Click += new System.EventHandler(this.yeşilTemaToolStripMenuItem_Click);


            this.textBoxContent.Dock = DockStyle.Fill;
            this.textBoxContent.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContent.Location = new System.Drawing.Point(0, 24);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(800, 426);
            this.textBoxContent.TabIndex = 1;
            this.textBoxContent.Text = "";
            this.textBoxContent.TextChanged += new System.EventHandler(this.textBoxContent_TextChanged);
            this.textBoxContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxContent_MouseUp);
            this.textBoxContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxContent_KeyUp);

            this.statusStrip.Items.AddRange(new ToolStripItem[] {
                this.statusLabel
            });
            this.statusStrip.Location = new System.Drawing.Point(0, 450);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";

            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(785, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

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

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e) => NewFile();
        private void açToolStripMenuItem_Click(object sender, EventArgs e) => OpenFile();
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile();
        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e) => SaveFileAs();
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) => ExitApplication();
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e) => Undo();
        private void yineleToolStripMenuItem_Click(object sender, EventArgs e) => Redo();
        private void kesToolStripMenuItem_Click(object sender, EventArgs e) => textBoxContent.Cut();
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e) => textBoxContent.Copy();
        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e) => textBoxContent.Paste();
        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e) => textBoxContent.SelectAll();
        private void bulToolStripMenuItem_Click(object sender, EventArgs e) => ShowFindReplace();
        private void gitToolStripMenuItem_Click(object sender, EventArgs e) => ShowGoToLine();
        private void tarihSaatToolStripMenuItem_Click(object sender, EventArgs e) => InsertDateTime();
        private void resimEkleToolStripMenuItem_Click(object sender, EventArgs e) => InsertImage();
        private void büyükHarfToolStripMenuItem_Click(object sender, EventArgs e) => ConvertToUpperCase();
        private void küçükHarfToolStripMenuItem_Click(object sender, EventArgs e) => ConvertToLowerCase();
        private void başlıkHarfToolStripMenuItem_Click(object sender, EventArgs e) => ConvertToTitleCase();
        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e) => SelectFont();
        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e) => SelectTextColor();
        private void açıkTemaToolStripMenuItem_Click(object sender, EventArgs e) => SetThemeLight();
        private void koyuTemaToolStripMenuItem_Click(object sender, EventArgs e) => SetThemeDark();
        private void maviTemaToolStripMenuItem_Click(object sender, EventArgs e) => SetThemeBlue();
        private void yeşilTemaToolStripMenuItem_Click(object sender, EventArgs e) => SetThemeGreen();
    }

    partial class FindReplaceForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblFind;
        private TextBox txtFind;
        private Label lblReplace;
        private TextBox txtReplace;
        private CheckBox chkMatchCase;
        private CheckBox chkMatchWholeWord;
        private Button btnFindNext;
        private Button btnReplace;
        private Button btnReplaceAll;
        private Button btnCancel;

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
            this.lblFind = new Label();
            this.txtFind = new TextBox();
            this.lblReplace = new Label();
            this.txtReplace = new TextBox();
            this.chkMatchCase = new CheckBox();
            this.chkMatchWholeWord = new CheckBox();
            this.btnFindNext = new Button();
            this.btnReplace = new Button();
            this.btnReplaceAll = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(12, 15);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(28, 15);
            this.lblFind.Text = "Bul:";

            this.txtFind.Location = new System.Drawing.Point(80, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(250, 23);
            this.txtFind.TabIndex = 1;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);

            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(12, 45);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(62, 15);
            this.lblReplace.Text = "Değiştir:";

            this.txtReplace.Location = new System.Drawing.Point(80, 42);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(250, 23);
            this.txtReplace.TabIndex = 2;

            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(80, 75);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(100, 19);
            this.chkMatchCase.Text = "Büyük/küçük harf";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            this.chkMatchCase.CheckedChanged += new System.EventHandler(this.chkMatchCase_CheckedChanged);

            this.chkMatchWholeWord.AutoSize = true;
            this.chkMatchWholeWord.Location = new System.Drawing.Point(80, 100);
            this.chkMatchWholeWord.Name = "chkMatchWholeWord";
            this.chkMatchWholeWord.Size = new System.Drawing.Size(120, 19);
            this.chkMatchWholeWord.Text = "Tam kelime eşleş";
            this.chkMatchWholeWord.UseVisualStyleBackColor = true;
            this.chkMatchWholeWord.CheckedChanged += new System.EventHandler(this.chkMatchWholeWord_CheckedChanged);

            this.btnFindNext.Location = new System.Drawing.Point(350, 10);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(100, 25);
            this.btnFindNext.TabIndex = 3;
            this.btnFindNext.Text = "Sonrakini Bul";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);

            this.btnReplace.Location = new System.Drawing.Point(350, 40);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(100, 25);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Değiştir";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);

            this.btnReplaceAll.Location = new System.Drawing.Point(350, 70);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(100, 25);
            this.btnReplaceAll.TabIndex = 5;
            this.btnReplaceAll.Text = "Tümünü Değiştir";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);

            this.btnCancel.Location = new System.Drawing.Point(350, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 135);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.chkMatchWholeWord);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFind);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindReplaceForm";
            this.Text = "Bul ve Değiştir";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    partial class GoToLineForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLineNumber;
        private TextBox txtLineNumber;
        private Button btnGoTo;
        private Button btnCancel;

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
            this.lblLineNumber = new Label();
            this.txtLineNumber = new TextBox();
            this.btnGoTo = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            this.lblLineNumber.AutoSize = true;
            this.lblLineNumber.Location = new System.Drawing.Point(12, 15);
            this.lblLineNumber.Name = "lblLineNumber";
            this.lblLineNumber.Size = new System.Drawing.Size(100, 15);
            this.lblLineNumber.Text = "Satır numarası:";

            this.txtLineNumber.Location = new System.Drawing.Point(12, 35);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(250, 23);
            this.txtLineNumber.TabIndex = 1;
            this.txtLineNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineNumber_KeyDown);

            this.btnGoTo.Location = new System.Drawing.Point(280, 12);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(75, 25);
            this.btnGoTo.TabIndex = 2;
            this.btnGoTo.Text = "Git";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);

            this.btnCancel.Location = new System.Drawing.Point(280, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 80);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(this.lblLineNumber);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToLineForm";
            this.Text = "Satıra Git";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

