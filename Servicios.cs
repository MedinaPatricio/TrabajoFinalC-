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
	/// Description of Servicio.
	/// </summary>
	public class Servicio
	{
		private ArrayList listaDeMedicos;
		private ArrayList listaDePacientes;
		private string especialidad;
		private string jefe;
		private int camas;
		
		
		public Servicio(string especialidad, string jefe, int camas)
		{
			this.camas = camas;
			this.jefe = jefe;
			this.especialidad = especialidad;
			this.listaDeMedicos = new ArrayList();
			this.listaDePacientes = new ArrayList();
		}
		
		public int cantidadDeMedicos()
		{
			return listaDeMedicos.Count;
		}
		public int cantidadDePacientes()
		{
			return listaDePacientes.Count;
		}
		
		public void agregarMedicoAUnServicio( Medico medico)
		{
			listaDeMedicos.Add(medico);
		}
		
		
		public void borrarMedicoDeUnServicio(Medico medico)
		{
			listaDeMedicos.Remove(medico);
		}
		
		public Medico medicoSegunIndice(int indice)
		{
			return (Medico)listaDeMedicos[indice];
		}
		public Paciente pacienteSegunIndice(int indice)
		{
			return (Paciente)listaDePacientes[indice];
		}
		
		public bool esPaciente(int dni)
		{
			foreach (Paciente pac in listaDePacientes)
			{
				if (pac.Dni == dni)
				{
					return true;
				}
			}
			return false;
		}

		public bool esMedicoLeg(int legajo)
		{
			foreach (Medico med in listaDeMedicos)
			{
				if (med.Legajo == legajo)
				{
					return true;
				}
			}
			return false;
		}
		
		
		public void internarPaciente(Paciente paciente)
		{
			listaDePacientes.Add(paciente);
		}
		
		public void altaPaciente(Paciente paciente)
		{
			listaDePacientes.Remove(paciente);
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
		
		public ArrayList Medicos
		{
			get
			{
				return listaDeMedicos;
			}
		}
		public ArrayList Pacientes
		{
			get
			{
				return listaDePacientes;
			}
		}
		public string Jefe
		{
			set 
			{
				Jefe = value;
			}
			get
			{
				return jefe;
			}
		}
				
		public int Camas
		{
			set 
			{
				camas = value;
			}
			get
			{
				return camas;
			}
		}
	}
}
