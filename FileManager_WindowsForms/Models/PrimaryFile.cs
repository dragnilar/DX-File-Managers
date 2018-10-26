using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager_WindowsForms.Models
{
    public class PrimaryFile : AbstractFile
    {
        public PrimaryFile(int id, string name, string type, string path)
        {
            Id = id;
            FileName = name;
            FileType = type;
            FilePath = path;
        }


        
    }
}
