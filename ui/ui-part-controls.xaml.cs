﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace xigt2
{
	public partial class ui_part_controls : StackPanel
	{
		public ui_part_controls()
		{
			InitializeComponent();
		}

		protected override HitTestResult HitTestCore(PointHitTestParameters htp)
		{
			var htr = base.HitTestCore(htp);
			if (htr == null)
				htr = new PointHitTestResult(this, htp.HitPoint);
			return htr;
		}
	};
}
