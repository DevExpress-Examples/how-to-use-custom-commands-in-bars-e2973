using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DXVisualizer;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            DataContext = this;
            InitializeComponent();
        }
    }

    public class MyCommand : ICommand {        
        public MyCommand() {

        }
        #region ICommand Members

        public bool CanExecute(object parameter) {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter) {
            ((MainPage)parameter).biButton1.IsEnabled = !((MainPage)parameter).biButton1.IsEnabled;
        }

        #endregion
    }


    public class MyCommands {
        public MyCommand Command { get; set; }
        public MyCommands() {
            Command = new MyCommand();
        }
    }

}
