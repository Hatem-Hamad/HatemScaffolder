using System.Diagnostics.CodeAnalysis;

namespace AwesomeGridScaffolder.VSExtension.UI
{
    //Create the class to avoid referencing the assembly of "Microsoft.VisualStudio.shell.<version>.dll" in xaml,
    //becasue the same xaml source will be used by both dev11 and dev12 OOB 
    [ExcludeFromCodeCoverage]
    internal class VSPlatformDialogWindow : System.Windows.Window
    {
    }
}
