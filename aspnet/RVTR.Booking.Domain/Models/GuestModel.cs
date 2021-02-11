using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RVTR.Booking.Domain.Models
{
  public class GuestModel : IValidatableObject
  {
    public int Id { get; set; }
    public int? BookingModelId { get; set; }
    public string FirstName { get; set; }
    public string LasstName { get; set; }
    public bool IsMinor { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => new List<ValidationResult>();
  }
}
