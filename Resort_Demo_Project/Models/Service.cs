namespace Resort_Demo_Project.Models
{
	public class Service
	{
		public int IdService { get; set; }
		public string NameService { get; set; }
		public virtual ICollection<ResortDetailServices> ResortDetailServices { get; set;}
	}
}
