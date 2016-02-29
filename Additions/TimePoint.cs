namespace Com.Wdullaer.Materialdatetimepicker.Time
{
    /*
     * add partial class due to Java generics and IComparable interface in Xamarin.Android
     * Vendor/MaterialDateTimePickerBinding/obj/Debug/generated/src/Com.Wdullaer.Materialdatetimepicker.Time.Timepoint.cs(23,23): Error CS0535: `Com.Wdullaer.Materialdatetimepicker.Time.Timepoint' does not implement interface member `Java.Lang.IComparable.CompareTo(Java.Lang.Object)' (CS0535) (MaterialDateTimePickerBinding)
     * https://forums.xamarin.com/discussion/1950/binding-jar-file-with-class-that-implements-java-lang-icomparable
     */
    public partial class Timepoint
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object obj)
        {
            return CompareTo ((Timepoint) obj);
        }
    }
}