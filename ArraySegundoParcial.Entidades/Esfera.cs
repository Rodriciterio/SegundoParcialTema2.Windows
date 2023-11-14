namespace ArraySegundoParcial.Entidades
{
    public class Esfera : ICloneable
    {
        public int Radio { get; set; }

        public Esfera()
        {
            
        }

        public Esfera(int radio, TipoDeBorde borde, TipoDeRelleno relleno)
        {
            Radio = radio;
			TipoDeBorde = borde;
			TipoDeRelleno = relleno;
        }

        private TipoDeRelleno tipoDeRelleno;

		public  TipoDeRelleno TipoDeRelleno
		{
			get { return tipoDeRelleno; }
			set { tipoDeRelleno = value; }
		}

		private TipoDeBorde tipoDeBorde;

		public TipoDeBorde TipoDeBorde
		{
			get { return tipoDeBorde; }
			set { tipoDeBorde = value; }
		}

		public double Area()=>Math.Round(4 * Math.PI * Math.Pow(Radio, 2));
		public double Volumen()=>(4/3 * (Math.PI * Math.Pow(Radio, 3)));

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}