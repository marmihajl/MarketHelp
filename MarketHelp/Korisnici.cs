
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
    
public partial class Korisnici
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Korisnici()
    {

        this.Dokumenti = new HashSet<Dokumenti>();

        this.Place = new HashSet<Place>();

    }


    public string korisnicko_ime { get; set; }

    public int id_uloge { get; set; }

    public string ime_prezime { get; set; }

    public string kontakt { get; set; }

    public string lozinka { get; set; }

    public Nullable<int> satnica { get; set; }

    public Nullable<int> satnica_prekovremeno { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Dokumenti> Dokumenti { get; set; }

    public virtual Uloge_korisnika Uloge_korisnika { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Place> Place { get; set; }

}

}