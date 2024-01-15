using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kezyma.Modding.ModBackup.Models
{
    public class ModSettings
    {
        public string GameGuid { get; set; }
        public string ModGuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Folders { get; set; }
        public DateTime BackupDate { get; set; }
    }
}
