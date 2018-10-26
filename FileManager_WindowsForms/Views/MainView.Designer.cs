using FileManager_WindowsForms.ViewModels;

namespace FileManager_WindowsForms.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.fluentFormContainerMain = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.navigationFrameMain = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPagePrimaryFiles = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.label1 = new System.Windows.Forms.Label();
            this.accordianMain = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.elementMain = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementPrimaryFiles = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementMisc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentFormControlMain = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.mvvmContextMain = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.primaryFilesMain = new FileManager_WindowsForms.Views.PrimaryFiles();
            this.fluentFormContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrameMain)).BeginInit();
            this.navigationFrameMain.SuspendLayout();
            this.navigationPagePrimaryFiles.SuspendLayout();
            this.navigationPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordianMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContextMain)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentFormContainerMain
            // 
            this.fluentFormContainerMain.Controls.Add(this.navigationFrameMain);
            this.fluentFormContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentFormContainerMain.Location = new System.Drawing.Point(173, 30);
            this.fluentFormContainerMain.Margin = new System.Windows.Forms.Padding(2);
            this.fluentFormContainerMain.Name = "fluentFormContainerMain";
            this.fluentFormContainerMain.Size = new System.Drawing.Size(1027, 770);
            this.fluentFormContainerMain.TabIndex = 0;
            // 
            // navigationFrameMain
            // 
            this.navigationFrameMain.Controls.Add(this.navigationPagePrimaryFiles);
            this.navigationFrameMain.Controls.Add(this.navigationPageSettings);
            this.navigationFrameMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrameMain.Location = new System.Drawing.Point(0, 0);
            this.navigationFrameMain.Name = "navigationFrameMain";
            this.navigationFrameMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPagePrimaryFiles,
            this.navigationPageSettings});
            this.navigationFrameMain.SelectedPage = this.navigationPagePrimaryFiles;
            this.navigationFrameMain.Size = new System.Drawing.Size(1027, 770);
            this.navigationFrameMain.TabIndex = 0;
            this.navigationFrameMain.Text = "navigationFrame1";
            // 
            // navigationPagePrimaryFiles
            // 
            this.navigationPagePrimaryFiles.Controls.Add(this.primaryFilesMain);
            this.navigationPagePrimaryFiles.Name = "navigationPagePrimaryFiles";
            this.navigationPagePrimaryFiles.Size = new System.Drawing.Size(1027, 770);
            // 
            // navigationPageSettings
            // 
            this.navigationPageSettings.Caption = "navigationPageSettings";
            this.navigationPageSettings.Controls.Add(this.label1);
            this.navigationPageSettings.Name = "navigationPageSettings";
            this.navigationPageSettings.Size = new System.Drawing.Size(1027, 770);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // accordianMain
            // 
            this.accordianMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordianMain.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elementMain,
            this.elementMisc});
            this.accordianMain.Location = new System.Drawing.Point(0, 30);
            this.accordianMain.Margin = new System.Windows.Forms.Padding(2);
            this.accordianMain.Name = "accordianMain";
            this.accordianMain.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordianMain.Size = new System.Drawing.Size(173, 770);
            this.accordianMain.TabIndex = 1;
            this.accordianMain.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // elementMain
            // 
            this.elementMain.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elementPrimaryFiles});
            this.elementMain.Expanded = true;
            this.elementMain.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementMain.ImageOptions.SvgImage")));
            this.elementMain.Name = "elementMain";
            this.elementMain.Text = "File Managers";
            // 
            // elementPrimaryFiles
            // 
            this.elementPrimaryFiles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementPrimaryFiles.ImageOptions.SvgImage")));
            this.elementPrimaryFiles.Name = "elementPrimaryFiles";
            this.elementPrimaryFiles.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elementPrimaryFiles.Text = "Primary Files";
            // 
            // elementMisc
            // 
            this.elementMisc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elementSettings});
            this.elementMisc.Expanded = true;
            this.elementMisc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementMisc.ImageOptions.SvgImage")));
            this.elementMisc.Name = "elementMisc";
            this.elementMisc.Text = "Settings";
            // 
            // elementSettings
            // 
            this.elementSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementSettings.ImageOptions.SvgImage")));
            this.elementSettings.Name = "elementSettings";
            this.elementSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elementSettings.Text = "Settings";
            // 
            // fluentFormControlMain
            // 
            this.fluentFormControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentFormControlMain.FluentDesignForm = this;
            this.fluentFormControlMain.Location = new System.Drawing.Point(0, 0);
            this.fluentFormControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.fluentFormControlMain.Name = "fluentFormControlMain";
            this.fluentFormControlMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentFormControlMain.Size = new System.Drawing.Size(1200, 30);
            this.fluentFormControlMain.TabIndex = 2;
            this.fluentFormControlMain.TabStop = false;
            // 
            // mvvmContextMain
            // 
            this.mvvmContextMain.ContainerControl = this;
            this.mvvmContextMain.ViewModelType = typeof(FileManager_WindowsForms.ViewModels.MainViewModel);
            // 
            // primaryFilesMain
            // 
            this.primaryFilesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryFilesMain.Location = new System.Drawing.Point(0, 0);
            this.primaryFilesMain.Name = "primaryFilesMain";
            this.primaryFilesMain.Size = new System.Drawing.Size(1027, 770);
            this.primaryFilesMain.TabIndex = 2;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlContainer = this.fluentFormContainerMain;
            this.Controls.Add(this.fluentFormContainerMain);
            this.Controls.Add(this.accordianMain);
            this.Controls.Add(this.fluentFormControlMain);
            this.FluentDesignFormControl = this.fluentFormControlMain;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.NavigationControl = this.accordianMain;
            this.Text = "File Vision Manager";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.fluentFormContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrameMain)).EndInit();
            this.navigationFrameMain.ResumeLayout(false);
            this.navigationPagePrimaryFiles.ResumeLayout(false);
            this.navigationPageSettings.ResumeLayout(false);
            this.navigationPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordianMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContextMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentFormContainerMain;
        private DevExpress.XtraBars.Navigation.AccordionControl accordianMain;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementMain;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentFormControlMain;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContextMain;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementMisc;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrameMain;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPagePrimaryFiles;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementPrimaryFiles;
        private System.Windows.Forms.Label label1;
        private PrimaryFiles primaryFilesMain;
    }
}

