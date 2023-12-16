namespace Resort_Demo_Project.Models
{
	public class District
	{
		public int IdDistrict { get; set; }
		public string Name { get; set; }
		public virtual Province Province { get; set; }
		public virtual ICollection<Commune> Communes { get; set; }
	}
}
