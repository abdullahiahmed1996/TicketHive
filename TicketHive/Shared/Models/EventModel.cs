﻿using System.ComponentModel.DataAnnotations;

namespace TicketHive.Shared.Models
{
	public class EventModel
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = null!;
        [Required]
        public CategoryEnum Type { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public string Venue { get; set; } = null!;
        [Required]
        public int Price { get; set; }
        [Required]
        public int Capacity { get; set; }
        public bool IsSoldOut { get; set; }
		public List<UserModel>? EventUsers { get; set; } = new();
		public string? ImageUrl { get; set; }
    }
}