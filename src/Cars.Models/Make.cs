namespace Cars.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.8.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Make : Prism.Mvvm.BindableBase
    {
        private int _id;
        private string _name;
        private string _country;

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country
        {
            get { return _country; }
            set { SetProperty(ref _country, value); }
        }
    }
}
