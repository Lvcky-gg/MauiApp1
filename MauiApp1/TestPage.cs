using static System.Net.Mime.MediaTypeNames;

namespace MauiApp1;

public class TestPage : ContentPage
{
    int count = 0;
    Label counterLabel;
    public TestPage()
	{
        var scrollView = new ScrollView();
        var stackLayout = new StackLayout();
        scrollView.Content = stackLayout;

        counterLabel = new Label { Text = "Count: 1",FontSize = 22, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center};
        stackLayout.Children.Add(counterLabel);
        var btnCounter = new Button {Text = "Click To Count", HorizontalOptions = LayoutOptions.Center };
        stackLayout.Children.Add(btnCounter);
        btnCounter.Clicked += OnClickedEvent;
        this.Content = scrollView;

    }

    private void OnClickedEvent(Object sender, EventArgs e)
    {
        count++;
        counterLabel.Text = $"Click Count {count}";

        SemanticScreenReader.Announce(counterLabel.Text);
    }
}