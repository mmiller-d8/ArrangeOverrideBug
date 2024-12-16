
using System.Diagnostics;

namespace ArrangeOverrideBug;

public partial class MainPage : ContentPage
{

	private bool _wasArranged;

	public MainPage()
	{
		InitializeComponent();
	}



    protected override Size ArrangeOverride(Rect bounds)
    {
		_wasArranged = true;
		Debug.WriteLine($"ArrangeOverride was called in {nameof(MainPage)}");
        return base.ArrangeOverride(bounds);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

		if (!_wasArranged)
			Debug.WriteLine($"ArrangeOverride was ** N O T ** called in {nameof(MainPage)}");
    }
}

