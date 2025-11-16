using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace NotepadApp
{
    public partial class MainForm : Form
    {
        private string currentFilePath = string.Empty;
        private bool isModified = false;
        private Theme currentTheme = Theme.Light;

        public enum Theme
        {
            Light,
            Dark,
            Blue,
            Green
        }

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Not Defteri - Yeni Dosya";
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            UpdateStatusBar();
            ApplyTheme(Theme.Light);
            UpdateThemeMenu();
        }

        private void NewFile()
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show(
                    "Değişiklikler kaydedilsin mi?",
                    "Not Defteri",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            textBoxContent.Clear();
            currentFilePath = string.Empty;
            isModified = false;
            this.Text = "Not Defteri - Yeni Dosya";
            UpdateStatusBar();
        }

        private void OpenFile()
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show(
                    "Değişiklikler kaydedilsin mi?",
                    "Not Defteri",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|RTF Dosyaları (*.rtf)|*.rtf|Tüm Dosyalar (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentFilePath = openFileDialog.FileName;
                        if (Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                        {
                            textBoxContent.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            textBoxContent.Text = File.ReadAllText(currentFilePath);
                        }
                        isModified = false;
                        this.Text = $"Not Defteri - {Path.GetFileName(currentFilePath)}";
                        UpdateStatusBar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Dosya açılırken hata oluştu:\n{ex.Message}",
                            "Hata",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileAs();
            }
            else
            {
                try
                {
                    if (Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                    {
                        textBoxContent.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(currentFilePath, textBoxContent.Text);
                    }
                    isModified = false;
                    this.Text = $"Not Defteri - {Path.GetFileName(currentFilePath)}";
                    UpdateStatusBar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Dosya kaydedilirken hata oluştu:\n{ex.Message}",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void SaveFileAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|RTF Dosyaları (*.rtf)|*.rtf|Tüm Dosyalar (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentFilePath = saveFileDialog.FileName;
                        if (Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                        {
                            textBoxContent.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            File.WriteAllText(currentFilePath, textBoxContent.Text);
                        }
                        isModified = false;
                        this.Text = $"Not Defteri - {Path.GetFileName(currentFilePath)}";
                        UpdateStatusBar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Dosya kaydedilirken hata oluştu:\n{ex.Message}",
                            "Hata",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExitApplication()
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show(
                    "Değişiklikler kaydedilsin mi?",
                    "Not Defteri",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            Application.Exit();
        }

        private void SelectFont()
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = textBoxContent.Font;
                fontDialog.ShowColor = false;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxContent.Font = fontDialog.Font;
                }
            }
        }

        private void SelectTextColor()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = textBoxContent.SelectionColor;
                colorDialog.FullOpen = true;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    if (textBoxContent.SelectionLength > 0)
                    {
                        textBoxContent.SelectionColor = colorDialog.Color;
                    }
                    else
                    {
                        textBoxContent.SelectionColor = colorDialog.Color;
                        textBoxContent.ForeColor = colorDialog.Color;
                    }
                }
            }
        }

        private void InsertImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string imagePath = openFileDialog.FileName;
                        Image image = Image.FromFile(imagePath);
                        
                        Clipboard.SetImage(image);
                        textBoxContent.Paste();
                        
                        image.Dispose();
                        isModified = true;
                        string fileName = string.IsNullOrEmpty(currentFilePath) ? "Yeni Dosya" : Path.GetFileName(currentFilePath);
                        this.Text = $"Not Defteri - {fileName} *";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Resim eklenirken hata oluştu:\n{ex.Message}",
                            "Hata",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ApplyTheme(Theme theme)
        {
            currentTheme = theme;
            
            switch (theme)
            {
                case Theme.Light:
                    this.BackColor = SystemColors.Control;
                    this.ForeColor = SystemColors.ControlText;
                    
                    textBoxContent.BackColor = Color.White;
                    textBoxContent.ForeColor = Color.Black;
                    
                    menuStrip.BackColor = SystemColors.MenuBar;
                    menuStrip.ForeColor = SystemColors.ControlText;
                    
                    statusStrip.BackColor = SystemColors.Control;
                    statusStrip.ForeColor = SystemColors.ControlText;
                    
                    statusLabel.ForeColor = SystemColors.ControlText;
                    
                    SetAllMenuColors(SystemColors.ControlText, SystemColors.MenuBar);
                    break;
                    
                case Theme.Dark:
                    this.BackColor = Color.FromArgb(30, 30, 30);
                    this.ForeColor = Color.White;
                    
                    textBoxContent.BackColor = Color.FromArgb(45, 45, 45);
                    textBoxContent.ForeColor = Color.White;
                    
                    menuStrip.BackColor = Color.FromArgb(40, 40, 40);
                    menuStrip.ForeColor = Color.White;
                    
                    statusStrip.BackColor = Color.FromArgb(40, 40, 40);
                    statusStrip.ForeColor = Color.White;
                    
                    statusLabel.ForeColor = Color.White;
                    
                    SetAllMenuColors(Color.White, Color.FromArgb(40, 40, 40));
                    break;
                    
                case Theme.Blue:
                    this.BackColor = Color.FromArgb(30, 50, 70);
                    this.ForeColor = Color.White;
                    
                    textBoxContent.BackColor = Color.FromArgb(40, 65, 90);
                    textBoxContent.ForeColor = Color.White;
                    
                    menuStrip.BackColor = Color.FromArgb(35, 55, 75);
                    menuStrip.ForeColor = Color.White;
                    
                    statusStrip.BackColor = Color.FromArgb(35, 55, 75);
                    statusStrip.ForeColor = Color.White;
                    
                    statusLabel.ForeColor = Color.White;
                    
                    SetAllMenuColors(Color.White, Color.FromArgb(35, 55, 75));
                    break;
                    
                case Theme.Green:
                    this.BackColor = Color.FromArgb(30, 60, 40);
                    this.ForeColor = Color.White;
                    
                    textBoxContent.BackColor = Color.FromArgb(40, 75, 50);
                    textBoxContent.ForeColor = Color.White;
                    
                    menuStrip.BackColor = Color.FromArgb(35, 65, 45);
                    menuStrip.ForeColor = Color.White;
                    
                    statusStrip.BackColor = Color.FromArgb(35, 65, 45);
                    statusStrip.ForeColor = Color.White;
                    
                    statusLabel.ForeColor = Color.White;
                    
                    SetAllMenuColors(Color.White, Color.FromArgb(35, 65, 45));
                    break;
            }
            
            UpdateThemeMenu();
        }

        private void SetAllMenuColors(Color foreColor, Color backColor)
        {
            foreach (ToolStripItem item in menuStrip.Items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    SetMenuColor(menuItem, foreColor, backColor);
                }
            }
        }

        private void UpdateThemeMenu()
        {
            açıkTemaToolStripMenuItem.Checked = (currentTheme == Theme.Light);
            koyuTemaToolStripMenuItem.Checked = (currentTheme == Theme.Dark);
            maviTemaToolStripMenuItem.Checked = (currentTheme == Theme.Blue);
            yeşilTemaToolStripMenuItem.Checked = (currentTheme == Theme.Green);
        }

        private void ToggleTheme()
        {
            if (currentTheme == Theme.Dark)
                ApplyTheme(Theme.Light);
            else
                ApplyTheme(Theme.Dark);
        }

        private void SetThemeLight() => ApplyTheme(Theme.Light);
        private void SetThemeDark() => ApplyTheme(Theme.Dark);
        private void SetThemeBlue() => ApplyTheme(Theme.Blue);
        private void SetThemeGreen() => ApplyTheme(Theme.Green);

        private void SetMenuColor(ToolStripMenuItem menuItem, Color foreColor, Color backColor)
        {
            menuItem.ForeColor = foreColor;
            menuItem.BackColor = backColor;
            
            foreach (ToolStripItem item in menuItem.DropDownItems)
            {
                if (item is ToolStripMenuItem subMenuItem)
                {
                    subMenuItem.ForeColor = foreColor;
                    subMenuItem.BackColor = backColor;
                    SetMenuColor(subMenuItem, foreColor, backColor);
                }
                else if (item is ToolStripSeparator separator)
                {
                }
            }
        }

        private void UpdateStatusBar()
        {
            int line = textBoxContent.GetLineFromCharIndex(textBoxContent.SelectionStart) + 1;
            int column = textBoxContent.SelectionStart - textBoxContent.GetFirstCharIndexFromLine(line - 1) + 1;
            int charCount = textBoxContent.TextLength;
            int wordCount = CountWords(textBoxContent.Text);
            statusLabel.Text = $"Satır: {line}, Sütun: {column} | Karakter: {charCount} | Kelime: {wordCount}";
        }

        private int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        private void ShowFindReplace()
        {
            using (FindReplaceForm findReplaceForm = new FindReplaceForm(textBoxContent))
            {
                findReplaceForm.ApplyTheme(currentTheme);
                findReplaceForm.ShowDialog(this);
            }
        }

        private void ShowGoToLine()
        {
            using (GoToLineForm goToLineForm = new GoToLineForm(textBoxContent))
            {
                goToLineForm.ApplyTheme(currentTheme);
                goToLineForm.ShowDialog(this);
            }
        }

        private void Undo()
        {
            if (textBoxContent.CanUndo)
            {
                textBoxContent.Undo();
            }
        }

        private void Redo()
        {
            if (textBoxContent.CanRedo)
            {
                textBoxContent.Redo();
            }
        }

        private void InsertDateTime()
        {
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            textBoxContent.SelectedText = dateTime;
            textBoxContent.Focus();
        }

        private void ConvertToUpperCase()
        {
            if (textBoxContent.SelectionLength > 0)
            {
                string selectedText = textBoxContent.SelectedText;
                textBoxContent.SelectedText = selectedText.ToUpper();
            }
            else
            {
                textBoxContent.SelectAll();
                textBoxContent.SelectedText = textBoxContent.Text.ToUpper();
            }
        }

        private void ConvertToLowerCase()
        {
            if (textBoxContent.SelectionLength > 0)
            {
                string selectedText = textBoxContent.SelectedText;
                textBoxContent.SelectedText = selectedText.ToLower();
            }
            else
            {
                textBoxContent.SelectAll();
                textBoxContent.SelectedText = textBoxContent.Text.ToLower();
            }
        }

        private void ConvertToTitleCase()
        {
            if (textBoxContent.SelectionLength > 0)
            {
                string selectedText = textBoxContent.SelectedText;
                textBoxContent.SelectedText = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(selectedText.ToLower());
            }
            else
            {
                textBoxContent.SelectAll();
                textBoxContent.SelectedText = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxContent.Text.ToLower());
            }
        }

        private void textBoxContent_TextChanged(object sender, EventArgs e)
        {
            if (!isModified)
            {
                isModified = true;
                string fileName = string.IsNullOrEmpty(currentFilePath) ? "Yeni Dosya" : Path.GetFileName(currentFilePath);
                this.Text = $"Not Defteri - {fileName} *";
            }
            UpdateStatusBar();
        }

        private void textBoxContent_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateStatusBar();
        }

        private void textBoxContent_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateStatusBar();
        }
    }

    public partial class FindReplaceForm : Form
    {
        private RichTextBox targetTextBox;
        private int lastSearchIndex = 0;
        private bool matchCase = false;
        private bool matchWholeWord = false;

        public FindReplaceForm(RichTextBox textBox)
        {
            InitializeComponent();
            targetTextBox = textBox;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void ApplyTheme(MainForm.Theme theme)
        {
            Color formBackColor, formForeColor, textBoxBackColor, textBoxForeColor;
            
            switch (theme)
            {
                case MainForm.Theme.Light:
                    formBackColor = SystemColors.Control;
                    formForeColor = SystemColors.ControlText;
                    textBoxBackColor = Color.White;
                    textBoxForeColor = Color.Black;
                    break;
                    
                case MainForm.Theme.Dark:
                    formBackColor = Color.FromArgb(30, 30, 30);
                    formForeColor = Color.White;
                    textBoxBackColor = Color.FromArgb(45, 45, 45);
                    textBoxForeColor = Color.White;
                    break;
                    
                case MainForm.Theme.Blue:
                    formBackColor = Color.FromArgb(30, 50, 70);
                    formForeColor = Color.White;
                    textBoxBackColor = Color.FromArgb(40, 65, 90);
                    textBoxForeColor = Color.White;
                    break;
                    
                case MainForm.Theme.Green:
                    formBackColor = Color.FromArgb(30, 60, 40);
                    formForeColor = Color.White;
                    textBoxBackColor = Color.FromArgb(40, 75, 50);
                    textBoxForeColor = Color.White;
                    break;
                    
                default:
                    formBackColor = SystemColors.Control;
                    formForeColor = SystemColors.ControlText;
                    textBoxBackColor = Color.White;
                    textBoxForeColor = Color.Black;
                    break;
            }
            
            this.BackColor = formBackColor;
            this.ForeColor = formForeColor;
            lblFind.ForeColor = formForeColor;
            lblReplace.ForeColor = formForeColor;
            txtFind.BackColor = textBoxBackColor;
            txtFind.ForeColor = textBoxForeColor;
            txtReplace.BackColor = textBoxBackColor;
            txtReplace.ForeColor = textBoxForeColor;
            chkMatchCase.ForeColor = formForeColor;
            chkMatchWholeWord.ForeColor = formForeColor;
            
            btnFindNext.BackColor = formBackColor;
            btnFindNext.ForeColor = formForeColor;
            btnReplace.BackColor = formBackColor;
            btnReplace.ForeColor = formForeColor;
            btnReplaceAll.BackColor = formBackColor;
            btnReplaceAll.ForeColor = formForeColor;
            btnCancel.BackColor = formBackColor;
            btnCancel.ForeColor = formForeColor;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Replace();
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            ReplaceAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindNext()
        {
            string searchText = txtFind.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Aranacak metni girin.", "Bul", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringComparison comparison = matchCase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            string text = targetTextBox.Text;
            int startIndex = targetTextBox.SelectionStart + targetTextBox.SelectionLength;

            int index = text.IndexOf(searchText, startIndex, comparison);
            
            if (index == -1 && startIndex > 0)
            {
                index = text.IndexOf(searchText, 0, comparison);
            }

            if (index != -1)
            {
                targetTextBox.Select(index, searchText.Length);
                targetTextBox.ScrollToCaret();
                targetTextBox.Focus();
                lastSearchIndex = index;
            }
            else
            {
                MessageBox.Show($"'{searchText}' bulunamadı.", "Bul", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Replace()
        {
            if (targetTextBox.SelectedText == txtFind.Text || 
                (targetTextBox.SelectedText.Equals(txtFind.Text, matchCase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase)))
            {
                int selectionStart = targetTextBox.SelectionStart;
                targetTextBox.SelectedText = txtReplace.Text;
                targetTextBox.Select(selectionStart, txtReplace.Text.Length);
                FindNext();
            }
            else
            {
                FindNext();
            }
        }

        private void ReplaceAll()
        {
            string searchText = txtFind.Text;
            string replaceText = txtReplace.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Aranacak metni girin.", "Değiştir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringComparison comparison = matchCase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            string text = targetTextBox.Text;
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(searchText, index, comparison)) != -1)
            {
                text = text.Remove(index, searchText.Length).Insert(index, replaceText);
                index += replaceText.Length;
                count++;
            }

            if (count > 0)
            {
                targetTextBox.Text = text;
                MessageBox.Show($"{count} değişiklik yapıldı.", "Değiştir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"'{searchText}' bulunamadı.", "Değiştir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            matchCase = chkMatchCase.Checked;
        }

        private void chkMatchWholeWord_CheckedChanged(object sender, EventArgs e)
        {
            matchWholeWord = chkMatchWholeWord.Checked;
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindNext();
                e.Handled = true;
            }
        }
    }

    public partial class GoToLineForm : Form
    {
        private RichTextBox targetTextBox;

        public GoToLineForm(RichTextBox textBox)
        {
            InitializeComponent();
            targetTextBox = textBox;
            this.StartPosition = FormStartPosition.CenterParent;
            
            int totalLines = textBox.Lines.Length;
            lblLineNumber.Text = $"Satır numarası (1-{totalLines}):";
        }

        public void ApplyTheme(MainForm.Theme theme)
        {
            Color formBackColor, formForeColor, textBoxBackColor, textBoxForeColor;
            
            switch (theme)
            {
                case MainForm.Theme.Light:
                    formBackColor = SystemColors.Control;
                    formForeColor = SystemColors.ControlText;
                    textBoxBackColor = Color.White;
                    textBoxForeColor = Color.Black;
                    break;
                    
                case MainForm.Theme.Dark:
                    formBackColor = Color.FromArgb(30, 30, 30);
                    formForeColor = Color.White;
                    textBoxBackColor = Color.FromArgb(45, 45, 45);
                    textBoxForeColor = Color.White;
                    break;
                    
                case MainForm.Theme.Blue:
                    formBackColor = Color.FromArgb(30, 50, 70);
                    formForeColor = Color.White;
                    textBoxBackColor = Color.FromArgb(40, 65, 90);
                    textBoxForeColor = Color.White;
                    break;
                    
                case MainForm.Theme.Green:
                    formBackColor = Color.FromArgb(30, 60, 40);
                    formForeColor = Color.White;
                    textBoxBackColor = Color.FromArgb(40, 75, 50);
                    textBoxForeColor = Color.White;
                    break;
                    
                default:
                    formBackColor = SystemColors.Control;
                    formForeColor = SystemColors.ControlText;
                    textBoxBackColor = Color.White;
                    textBoxForeColor = Color.Black;
                    break;
            }
            
            this.BackColor = formBackColor;
            this.ForeColor = formForeColor;
            lblLineNumber.ForeColor = formForeColor;
            txtLineNumber.BackColor = textBoxBackColor;
            txtLineNumber.ForeColor = textBoxForeColor;
            
            btnGoTo.BackColor = formBackColor;
            btnGoTo.ForeColor = formForeColor;
            btnCancel.BackColor = formBackColor;
            btnCancel.ForeColor = formForeColor;
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLineNumber.Text, out int lineNumber))
            {
                int totalLines = targetTextBox.Lines.Length;
                
                if (lineNumber < 1 || lineNumber > totalLines)
                {
                    MessageBox.Show(
                        $"Satır numarası 1 ile {totalLines} arasında olmalıdır.",
                        "Git",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                int charIndex = targetTextBox.GetFirstCharIndexFromLine(lineNumber - 1);
                if (charIndex >= 0)
                {
                    targetTextBox.Select(charIndex, 0);
                    targetTextBox.ScrollToCaret();
                    targetTextBox.Focus();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir satır numarası girin.", "Git", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLineNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGoTo_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

