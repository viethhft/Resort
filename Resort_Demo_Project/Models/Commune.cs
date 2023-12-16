namespace Resort_Demo_Project.Models
{
	public class Commune
	{
		public int IdCommune { get; set; }
		public string Name { get; set; }
		public virtual District District { get; set; }
		public virtual Resort Resort { get; set; }
	}
}
