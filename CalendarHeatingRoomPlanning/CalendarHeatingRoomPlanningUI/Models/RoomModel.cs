//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace CalendarHeatingRoomPlanning {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.exampleURI.com/Schema1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.exampleURI.com/Schema1", IsNullable=false)]
    public partial class RoomModel {

        //??PATCHED martin@familie-kaul.de 2021-05-04: use List collection instead of Array
        private System.Collections.Generic.List<SingleRoom> roomDataField;

        //??PATCHED martin@familie-kaul.de 2021-05-04: use List collection instead of Array
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Rooms", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public System.Collections.Generic.List<SingleRoom> RoomData {
            get {
                return this.roomDataField;
            }
            set {
                this.roomDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.exampleURI.com/Schema1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.exampleURI.com/Schema1", IsNullable=false)]
    public partial class SingleRoom {
        
        private string[] aliasesField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Aliases", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] Aliases {
            get {
                return this.aliasesField;
            }
            set {
                this.aliasesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.exampleURI.com/Schema1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.exampleURI.com/Schema1", IsNullable=false)]
    public partial class Rooms {

        //??PATCHED martin@familie-kaul.de 2021-05-04: use List collection instead of Array
        private System.Collections.Generic.List<SingleRoom> rooms1Field;

        //??PATCHED martin@familie-kaul.de 2021-05-04: use List collection instead of Array
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rooms", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.Generic.List<SingleRoom> Rooms1 {
            get {
                return this.rooms1Field;
            }
            set {
                this.rooms1Field = value;
            }
        }
    }
}
