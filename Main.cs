using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;

namespace BTRLogGather
{
    public partial class Main : Form
    {
        private static string battleTechExe = File.Exists(Environment.CurrentDirectory + "\\battletech.exe")
            ? new FileInfo(Environment.CurrentDirectory + "\\battletech.exe").FullName
            : default;

        private static readonly string MainDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BTRLogGather\\");
        private static string guidDir = Guid.NewGuid().ToString();

        private static readonly string[] OmitStrings =
        {
            "readme",
            "license",
            "licence",
            "how to",
        };

        public Main()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(battleTechExe))
            {
                var parentDir = new DirectoryInfo(Environment.CurrentDirectory).Parent?.FullName;
                battleTechExe = File.Exists($"{parentDir}\\battletech.exe")
                    ? new FileInfo($"{parentDir}\\battletech.exe").FullName
                    : default;
            }
        }

        private void Gather_Click(object sender, EventArgs e)
        {
            CreateMainDir();
            GetBattleTechExe();
            if (battleTechExe.EndsWith("battletech.exe"))
            {
                var path = Path.Combine(MainDir, guidDir);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                var root = new FileInfo(battleTechExe).DirectoryName;
                var modtek = Path.Combine(root, "mods/.modtek");
                var appDataOutputLog = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}Low\\Harebrained Schemes\\BATTLETECH\\output_log.txt";
                if (detailedLogsCheckBox.Checked)
                {
                    var logs = Directory.EnumerateFiles(Path.Combine(root, "mods"), "*.txt", SearchOption.AllDirectories);
                    logs = logs.Concat(Directory.EnumerateFiles(Path.Combine(root, "mods"), "*.log", SearchOption.AllDirectories));
                    foreach (var file in logs)
                    {
                        var lower = file.ToLower();
                        if (!OmitStrings.Any(x => lower.Contains(x)))
                        {
                            var subDir = Regex.Match(lower, @"\\(\w*)\\\w*\.(txt|log)").Groups[1].ToString();
                            subDir = subDir == "mods" ? "" : subDir;
                            var targetFile = $"{MainDir}\\{guidDir}\\{subDir}\\{lower.Split('\\').Last()}";
                            if (!Directory.Exists(targetFile))
                            {
                                Directory.CreateDirectory($"{MainDir}\\{guidDir}\\{subDir}");
                            }

                            File.Copy(lower, targetFile);
                        }
                    }
                }
                else
                {
                    File.Copy(Path.Combine(root, "mods/output_log.txt"), Path.Combine(path, "output_log.txt"), true);
                    File.Copy(Path.Combine(root, "mods/cleaned_output_log.txt"), Path.Combine(path, "cleaned_output_log.txt"), true);
                    File.Copy(Path.Combine(modtek, "harmony_summary.log"), Path.Combine(path, "harmony_summary.log"), true);
                    File.Copy(Path.Combine(modtek, "ModTek.log"), Path.Combine(path, "ModTek.log"), true);
                }

                var tmp = Path.Combine(path, "HBS");
                if (!Directory.Exists(tmp))
                {
                    Directory.CreateDirectory(tmp);
                }

                File.Copy(appDataOutputLog, Path.Combine(path, "HBS\\output_log.txt"), true);
                PackageZip(path, guidDir);
                Process.Start(MainDir);
            }
        }

        private static void PackageZip(string path, string guidDir)
        {
            ZipFile.CreateFromDirectory(path, $"{MainDir}\\{DateTime.Now.ToString("yyyy-M-d HHmmssss")}.zip");
            Directory.Delete(Path.Combine(MainDir, guidDir), true);
        }

        private static void CreateMainDir()
        {
            if (!Directory.Exists(MainDir))
            {
                Directory.CreateDirectory(MainDir);
            }
        }

        private static void GetBattleTechExe()
        {
            var dialog = new OpenFileDialog
            {
                Title = @"Please select your BattleTech.exe file in the game folder",
                Filter = @"BattleTech.exe|BattleTech.exe",
            };
            if (string.IsNullOrEmpty(battleTechExe) ||
                !battleTechExe.ToLower().EndsWith("battletech.exe"))
            {
                dialog.ShowDialog();
                battleTechExe = dialog.FileName.ToLower();
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(MainDir))
            {
                Process.Start(MainDir);
            }
            else
            {
                MessageBox.Show("No folder created yet", "", MessageBoxButtons.OK);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(battleTechExe) &&
                battleTechExe.ToLower().EndsWith("battletech.exe"))
            {
                Process.Start(battleTechExe);
            }
            else if (string.IsNullOrEmpty(battleTechExe) ||
                     !battleTechExe.EndsWith("battletech.exe"))
            {
                GetBattleTechExe();
                if (battleTechExe.EndsWith("battletech.exe"))
                {
                    Process.Start(battleTechExe);
                }
            }
        }
    }
}
