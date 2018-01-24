using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("oRACLE");
            IDataSpace db;
            db = new Oracle();
            db.Selecct();
            db.Insert();
            db.Delete();
            db.Update();

            Console.WriteLine("SQL sERVER");
            IDataSpace sqlserver;
            sqlserver = new SQLServer();
            sqlserver.Selecct();
            sqlserver.Insert();
            sqlserver.Delete();
            sqlserver.Update();


        }
    }
}
interface IDataSpace
{
    void Selecct();
    void Insert();
    void Delete();
    void Update();
}
class SQLServer : IDataSpace
{

    public void Selecct()
    {
        Console.WriteLine("Select");
    }

    public void Insert()
    {
        Console.WriteLine("Insert");
    }

    public void Delete()
    {
        Console.WriteLine("Delete");
    }

    public void Update()
    {
        Console.WriteLine("Update"); 
    }
}
class Oracle : IDataSpace
{
    public void Selecct()
    {
        Console.WriteLine("SelectW");
    }

    public void Insert()
    {
        Console.WriteLine("InsertW");
    }

    public void Delete()
    {
        Console.WriteLine("DeleteW");
    }

    public void Update()
    {
        Console.WriteLine("UpdateW");
    }
}
