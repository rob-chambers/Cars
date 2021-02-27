namespace Cars.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.8.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Warranty : Prism.Mvvm.BindableBase
    {
        private int _id;
        private int _years;
        private int? _mileage;

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        [Newtonsoft.Json.JsonProperty("years", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Years
        {
            get { return _years; }
            set { SetProperty(ref _years, value); }
        }

        [Newtonsoft.Json.JsonProperty("mileage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Mileage
        {
            get { return _mileage; }
            set { SetProperty(ref _mileage, value); }
        }
    }
}
