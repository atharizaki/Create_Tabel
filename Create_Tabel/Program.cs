using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-301VMEB\\ZAKI;database=ProdiTI;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM Char(12) not null primary key, Nama Varchar(50), Alamat Varchar(255), " +
                    "Jenis_Kelamin Char(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
