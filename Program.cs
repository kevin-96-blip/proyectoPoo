namespace ejercicioPracticoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int idEstudiante;
            int edadEstudiante;
            int Respuesta;
            bool isValidId = false;

            Estudiante estudiante1 = new Estudiante(1, "Kev", 23);
            Empleado empleado1 = new Empleado(2, "Mary", 25);
            
            do
            {
                estudiante1.getInfo();
                empleado1.getInfo();
                Console.WriteLine();
                Console.WriteLine("ACTUALIZAR ESTUDIANTE");
                Console.WriteLine();
                do {
                    Console.Write("Ingrese ID: ");
                    string inputID = Console.ReadLine();
                    isValidId = int.TryParse(inputID, out idEstudiante);

                    if(!isValidId) Console.WriteLine("ID INVALIDO, Por favor" +
                        " ingrese un numero valido");
                } while (!isValidId);
                
                Console.Write("Nombre: ");
                string nEstudiante = Console.ReadLine();
                do {
                    Console.Write("Edad: ");
                    string inputEdad = Console.ReadLine();
                    isValidId = int.TryParse(inputEdad, out edadEstudiante);

                    if(!isValidId) Console.WriteLine("Edad no valida, ingrese una edad valida, por favor");

                } while (!isValidId);

                estudiante1.setInfo(idEstudiante, nEstudiante, edadEstudiante);

                Console.WriteLine();
                Console.WriteLine("Deseas continuar: ");
                Console.WriteLine("1 - SI");
                Console.WriteLine("2 - NO");
                do {
                    string inputRespuesta = Console.ReadLine();
                    isValidId = int.TryParse(inputRespuesta, out Respuesta);

                    if(!isValidId) Console.WriteLine("Ingrese una opcion valida");
                } while(!isValidId);

                int r = Respuesta;
                if (r == 2) continuar = false;
            }
            while (continuar == true);
        }
    }

    class Persona
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected int Age { get; set; }
        public Persona(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public void getInfo()
        {
            Console.WriteLine();
            Console.WriteLine("INFORMACION DEL USUARIO");
            Console.WriteLine($"NOMBRE: {Name}\n ID: {Id}\n Edad: {Age}");
        }

        public virtual void setInfo(int id, string name, int age)
        {
            ;
        }
    }

    class Empleado : Persona
    {
        public Empleado(int id, string name, int age) : base(id, name, age)
        {

        }

        public override void setInfo(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;

            Console.WriteLine("ÏNFORMACION ACTUALIZADA EMPLEADO");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Edad: " + age);
        }
    }

    class Estudiante : Persona
    {
        public Estudiante(int id, string name, int age) : base(id, name, age)
        {

        }
        public override void setInfo(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;

            Console.WriteLine("ÏNFORMACION ACTUALIZADA ESTUDIANTE");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Edad: " + age);
        }
    }
}