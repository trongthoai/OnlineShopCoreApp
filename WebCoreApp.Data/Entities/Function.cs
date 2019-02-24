﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Data.Interfaces;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("Functions")]
    public class Function : DomainEntity<string>, ISwitchable, ISortable
    {
        public Function()
        {

        }
        public Function(string name, string url, string parentId, string iconCss, int sortOrder)
        {
            this.Name = name;
            this.URL = url;
            this.ParentId = parentId;
            this.IconCss = iconCss;
            this.SorOrder = sortOrder;
            this.Status = Status.Active;
        }
        [Required]
        [StringLength(128)]
        public string Name { set; get; }

        [Required]
        [StringLength(250)]
        public string URL { set; get; }


        [StringLength(128)]
        public string ParentId { set; get; }

        public string IconCss { get; set; }
        public int SorOrder { set; get; }
        public Status Status { set; get; }
    }
}
