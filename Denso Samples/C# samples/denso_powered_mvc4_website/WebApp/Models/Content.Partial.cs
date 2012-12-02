﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using data = System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeNSo;

namespace WebApp.Models
{
  /// <summary>
  /// All attributes are from MVC or DataAnnotations 
  /// </summary>
  public partial class Content
  {
    [data.Key]  // Used to instruct MVC4 that this is a key 
    public int Id { get; set; }

    [Required]
    [data.DataType(DataType.Text)]
    [data.StringLength(50)]
    [Remote("CheckName", "Pages")]
    public string Name { get; set; }

    [Required]
    [data.StringLength(200)]
    [data.DataType(DataType.Text)]
    public string Title { get; set; }

    [data.DataType(DataType.Text)]
    [data.StringLength(100)]
    public string Path { get; set; }

    [AllowHtml]
    [data.DataType(DataType.Html)]    
    public string Body { get; set; }

    [data.DataType(DataType.ImageUrl)]
    [data.StringLength(100)]
    public string Image { get; set; }

    [Required]
    [data.DataType(DataType.Text)]
    [data.StringLength(50)]
    public string Category { get; set; }

    [IgnoreProperty] // Tell Denso to not include this property in the store.. 
                     // we will save files in a different way for this project.
    public HttpPostedFileBase File { get; set; }
  }
}