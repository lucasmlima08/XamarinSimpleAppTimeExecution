using Android.App;
using Android.Widget;
using Android.OS;

namespace TesteDesempenhoXMN
{
	[Activity (Label = "TesteDesempenhoXMN", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button reset = FindViewById<Button> (Resource.Id.reset);
			Button calculate = FindViewById<Button> (Resource.Id.calculate);

			EditText value = FindViewById<EditText> (Resource.Id.value);

			TextView result = FindViewById<TextView> (Resource.Id.result);

			// Eventos
			reset.Click += delegate {
				value.Text = "";
				result.Text = "| Resultado |";
			};

			calculate.Click += delegate {
				int valueInt = int.Parse(value.Text);

				var watch = System.Diagnostics.Stopwatch.StartNew();
				for (int i = 0; i < valueInt; i++);
				long elapsedMs = watch.ElapsedMilliseconds;

				result.Text = "Resultado: "+elapsedMs;
			};
		}
	}
}