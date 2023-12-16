namespace Resort_Demo_Project.Models
{
	public class Rate
	{
		public int IdRate { get; set; }
		public int IdUser { get; set; }
		public int RateStar { get; set; }
		public virtual User User { get; set; }
		public virtual Resort Resort { get; set; }
	}
}
