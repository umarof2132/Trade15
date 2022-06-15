namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserID { get; set; }

        [StringLength(50)]
        public string UserSurname { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserPatronymic { get; set; }

        [StringLength(50)]
        public string UserLogin { get; set; }

        [StringLength(50)]
        public string UserPassword { get; set; }

        public int UserRole { get; set; }

        public virtual Role Role { get; set; }
    }
}
