using System;
using AwesomeGridScaffolder.VSExtension.UI;

namespace AwesomeGridScaffolder.WebForms.UI
{
    /// <summary>
    /// Interaction logic for WebFormsScaffolderDialog.xaml
    /// </summary>
    internal partial class WebFormsScaffolderDialog : VSPlatformDialogWindow
    {
        public WebFormsScaffolderDialog(WebFormsCodeGeneratorViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("viewModel");
            }
            
            InitializeComponent();
            
            viewModel.PromptForNewDataContextTypeName += model =>
            {
                var dialog = new NewDataContextDialog(model);
                var result = dialog.ShowDialog();
                model.Canceled = !result.HasValue || !result.Value;
            };

            viewModel.Close += result => DialogResult = result;

            DataContext = viewModel;
        }
    }
}
