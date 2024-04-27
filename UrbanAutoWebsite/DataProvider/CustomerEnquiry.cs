using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UrbanAutoWebsite.DataProvider;

[Table("CustomerEnquiry")]
public partial class CustomerEnquiry
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    public string FirstName { get; set; } = null!;

    [StringLength(255)]
    public string LastName { get; set; } = null!;

    [StringLength(255)]
    public string Email { get; set; } = null!;

    [StringLength(255)]
    public string Phone { get; set; } = null!;

    [StringLength(255)]
    public string State { get; set; } = null!;

    [StringLength(255)]
    public string City { get; set; } = null!;

    public string Description { get; set; } = null!;
}
