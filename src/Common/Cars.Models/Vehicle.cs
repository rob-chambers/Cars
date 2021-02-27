namespace Cars.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.8.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Vehicle : Prism.Mvvm.BindableBase
    {
        private Model _model;
        private string _name;
        private int _year;
        private int _doors;
        private decimal _price;
        private float _engineSize;
        private int _horsePower;
        private int _fuelTankCapacity;
        private float _mpg;

        [Newtonsoft.Json.JsonProperty("model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Model Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Year
        {
            get { return _year; }
            set { SetProperty(ref _year, value); }
        }

        [Newtonsoft.Json.JsonProperty("doors", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Doors
        {
            get { return _doors; }
            set { SetProperty(ref _doors, value); }
        }

        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }

        [Newtonsoft.Json.JsonProperty("engineSize", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float EngineSize
        {
            get { return _engineSize; }
            set { SetProperty(ref _engineSize, value); }
        }

        [Newtonsoft.Json.JsonProperty("horsePower", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int HorsePower
        {
            get { return _horsePower; }
            set { SetProperty(ref _horsePower, value); }
        }

        [Newtonsoft.Json.JsonProperty("fuelTankCapacity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int FuelTankCapacity
        {
            get { return _fuelTankCapacity; }
            set { SetProperty(ref _fuelTankCapacity, value); }
        }

        [Newtonsoft.Json.JsonProperty("mpg", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float Mpg
        {
            get { return _mpg; }
            set { SetProperty(ref _mpg, value); }
        }
    }
}
