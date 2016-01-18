using AwesomeGridScaffolder.VSExtension.UI;
using System;
using System.Windows;

namespace AwesomeGridScaffolder.WebForms.UI
{
    /// <summary>
    /// Interaction logic for NewDataContextDialog.xaml
    /// </summary>
    internal partial class NewDataContextDialog : VSPlatformDialogWindow
    {
        private readonly WebFormsNewDataContextViewModel _viewModel;

        public NewDataContextDialog(WebFormsNewDataContextViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            _viewModel.Close += result => DialogResult = result;
        }
    }
}
