using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Model
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int IssueYear { get; set; }

        public Brand Brand { get; set; }
    }
}
