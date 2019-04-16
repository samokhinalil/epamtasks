using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class FileChangesSaver
    {
        public string WatchingDirectory { get; set; }
        public string SavingDirectory { get; set; }

        public FileChangesSaver(string watchingDirectory, string savingDirectory)
        {
            WatchingDirectory = watchingDirectory;
            SavingDirectory = savingDirectory;
        }

        public void BeginWatch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(WatchingDirectory, "*.txt");
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnChanged);

            SaveCopy();
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            SaveCopy();
        }

        public void SaveCopy()
        {
            var targetDir = new DirectoryInfo(SavingDirectory);
            var dir = targetDir.CreateSubdirectory(DateTime.Now.ToString("dd-MM-yy_HH-mm-ss"));
            Copy(WatchingDirectory, dir.ToString());
        }

        private void Copy(string watchingDirectory, string savingDirectory)
        {
            var sourceDir = new DirectoryInfo(watchingDirectory);
            var targetDir = new DirectoryInfo(savingDirectory);

            foreach (var file in sourceDir.GetFiles())
            {
                file.CopyTo(Path.Combine(targetDir.ToString(), file.Name), true);
            }

            foreach (var innerDir in sourceDir.GetDirectories())
            {
                var copyInnerDir = targetDir.CreateSubdirectory(innerDir.Name);
                Copy(innerDir.FullName, copyInnerDir.ToString());
            }
        }

        public void RollBack(int inputNumber)
        {
            DirectoryInfo directoryFrom = new DirectoryInfo(WatchingDirectory);
            DirectoryInfo directoryTo = new DirectoryInfo(SavingDirectory);
            var dirNames = directoryTo.GetDirectories();
            for (int i = 0; i < dirNames.Length; i++)
            {
                if (i == inputNumber)
                {
                    directoryFrom.Delete(true);
                    dirNames[i].MoveTo(WatchingDirectory);
                    break;
                }
            }
        }
    }
}
