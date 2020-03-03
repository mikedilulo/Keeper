using System;

namespace Keepr.Models
{
  public class Vault
  {
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Img { get; set; }
    public bool IsPrivate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime TimeStamp { get; }
  }
}