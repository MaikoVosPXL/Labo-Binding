using ActorsApplication.Data;

namespace ActorsApplication.Pages;

public partial class ActorDetailPage : ContentPage
{
    private Actor _selectedActor;

	public ActorDetailPage()
	{
		InitializeComponent();

        _selectedActor = new Actor()
        {
            LastName = "Carell",
            FirstName = "Steve",
            BirthYear = 1962,
            ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/9/96/Steve_Carell_November_2014.jpg",
            ShortBio = "Steve Carell is an American actor, comedian, writer, and producer, best known for his role as Michael Scott in the U.S. version of The Office. He has also starred in films such as The 40-Year-Old Virgin, Foxcatcher, and Crazy, Stupid, Love. Carell's blend of comedic timing and emotional depth has earned him critical acclaim and numerous awards throughout his career."
        };
    }

    protected override void OnAppearing()
    {
        BindingContext = _selectedActor;
    }

    private void DemoChange(object sender, EventArgs e)
    {
        _selectedActor.FirstName = "Michael Gary";
        _selectedActor.LastName = "Scott";
        _selectedActor.ProfilePicture = "https://upload.wikimedia.org/wikipedia/en/thumb/d/dc/MichaelScott.png/220px-MichaelScott.png";
        _selectedActor.ShortBio = "Michael Gary Scott is a fictional character in the NBC sitcom The Office, portrayed by Steve Carell. Michael is the regional manager of the Scranton, Pennsylvania branch of Dunder Mifflin, a paper company, for the majority of the series.";
    }
}