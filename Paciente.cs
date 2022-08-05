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
	public class Paciente
	{
		private int dni;
		private string nombre;
		private string apellido;
		private string diagnostico;
		private string fechaDeNac;
		private string fechaingreso;
		private int legajoMedico;
		
		public Paciente(string nombre, string apellido, int dni, string diagnostico,string nacimiento,string ingreso, int legajoMedico)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.diagnostico = diagnostico;
			this.legajoMedico = legajoMedico;
			fechaDeNac = nacimiento;
			fechaingreso = ingreso;
		}
		public string Nombre
		{
			set 
			{
				nombre= value;
			}
			get
			{
				return nombre;
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
		
		public string Diagnostico
		{
			set 
			{
				diagnostico = value;
			}
			get
			{
				return diagnostico;
			}
		}
		public string fechanac
		{
			set 
			{
				fechaDeNac = value;
			}
			get
			{
				return fechaDeNac;
			}
		}
		public string fechain
		{
			set 
			{
				fechaingreso = value;
			}
			get
			{
				return fechaingreso;
			}
		}
		public int Medico
		{
			set 
			{
				legajoMedico= value;
			}
			get
			{
				return legajoMedico;
			}
		}
		
	}
}

