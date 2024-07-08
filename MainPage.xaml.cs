namespace DateTimeExample;

public partial class MainPage : ContentPage
{
	public string DateTimeMin { get; } = $"Non UTC: {DateTime.MinValue.ToString()}";
	public string DateTimeMinUTC { get; } = $"Non UTC: {DateTime.MinValue.ToUniversalTime().ToString()}";

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}

