﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using PDFPatcher.Model;

namespace PDFPatcher
{
	public abstract class DocumentOptions
	{
		[XmlElement ("指定元数据")]
		public GeneralInfo MetaData { get; set; }

		[XmlElement ("阅读器设置")]
		public ViewerOptions ViewerPreferences { get; set; }

		[XmlIgnore]
		internal List<PageLabel> PageLabels { get; private set; }

		[XmlAttribute ("压缩索引表和书签")]
		public bool FullCompression { get; set; }

		[XmlAttribute ("统一页面方向")]
		public bool UnifyPageOrtientation { get; set; }

		/// <summary>
		/// 设置统一页面方向要旋转的页面。默认旋转横向的页面。
		/// </summary>
		[XmlAttribute ("旋转源页面方向")]
		public bool RotateVerticalPages { get; set; }

		/// <summary>
		/// 设置统一页面旋转页面的方向。默认为顺时针旋转。
		/// </summary>
		[XmlAttribute ("旋转方向")]
		public bool RotateAntiClockwise { get; set; }

		protected DocumentOptions () {
			this.FullCompression = true;
			this.PageLabels = new List<PageLabel> ();
			this.ViewerPreferences = new ViewerOptions ();
			this.MetaData = new GeneralInfo ();
		}
	}
}