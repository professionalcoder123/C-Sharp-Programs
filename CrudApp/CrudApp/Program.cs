using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using CrudApp;

internal class Program
{
    static void Main(string[] args)
    {
        //UserData.PerformSql();

        Employee.PerformSql();
    }
}