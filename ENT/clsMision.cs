namespace ENT
{
    public class clsMision
    {
        private int id;

        private String nombre;

        private String descripcion;

        private double recompensa;

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public double Recompensa { get;set; }

        public clsMision() { }

        public clsMision(int id, string nombre, string descripcion, double recompensa)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Recompensa = recompensa;
        }
    }
}
