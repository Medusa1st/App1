using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1
{
    // 更改Label的值可更改APP名称和APP内标题
    // 更改Icon的值可更改图标图片
    [Activity(Label = "小安琪成长记", MainLauncher = true, Icon = "@drawable/aq")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("我们的小安琪{0}岁啦!", count++); };

        }
    }
}

