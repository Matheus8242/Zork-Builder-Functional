using ZorkBuilder.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zork.Builder.WinForms.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename 
        { 
            get => mFilename;
            set 
            {
                if(mFilename != value)
                {
                    mFilename = value;
                    OnPropertyChanged();
                }
            } 
        }
        public GameWorld Gameworld { get; set; }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string mFilename;
    }
}
