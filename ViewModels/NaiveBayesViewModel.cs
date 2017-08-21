using NaiveBayesDemo.Common;
using System;
using System.Windows.Input;

namespace NaiveBayesDemo.ViewModels
{
    public class NaiveBayesViewModel : ViewModelBase
    {

        public NaiveBayesViewModel()
        {
            //Instantiate all commands here
            ClassifyTextCommand = new DelegateCommand(ClassifyText);
            TrainCommand = new DelegateCommand(Train);
            TestCommand = new DelegateCommand(Test);
        }

        private string _textToClassify = "";

        //PROPERTIES

        public String TextToClassify
        {
            get { return _textToClassify; }
            set { Set(ref _textToClassify, value); }
        }

        //COMMANDS
        
        public ICommand ClassifyTextCommand { get; private set; }

        private void ClassifyText()
        {
            TextToClassify += "ClassifyCommand ";
        }

        public ICommand TrainCommand { get; private set; }

        private void Train()
        {
            TextToClassify += "TrainCommand ";
        }

        public ICommand TestCommand { get; private set; }

        private void Test()
        {
            TextToClassify = "TRIGGER";
        }
    }
}
