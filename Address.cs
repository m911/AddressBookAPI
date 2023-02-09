﻿using System.ComponentModel.DataAnnotations;

namespace AddressBookAPI
{
	public class Address
	{
		[Key]
		public int AddressId { get; set; }

		[Required]
		[StringLength(20)]
		public string FirstName { get; set; } = string.Empty;

		[Required]
		[StringLength(20)]
		public string LastName { get; set; } = string.Empty;

		[Required]
		public string Telephone { get; set; } = string.Empty;

		[Required]
		public string UserAddress { get; set; } = string.Empty;

		public DateTime LastUpdatedOn { get; set; }

		public int LastUpdatedBy { get; set; }
	}
}
