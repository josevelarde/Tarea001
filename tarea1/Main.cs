using System;

namespace Tarea_1
{
	class Persona{
		public string nombre;
		public string telefono;
		public string email;
		public string domicilio;
		
		public Persona (){
			
		}
		public static void Main (string []args){
			Persona Persona=new Persona();
			
			Console.WriteLine ( "Nombre" );
			Persona.nombre = Console.ReadLine();
			
			Console.WriteLine ( "Telefono");
			Persona.telefono = Console.ReadLine();
			
			Console.WriteLine ( "Email");
			Persona.email = Console.ReadLine();
			
			Console.WriteLine ( "Domicilio");
			Persona.domicilio = Console.ReadLine();
			
			
			Console.WriteLine("\nNombre Introducido: "+Persona.nombre);
			
			Console.WriteLine("\nTelefono Introducido: "+Persona.telefono);
			
			Console.WriteLine("\nEmail Introducido: "+Persona.email);
			
			Console.WriteLine("\nDomicilio Introducido: "+Persona.domicilio);
		}
	}
}
