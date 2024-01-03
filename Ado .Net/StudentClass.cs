using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ado_StudentClass_Information
{
    internal class StudentClass
    {
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=Testdb";

        public string InsertStudent(int rno,string studname,string gender,string hobby,string city,string dob)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "Insert into student values(@rno,@studname,@gender,@hobby,@city,@dob)";

                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    command.Parameters.AddWithValue("studname", studname);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@hobby", hobby);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.ExecuteNonQuery();

                    con.Close();
                    return "Record Inserted Successfully";
                }
            }
        }

        public string UpdateStudent(int rno,string studname,string gender,string hobby,string city,string dob)
        {
            string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=Testdb";

            using(SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "update student set studname=@studname,gender=@gender,hobby=@hobby,city=@city,dob=@dob where rno=@rno";

                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@studname", studname);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@hobby", hobby);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.Parameters.AddWithValue("@rno", rno);

                    command.ExecuteNonQuery();

                    con.Close();
                    return "Record Updated Successfully";
                }
            }

        }
        public string DeleteStudent(int rno,string studname)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "Delete from student where rno=@rno or studname=@studname";

                using(SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("rno", rno);
                    command.Parameters.AddWithValue("studname", studname);
                    command.ExecuteNonQuery();

                    con.Close();
                    return "Record Deleted Succsessfully";
                }
            }
        }

        public List<Student> SearchStudent(int rno)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "select * from student where rno=@rno";

                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    SqlDataReader dr = command.ExecuteReader();
                    List<Student> li = new List<Student>();
                    while (dr.Read())
                    {
                        li.Add(new Student(Convert.ToInt32(dr["rno"].ToString()), dr["studname"].ToString(), dr["gender"].ToString(), dr["hobby"].ToString(), dr["city"].ToString(),dr["dob"].ToString()));
                    }
                    return li;
                }
            }
        }
    }
}