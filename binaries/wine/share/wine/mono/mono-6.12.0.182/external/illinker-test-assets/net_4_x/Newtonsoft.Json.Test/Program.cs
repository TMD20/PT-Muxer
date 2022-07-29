using Newtonsoft.Json;

class MainClass 
{
	public static void Main (string [] args)
	{
		new MainClass ();
		JsonConvert.DeserializeObject<MainClass> ("{}");
	}
}
