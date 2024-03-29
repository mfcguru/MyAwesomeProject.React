using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Data.Entities
{
	public class UserInRole
	{
		[Key]
		public int UserId { get; set; }
		public virtual User User { get; set; }
		[Key]
		public int RoleId { get; set; }
		public virtual Role Role { get; set; }
	}
}
