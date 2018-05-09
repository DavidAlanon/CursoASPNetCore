namespace MisClases.Gente
{
    public enum Genero
    {
        Hombre,
        Mujer
    }

    public class Persona
    {
        public string Nombre { get; set; }
        
        public string Apellidos { get; set; }

        public int Edad { get; set; }

        public Genero Genero {get; set; }

        public Persona(string nombre, string apellidos, int edad, Genero genero)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Genero = genero;
        }

        public virtual string GetNombreCompleto()
        {     
            return Nombre + " " + Apellidos;
        } 

        public bool EsMayorDeEdad()
        {
            return Edad >=18;
        }
    }

    public class Plebeyo : Persona
    {
        public Plebeyo(string nombre, string apellidos, int edad, Genero genero) : base(nombre, apellidos, edad, genero)
        {
        }
    }


    public class Aristocrata : Persona
    {
        public Aristocrata(string nombre, string apellidos, int edad, Genero genero, string titulo) 
            :base(nombre, apellidos, edad, genero)
        {
            Titulo = titulo;
        }

        public string Titulo {get; set;}
        public override string GetNombreCompleto()
        {     
            return GetPretitulo() + " " + Titulo + " " + Nombre + " " + Apellidos;
        } 

        private string GetPretitulo()

        {
            if(Genero==Genero.Hombre)
            {
                return "Mr. ";
            }
            
            {
            return "Lady ";
            }

        }

    }
}

