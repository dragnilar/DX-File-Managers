using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using FileManager_WindowsForms.Models;

namespace FileManager_WindowsForms.ViewModels
{
    [POCOViewModel]
    public class PrimaryFilesViewModel
    {
        public virtual List<PrimaryFile> Files { get; set; }
        public virtual PrimaryFile SelectedEntity { get; set; }
        public virtual decimal NumberOfSelectedFiles { get; set; }
        public virtual string CustomFileSuffix { get; set; }

        protected IFolderBrowserDialogService FolderBrowserDialogService =>
            this.GetService<IFolderBrowserDialogService>();

        protected IMessageBoxService MessageBoxService => this.GetService<IMessageBoxService>();

        public PrimaryFilesViewModel()
        {
            Files = App.Files.PrimaryFiles;
            NumberOfSelectedFiles = 1;
            CustomFileSuffix = string.Empty;
            SelectedEntity = App.Files.PrimaryFiles.FirstOrDefault();
        }

        public void FileSelected()
        {
            BrowseForExportPath();
        }

        public void BrowseForExportPath()
        {
            var selected = FolderBrowserDialogService.ShowDialog();
            if (selected)
            {
                ExportSelectedFile(FolderBrowserDialogService.ResultPath);
            }
        }

        private void ExportSelectedFile(string selectedDirectory)
        {
            if (SelectedEntity != null)
            {
               var result= SelectedEntity.ExportFile(selectedDirectory, CustomFileSuffix, Convert.ToInt32(NumberOfSelectedFiles));
               DisplayResult(result, selectedDirectory);
            }
        }

        private void DisplayResult(bool result, string selectedDirectory)
        {
            if (result)
            {
                ShowSuccessResult(selectedDirectory);
            }

            else
            {
                ShowFailureResult();
            }
        }

        private void ShowFailureResult()
        {
            MessageBoxService.ShowMessage(
                "The file export failed. Please verify the folder doesn't contain a file with the same name.\n" +
                "If you continue to experience problems, please consult your administrator.",
                "Export Failed", MessageButton.OK);

        }

        private void ShowSuccessResult(string selectedDirectory)
        {
            var decision = MessageBoxService.ShowMessage(
                "The file was successfully exported. Do you wish to navigate" +
                "to the folder where it was saved?",
                "Export Successful", MessageButton.YesNo);

            if (decision == MessageResult.Yes)
            {
                Process.Start("explorer.exe", selectedDirectory);
            }
        }
    }
}