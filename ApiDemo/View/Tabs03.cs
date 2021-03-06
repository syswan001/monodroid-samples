/*
 * Copyright (C) 2008 The Android Open Source Project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Views;

namespace MonoDroid.ApiDemo
{
	/**
 	* An example of tab content that launches an activity via {@link android.widget.TabHost.TabSpec#setContent(android.content.Intent)}
 	*/
	[Activity (Label = "Views/Tabs/03. Content By Intent")]
	[IntentFilter (new[] { Intent.ActionMain }, Categories = new string[] { ApiDemo.SAMPLE_CATEGORY })]
	public class Tabs03 : TabActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			TabHost.AddTab (TabHost.NewTabSpec ("tab1").SetIndicator ("list")
			               .SetContent (new Intent (this, typeof (List1))));

			TabHost.AddTab (TabHost.NewTabSpec ("tab2").SetIndicator ("photo list")
			               .SetContent (new Intent (this, typeof (List8))));

			// This tab sets the intent flag so that it is recreated each time
			// the tab is clicked.
			TabHost.AddTab (TabHost.NewTabSpec ("tab3").SetIndicator ("destroy")
			               .SetContent (new Intent (this, typeof (Controls1))
			            .AddFlags (ActivityFlags.ClearTop)));
		}
	}
}