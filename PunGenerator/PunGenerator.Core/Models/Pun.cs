using SQLite;

namespace PunGenerator.Core.Models
{
	public class Pun
	{
		[PrimaryKey, AutoIncrement]
		public int? Id { get; set; }

		public string Question { get; set; }

		public string Answer { get; set; }
	}
}
