namespace Resort_Demo_Project.Models
{
	public class ConvenientResort
	{
		public int IdConvenient { get; set; }
		public int IdResort { get; set; }
		public virtual Convenient Convenient { get; set; }
		public virtual Resort Resort { get; set; }
	}
}
