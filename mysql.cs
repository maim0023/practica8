using System;

using MySql.Data.MySqlClient;



namespace alumnos

{

  public class MySQL

	{

		protected MySqlConnection myConnection;

		public MySQL ()

		{

		}

		

		protected void abrirConexion(){

			string connectionString =

				"Server=localhost;" +

					"Database=escuela;" +

					"User ID=Programacion;" +

					"Password=Miguel0023;" +

					"Pooling=false";

	       this.myConnection = new MySqlConnection(connectionString);

	       this.myConnection.Open();

		}

		

		protected void cerrarConexion(){

			this.myConnection.Close(); 

			this.myConnection = null;

		}

	}

}

