using Sequel.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Sequel.Models
{
    public class BigIntModelFoundation
    {
        [Key]
        [IdentityKey]
        public Int64 id { get; set; }
    }
}
