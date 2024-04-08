using MauiShellTransitionTest.Pages;

namespace MauiShellTransitionTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ModalPage), typeof(ModalPage));
            Routing.RegisterRoute(nameof(ModelessPage), typeof(ModelessPage));
        }
    }
}
