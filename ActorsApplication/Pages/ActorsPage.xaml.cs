using ActorsApplication.Data;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ActorsApplication.Pages;

public partial class ActorsPage : ContentPage
{
    public ObservableCollection<Actor> ActorsList { get; set; }

    public ActorsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        ActorsList = new ObservableCollection<Actor>(InMemoryActors.GetActors());
        BindingContext = this;
    }

    private async void AddActorClicked(object sender, EventArgs e)
    {
        string lastName = await DisplayPromptAsync("Lastname", "");
        string firstName = await DisplayPromptAsync("Firstname", "");
        string bio = "n/a";

        Actor newActor = new Actor();
        newActor.FirstName = firstName;
        newActor.LastName = lastName;
        newActor.ShortBio = bio;
        
        // Add the actor to the list
        ActorsList.Add(newActor);
    }

    private void DeleteThisActor(object sender, EventArgs e)
    {
        Button buttonClicked = sender as Button;
        if (buttonClicked != null)
        {
            Actor actorToDelete = buttonClicked.CommandParameter as Actor;
            if (actorToDelete != null)
            {
                ActorsList.Remove(actorToDelete);
            }
        }

    }
}