﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ik.ItAdmin.Web.Models
{
    public class SerialDefineInfoModel
    {
        public Guid? Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "标识")]
        public string Key { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "名称")]
        public string Name { get; set; }
        public long NextValue { get; set; }
        public string PrefixValue { get; set; }

        [Display(Name = "编号位数")]
        public int FormatLength { get; set; }
        public string DateFormat { get; set; }

        [Display(Name = "申请容量")]
        public int ApplyCapacity { get; set; }

        [Display(Name = "检查阈值")]
        public int CheckThreshold { get; set; }
        public DateTime CreateTime { get; set; }
        public string Desc { get; set; }
    }
}