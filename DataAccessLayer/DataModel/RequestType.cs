namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestType")]
    public partial class RequestType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestType()
        {
            ExistingMadarsaOperationsRequests = new HashSet<ExistingMadarsaOperationsRequest>();
            MadarsaConstructionRequests = new HashSet<MadarsaConstructionRequest>();
            MadarsaExtensionRequests = new HashSet<MadarsaExtensionRequest>();
            MadarsaLandRequests = new HashSet<MadarsaLandRequest>();
            MasjidConstructionRequests = new HashSet<MasjidConstructionRequest>();
            MasjidExtensionRequests = new HashSet<MasjidExtensionRequest>();
            MasjidLandRequests = new HashSet<MasjidLandRequest>();
            NewMadarsaOperationsRequests = new HashSet<NewMadarsaOperationsRequest>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExistingMadarsaOperationsRequest> ExistingMadarsaOperationsRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MadarsaConstructionRequest> MadarsaConstructionRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MadarsaExtensionRequest> MadarsaExtensionRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MadarsaLandRequest> MadarsaLandRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasjidConstructionRequest> MasjidConstructionRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasjidExtensionRequest> MasjidExtensionRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasjidLandRequest> MasjidLandRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewMadarsaOperationsRequest> NewMadarsaOperationsRequests { get; set; }
    }
}
