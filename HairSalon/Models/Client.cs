using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Note { get; set; }
  }

}