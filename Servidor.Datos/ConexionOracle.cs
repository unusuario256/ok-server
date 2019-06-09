﻿using Oracle.ManagedDataAccess.Client;
using System;
//using Dapper;
//using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;

namespace Servidor.Datos
{
    public class ConexionOracle
    {
        private const String SOURCE = "LOCALHOST:1521";
        private static String USER   = "SERVIDOR_TEST_";
        private static String PASSWD = "servidor123";
        private static OracleConnection con;
        private static ConexionOracle _instance = new ConexionOracle();
        public static ConexionOracle Conexion
        {
            get {
                if (_instance != null)
                {
                    return _instance;
                }
                else
                {
                    return _instance = new ConexionOracle();
                }
            }
        }
        public List<T> GetAll<T>(DataBaseConUser dbcu) where T : class
        {
            switch (dbcu)
            {
                case DataBaseConUser.OkCasa:
                    USER += "ok";
                    break;
                case DataBaseConUser.BancoEstado:
                    USER += "be";
                    break;
                case DataBaseConUser.Transbank:
                    USER += "tb";
                    break;
            }
            using (con = new OracleConnection(StringConexion()))
            {
                CommandManager cmd = new CommandManager(con);
                return cmd.GetAll<T>();
            }
        }
        public T Get<T>(dynamic id, DataBaseConUser dbcu) where T : class
        {
            switch (dbcu)
            {
                case DataBaseConUser.OkCasa:
                    USER += "ok";
                    break;
                case DataBaseConUser.BancoEstado:
                    USER += "be";
                    break;
                case DataBaseConUser.Transbank:
                    USER += "tb";
                    break;
            }
            using (con = new OracleConnection(StringConexion()))
            {
                CommandManager cmd = new CommandManager(con);
                return cmd.Get<T>(id);
            }
        }
        public bool Insert(Object objeto, DataBaseConUser dbcu)
        {
            try
            {
                switch (dbcu)
                {
                    case DataBaseConUser.OkCasa:
                        USER += "ok";
                        break;
                    case DataBaseConUser.BancoEstado:
                        USER += "be";
                        break;
                    case DataBaseConUser.Transbank:
                        USER += "tb";
                        break;
                }
                using (con = new OracleConnection(StringConexion()))
                {
                    CommandManager cmd = new CommandManager(con);
                    return cmd.Insert(objeto);
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool Update(Object objeto, DataBaseConUser dbcu)
        {
            switch (dbcu)
            {
                case DataBaseConUser.OkCasa:
                    USER += "ok";
                    break;
                case DataBaseConUser.BancoEstado:
                    USER += "be";
                    break;
                case DataBaseConUser.Transbank:
                    USER += "tb";
                    break;
            }
            using (con = new OracleConnection(StringConexion()))
            {
                CommandManager cmd = new CommandManager(con);
                return cmd.Update(objeto);
            }
            
        }
        public bool Delete(Object objeto, DataBaseConUser dbcu)
        {
            switch (dbcu)
            {
                case DataBaseConUser.OkCasa:
                    USER += "ok";
                    break;
                case DataBaseConUser.BancoEstado:
                    USER += "be";
                    break;
                case DataBaseConUser.Transbank:
                    USER += "tb";
                    break;
            }
            using (con = new OracleConnection(StringConexion()))
            {
                CommandManager cmd = new CommandManager(con);
                return cmd.Delete(objeto);
            }
            
        }
        private String StringConexion()
        {
            return "DATA SOURCE=" + SOURCE + ";USER ID=" + USER + ";PASSWORD=" + PASSWD + ";";
        }
    }
    public enum DataBaseConUser
    {
        OkCasa,
        BancoEstado,
        Transbank
    }
}
