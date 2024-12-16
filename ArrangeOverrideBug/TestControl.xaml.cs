
using System.Diagnostics;

namespace ArrangeOverrideBug;

public partial class TestControl : ContentView
{
	public TestControl()
	{
		InitializeComponent();
	}

    protected override Size ArrangeOverride(Rect bounds)
    {
		Debug.WriteLine($"ArrangeOverride was called in {nameof(TestControl)}");
        return base.ArrangeOverride(bounds);
    }
}