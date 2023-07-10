using AINewsApp.Model;
using AINewsApp.Services;
using AINewsApp.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AINewsApp.ViewModel
{
    public partial class AINewsViewModel : ObservableObject
    {
        private AINewsService newsService;
        public ObservableCollection<AINews> NewsCollection { get; set; } = new ObservableCollection<AINews>();
        public AINewsViewModel(AINewsService newsService)
        {
            this.newsService = newsService;
            GetNewsList();
        }

        private async void GetNewsList()
        {
            var news = await newsService.GetNewsAsync();
            foreach (var item in news)
            {
                NewsCollection.Add(item);
            }
        }

        /*[ObservableProperty]
        AINews selectedNews;


        [RelayCommand]
        void GoToDetails()
        {
            if (SelectedNews == null) return;
            Shell.Current.GoToAsync($"{nameof(AINewsDetailPage)}",
                new Dictionary<string, object>
                {
                    {"News", SelectedNews}
                });
            SelectedNews = null;
        }*/
        [RelayCommand]
        void GoToDetails(AINews news)
        {
            if (news == null) return;
            Shell.Current.GoToAsync($"{nameof(AINewsDetailPage)}",
                new Dictionary<string, object>
                {
                    {"News", news}
                });
            news = null;
        }
    }
}
