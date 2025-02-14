﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace workshop.wwwapi.Models
{
    //TODO: decorate class/columns accordingly
    [Table("patients")]
    public class Patient
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string FullName { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
