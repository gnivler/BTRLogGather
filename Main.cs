using System;
using System.IO;
using System.Windows.Forms;

namespace BTRLogGather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gather_Click(object sender, EventArgs e)
        {
            var temp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BTRLogGather\\");
            var timeStamp = DateTime.Now.ToLongTimeString().Replace(" ", "").Replace(":", "");
            temp = Path.Combine(temp, timeStamp);
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            var dialog = new OpenFileDialog
            {
                Title = "Please select your BattleTech.exe file in the game folder",
                Filter = "BattleTech.exe|BattleTech.exe",
            };
            dialog.ShowDialog();
            if (dialog.FileName.ToLower().EndsWith("battletech.exe") )
            {
                var root = new FileInfo(dialog.FileName).DirectoryName;
                var modtek = Path.Combine(root, "mods/.modtek");
                File.Copy(Path.Combine(root, "mods/output_log.txt"), Path.Combine(temp, "output_log.txt"), true);
                File.Copy(Path.Combine(root, "mods/cleaned_output_log.txt"), Path.Combine(temp, "cleaned_output_log.txt"), true);
                File.Copy(Path.Combine(modtek, "harmony_summary.log"), Path.Combine(temp, "harmony_summary.log"), true);
                File.Copy(Path.Combine(modtek, "ModTek.log"), Path.Combine(temp, "ModTek.log"), true);
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            
        }
    }
}
