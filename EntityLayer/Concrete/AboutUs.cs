﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class AboutUs
	{
		public Guid Id { get; set; }
		public string? Title1 { get; set; }
		public string? Title2 { get; set; }
		public string? Content { get; set; }
		public int RoomCount { get; set; }
		public int StaffCount { get; set; }
		public int CustomerCount { get; set; }
	}
}

