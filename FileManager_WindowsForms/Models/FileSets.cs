using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager_WindowsForms.Models
{
    public class FileSets
    {
        public List<PrimaryFile> PrimaryFiles { get; set; }

        public FileSets()
        {
            SetPrimaryFiles();
        }

        private void SetPrimaryFiles()
        {
            var list = new List<PrimaryFile>();

            list.Add(new PrimaryFile(1, "Test Text File", ".txt", AppDomain.CurrentDomain.BaseDirectory + "TestFiles\\TestTextFile.txt"));
            list.Add(new PrimaryFile(1, "Test Excel File", ".xlsx", AppDomain.CurrentDomain.BaseDirectory + "TestFiles\\TestWorkBook.xlsx"));
            list.Add(new PrimaryFile(1, "Test XML File", ".xml", AppDomain.CurrentDomain.BaseDirectory + "TestFiles\\TestXmlFile.xml"));

            PrimaryFiles = list;
        }
    }
}
