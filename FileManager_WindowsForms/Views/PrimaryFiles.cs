using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.CommonDialogs;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;
using FileManager_WindowsForms.Models;
using FileManager_WindowsForms.ViewModels;

namespace FileManager_WindowsForms.Views
{
    public partial class PrimaryFiles : DevExpress.XtraEditors.XtraUserControl
    {
        public PrimaryFiles()
        {
            InitializeComponent();
            if (!mvvmContextPrimaryFiles.IsDesignMode)
            {
                InitializeBindings();
                mvvmContextPrimaryFiles.RegisterService(
                    FolderBrowserDialogService.Create(FolderBrowserStyle.SkinnableWide));
                MVVMContext.RegisterFlyoutMessageBoxService();
            }
        }



        void InitializeBindings()
        {
            var fluent = mvvmContextPrimaryFiles.OfType<PrimaryFilesViewModel>();

            fluent.SetBinding(gridControlFileList, gridcontrol => gridcontrol.DataSource, x => x.Files);
            fluent.SetBinding(rangeTrackNumberOfFiles, x => x.EditValue, vm => vm.NumberOfSelectedFiles);
            fluent.SetBinding(spinEditNumberOfFiles, x => x.EditValue, vm => vm.NumberOfSelectedFiles);
            fluent.SetBinding(textEditFileSuffix, x => x.EditValue, vm => vm.CustomFileSuffix);
            fluent.BindCommand(simpleButtonSaveSelectedFile, x=>x.BrowseForExportPath());
           

            fluent.WithEvent<DevExpress.XtraGrid.Views.Base.ColumnView,
                    DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs>(
                    gridViewFileList, "FocusedRowObjectChanged").SetBinding(x => x.SelectedEntity,
                    args => args.Row as PrimaryFile, (gView, entity) =>
                        gView.FocusedRowHandle = gView.FindRow(entity));

            fluent.WithEvent<DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs>(gridViewFileList, "RowCellClick")
                .EventToCommand(
                    x => x.FileSelected(), x=>x.SelectedEntity, args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));


        }
    }
}
