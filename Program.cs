/*
 * Creado por SharpDevelop.
 * Usuario: FliaMedinaVillanueva
 * Fecha: 30/05/2022
 * Hora: 21:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Threading;
namespace Clinica
{
	class Program
	{
		
		public static void escribirRojo(string texto)
		{
			
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(texto);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		
		public static void escribirVerde(string texto)
		{
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(texto);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		
		
		public static void escribirNaranja(string texto)
		{
			
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(texto);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		
		public static void escribirAmarillo(string texto)
		{
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(texto);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		
		public static void escribirAzul(string texto)
		{
			
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(texto);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		
		public static int verificarEnteroYVacio()
		{
			try 
			{
			int entero = int.Parse(Console.ReadLine());
			return entero;
			} 
			catch (Exception)
			{	
			escribirRojo("Dato incorrecto");
			return verificarEnteroYVacio();
			}
		}

		public static string verificarCadenaVacia()
		{
			string cadena;
			cadena = Console.ReadLine();
			while (cadena == "")
			{
				escribirRojo("Ingrese algun dato");
				cadena =Console.ReadLine();
			}
			return cadena;
		}
		public static string consultarHorario()
		{
			string horario = "";
			int opcionHorario;
			Console.WriteLine("Horario");
			Console.WriteLine("1. Mañana");
			Console.WriteLine("2. Tarde");
			Console.WriteLine("3. Noche");	
			opcionHorario = verificarEnteroYVacio();
			while (opcionHorario < 1 || opcionHorario > 3) 
			{
				escribirRojo("La opcion ingresa es incorrecta");
				opcionHorario = verificarEnteroYVacio();
			}
			Console.ForegroundColor = ConsoleColor.Gray;
			switch (opcionHorario)
			{
				case 1:
					horario = "Mañana";
					break;
				case 2:
					horario = "Tarde";
					break;
				case 3:
					horario = "Noche";
					break;
				default:
					escribirRojo("Opcion incorrecta");
					break;
			}
			return horario;
		}
		public static Servicio consularEspecialidad(Clinica c, string motivo)
		{
			int contador = 1, OpcionEspe;
			Console.WriteLine("Servicios");
			Console.WriteLine("");
			if (c.mostrarServicios.Count == 0)
			{
				escribirRojo("No hay ningun servicio");
				Console.WriteLine("Presione cualquier tecla para volver al menu principal");
				Console.ReadKey(true);
				menuPrincipal(c);
			}
				foreach (Servicio ser in c.mostrarServicios)
				{
					if (motivo == "paciente") 
					{
						if (ser.Camas == 0)
						{
							escribirRojo(contador +". "+ ser.Especialidad);
							contador += 1;
						}
						else if (ser.Camas < 3) 
						{
							escribirNaranja(contador +". "+ ser.Especialidad);
							contador += 1;
						}
						else
						{
							escribirVerde(contador +". "+ ser.Especialidad);
							contador += 1;
						}
					}
					else
					{
					Console.WriteLine(contador +". "+ ser.Especialidad);
					contador += 1;
					}
				}
				Console.WriteLine("");
				Console.WriteLine("Escriba una opcion");
				OpcionEspe = verificarEnteroYVacio();
					while (OpcionEspe < 1 || OpcionEspe > c.mostrarServicios.Count) 
					{
						escribirRojo("La opcion ingresa es incorrecta");
						OpcionEspe = verificarEnteroYVacio();
					}
					return ((Servicio)c.mostrarServicios[OpcionEspe-1]);
		}
		public static bool consultarDniMedico(int dni, Clinica c)
		{	
			bool existe = false;
			foreach (Servicio ser in c.mostrarServicios)
			{	
				foreach (Medico med in ser.Medicos)
				{	
					if (med.Dni == dni)
					{
						existe = true;
					}
				}
			}
			return existe;	
		}
		public static int obtenerLegajo(Clinica c)
		{	
			int legajo = 0;
			foreach (Servicio ser in c.mostrarServicios)
			{	
				foreach (Medico med in ser.Medicos)
				{	
					if (med.Legajo > legajo)
					{
						legajo = med.Legajo;
					}
				}
			}
			return legajo;	
		}
		public static bool consultarDniPaciente(int dni, Clinica c)
		{
			foreach (Servicio ser in c.mostrarServicios)
			{	
				foreach (Paciente pac in ser.Pacientes)
				{
					if (pac.Dni == dni) 
					{
					return true;
					}
				}
			}
			return false;	
		}
		static void agregarUnMedico(Clinica c)
		{
			Console.Clear();
			Console.Title = "NUEVO MEDICO";
			escribirAmarillo("\n\tNUEVO MEDICO\n\n");
			string nombreMedico, apellidoMedico, especialidad, horario;
			int legajoMedico, dniMedico;
			Console.ForegroundColor = ConsoleColor.Gray;
			especialidad = consularEspecialidad(c,"medico").Especialidad;
			//horario = "";
			Console.WriteLine("Ingrese el dni del medico: ");
			dniMedico = verificarEnteroYVacio();
			if (consultarDniMedico(dniMedico,c) == true)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("El dni ingresado ya existe");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Presione cualquier tecla para volver al menu principal");
				Console.ReadKey(true);
				menuPrincipal(c);
			}
			else
			{
				Console.WriteLine("Ingrese el nombre del medico: ");
				nombreMedico = verificarCadenaVacia();
				Console.WriteLine("Ingrese el apellido del medico: ");
				apellidoMedico = verificarCadenaVacia();
				Console.WriteLine("Ingrese la matricula medico: ");
				legajoMedico = obtenerLegajo(c)+1;
				horario = consultarHorario();
				Medico NuevoMedico = new Medico(dniMedico,legajoMedico,nombreMedico, apellidoMedico, especialidad, horario);	
				foreach (Servicio serv in c.mostrarServicios)
				{
					if (serv.Especialidad == especialidad)
					{
						serv.agregarMedicoAUnServicio(NuevoMedico);
					}
				}
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Medico agregado exitosamente");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Presione cualquier tecla para volver al menu principal");
				Console.ReadKey(true);
			}
		}
		public static void PacientesDeUnServicio(Clinica c)
		{
			Console.Clear();
			Console.Title="PACIENTES";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("\n\tVER PACIENTES\n\n");
			Console.ForegroundColor = ConsoleColor.Gray;
			string especialidadPaciente = consularEspecialidad(c,"medico").Especialidad;
			foreach (Servicio ser in c.mostrarServicios) 
			{
				if (ser.Especialidad == especialidadPaciente)
				{
					foreach (Paciente pac in ser.Pacientes) 
					{
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.WriteLine("Nombre: " + pac.Nombre);
					Console.WriteLine("Apellido: " + pac.Apellido);
					Console.WriteLine("DNI: " + pac.Dni);
					Console.WriteLine("Fecha de nacimiento: " + pac.fechanac);
					Console.WriteLine("Diagnostico: " + pac.Diagnostico);
					Console.WriteLine("Fecha de ingreso: " + pac.fechain);
					Console.WriteLine("Legajo medico a cargo: " + pac.Medico);
					Console.WriteLine("---------------------------------------");
					}
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.WriteLine("Presione cualquier tecla para volver al menu principal");
					Console.ReadKey(true);
					break;						
				}
			}
		}
		public static void altaPaciente(Clinica c)
		{
			Console.Clear();
			Console.Title="ALTAS";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("\n\tALTA PACIENTE\n\n");
			Console.ForegroundColor = ConsoleColor.Gray;
			string especialidadPaciente = consularEspecialidad(c,"medico").Especialidad;
			int ayuda = 0;
			Console.WriteLine("Ingrese el legajo del médico");
			int medico = verificarEnteroYVacio();
			Console.WriteLine("Ingrese el dni del paciente");
			int dnipaciente = verificarEnteroYVacio();
			foreach (Servicio ser in c.mostrarServicios)
			{
				if (ser.Especialidad == especialidadPaciente) 
				{
					foreach (Medico med in ser.Medicos) 
					{
						if (med.Legajo == medico) 
						{
							foreach (Paciente pac in ser.Pacientes) 
							{
								if (pac.Dni == dnipaciente) 
								{
									ser.altaPaciente(pac);
									ayuda = 1;
									Console.ForegroundColor = ConsoleColor.Green;
									Console.WriteLine("Paciente dado de alta");
									ser.Camas += 1;
									Console.ForegroundColor = ConsoleColor.Gray;
									Console.WriteLine("Presione cualquier tecla para volver al menu principal");
									Console.ReadKey(true);
									break;
								}
							}
						}	
					}
				}
			}
			if (ayuda == 0) 
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("El paciente no existe");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Presione cualquier tecla para volver al menu principal");
				Console.ReadKey(true);
			}
		}
		public static void internarPaciente(Clinica c)
		{
			try
			{
			Console.Clear();
			Console.Title="INTERNACION";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("\n\tINTERNAR PACIENTE\n\n");
			Console.ForegroundColor = ConsoleColor.Gray;
			string nombrePaciente, apellidoPaciente, diagnosticoPaciente, especialidadPaciente, fechaNac, hoy;
			int medicoACargo;
			int dni;
			especialidadPaciente = consularEspecialidad(c,"paciente").Especialidad;
			foreach (Servicio ser in c.mostrarServicios) 
			{
				if (ser.Especialidad == especialidadPaciente) 
				{
					if (ser.Medicos.Count == 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("No hay medicos disponibles en esta especialidad");
						Console.ForegroundColor = ConsoleColor.Gray;
						Console.WriteLine("Presione cualquier tecla para volver al menu principal");
						Console.ReadKey(true);
						menuPrincipal(c);
					}
					if (ser.Camas == 0)
					{
						throw new noHayCamas();
					}
				}
			}
			Console.WriteLine("Ingrese el dni del paciente: ");
			dni = verificarEnteroYVacio();
			if(consultarDniPaciente(dni,c) == true)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("El dni ingresado ya existe");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Presione cualquier tecla para volver al menu principal");
				Console.ReadKey(true);
				menuPrincipal(c);
			}
			else
			{
			Console.WriteLine("Ingrese el nombre del paciente: ");
			nombrePaciente = verificarCadenaVacia();
			Console.WriteLine("Ingrese el apellido del paciente: ");
			apellidoPaciente = verificarCadenaVacia();
			Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/aaaa): ");
			fechaNac = verificarCadenaVacia();
			Console.WriteLine("Ingrese el diagnostico del paciente: ");
			diagnosticoPaciente = verificarCadenaVacia();
			Console.WriteLine("Ingrese el legajo del médico a cargo: ");
			medicoACargo = verificarEnteroYVacio();
			int p = 0; // ayuda para saber si el medico existe
			foreach (Servicio ser in c.mostrarServicios) 
			{
				if (ser.Especialidad == especialidadPaciente) 
				{
					foreach (Medico med in ser.Medicos) 
					{
						if (med.Legajo == medicoACargo) 
						{
								hoy = DateTime.Now.ToString("dd-MM-yyyy");
								Paciente NuevoPaciente = new Paciente(nombrePaciente, apellidoPaciente,  dni,  diagnosticoPaciente,fechaNac,hoy,med.Legajo);
								ser.internarPaciente(NuevoPaciente);
								ser.Camas = ser.Camas-1;
								p = 0;
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine("Paciente internado con exito");
								Console.ForegroundColor = ConsoleColor.Gray;
								Console.WriteLine("Presione cualquier tecla para volver al menu principal");
								Console.ReadKey(true);
								break;
						}
						else
						{
							p = 1;
									
						}
					}
				}
			}
			if (p != 0) 
			{	Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("El medico no existe (Ver opcion 7 del menu principal)");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Presione cualquier tecla para volver al menu principal");
				Console.ReadKey(true);
			}
			}
			}
			catch(noHayCamas)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("No hay camas disponibles");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Presione cualquier tecla para volver al menu principal");
				Console.ReadKey(true);
				menuPrincipal(c);
			}
		}
		public static int cantidadDeMedicosTotal(Clinica c)
		{ 
			int contador = 0;
			foreach (Servicio ser in c.mostrarServicios) 
			{
				foreach (Medico med in ser.Medicos)
				{
					contador++;
				}
			}
			return contador;
		}
		public static void borrarMedico(Clinica c)
		{
			Console.Clear();
			Console.Title="BORRAR MEDICO";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("\n\tBORRAR MEDICO\n\n");
			Console.ForegroundColor = ConsoleColor.Gray;
			Servicio Verificarserv = consularEspecialidad(c,"medico");
			Console.WriteLine("");
			Console.WriteLine("Seleccione el médico segun las opciones");
			Console.WriteLine("");
			int contador = 1;
			foreach (Medico med in Verificarserv.Medicos)
			{ 
				bool tienePac = false;
					foreach (Paciente pac in Verificarserv.Pacientes) 
					{
						if (pac.Medico == med.Legajo)
						{
							escribirRojo(contador + ". " + med.Apellido +" "+ med.Nombre + " Legajo: " + med.Legajo);
							tienePac = true;
							break;
						}
					}
					if (tienePac == false) 
					{
						escribirVerde(contador + ". " + med.Apellido + " " +  med.Nombre + " Legajo: " + med.Legajo);
					}
				contador++;
			}
			if (Verificarserv.Medicos.Count == 0)
			{
				escribirRojo("No hay médicos en el servicio "+ Verificarserv.Especialidad);
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("");
				Console.WriteLine("Escriba una opcion");
				int opcionmed = verificarEnteroYVacio();
				while (opcionmed < 1 || opcionmed > Verificarserv.Medicos.Count)
				{
					escribirRojo("Opcion incorrecta");
					opcionmed = verificarEnteroYVacio();
				}
				int legajomed = ((Medico)Verificarserv.Medicos[opcionmed-1]).Legajo;
				bool tienepac = false;
				foreach (Paciente pac in Verificarserv.Pacientes) 
				{
					if (pac.Medico == legajomed)
					{
						tienepac = true;
						escribirRojo("No se puede eliminar el médico por que tiene pacientes a cargo");
						Console.ReadKey();
						break;
					}
				}
				if (tienepac == false)
				{
					Verificarserv.borrarMedicoDeUnServicio((Medico)Verificarserv.Medicos[opcionmed-1]);
					escribirVerde("Ok");
					Console.ReadKey();
				}
			}
		}
		public static void serviciosConMedicosNocturnos(Clinica c)
		{
			Console.Clear();
			int contador = 0;
			Console.Title="SERVICIOS CON MÉDICOS NOCTURNOS";
			escribirAmarillo("\n\tSERVICIOS CON MÉDICOS NOCTURNOS\n\n");
			foreach (Servicio ser in c.mostrarServicios) 
			{
				foreach (Medico med in ser.Medicos) 
				{
					if(med.Turno == "Noche")
					{
						escribirVerde(ser.Especialidad);
						Console.WriteLine("");
						contador += 1;
					}
				}
			}
			if (contador == 0)
			{
				escribirRojo("Vacio");
			}
					Console.WriteLine("Presione cualquier tecla para volver al menu principal");
					Console.ReadKey(true);		
		}
		public static void mostrarServicios(Clinica c)
		{
			Console.Clear();
			Console.Title="SERVICIOS";
			escribirAmarillo("\n\tLISTA DE SERVICIOS\n\n");
			foreach (Servicio ser in c.mostrarServicios)
				{
					Console.WriteLine("Especialidad: "+ser.Especialidad);
					Console.WriteLine("Jefe: " + ser.Jefe);
					if (ser.Camas == 0) 
					{
						escribirRojo("Camas disponibles: " + ser.Camas);
					}
					else if (ser.Camas < 3) 
					{
						escribirNaranja("Camas disponibles: " + ser.Camas);
					}
					else
					{
						escribirVerde("Camas disponibles: " + ser.Camas);
					}
					Console.WriteLine("------------------------------");
				}
			if (c.mostrarServicios.Count == 0) 
			{
				escribirRojo("Vacio");
			}
			Console.WriteLine("Presione cualquier tecla para volver al menu principal");
			Console.ReadKey(true);		
		}
		
		public static void mostrarMedicos(Clinica c)
		{	
			Console.Clear();
			Console.Title="MEDICOS";
			escribirAmarillo("\n\tLISTA DE MEDICOS\n\n");
			int contador = 0;
			foreach (Servicio ser in c.mostrarServicios)
			{	
				if (ser.Medicos.Count == 0) 
				{
					contador += 1;
				}
				foreach (Medico med in ser.Medicos)
				{	
					Console.WriteLine("Nombre: " + med.Nombre);
					Console.WriteLine("Apellido: " + med.Apellido);
					Console.WriteLine("DNI: " + med.Dni);
					Console.WriteLine("Legajo: " +  med.Legajo);
					Console.WriteLine("Turno: " + med.Turno);
					Console.WriteLine("Especialidad: " + med.Especialidad);
					Console.WriteLine("-----------------------------------");
				}
			}
			if (contador == c.mostrarServicios.Count)
			{
				escribirRojo("Vacio");
			}
				Console.WriteLine("Presione cualquier tecla para volver al menu principal");
				Console.ReadKey(true);	
		}
		public static void salir()
		{
			Console.Clear();
			escribirAmarillo("\n\tGracias por ultilizar nuestros servicios!! Te esperamos pronto\n\n");
			Thread.Sleep(3000);	
			return;
		}
		public static void opcionMenuPrincipal(int opcion, Clinica c)
		{
			switch (opcion)
			{
				case 1:
					agregarUnMedico(c);
					menuPrincipal(c);
					break;
				case 2:
					borrarMedico(c);
					menuPrincipal(c);
					break;
				case 3:
					internarPaciente(c);
					menuPrincipal(c);
					break;
				case 4:
					serviciosConMedicosNocturnos(c);
					menuPrincipal(c);
					break;
				case 5:
					altaPaciente(c);
					menuPrincipal(c);
					break;
				case 6:
					mostrarServicios(c);
					menuPrincipal(c);
					break;
				case 7:
					mostrarMedicos(c);
					menuPrincipal(c);
					break;
				case 8:
					PacientesDeUnServicio(c);
					menuPrincipal(c);
					break;
				case 9:
					salir();
					break;
				case 10:
					nuevoServicio(c);
					menuPrincipal(c);
					break;
				default:
					escribirRojo("La opcion no existe");
					Console.WriteLine("Presione cualquier tecla para volver al menu principal");
					Console.ReadKey(true);
					menuPrincipal(c);
					break;
			}	
		}
		public static void nuevoServicio(Clinica c)
		{
			Console.Clear();
			Console.Title="NUEVO SERVICIO";
			escribirAmarillo("\n\tNUEVO SERVICIO\n\n");
			string especialidad, jefe;
			int camas;
			Console.WriteLine("Ingrese la especialidad");
			especialidad = verificarCadenaVacia();
			Console.WriteLine("Ingrese el nombre del jefe");
			jefe = verificarCadenaVacia();
			Console.WriteLine("Ingrese la cantidad de camas");
			camas = verificarEnteroYVacio();
			Servicio nuevoservicio = new Servicio(especialidad,jefe,camas);
			c.agregarServicio(nuevoservicio);
			escribirVerde("Servicio creado con exito");
			Console.WriteLine("Presione cualquier tecla para volver al menu principal");
			Console.ReadKey(true);
		}
		public static void menuPrincipal(Clinica c)
		{
			Console.Clear();
			int opcion;
			Console.Title="MENU";
			escribirAzul(c.Nombre);
			escribirAmarillo("\n\tMENU PRINCIPAL\n\n");
			Console.WriteLine(" 1. Agregar a un médico en el servicio correspondiente a su especialidad");
			Console.WriteLine(" 2. Eliminar a un médico");
			Console.WriteLine(" 3. Internar a un paciente e un servicio dado y a cargo de un médico determinado");
			Console.WriteLine(" 4. Listado de los servicios que tienen médicos de guardia en horarios nocturno");
			Console.WriteLine(" 5. Dar de alta(egreso) a un paciente internado en un servicio dado y a cargo de un médico determinado");
			Console.WriteLine(" 6. Lista de servicios");
			Console.WriteLine(" 7. Lista de médicos");
			Console.WriteLine(" 8. Lista de pacientes en un servicio");
			Console.WriteLine(" 9. Salir del programa");
			escribirAzul("10. (Extra) Nuevo servicio");
			Console.WriteLine("Ingrese una opcion: ");
			opcion = verificarEnteroYVacio();
			opcionMenuPrincipal(opcion,c);
		}
		public static void Main(string[] args)
		{
			Clinica c1 = new Clinica("Clinica MEDINA");
			Servicio e1 = new Servicio("Cardialogía","Patricio",30);
			Servicio e2 = new Servicio("Infectología","Matias",25);
			Servicio e3 = new Servicio("Pediatría","Lenadro",5);
			Servicio e4 = new Servicio("Traumatología","Esteban",15);
			Servicio e5 = new Servicio("Guardia","Nicolas",24);
			Servicio e6 = new Servicio("Neurología","Miguel",25);
			Servicio e7 = new Servicio("Oftalmología","Francisco",18);
			Servicio e8 = new Servicio("Terapia intensiva","Julian",0);
			Servicio e9 = new Servicio("COVID-19","Julio",2);
			c1.agregarServicio(e1);
			c1.agregarServicio(e2);
			c1.agregarServicio(e3);
			c1.agregarServicio(e4);
			c1.agregarServicio(e5);
			c1.agregarServicio(e6);
			c1.agregarServicio(e7);
			c1.agregarServicio(e8);
			c1.agregarServicio(e9);
			Medico m0 = new Medico ( 11111,  1,  "Mauro",  "Salinas",  "Cardialogía",  "Mañana");
			Medico m1 = new Medico ( 11112,  2,  "Patricio",  "Medina",  "Cardialogía",  "Tarde");
			Medico m2 = new Medico ( 11113,  3,  "Juana",  "Viale",  "Cardialogía",  "Noche");
			Medico m3 = new Medico ( 11114,  4,  "Juan",  "Perez",  "Infectología",  "Mañana");
			Medico m4 = new Medico ( 11115,  5,  "Jonathan",  "Mendez",  "Infectología",  "Tarde");
			Medico m5 = new Medico ( 11116,  6,  "Mirta",  "Ochoa",  "Infectología",  "Noche");
			Medico m6 = new Medico ( 11117,  7,  "Javier",  "Gomez",  "Pediatría",  "Mañana");
			Medico m7 = new Medico ( 11118,  8,  "Martin",  "Martinez",  "Pediatría",  "Tarde");
			Medico m8 = new Medico ( 11119,  9,  "Homero",  "Simpsons",  "Pediatría",  "Noche");
			Medico m9 = new Medico ( 111110,  10,  "Mauricio",  "Diaz",  "Traumatología",  "Mañana");
			Medico m10 = new Medico ( 111111,  11,  "Sebastian",  "Romero",  "Traumatología",  "Tarde");
			Medico m11 = new Medico ( 111112,  12,  "Bautista",  "Diaz",  "Traumatología",  "Noche");
			Medico m12 = new Medico ( 111113,  13,  "Jose",  "Garcia",  "Guardia",  "Mañana");
			Medico m13 = new Medico ( 111114,  14,  "Jose",  "Garcia",  "Guardia",  "Tarde");
			Medico m14 = new Medico ( 111115,  15,  "Francisco",  "Sosa",  "Guardia",  "Noche");
			Medico m15 = new Medico ( 111116,  16,  "Walter",  "Torres",  "Neurología",  "Mañana");
			Medico m16 = new Medico ( 111117,  17,  "Jorge",  "Ruiz",  "Neurología",  "Tarde");
			Medico m17 = new Medico ( 111118,  18,  "Lorena",  "Villa",  "Neurología",  "Noche");
			Medico m18 = new Medico ( 111119,  19,  "Lucas",  "Flores",  "Oftalmología",  "Mañana");
			Medico m19 = new Medico ( 111120,  20,  "Josefina",  "Acosta",  "Oftalmología",  "Tarde");
			Medico m20 = new Medico ( 111121,  21,  "Benjamin",  "Floresta",  "Oftalmología",  "Noche");
			Medico m21 = new Medico ( 111122,  22,  "Andrea",  "Rojas",  "Terapia intensiva",  "Mañana");
			Medico m22 = new Medico ( 111123,  23,  "Yanina",  "Roa",  "Terapia intensiva",  "Tarde");
			Medico m23 = new Medico ( 111124,  24,  "Martina",  "Altamirano",  "Terapia intensiva",  "Noche");
			Medico m24 = new Medico ( 111125,  25,  "Veronica",  "Sanchez",  "COVID-19",  "Mañana");
			Medico m25 = new Medico ( 111126,  26,  "Juana",  "Benitez",  "COVID-19",  "Tarde");
			Medico m26 = new Medico ( 111127,  27,  "Claudia",  "Mao",  "COVID-19",  "Noche");
			e1.agregarMedicoAUnServicio(m0);
			e1.agregarMedicoAUnServicio(m1);
			e1.agregarMedicoAUnServicio(m2);
			e2.agregarMedicoAUnServicio(m3);
			e2.agregarMedicoAUnServicio(m4);
			e2.agregarMedicoAUnServicio(m5);
			e3.agregarMedicoAUnServicio(m6);
			e3.agregarMedicoAUnServicio(m7);
			e3.agregarMedicoAUnServicio(m8);
			e4.agregarMedicoAUnServicio(m9);
			e4.agregarMedicoAUnServicio(m10);
			e4.agregarMedicoAUnServicio(m11);
			e5.agregarMedicoAUnServicio(m12);
			e5.agregarMedicoAUnServicio(m13);
			e5.agregarMedicoAUnServicio(m14);
			e6.agregarMedicoAUnServicio(m15);
			e6.agregarMedicoAUnServicio(m16);
			e6.agregarMedicoAUnServicio(m17);
			e7.agregarMedicoAUnServicio(m18);
			e7.agregarMedicoAUnServicio(m19);
			e7.agregarMedicoAUnServicio(m20);
			e8.agregarMedicoAUnServicio(m21);
			e8.agregarMedicoAUnServicio(m22);
			e8.agregarMedicoAUnServicio(m23);
			e9.agregarMedicoAUnServicio(m24);
			e9.agregarMedicoAUnServicio(m25);
			e9.agregarMedicoAUnServicio(m26);
			string hoy = DateTime.Now.ToString("dd-MM-yyyy");
			Paciente p1 = new Paciente( "José",  "Morales",  111,  "COVID-19 Positivo", "03/05/1991", hoy,25);
			Paciente p2 = new Paciente( "Martin",  "Martinez",  112,  "COVID-19 Positivo", "03/05/1991", hoy,25);
			Paciente p3 = new Paciente( "Manuela",  "Pérez",  113,  "COVID-19 Positivo", "03/05/1991", hoy,25);
			Paciente p4 = new Paciente( "Oscar",  "Medina",  114,  "COVID-19 Positivo", "03/05/1991", hoy,26);
			Paciente p5 = new Paciente( "Javier",  "Taquichiri",  115,  "COVID-19 Positivo", "03/05/1991", hoy,26);
			Paciente p6 = new Paciente( "Ana",  "Rodriguez",  116,  "COVID-19 Positivo", "03/05/1991", hoy,27);
			Paciente p7 = new Paciente( "Anabela",  "Villanueva",  117,  "COVID-19 Positivo", "03/05/1991", hoy,27);
			Paciente p8 = new Paciente( "Josefa",  "Villareal",  118,  "COVID-19 Positivo", "03/05/1991", hoy,27);
			e9.internarPaciente(p1);
			e9.internarPaciente(p2);
			e9.internarPaciente(p3);
			e9.internarPaciente(p4);
			e9.internarPaciente(p5);
			e9.internarPaciente(p6);
			e9.internarPaciente(p7);
			e9.internarPaciente(p8);
			menuPrincipal(c1);
		}
	}
}