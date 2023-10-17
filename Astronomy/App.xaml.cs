namespace Astronomy;

public partial class App : Application
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyPage));
    }
}
