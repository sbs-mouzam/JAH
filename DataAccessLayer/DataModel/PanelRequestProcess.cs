namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PanelRequestProcess")]
    public partial class PanelRequestProcess
    {
        public int Id { get; set; }

        public int? RequestSubmitId { get; set; }

        public int? BoardMemberId { get; set; }

        public bool? IsApproved { get; set; }

        public bool? IsLiked { get; set; }

        [StringLength(50)]
        public string Comment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public virtual BoardRequestProcess BoardRequestProcess { get; set; }

        public virtual RequestSubmit RequestSubmit { get; set; }
    }
}
