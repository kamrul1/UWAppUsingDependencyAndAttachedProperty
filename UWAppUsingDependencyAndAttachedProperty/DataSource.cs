using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This demonstrates data binding to our custom header control
/// </summary>
namespace UWAppUsingDependencyAndAttachedProperty
{
    public class DataSource
    {
        public string DialogValue
        {
            get { return "Dialog Hooray!"; }
        }

        public string TitleValue
        {
            get { return "Title Hooray!"; }
        }
    }
}
