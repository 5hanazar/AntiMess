﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AntiMess
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void pickButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }
        private void readyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBoxLog.Text = "";
                CheckDirectory(textBox1.Text);
            }
        }
        private void CheckDirectory(string directoryInfo)
        {
            var dir = new DirectoryInfo(directoryInfo);
            textBoxLog.Text += $"Checking: {directoryInfo}" + Environment.NewLine;
            //if (dir.GetDirectories().Length == 0) textBoxLog.Text += $"No child: {directoryInfo + " " + IsNameUnderscore(dir)}" + Environment.NewLine;
            foreach (var subdirectory in Directory.GetDirectories(directoryInfo))
            {
                CheckDirectory(subdirectory);
            }
            if (directoryInfo != textBox1.Text && IsNameUnderscore(dir)) MoveToParentAndDelete(dir);
        }
        private void MoveToParentAndDelete(DirectoryInfo directoryInfo)
        {
            foreach (var file in directoryInfo.GetFiles())
            {
                try
                {
                    string newPath = Path.Combine(directoryInfo.Parent.FullName, file.Name);
                    File.Move(file.FullName, newPath);
                    textBoxLog.Text += $"Moved: {file.FullName}" + Environment.NewLine;
                } catch (Exception ex)
                {
                    string newPath = Path.Combine(directoryInfo.Parent.FullName, $"{Path.GetFileNameWithoutExtension(file.Name)}_dupl{file.Extension}");
                    File.Move(file.FullName, newPath);
                    textBoxLog.Text += $"Moved: {file.FullName}" + Environment.NewLine;
                }
            }
            foreach (var file in directoryInfo.GetDirectories())
            {
                try
                {
                    string newPath = Path.Combine(directoryInfo.Parent.FullName, file.Name);
                    Directory.Move(file.FullName, newPath);
                    textBoxLog.Text += $"Moved: {file.FullName}" + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    string newPath = Path.Combine(directoryInfo.Parent.FullName, $"{file.Name}_dupl");
                    Directory.Move(file.FullName, newPath);
                    textBoxLog.Text += $"Moved: {file.FullName}" + Environment.NewLine;
                }
            }
            directoryInfo.Delete();
            textBoxLog.Text += $"Deleted: {directoryInfo.FullName}" + Environment.NewLine;
        }
        private bool IsNameUnderscore(DirectoryInfo directoryInfo)
        {
            return directoryInfo.Name.All(c => c == '_');
        }

        private void buttonGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/5hanazar/AntiMess");
        }
    }
}
