using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebLab.Api.Models
{
    [Table("todo")]
    public class Todo
    {
        public long id { get; set; }
        public string name { get; set; }
        public bool is_complete { get; set; }
    }
}
