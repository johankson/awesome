using System;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Graphics;
using Xamarin.Forms;
using Awesome.Droid;

[assembly: ExportRenderer(typeof(Label), typeof(AwesomeRenderer))]

namespace Awesome.Droid
{
    public class AwesomeRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var label = (TextView)Control;

            var text = label.Text;
            if(text.Length > 1 || text[0] < 0xf000)
            {
                return;
            }

            var font = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "fontawesome.ttf");
            label.Typeface = font;
        }
    }
}
   