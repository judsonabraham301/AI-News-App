using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using CommunityToolkit.Mvvm.ComponentModel;
using AINewsApp.Model;

namespace AINewsApp.ViewModel
{
    [QueryProperty(nameof(News), "News")]
    public partial class AINewsDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        AINews news;

    }
}
