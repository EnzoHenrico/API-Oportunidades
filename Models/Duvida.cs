using System.ComponentModel.DataAnnotations;

namespace Models;

public class Duvida
{
    [Key]
    public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataDuvida { get; set; }
}