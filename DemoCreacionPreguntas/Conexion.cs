using System;



public class Conexion
{
	public string token;
	public string URL;

	public Conexion() { }

	public Conexion(string tokenBD, string link)
	{
		token = tokenBD;
		URL = link;
	}

	
}
