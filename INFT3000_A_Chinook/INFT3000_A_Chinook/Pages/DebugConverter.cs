using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;

namespace INFT3000_A_Chinook.Pages  
{
    public class DebugConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // // This line will break into the debugger when the binding updates.
            // You can inspect the 'value' being passed in to see what data is being bound.
            Debugger.Break();

            // Just pass the value through without actually converting it.
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // This line will also break into the debugger when the binding is reversed.
            Debugger.Break();

            // Just pass the value back through without actually converting it.
            return value;
        }
    }
}
