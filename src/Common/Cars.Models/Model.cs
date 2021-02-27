namespace Cars.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.8.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Model : Prism.Mvvm.BindableBase
    {
        private int _id;
        private Make _make;
        private string _name;
        private Category _category;
        private Warranty _warranty;

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        [Newtonsoft.Json.JsonProperty("make", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Make Make
        {
            get { return _make; }
            set { SetProperty(ref _make, value); }
        }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Category Category
        {
            get { return _category; }
            set { SetProperty(ref _category, value); }
        }

        [Newtonsoft.Json.JsonProperty("warranty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Warranty Warranty
        {
            get { return _warranty; }
            set { SetProperty(ref _warranty, value); }
        }
    }
}
