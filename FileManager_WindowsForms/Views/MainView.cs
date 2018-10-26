using DevExpress.XtraEditors;
using FileManager_WindowsForms.ViewModels;

namespace FileManager_WindowsForms.Views
{
    public partial class MainView : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContextMain.IsDesignMode)
                InitializeBindings();
            HookUpEvents();

        }

        private void HookUpEvents()
        {
            elementPrimaryFiles.Click +=
                (sender, args) => navigationFrameMain.SelectedPage = navigationPagePrimaryFiles;
            elementSettings.Click += (sender, args) => navigationFrameMain.SelectedPage = navigationPageSettings;
        }

        void InitializeBindings()
        {
            var fluent = mvvmContextMain.OfType<MainViewModel>();
        }
    }
}
