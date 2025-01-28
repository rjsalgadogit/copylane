using Sequel.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Sequel.Models
{
    public class ModelFoundation
    {
        [Key]
        [IdentityKey]
        public int id { get; set; }
    }
}
