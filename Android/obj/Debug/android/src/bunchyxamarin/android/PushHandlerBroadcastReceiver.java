package bunchyxamarin.android;


public class PushHandlerBroadcastReceiver
	extends gcm.client.GcmBroadcastReceiverBase_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("bunchyXamarin.Android.PushHandlerBroadcastReceiver, bunchyXamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PushHandlerBroadcastReceiver.class, __md_methods);
	}


	public PushHandlerBroadcastReceiver () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PushHandlerBroadcastReceiver.class)
			mono.android.TypeManager.Activate ("bunchyXamarin.Android.PushHandlerBroadcastReceiver, bunchyXamarin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
