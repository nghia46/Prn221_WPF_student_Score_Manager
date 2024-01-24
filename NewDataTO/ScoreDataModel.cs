using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;

public class ScoreDataModel
{
    [Name("SBD")]
    [Key]
    public required int? SBD { get; set; }
    [Name("Toan")]
    public required string Toan { get; set; }
    [Name("Van")]
    public required decimal? Van { get; set; }
    [Name("Ly")]
    public required decimal? Ly { get; set; }
    [Name("Sinh")]
    public required decimal? Sinh { get; set; }
    [Name("NgoaiNgu")]
    public required decimal? NgoaiNgu { get; set; }
    [Name("Year")]
    public required decimal? Year { get; set; }
    [Name("Hoa")]
    public required decimal? Hoa { get; set; }
    [Name("LichSu")]
    public required decimal? LichSu { get; set; }
    [Name("DiaLy")]
    public required decimal? DiaLy { get; set; }
    [Name("GDCD")]
    public required decimal? GDCD { get; set; }
    [Name("MaTinh")]
    public required decimal? MaTinh { get; set; }
}
