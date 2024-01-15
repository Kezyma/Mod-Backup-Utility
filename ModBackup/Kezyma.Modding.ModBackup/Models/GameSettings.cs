using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kezyma.Modding.ModBackup.Models
{
    public class GameSettings
    {
        public GameSettings() { Folders = new List<FolderDefinition>(); }
        public string Guid { get; set; }
        public string Name { get; set; }
        public DateTime ScanDate { get; set; }
        public List<FolderDefinition> Folders { get; set; }
    }

    public class FolderDefinition
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<FileDefinition> Files { get; set; }
    }

    public class FileDefinition
    {
        public FileDefinition() { }
        public FileDefinition(string path, string hash)
        {
            Path = path;
            Hash = hash;
        }
        public string Path { get; set; }
        public string Hash { get; set; }
    }
}
