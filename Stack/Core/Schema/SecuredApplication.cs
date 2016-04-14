#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5456
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Opc.Ua.Security
{


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SecuredApplication", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd")]
    public partial class SecuredApplication
    {
        private string ApplicationNameField;
        
        private string ApplicationUriField;
        
        private Opc.Ua.Security.ApplicationType ApplicationTypeField;
        
        private string ProductNameField;
        
        private string ConfigurationModeField;
        
        private System.DateTime LastExportTimeField;
        
        private string ConfigurationFileField;
        
        private string ExecutableFileField;
        
        private Opc.Ua.Security.CertificateIdentifier ApplicationCertificateField;
        
        private Opc.Ua.Security.CertificateStoreIdentifier TrustedCertificateStoreField;
        
        private Opc.Ua.Security.CertificateList TrustedCertificatesField;
        
        private Opc.Ua.Security.CertificateStoreIdentifier IssuerCertificateStoreField;
        
        private Opc.Ua.Security.CertificateList IssuerCertificatesField;
        
        private Opc.Ua.Security.CertificateStoreIdentifier RejectedCertificatesStoreField;
        
        private Opc.Ua.Security.ListOfBaseAddresses BaseAddressesField;
        
        private Opc.Ua.Security.ListOfSecurityProfiles SecurityProfilesField;
        
        private Opc.Ua.Security.ListOfExtensions ExtensionsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationName
        {
            get
            {
                return this.ApplicationNameField;
            }
            set
            {
                this.ApplicationNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationUri
        {
            get
            {
                return this.ApplicationUriField;
            }
            set
            {
                this.ApplicationUriField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public Opc.Ua.Security.ApplicationType ApplicationType
        {
            get
            {
                return this.ApplicationTypeField;
            }
            set
            {
                this.ApplicationTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ProductName
        {
            get
            {
                return this.ProductNameField;
            }
            set
            {
                this.ProductNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ConfigurationMode
        {
            get
            {
                return this.ConfigurationModeField;
            }
            set
            {
                this.ConfigurationModeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public System.DateTime LastExportTime
        {
            get
            {
                return this.LastExportTimeField;
            }
            set
            {
                this.LastExportTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string ConfigurationFile
        {
            get
            {
                return this.ConfigurationFileField;
            }
            set
            {
                this.ConfigurationFileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string ExecutableFile
        {
            get
            {
                return this.ExecutableFileField;
            }
            set
            {
                this.ExecutableFileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public Opc.Ua.Security.CertificateIdentifier ApplicationCertificate
        {
            get
            {
                return this.ApplicationCertificateField;
            }
            set
            {
                this.ApplicationCertificateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public Opc.Ua.Security.CertificateStoreIdentifier TrustedCertificateStore
        {
            get
            {
                return this.TrustedCertificateStoreField;
            }
            set
            {
                this.TrustedCertificateStoreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public Opc.Ua.Security.CertificateList TrustedCertificates
        {
            get
            {
                return this.TrustedCertificatesField;
            }
            set
            {
                this.TrustedCertificatesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public Opc.Ua.Security.CertificateStoreIdentifier IssuerCertificateStore
        {
            get
            {
                return this.IssuerCertificateStoreField;
            }
            set
            {
                this.IssuerCertificateStoreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public Opc.Ua.Security.CertificateList IssuerCertificates
        {
            get
            {
                return this.IssuerCertificatesField;
            }
            set
            {
                this.IssuerCertificatesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public Opc.Ua.Security.CertificateStoreIdentifier RejectedCertificatesStore
        {
            get
            {
                return this.RejectedCertificatesStoreField;
            }
            set
            {
                this.RejectedCertificatesStoreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public Opc.Ua.Security.ListOfBaseAddresses BaseAddresses
        {
            get
            {
                return this.BaseAddressesField;
            }
            set
            {
                this.BaseAddressesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public Opc.Ua.Security.ListOfSecurityProfiles SecurityProfiles
        {
            get
            {
                return this.SecurityProfilesField;
            }
            set
            {
                this.SecurityProfilesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
        public Opc.Ua.Security.ListOfExtensions Extensions
        {
            get
            {
                return this.ExtensionsField;
            }
            set
            {
                this.ExtensionsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CertificateIdentifier", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd")]
    public partial class CertificateIdentifier
    {
        private string StoreTypeField;
        
        private string StorePathField;
        
        private string SubjectNameField;
        
        private string ThumbprintField;
        
        private byte[] RawDataField;
        
        private int ValidationOptionsField;
        
        private byte[] OfflineRevocationListField;
        
        private string OnlineRevocationListField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StoreType
        {
            get
            {
                return this.StoreTypeField;
            }
            set
            {
                this.StoreTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StorePath
        {
            get
            {
                return this.StorePathField;
            }
            set
            {
                this.StorePathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string SubjectName
        {
            get
            {
                return this.SubjectNameField;
            }
            set
            {
                this.SubjectNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Thumbprint
        {
            get
            {
                return this.ThumbprintField;
            }
            set
            {
                this.ThumbprintField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public byte[] RawData
        {
            get
            {
                return this.RawDataField;
            }
            set
            {
                this.RawDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int ValidationOptions
        {
            get
            {
                return this.ValidationOptionsField;
            }
            set
            {
                this.ValidationOptionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public byte[] OfflineRevocationList
        {
            get
            {
                return this.OfflineRevocationListField;
            }
            set
            {
                this.OfflineRevocationListField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string OnlineRevocationList
        {
            get
            {
                return this.OnlineRevocationListField;
            }
            set
            {
                this.OnlineRevocationListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CertificateStoreIdentifier", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd")]
    public partial class CertificateStoreIdentifier
    {
        private string StoreTypeField;
        
        private string StorePathField;
        
        private int ValidationOptionsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = false)]
        public string StoreType
        {
            get
            {
                return this.StoreTypeField;
            }
            set
            {
                this.StoreTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = false, Order = 1)]
        public string StorePath
        {
            get
            {
                return this.StorePathField;
            }
            set
            {
                this.StorePathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int ValidationOptions
        {
            get
            {
                return this.ValidationOptionsField;
            }
            set
            {
                this.ValidationOptionsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CertificateList", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd")]
    public partial class CertificateList
    {
        private Opc.Ua.Security.ListOfCertificateIdentifier CertificatesField;
        
        private int ValidationOptionsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, EmitDefaultValue = false)]
        public Opc.Ua.Security.ListOfCertificateIdentifier Certificates
        {
            get
            {
                return this.CertificatesField;
            }
            set
            {
                this.CertificatesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ValidationOptions
        {
            get
            {
                return this.ValidationOptionsField;
            }
            set
            {
                this.ValidationOptionsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ApplicationType", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd")]
    public enum ApplicationType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Server_0 = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Client_1 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ClientAndServer_2 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DiscoveryServer_3 = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ListOfBaseAddresses", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd", ItemName="BaseAddress")]
    public class ListOfBaseAddresses : System.Collections.Generic.List<string>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ListOfSecurityProfiles", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd", ItemName="SecurityProfile")]
    public class ListOfSecurityProfiles : System.Collections.Generic.List<Opc.Ua.Security.SecurityProfile>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ListOfExtensions", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd", ItemName="Extension")]
    public class ListOfExtensions : System.Collections.Generic.List<System.Xml.XmlElement>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ListOfCertificateIdentifier", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd", ItemName="CertificateIdentifier")]
    public class ListOfCertificateIdentifier : System.Collections.Generic.List<Opc.Ua.Security.CertificateIdentifier>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SecurityProfile", Namespace="http://opcfoundation.org/UA/2011/03/SecuredApplication.xsd")]
    public partial class SecurityProfile
    {
        private string ProfileUriField;
        
        private bool EnabledField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ProfileUri
        {
            get
            {
                return this.ProfileUriField;
            }
            set
            {
                this.ProfileUriField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public bool Enabled
        {
            get
            {
                return this.EnabledField;
            }
            set
            {
                this.EnabledField = value;
            }
        }
    }
}