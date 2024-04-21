﻿using SOUKTCHAD.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SOUKTCHAD.Data.ModelViews
{
    public class NewProductVM
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = ("الاسم مطلوب"))]
        public string? Name { get; set; }
        [Display(Name = "PhotoURL1")]
        [Required(ErrorMessage = ("رابط الصورة مطلوب"))]
        public string? PhotoURL1 { get; set; }
        [Display(Name = "PhotoURL2")]
        [Required(ErrorMessage = ("رابط الصورة مطلوب"))]
        public string? PhotoURL2 { get; set; }
        [Display(Name = "PhotoURL3")]
        [Required(ErrorMessage = ("رابط الصورة مطلوب"))]
        public string? PhotoURL3 { get; set; }
        [Display(Name = "price")]
        [Required(ErrorMessage = ("يجب إدخال السعر"))]
        public double Price { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = ("لا يمكن ترك هذه المساحة فارغة"))]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "يجب أن يكون الوصف بين 3 و 250 حرفًا")]
        public string? Description { get; set; }
        [Display(Name = "Sex")]
        [Required(ErrorMessage = ("لا يمكن ترك هذه المساحة فارغة"))]
        public string? Sex { get; set; }
        //relations
        [ForeignKey("CATIGORYID")]
        public int? CATIGORYID { get; set; }
        public CATIGORY? CATIGORY { get; set; }
    }
}
