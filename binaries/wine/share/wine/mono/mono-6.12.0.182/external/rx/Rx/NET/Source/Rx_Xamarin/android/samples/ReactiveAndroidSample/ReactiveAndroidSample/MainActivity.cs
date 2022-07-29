using System;
using System.Reactive;
using System.Reactive.Linq;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace ReactiveAndroidSample
{
	[Activity (Label = "ReactiveAndroidSample", MainLauncher = true)]
	public class Activity1 : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			var text = FindViewById<TextView> (Resource.Id.theText);

			var surface = FindViewById<View> (Resource.Id.theToucheable);

			triple_touch_source = Observable.FromEventPattern<View.TouchEventArgs> (surface, "Touch")
				.Where (ev => ev.EventArgs.Event.Action == MotionEventActions.Move)
				.Where (ev => ev.EventArgs.Event.PointerCount == 3)
				//.SubscribeOn (Application.SynchronizationContext)
				.ToEventPattern ();

			TripleTouch += (sender, ev) => 
				this.RunOnUiThread (() => 
				                    text.Text = GetEventDescription (ev.Event));
		}

		IEventPatternSource<View.TouchEventArgs> triple_touch_source;

		public event EventHandler<View.TouchEventArgs> TripleTouch {
			add { triple_touch_source.OnNext += value; }
			remove { triple_touch_source.OnNext -= value; }
		}

		static string GetEventDescription (MotionEvent e)
		{
			return string.Format ("({0}, {1})", e.RawX, e.RawY);
		}
	}
}
