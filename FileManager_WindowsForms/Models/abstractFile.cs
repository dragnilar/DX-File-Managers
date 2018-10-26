using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager_WindowsForms.Models
{
    public abstract class AbstractFile
    {
        //Reminder - you cannot make these public, otherwise the DXGrid will not be able to see them :P
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }


        public bool ExportFile(string selectedDirectory, string customSuffix = "", int numberOfCopies = 1)
        {
            try
            {
                var trueFileName = Path.GetFileNameWithoutExtension(FilePath);
                var extension = Path.GetExtension(FilePath);
                var destinationFilePath = Path.Combine(selectedDirectory, trueFileName + customSuffix + extension);
                CreateFileCopies(numberOfCopies, destinationFilePath);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private void CreateFileCopies(int numberOfCopies, string destinationFilePath)
        {
            var unchangedDestinationFilePath = destinationFilePath;

            for (int i = 0; i < numberOfCopies; i++)
            {
                if (i > 0)
                {
                    var additionalCopyString = (i + 1).ToString();
                    destinationFilePath = AdjustFileNameForAdditionalCopy(unchangedDestinationFilePath, additionalCopyString);
                }

                if (File.Exists(destinationFilePath))
                {
                    continue;
                }

                File.Copy(FilePath, destinationFilePath);
            }
        }


        private string AdjustFileNameForAdditionalCopy(string unchangedDestinationFilePath, string additionalCopyNumberString)
        {
            var pathWithoutFileName = Path.GetDirectoryName(unchangedDestinationFilePath);
            var fileName = Path.GetFileNameWithoutExtension(unchangedDestinationFilePath);
            var fileExtension = Path.GetExtension(unchangedDestinationFilePath);

            return $"{pathWithoutFileName}\\{fileName}-{additionalCopyNumberString}{fileExtension}";
        }
    }
}
