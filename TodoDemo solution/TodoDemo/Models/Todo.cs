using System;
namespace TodoDemo.Models
{
	public class Todo
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string? description { get; set; }
		public DateTime createdDate { get; set; }
		public bool isFinished { get; set; }
	}
}

