using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Lecture_MVC.Models
{
    public class UserManagment
    {
        public bool addUer(User u)
        {
            string con = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=UserDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "insert into SignUp(username, email, password) values(@u, @e, @p)";
            SqlParameter p1 = new SqlParameter("u", u.username);
            SqlParameter p2 = new SqlParameter("e", u.email);
            SqlParameter p3 = new SqlParameter("p", u.password);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            int row = cmd.ExecuteNonQuery();
            if(row>0)
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
