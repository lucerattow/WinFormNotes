using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace WinFormNotes.Data.Models
{
    [Table(Name = "Categorys")]
    public class Category
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Length = 25), NotNull]
        public string Name { get; set; }
    }
}
