namespace MenuAtividadeFlyout;

public partial class AppFlyoutPage : FlyoutPage
{
	public AppFlyoutPage()
	{
		InitializeComponent();
        //Define que a página inicial aberta dentro do Detail é a MainPage (Home)
        Detail = new NavigationPage(new MainPage());
    }

    private void OndemonslayerClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new DemonSlayerPage());
        IsPresented = false;
    }

    private void OnnarutoClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new NarutoPage());
        IsPresented = false;
    }

    private void OnonepieceClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new OnePiecePage());
        IsPresented = false;
    }

    private void OnonepunchmanClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new OnePunchManPage());
        IsPresented = false;
    }
}