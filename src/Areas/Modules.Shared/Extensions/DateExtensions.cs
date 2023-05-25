namespace Modules.Shared.Extensions
{
    public static class DateExtensions
    {
        public static string FormatDate
        {
            get { return "dd/MM/yyyy"; }
        }
        public static string FormatTime
        {
            get { return "HH:mm:ss"; }
        }
        public static string FormatDateFull
        {
            get { return "dd/MM/yyyy HH:mm:ss"; }
        } 
    }
}