/*
 * Created by SharpDevelop.
 * User: jpapa
 * Date: 4/8/2019
 * Time: 1:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GIGACABLE
{
	/// <summary>
	/// Description of Reporte.
	/// </summary>
	public class Reporte
	{
		String id;
		String status;
		String descripcion;
		DateTime fecha_ini;
		DateTime fecha_fin;
		Usuario usuario;
		Usuario tecnico;
		Usuario cliente;
		TipoDeReporte tipo;
		//Constructor to generate
		public Reporte(Usuario cliente,Usuario usuario,Usuario tecnico,String descripcion, String status,TipoDeReporte tipo)
		{
			this.status = status;
			this.descripcion = descripcion;
			this.fecha_ini = DateTime.Now;
			this.usuario = usuario;
			this.tecnico = tecnico;
			this.cliente = cliente;
			this.tipo = tipo;
		}
		//Contructor when reading
		public Reporte(String id,String status,String descripcion,DateTime fecha_ini,DateTime fecha_fin,Usuario usuario,Usuario tecnico,Usuario cliente,TipoDeReporte tipo){
			this.id = id;
			this.status = status;
			this.descripcion = descripcion;
			this.fecha_ini = fecha_ini;
			this.fecha_fin = fecha_fin;
			this.usuario = usuario;
			this.tecnico = tecnico;
			this.cliente = cliente;
			this.tipo = tipo;
		}
		public void setId(){
			//id="TODO:Get id from db";
		}
		public void save(){
			//TODO: Save to db
		}
	}
}
