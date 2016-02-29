### What is it

This is a Xamarin.Android bindings for ["Material DateTime Picker"](https://github.com/wdullaer/MaterialDateTimePicker) from [@wdullaer](https://github.com/wdullaer)

More information: [http://sorokoletov.com/2016/02/29/material-date-time-picker-available-for-xamarin-android-apps-bindings/](http://sorokoletov.com/2016/02/29/material-date-time-picker-available-for-xamarin-android-apps-bindings/)

### How to use this library (examples)

Three simple steps:

1. Reference the bindings project in your app project (clone/copy/submodule/whatever)
2. In your activity implement interface OnTimeSetListener/OnDateSetListener 
3. Create a datepicker and show it

Basically these steps are described in the [Readme.md file of the original library](https://github.com/wdullaer/MaterialDateTimePicker/blob/master/README.md)

```
//implement OnDateSetListener
public class HomeView : BaseActionBarView<HomeViewModel>,  
Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog.IOnDateSetListener

```

```
private void OnChooseDateButtonClick(object sender, EventArgs e)
{
    Java.Util.Calendar now = Java.Util.Calendar.Instance;
    Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog dpd = 
        Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog.NewInstance(
        this,
        now.Get(Java.Util.CalendarField.Year),
        now.Get(Java.Util.CalendarField.Month),
        now.Get(Java.Util.CalendarField.DayOfMonth)
    );
    dpd.Show(FragmentManager, "Datepickerdialog");
}

public void OnDateSet(Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog p0, int p1, int p2, int p3)
{
    p0.Dismiss();
}
		
```

Make sure you are using the same version (23.1.1) of Xamarin.Android.Support.v4 package in your application project.

### Demo

<img src="Screenshots/material-date-time-picker-xamarin-android.png?raw=true" 
title="Material Date Time Picker in Xamarin.Android app" alt="Material Date Time Picker in Xamarin.Android app" width="320">

