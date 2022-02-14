using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace WinFormNotes.Data.Models
{
    [Table(Name = "TodoTasks")]
    public class TodoTask
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column, NotNull]
        public int Category { get; set; }

        [Column(Length = 255), NotNull]
        public string TaskContent { get; set; }

        [Column, NotNull]
        public int State { get; set; }

        [Column(Length = 8), NotNull]
        public string Date_start { get; set; }

        [Column(Length = 8), NotNull]
        public string Date_end { get; set; }
    }
}
