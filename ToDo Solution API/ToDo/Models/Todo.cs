using System;
namespace ToDo.Models
{
	public class Todo
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public bool isFinished { get; set; } = false;
    }
}

