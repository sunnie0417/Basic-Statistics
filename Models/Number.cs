using System;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models;

public class NumbersModel
{
    [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Must enter a valid numeric number")]
    public string? Number1 { get; set; }
    [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Must enter a valid numeric number")]
    public string? Number2 { get; set; }
    [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Must enter a valid numeric number")]
    public string? Number3 { get; set; }
    [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Must enter a valid numeric number")]
    public string? Number4 { get; set; }
}
