using NaiveBayesDemo.ViewModels;
using System.Windows.Controls;

namespace NaiveBayesDemo.Views
{
    /// <summary>
    /// Interaction logic for NaiveBayesView.xaml
    /// </summary>
    public partial class NaiveBayesView : UserControl
    {
        public NaiveBayesView()
        {
            InitializeComponent();
        }

        protected NaiveBayesViewModel Model
        {
            get { return (NaiveBayesViewModel)Resources["ViewModel"]; }
        }
    }
}
