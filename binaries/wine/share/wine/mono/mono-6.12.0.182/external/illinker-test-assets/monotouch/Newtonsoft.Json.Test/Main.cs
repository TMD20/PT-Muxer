using UIKit;

namespace Newtonsoft.Json.Test {
	public class Application {
		// This is the main entry point of the application.
		static void Main (string [] args)
		{
			new EmptyClass ();
			JsonConvert.DeserializeObject<EmptyClass> ("{}");

			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
