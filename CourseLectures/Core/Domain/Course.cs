using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseLectures.Core.Domain
{
    [Table("Courses")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte Level { get; set; }

        public float FullPrice { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public Cover Cover { get; set; }

        public bool IsBeginnerCourse
        {
            get { return Level == 1; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
