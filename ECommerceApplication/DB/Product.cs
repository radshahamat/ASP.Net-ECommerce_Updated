
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ECommerceApplication.DB
{

using System;
    using System.Collections.Generic;
    
public partial class Product
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Product()
    {

        this.productOrders = new HashSet<productOrder>();

    }


    public int id { get; set; }

    public string name { get; set; }

    public int Quantity { get; set; }

    public int categoryId { get; set; }

    public int adminId { get; set; }

    public int price { get; set; }



    public virtual Admin Admin { get; set; }

    public virtual Category Category { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<productOrder> productOrders { get; set; }

}

}
