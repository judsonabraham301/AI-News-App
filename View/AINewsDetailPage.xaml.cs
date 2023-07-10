using AINewsApp.ViewModel;

namespace AINewsApp.View;

public partial class AINewsDetailPage : ContentPage
{
    public AINewsDetailPage(AINewsDetailViewModel newsDetailViewModel)
    {
        InitializeComponent();
        BindingContext = newsDetailViewModel;
    }
}