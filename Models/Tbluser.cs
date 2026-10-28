using System.ComponentModel.DataAnnotations;

namespace corefirst_211026.Models
{
    public class Tbluser
    {
        [Key]
        public int uid { get; set; }
        public string uname { get; set; }
        public int uage { get; set; }

    }
}
