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
	/// Description of Clinica.
	/// </summary>
	public class Clinica
	{
		private ArrayList listaDeServicios;
		private string nombre;
		public Clinica(string nombre)
		{
			listaDeServicios = new ArrayList();
			this.nombre = nombre;
		}

		public void agregarServicio(Servicio servicio)
		{
			listaDeServicios.Add(servicio);
		}
		public void eliminarServicio(Servicio servicio)
		{
			listaDeServicios.Remove(servicio);
		}
		public int cantidadDeServicios()
		{
			return listaDeServicios.Count;
		}
		public Servicio servicioSegunIndice(int indice)
		{
			return (Servicio)listaDeServicios[indice];
		}
		public bool existeServicio(string especialidad)
		{
			foreach (Servicio ser in listaDeServicios)
			{
				if (ser.Especialidad == especialidad)
				{
					return true;
				}
			}
			return false;
		}
		public ArrayList mostrarServicios
		{
			get
			{
				return listaDeServicios;
			}
		}
		public string Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				nombre = value;
			}
		}
	}
}
