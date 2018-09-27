﻿using System;
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
using Syncfusion.Windows.Shared;

namespace WorkFlowEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext for WorkFlowEditor
            ProcessAutomationViewModel VM = new ProcessAutomationViewModel();
            VM.GoBack = new DiagramFrontPageUtility.DelegateCommand<object>(OnGoBack);
            this.DataContext = VM;
        }

        private void OnGoBack(object parameter)
        {
            ProcessAutomationViewModel VM = this.DataContext as ProcessAutomationViewModel;
            VM.GoBack = null;
            this.DataContext = null;
            //Frame.GoBack();
        }
    }
}