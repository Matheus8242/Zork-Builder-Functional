using ZorkBuilder.Data;
using System.ComponentModel;

namespace Zork.Builder.WinForms.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }
        public GameWorld Gameworld { get; set; }
    }
}
