using Android.App;
using Android.Content;
using Android.OS;
using System;
using System.Collections.Generic;
using System.Text;

namespace rowad
{
    [Service]
    public class XamarinService : IntentService
    {
        private bool stopping = false;
        protected override void OnHandleIntent(Intent intent)
        {
            // some long-running task
            while (!stopping)
            {
            }
            StartService(new Intent(this, typeof(XamarinService)));
            StopService(new Intent(this, typeof(XamarinService)));
        }
    }
}
