using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DennisEFDemoes_ConsoleApp.CodeFirstDemo.DBModels
{
    [Table("PictureCategory", Schema = "dbo")]
    public class PictureCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; private set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; private set; }
        [ForeignKey("ParentCategoryId")]
        public virtual PictureCategory ParentCategory { get; set; } //书中没有virtual关键字，这会导致导航属性不能加载，后面的输出就只有根目录！！
        public virtual List<PictureCategory> Subcategories { get; set; }
        public PictureCategory()
        {
            Subcategories = new List<PictureCategory>();
        }
    }
}
