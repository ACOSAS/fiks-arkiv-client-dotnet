//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.629.0
namespace KS.Fiks.IO.Arkiv.Client.Models.Arkivering.Arkivmelding.Oppdatering
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.629.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("merknadOppdatering", Namespace="http://www.arkivverket.no/standarder/noark5/arkivmeldingoppdatering/v2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MerknadOppdatering
    {
        
        [System.Xml.Serialization.XmlElementAttribute("systemID")]
        public KS.Fiks.IO.Arkiv.Client.Models.Metadatakatalog.SystemID SystemID { get; set; }
        
        /// <summary>
        /// <para>M310</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("merknadstekst")]
        public string Merknadstekst { get; set; }
        
        /// <summary>
        /// <para>M084</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("merknadstype")]
        public string Merknadstype { get; set; }
        
        /// <summary>
        /// <para>M611</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("merknadsdato", DataType="dateTime")]
        public System.DateTime Merknadsdato { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MerknadsdatoSpecified { get; set; }
        
        /// <summary>
        /// <para>M612</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("merknadRegistrertAv")]
        public string MerknadRegistrertAv { get; set; }
        
        /// <summary>
        /// <para>M5..</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("skjermetObjekt")]
        public string SkjermetObjekt { get; set; }
    }
}
