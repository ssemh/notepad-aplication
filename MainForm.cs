using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotepadApp
{
    public partial class MainForm : Form
    {
        private string currentFilePath = string.Empty;
        private bool isModified = false;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Not Defteri - Yeni Dosya";
            UpdateStatusBar();
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
                openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentFilePath = openFileDialog.FileName;
                        textBoxContent.Text = File.ReadAllText(currentFilePath);
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
                    File.WriteAllText(currentFilePath, textBoxContent.Text);
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
                saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentFilePath = saveFileDialog.FileName;
                        File.WriteAllText(currentFilePath, textBoxContent.Text);
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

        private void ShowAbout()
        {
            MessageBox.Show(
                "Not Defteri Uygulaması\n\n" +
                "Basit bir metin düzenleme uygulaması.\n\n" +
                "C# ile geliştirilmiştir.",
                "Hakkında",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void UpdateStatusBar()
        {
            int line = textBoxContent.GetLineFromCharIndex(textBoxContent.SelectionStart) + 1;
            int column = textBoxContent.SelectionStart - textBoxContent.GetFirstCharIndexFromLine(line - 1) + 1;
            statusLabel.Text = $"Satır: {line}, Sütun: {column} | Karakter Sayısı: {textBoxContent.Text.Length}";
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
}

