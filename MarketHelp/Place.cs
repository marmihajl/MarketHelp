
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
    
public partial class Place
{

    public int id_place { get; set; }

    public string korisnicko_ime { get; set; }

    public int odradeno_sati { get; set; }

    public int odradeno_prekovremeno { get; set; }

    public int mjesec { get; set; }

    public double iznos_place { get; set; }



    public virtual Korisnici Korisnici { get; set; }

}

}