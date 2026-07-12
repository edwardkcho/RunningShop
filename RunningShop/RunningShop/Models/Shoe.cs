using System.ComponentModel.DataAnnotations.Schema;

namespace RunningShop.Models;

public class Shoe
{
    public int ShoeID { get; set; }

    [ForeignKey("Brand")]
    public int BrandID { get; set; }

    public string ShoeModel { get; set; }

    public double Size { get; set; }

    public string Width { get; set; }

    public string Description { get; set; }

    public string ShoeImageLink { get; set; }

    public double Price { get; set; }

    public bool IsActive { get; set; }

    public char Gender { get; set; }
}