using BuyAndSellTrading.Models;
using CommunityToolkit.Mvvm.Input;

namespace BuyAndSellTrading.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}