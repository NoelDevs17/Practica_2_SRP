using Practica_2_SRP;

public class Main { 
public static void main(String[] args)
{
    Persona persona1 = new Persona("Juan Perez", 30, "Calle Mayor 123", "juan.perez@email.com");
    Persona persona2 = new Persona("Maria Garcia", 25, "Avenida Libertad 456", "maria.garcia@email.com");

    CorreoElectronico correoElectronico = new CorreoElectronico("maria.garcia@email.com", "Asunto importante", "Hola Juan, ¿cómo estás?");
    correoElectronico.enviarCorreoElectronico(persona1);
}

}