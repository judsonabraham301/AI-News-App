using AINewsApp.ViewModel;

namespace AINewsApp.View;

public partial class AINewsPage : ContentPage
{
    public AINewsPage(AINewsViewModel newsViewModel)
    {
        InitializeComponent();
        BindingContext = newsViewModel;
    }
}