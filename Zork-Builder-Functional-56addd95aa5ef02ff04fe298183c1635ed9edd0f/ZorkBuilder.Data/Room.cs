using System.ComponentModel;
using ZorkBuilder.Data;

namespace ZorkBuilder.Data
{
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
    }
}
