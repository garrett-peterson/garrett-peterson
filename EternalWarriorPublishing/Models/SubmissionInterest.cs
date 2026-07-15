using System.ComponentModel.DataAnnotations;

namespace EternalWarriorPublishing.Models;

public class SubmissionInterest
{
    [Required(ErrorMessage = "Author name is required.")]
    public string AuthorName { get; set; } = "";

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Story title is required.")]
    public string StoryTitle { get; set; } = "";

    [Required(ErrorMessage = "Genre is required.")]
    public string Genre { get; set; } = "Epic Fantasy";

    [Required(ErrorMessage = "Short pitch is required.")]
    [MinLength(25, ErrorMessage = "The pitch should be at least 25 characters.")]
    public string Pitch { get; set; } = "";
}