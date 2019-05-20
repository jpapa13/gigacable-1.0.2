/*
 * Created by SharpDevelop.
 * User: jpapa
 * Date: 4/8/2019
 * Time: 1:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GIGACABLE
{
	/// <summary>
	/// Description of Usuario.
	/// </summary>
	public class Usuario
	{
		String id;
		String nombre;
		String usuario;
		public Usuario()
		{
			id = null;
			nombre=null;
			usuario=null;
		}
		public void setUsuario(String nombre, String usuario){
			this.nombre = nombre;
			this.usuario = usuario;
		}
		public void setId(String id){
			this.id = id;
		}
		public String getId(){
			return id;
		}
	}
}
