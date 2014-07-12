package xamarin.forms.labs.droid.controls.calendar;


public class CalendarPickerView
	extends android.widget.ListView
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Labs.Droid.Controls.Calendar.CalendarPickerView, Xamarin.Forms.Labs.Droid, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", CalendarPickerView.class, __md_methods);
	}


	public CalendarPickerView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == CalendarPickerView.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Labs.Droid.Controls.Calendar.CalendarPickerView, Xamarin.Forms.Labs.Droid, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public CalendarPickerView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == CalendarPickerView.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Labs.Droid.Controls.Calendar.CalendarPickerView, Xamarin.Forms.Labs.Droid, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public CalendarPickerView (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == CalendarPickerView.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Labs.Droid.Controls.Calendar.CalendarPickerView, Xamarin.Forms.Labs.Droid, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
