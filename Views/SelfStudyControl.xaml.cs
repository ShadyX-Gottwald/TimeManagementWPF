using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_TIME_MANAGEMENT.ViewModel;

namespace WPF_TIME_MANAGEMENT.Views {
    /// <summary>
    /// Interaction logic for SelfStudyControl.xaml
    /// </summary>
    public partial class SelfStudyControl :UserControl {
        public SelfStudyControl() {
            InitializeComponent();
            this.DataContext = new SemesterViewModel();
        }
    }
}
