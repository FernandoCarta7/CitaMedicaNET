using CitasMedicas.Models;

public class CrearMedicosPacientes
{
    Paciente paciente = new Paciente();
    Medico medico = new Medico();

    List<Paciente> listaPacientes = new List<Paciente>();
    List<Medico> listaMedico = new List<Medico>();


    public Paciente getPacienteRandom()
    {
        Paciente paciente = new Paciente();
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



        Random random = new Random();
        String nombre = listaNombresMasculinos[random.Next(0, listaNombresMasculinos.Count())];
        paciente.email = nombre;

        nombre = nombre + " " + listaNombresMasculinos[random.Next(0, listaNombresMasculinos.Count())];

        String apellidos = listaApellidos[random.Next(0, listaNombresMasculinos.Count())];
        paciente.email = paciente.email + "@correo.com";
        apellidos = apellidos + " " + listaApellidos[random.Next(0, listaNombresMasculinos.Count())];

        paciente.nombres = nombre;
        paciente.apellidos = apellidos;

        DateOnly date = new DateOnly(random.Next(2, 28), random.Next(1, 13), random.Next(1, 28));

        paciente.fechaNacimiento = date;
        

        

        return paciente;
    }
}