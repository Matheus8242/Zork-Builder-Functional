using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using ZorkBuilder.Data;
using Zork.Builder.WinForms.ViewModels;

namespace Zork.Builder.WinForms
{
    public partial class MainForm : Form
    {
        private WorldViewModel ViewModel 
        { 
            get => mViewModel;
            set 
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            } 
        }
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void SelectFileButton_Click(object sender, System.EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Gameworld = JsonConvert.DeserializeObject<GameWorld>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }

        private WorldViewModel mViewModel;
    }
}
