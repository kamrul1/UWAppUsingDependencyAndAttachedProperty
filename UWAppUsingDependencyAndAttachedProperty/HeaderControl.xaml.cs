using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UWAppUsingDependencyAndAttachedProperty
{
    public sealed partial class HeaderControl : UserControl
    {
        //dependency property
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title"
            , typeof(string)
            , typeof(HeaderControl)
            , new PropertyMetadata(String.Empty, new PropertyChangedCallback(TitleChanged)) //default value and callback methods
        );

        //call back method
        private static void TitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //as static need to cast headcontrol to get it back
            HeaderControl control = d as HeaderControl;
            control.HeaderText.Text = e.NewValue.ToString();
        }

        //implement property wrappers to make callback method easy to use
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public HeaderControl()
        {
            this.InitializeComponent();
        }
    }
}
