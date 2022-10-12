using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact dueño = new Contact("Pepito");
            // Crear la lista de contactos
            Phonebook contactos = new Phonebook(dueño);
            // Agregar contactos a la lista
            Contact Enzo = new Contact("Enzo porte");
            contactos.AddContact(Enzo);
            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
