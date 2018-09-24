namespace IssueTracker.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Issue
    {
       [Key]
	   public int Id { get; set; }
	   
	   [Required]
	   public string Title { get; set; }

	   [Required]
       public string Content { get; set; }

       [Required]
       public int Priority { get; set; }
    }
}
