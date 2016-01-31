using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

/// <summary>
/// This example shows Register Attached, rather then just attached.
/// </summary>
namespace UWAppUsingDependencyAndAttachedProperty
{
    public class DialogProperties: DependencyObject
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached(
                "Text"
                , typeof(string)
                , typeof(DialogProperties)
                , null    
            );


        public static string GetText(UIElement element)
        {
            return (string)element.GetValue(TextProperty);
        }

        public static void SetText(UIElement element, string value)
        {
            element.SetValue(TextProperty, value);
        }
    }
}
