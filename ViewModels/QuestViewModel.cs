using System.ComponentModel;
using System.Runtime.CompilerServices;
using SummonerSaveFileEditor.Models;

namespace SummonerSaveFileEditor.ViewModels
{
    public class QuestViewModel : INotifyPropertyChanged
    {
        private readonly QuestEntry _quest;

        public QuestViewModel(QuestEntry quest)
        {
            _quest = quest;
        }

        public int QuestId => _quest.QuestId;
        public string Name => _quest.Name;

        public bool Visible
        {
            get => _quest.Visible;
            set
            {
                if (_quest.Visible != value)
                {
                    _quest.Visible = value;
                    OnPropertyChanged();
                }
            }
        }

        public QuestEntry Model => _quest;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}