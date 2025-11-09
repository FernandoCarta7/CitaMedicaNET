
using System.Threading.Tasks;
using CitasMedicas.Data;
using CitasMedicas.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasMedicas.Services
{
    public class PacienteService : IPacienteService
    {

        private readonly CitasMedicasDbContext _context;


        public PacienteService(CitasMedicasDbContext context)
        {
            _context = context;
        }

        public async Task<Paciente> AddAsync(Paciente paciente)
        {
            await _context.AddAsync(paciente);
            return paciente;
        }

        public async Task<IEnumerable<Paciente>> GetAllAsync()
        {
            var lista = _context.Paciente.ToListAsync();
            return await lista;
        }
        public async Task<bool> DeleteAsync(int id)
        {
           Paciente ?paciente = await _context.Paciente.FindAsync(id);
            if (paciente is not null)
            {
                _context.Paciente.Remove(paciente);
                return true;
            }
            return false;
        }
        public async Task<Paciente?> GetByIdAsync(int id)
        {
            return await _context.Paciente.FindAsync(id);
        }
        async Task<bool> IPacienteService.UpdateAsync(int id, Paciente paciente)
        {
            Paciente ?paciente1 = await _context.Paciente.FindAsync(id);
            if (paciente1 is not null)
            {
                paciente1.Apellidos = paciente.Apellidos;
                paciente1.Email = paciente.Email;
                paciente1.FechaNacimiento = paciente.FechaNacimiento;
                paciente1.Nombres = paciente.Nombres;
                _context.Paciente.Update(paciente1);
                return true;
            }
            return false;

        }
        //public async Task<Paciente> getPacienteRandom()
        //{
        //    Paciente paciente = new Paciente();
        //    List<string> listaNombresMasculinos = new List<string>
        //    {
        //        "Juan", "Carlos", "Luis", "José", "Miguel",
        //        "Andrés", "Fernando", "Javier", "Alejandro", "Ricardo",
        //        "Manuel", "Eduardo", "Sergio", "Raúl", "Antonio",
        //        "Roberto", "Diego", "Adrián", "Francisco", "Héctor",
        //        "Cristian", "Julio", "Daniel", "Marco", "Oscar",
        //        "Gabriel", "David", "Mario", "Esteban", "Martín",
        //        "Tomás", "Hernán", "Rafael", "Iván", "Emilio",
        //        "Alberto", "Rodrigo", "Gustavo", "Felipe", "Sebastián",
        //        "Mauricio", "Nicolás", "Pablo", "Álvaro", "Leonardo",
        //        "Ramiro", "Jorge", "Mateo", "Ignacio", "Simón"
        //    };

        //            List<string> listaApellidos = new List<string>
        //    {
        //        "González", "Rodríguez", "García", "Martínez", "López",
        //        "Pérez", "Sánchez", "Ramírez", "Torres", "Flores",
        //        "Rivera", "Gómez", "Díaz", "Hernández", "Vásquez",
        //        "Romero", "Morales", "Ortiz", "Jiménez", "Reyes",
        //        "Ruiz", "Castro", "Mendoza", "Silva", "Moreno",
        //        "Guerrero", "Rojas", "Núñez", "Cruz", "Delgado",
        //        "Ramos", "Molina", "Suárez", "Aguilar", "Vargas",
        //        "Medina", "Paredes", "Carrillo", "Cortés", "Santos",
        //        "Peña", "Campos", "Fuentes", "Navarro", "Cabrera",
        //        "León", "Salazar", "Mejía", "Herrera", "Calderón"
        //    };

        //    Random random = new Random();

        //    // Generar nombres y apellidos
        //    string nombre = listaNombresMasculinos[random.Next(listaNombresMasculinos.Count)];
        //    string segundoNombre = listaNombresMasculinos[random.Next(listaNombresMasculinos.Count)];
        //    string apellido1 = listaApellidos[random.Next(listaApellidos.Count)];
        //    string apellido2 = listaApellidos[random.Next(listaApellidos.Count)];

        //    paciente.nombres = $"{nombre} {segundoNombre}";
        //    paciente.apellidos = $"{apellido1} {apellido2}";
        //    paciente.email = $"{nombre.ToLower()}.{apellido1.ToLower()}@correo.com";

        //    // Generar fecha de nacimiento (válida)
        //    int year = random.Next(1970, 2005);
        //    int month = random.Next(1, 13);
        //    int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
        //    paciente.fechaNacimiento = new DateOnly(year, month, day);

        //    // Construir sentencia SQL válida para SQL Server
        //    string sqlInsert = $@"
        //    INSERT INTO Paciente (nombres, apellidos, email, fechaNacimiento)
        //    VALUES ('{paciente.nombres.Replace("'", "''")}', 
        //            '{paciente.apellidos.Replace("'", "''")}', 
        //            '{paciente.email}', 
        //            '{paciente.fechaNacimiento:yyyy-MM-dd}');";

        //    Console.WriteLine(sqlInsert);



        //    return paciente;
        //}
        

    }
}