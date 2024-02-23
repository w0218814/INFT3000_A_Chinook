using System;
using System.Globalization;
using System.Windows.Data;


namespace INFT3000_A_Chinook.Converters  
{
    // Converts milliseconds to a string representation in minutes.
    public class MillisecondsToMinutesConverter : IValueConverter
    {
        // Converts the input milliseconds to minutes as a string.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Check if the input value is an integer.
            if (value is int milliseconds)
            {
                // Calculate minutes from milliseconds and format the string.
                return (milliseconds / 60000.0).ToString("0.##") + " minutes";
            }
            // Return "0 minutes" if conversion is not possible.
            return "0 minutes";
        }

        // ConvertBack is not implemented as the conversion is one-way.
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    // Converts bytes to a string representation in megabytes.
    public class BytesToMegabytesConverter : IValueConverter
    {
        // Converts the input bytes to megabytes as a string.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Check if the input value is an integer.
            if (value is int bytes)
            {
                // Calculate megabytes from bytes and format the string.
                return (bytes / 1048576.0).ToString("0.##") + " MB";
            }
            // Return "0 MB" if conversion is not possible.
            return "0 MB";
        }

        // ConvertBack is not implemented as the conversion is one-way.
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
