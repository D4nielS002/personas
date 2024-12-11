namespace personas.Models
{
    public class PersonaModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double IMC
        {
            get
            {

                return Peso / (Altura * Altura);

            }


        }
    }

}
