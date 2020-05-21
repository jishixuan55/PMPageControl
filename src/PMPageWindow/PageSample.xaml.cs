﻿using Du.PMPage.Wpf;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
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

namespace PMPageWindow
{
    /// <summary>
    /// PageSample.xaml 的交互逻辑
    /// </summary>
    public partial class PageSample : SldPMPage
    {
        public PageSample():base()
        {
            InitializeComponent();
        }

        public PageSample(ISldWorks app) : base(app)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowBubbleTooltipAt2("hi", "msg");
        }

        private void SldPMPage_Closed(SolidWorks.Interop.swconst.swPropertyManagerPageCloseReasons_e reason)
        {

        }
    }
}