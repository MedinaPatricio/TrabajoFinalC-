/*
 * Creado por SharpDevelop.
 * Usuario: FliaMedinaVillanueva
 * Fecha: 01/06/2022
 * Hora: 23:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
namespace Clinica
{
	/// <summary>
	/// Description of Medico.
	/// </summary>
	public class Medico
	{
		
		private int dni;
		private int legajo;
		private string nombre;
		private string apellido;
		private string especialidad;
		private string horario;
		
		
		public Medico(int dni, int legajo, string nombre, string apellido, string especialidad, string horario)
		{
		
			this.dni = dni;
			this.legajo = legajo;
			this.nombre = nombre;
			this.apellido = apellido;
			this.especialidad = especialidad;
			this.horario = horario;
			
		}
		
		
		
		public string Nombre
		{
			set 
			{
				nombre = value;
			}
			get
			{
				return nombre;
			}
		}
		public int Dni
		{
			set 
			{
				dni = value;
			}
			get
			{
				return dni;
			}
		}
		public int Legajo
		{
			set 
			{
				legajo = value;
			}
			get
			{
				return legajo;
			}
		}
		public string Apellido
		{
			set 
			{
				apellido = value;
			}
			get
			{
				return apellido;
			}
		}
		public string Especialidad
		{
			set 
			{
				especialidad = value;
			}
			get
			{
				return especialidad;
			}
		}
		public string Turno
		{
			set 
			{
				horario = value;
			}
			get
			{
				return horario;
			}
		}
	}
}
