using RecipeStystem;

namespace RecipeMAUI;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        UserNameTxt.Text = Preferences.Get("username", "");
        PasswordTxt.Text = Preferences.Get("password", "");
    }

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            MessageLbl.Text = "";
            DBManager.SetConnectionString(App.ConnStringSetting, true, UserNameTxt.Text, PasswordTxt.Text);
            App.LoggedIn = true;
            Preferences.Set("username", UserNameTxt.Text);
            Preferences.Set("password", PasswordTxt.Text);
            await Navigation.PopModalAsync();
        }
        catch(Exception ex)
        {
            MessageLbl.Text = ex.Message;
        }
    }

    private void CancelBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}