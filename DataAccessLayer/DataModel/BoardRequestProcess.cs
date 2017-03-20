namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoardRequestProcess")]
    public partial class BoardRequestProcess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoardRequestProcess()
        {
            PanelRequestProcesses = new HashSet<PanelRequestProcess>();
        }

        public int Id { get; set; }

        public int? RequestSubmitId { get; set; }

        public int? BoardMemberId { get; set; }

        public bool? IsApproved { get; set; }

        [StringLength(50)]
        public string Comment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public virtual RequestSubmit RequestSubmit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PanelRequestProcess> PanelRequestProcesses { get; set; }
    }
}
