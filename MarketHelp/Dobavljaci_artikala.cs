
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MarketHelp
{

using System;
    using System.Collections.Generic;
    
public partial class Dobavljaci_artikala
{

    public int id_artikla { get; set; }

    public string oib { get; set; }

    public System.DateTime datum_pocetka { get; set; }

    public Nullable<System.DateTime> datum_zavrsetka { get; set; }



    public virtual Artikli Artikli { get; set; }

    public virtual Suradnici Suradnici { get; set; }

}

}