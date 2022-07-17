namespace EksiSozlukClone.Api.Domain.Models;

public class EmailConfirmation
{
    public string OldEmailAddress { get; set; }
    public string NewEmailAddress { get; set; }
}