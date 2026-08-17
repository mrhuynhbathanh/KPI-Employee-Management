using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPIEmployeeManagement.Core.Models
{
    [Table("KPI_EMP2")]
    public class KpiEmployee
    {
        [Key]
        [Column("SEQ")]
        public int Seq { get; set; }

        [Column("BRCD")]
        [StringLength(4)]
        public string? Brcd { get; set; }

        [Column("TRCTCD")]
        [StringLength(2)]
        public string? Trctcd { get; set; }

        [Column("CUST_ID")]
        [StringLength(50)]
        public string? CustId { get; set; }

        [Column("EMPNO")]
        [StringLength(50)]
        public string? Empno { get; set; }

        [Column("GRPNO")]
        [StringLength(20)]
        public string? Grpno { get; set; }

        [Column("USER_ID")]
        [StringLength(20)]
        public string? UserId { get; set; }

        [Column("EMPLOYEE")]
        [StringLength(100)]
        public string? Employee { get; set; }

        [Column("EMAIL")]
        [StringLength(100)]
        public string? Email { get; set; }

        [Column("DEPARTMENT")]
        [StringLength(100)]
        public string? Department { get; set; }

        [Column("STATUS")]
        [StringLength(1)]
        public string? Status { get; set; }

        [Column("TRDT")]
        [StringLength(10)]
        public string? Trdt { get; set; }
    }
}
