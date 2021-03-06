//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeAndUserClient.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Home", Namespace="http://schemas.datacontract.org/2004/07/HomeAndUserLibrary")]
    [System.SerializableAttribute()]
    public partial class Home : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AreaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BhkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float RentField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Area {
            get {
                return this.AreaField;
            }
            set {
                if ((this.AreaField.Equals(value) != true)) {
                    this.AreaField = value;
                    this.RaisePropertyChanged("Area");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Bhk {
            get {
                return this.BhkField;
            }
            set {
                if ((this.BhkField.Equals(value) != true)) {
                    this.BhkField = value;
                    this.RaisePropertyChanged("Bhk");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Rent {
            get {
                return this.RentField;
            }
            set {
                if ((this.RentField.Equals(value) != true)) {
                    this.RentField = value;
                    this.RaisePropertyChanged("Rent");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IHomeService2")]
    public interface IHomeService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/GetHouses", ReplyAction="http://tempuri.org/IHomeService2/GetHousesResponse")]
        System.Data.DataSet GetHouses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/GetHouses", ReplyAction="http://tempuri.org/IHomeService2/GetHousesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetHousesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/getHome", ReplyAction="http://tempuri.org/IHomeService2/getHomeResponse")]
        System.Data.DataSet getHome(string feature, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/getHome", ReplyAction="http://tempuri.org/IHomeService2/getHomeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getHomeAsync(string feature, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/getHomeWithID", ReplyAction="http://tempuri.org/IHomeService2/getHomeWithIDResponse")]
        HomeAndUserClient.ServiceReference2.Home getHomeWithID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/getHomeWithID", ReplyAction="http://tempuri.org/IHomeService2/getHomeWithIDResponse")]
        System.Threading.Tasks.Task<HomeAndUserClient.ServiceReference2.Home> getHomeWithIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/RemoveHome", ReplyAction="http://tempuri.org/IHomeService2/RemoveHomeResponse")]
        int RemoveHome(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/RemoveHome", ReplyAction="http://tempuri.org/IHomeService2/RemoveHomeResponse")]
        System.Threading.Tasks.Task<int> RemoveHomeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/AddHome", ReplyAction="http://tempuri.org/IHomeService2/AddHomeResponse")]
        int AddHome(HomeAndUserClient.ServiceReference2.Home home);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/AddHome", ReplyAction="http://tempuri.org/IHomeService2/AddHomeResponse")]
        System.Threading.Tasks.Task<int> AddHomeAsync(HomeAndUserClient.ServiceReference2.Home home);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/UpdateHome", ReplyAction="http://tempuri.org/IHomeService2/UpdateHomeResponse")]
        int UpdateHome(int id, HomeAndUserClient.ServiceReference2.Home home);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeService2/UpdateHome", ReplyAction="http://tempuri.org/IHomeService2/UpdateHomeResponse")]
        System.Threading.Tasks.Task<int> UpdateHomeAsync(int id, HomeAndUserClient.ServiceReference2.Home home);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHomeService2Channel : HomeAndUserClient.ServiceReference2.IHomeService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HomeService2Client : System.ServiceModel.ClientBase<HomeAndUserClient.ServiceReference2.IHomeService2>, HomeAndUserClient.ServiceReference2.IHomeService2 {
        
        public HomeService2Client() {
        }
        
        public HomeService2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HomeService2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HomeService2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HomeService2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetHouses() {
            return base.Channel.GetHouses();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetHousesAsync() {
            return base.Channel.GetHousesAsync();
        }
        
        public System.Data.DataSet getHome(string feature, int limit) {
            return base.Channel.getHome(feature, limit);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getHomeAsync(string feature, int limit) {
            return base.Channel.getHomeAsync(feature, limit);
        }
        
        public HomeAndUserClient.ServiceReference2.Home getHomeWithID(int id) {
            return base.Channel.getHomeWithID(id);
        }
        
        public System.Threading.Tasks.Task<HomeAndUserClient.ServiceReference2.Home> getHomeWithIDAsync(int id) {
            return base.Channel.getHomeWithIDAsync(id);
        }
        
        public int RemoveHome(int id) {
            return base.Channel.RemoveHome(id);
        }
        
        public System.Threading.Tasks.Task<int> RemoveHomeAsync(int id) {
            return base.Channel.RemoveHomeAsync(id);
        }
        
        public int AddHome(HomeAndUserClient.ServiceReference2.Home home) {
            return base.Channel.AddHome(home);
        }
        
        public System.Threading.Tasks.Task<int> AddHomeAsync(HomeAndUserClient.ServiceReference2.Home home) {
            return base.Channel.AddHomeAsync(home);
        }
        
        public int UpdateHome(int id, HomeAndUserClient.ServiceReference2.Home home) {
            return base.Channel.UpdateHome(id, home);
        }
        
        public System.Threading.Tasks.Task<int> UpdateHomeAsync(int id, HomeAndUserClient.ServiceReference2.Home home) {
            return base.Channel.UpdateHomeAsync(id, home);
        }
    }
}
