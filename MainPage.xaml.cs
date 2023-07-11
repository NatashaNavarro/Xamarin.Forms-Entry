namespace Xamarin.Forms_Entry;

///<Summary>
///<Createddate> 2023/07/11 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2023/07/11 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Natasha Navarro </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Entry_Changed(object sender, TextChangedEventArgs e)
    {
        string pasado = e.OldTextValue;
        string nuevo = e.NewTextValue;
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}

