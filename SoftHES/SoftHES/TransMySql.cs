﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SoftHES
{
    public class TransMySql
    {
        //Metodo que devuelve si se registo el usuario o cuantas filas se ingresaron en la tabla 
        public int registro(users usuario)
        {
            //Creamos la conexion a MySql
            MySqlConnection conexion = ConexionReg.getConnexion();
            conexion.Open();

            string sql = "INSERT INTO users (nombre, usuario,password,idTipo) VALUES(@nombre, @usuario, @password, @idTipo)";

            //Creamos nuestro comando para poder hacer nuestra consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@idTipo", 1);

            //Regresa el numero de filas insertadas en la tabla
            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }

        internal bool existUs(string usuario)
        {
            throw new NotImplementedException();
        }

        public bool existeUs(string usuario)
        {

            MySqlDataReader reader;

            //Creamos la conexion a MySql
            MySqlConnection conexion = ConexionReg.getConnexion();
            conexion.Open();

            string sql = "SELECT id FROM users WHERE users LIKE @usuario";

            //Creamos nuestro comando para poder hacer nuestra consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion); 
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }
}