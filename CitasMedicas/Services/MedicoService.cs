using CitasMedicas.Data;
using CitasMedicas.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasMedicas.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly CitasMedicasDbContext _contextMedico;

        public MedicoService(CitasMedicasDbContext context)
        {
            this._contextMedico = context;
        }

        public async Task<Medico> AddAsync(Medico medico)
        {
            _contextMedico.Medico.Add(medico);
            await _contextMedico.SaveChangesAsync();
            return medico;
        }
        public async Task<IEnumerable<Medico>> GetAllAsync()
        {
            return await _contextMedico.Medico.ToListAsync();
        }

        public bool Delete(int id)
        {
            Medico? medico = new Medico();
            medico = GetByIdAsync(id);

            if ( medico is not null)
            {
                _contextMedico.Remove(id);
                return true;
            }

            return false;
        }


        public Medico? GetByIdAsync(int id)
        {
            return _contextMedico.Medico.Find(id);
        }

        public bool Update(int id, Medico medicoActualizado)
        {
            Medico? medico = new Medico();
            medico = GetByIdAsync(id);

            if ( medico is not null)
            {
                medico.Apellidos = medicoActualizado.Apellidos;
                medico.Especialidad = medicoActualizado.Especialidad;
                medico.Nombres = medicoActualizado.Nombres;

                _contextMedico.Medico.Update(medico);

                return true;
            }

            return false;
        }
        public async Task<Medico> getMedicoRandom()
        {
            Medico medico = new Medico();

            // Lista de nombres masculinos comunes
            List<string> listaNombresMasculinos = new List<string>
                {
                    "Juan", "Carlos", "Luis", "José", "Miguel",
                    "Andrés", "Fernando", "Javier", "Alejandro", "Ricardo",
                    "Manuel", "Eduardo", "Sergio", "Raúl", "Antonio",
                    "Roberto", "Diego", "Adrián", "Francisco", "Héctor",
                    "Cristian", "Julio", "Daniel", "Marco", "Oscar",
                    "Gabriel", "David", "Mario", "Esteban", "Martín",
                    "Tomás", "Hernán", "Rafael", "Iván", "Emilio",
                    "Alberto", "Rodrigo", "Gustavo", "Felipe", "Sebastián",
                    "Mauricio", "Nicolás", "Pablo", "Álvaro", "Leonardo",
                    "Ramiro", "Jorge", "Mateo", "Ignacio", "Simón"
                };

            // Lista de apellidos
            List<string> listaApellidos = new List<string>
                {
                    "González", "Rodríguez", "García", "Martínez", "López",
                    "Pérez", "Sánchez", "Ramírez", "Torres", "Flores",
                    "Rivera", "Gómez", "Díaz", "Hernández", "Vásquez",
                    "Romero", "Morales", "Ortiz", "Jiménez", "Reyes",
                    "Ruiz", "Castro", "Mendoza", "Silva", "Moreno",
                    "Guerrero", "Rojas", "Núñez", "Cruz", "Delgado",
                    "Ramos", "Molina", "Suárez", "Aguilar", "Vargas",
                    "Medina", "Paredes", "Carrillo", "Cortés", "Santos",
                    "Peña", "Campos", "Fuentes", "Navarro", "Cabrera",
                    "León", "Salazar", "Mejía", "Herrera", "Calderón"
                };

            // Lista de especialidades médicas
            List<string> listaEspecialidades = new List<string>
                {
                    "Cardiología", "Pediatría", "Neurología", "Dermatología", "Ginecología",
                    "Oftalmología", "Traumatología", "Psiquiatría", "Oncología", "Urología",
                    "Otorrinolaringología", "Endocrinología", "Reumatología", "Gastroenterología",
                    "Nefrología", "Hematología", "Anestesiología", "Medicina Interna",
                    "Medicina General", "Cirugía General"
                };

            Random random = new Random();

            // Generar nombres y apellidos
            string nombre = listaNombresMasculinos[random.Next(listaNombresMasculinos.Count)];
            string segundoNombre = listaNombresMasculinos[random.Next(listaNombresMasculinos.Count)];
            string apellido1 = listaApellidos[random.Next(listaApellidos.Count)];
            string apellido2 = listaApellidos[random.Next(listaApellidos.Count)];

            medico.Nombres = $"{nombre} {segundoNombre}";
            medico.Apellidos = $"{apellido1} {apellido2}";
            medico.Especialidad = listaEspecialidades[random.Next(listaEspecialidades.Count)];

            // Construir sentencia SQL válida
            string sqlInsert = $@"
            INSERT INTO Medico (Nombres, Apellidos, Especialidad)
            VALUES ('{medico.Nombres.Replace("'", "''")}', 
                    '{medico.Apellidos.Replace("'", "''")}', 
                    '{medico.Especialidad.Replace("'", "''")}');";

            // Mostrar por consola
            Console.WriteLine(sqlInsert);


            return medico;
        }

    }
}