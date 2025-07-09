using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsUesrData
    {

        public static bool GetUserInfoByUserID(int UserID, ref int PersonID,  ref string UserName,
                                              ref string  Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessStrings.connectionString);
            string query = @"Select * From Users  
                         Where UserID= @UserID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                Connection.Open();
               SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.Read())
                {
                    isFound = true;
                   
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                }
                else
                {
                    isFound = false;
                }
                Reader.Close();

            }catch(Exception ex)
            {
                isFound = false;
            }
            finally
            {

                Connection.Close();
            }
            return isFound;

        }


        public static bool GetUserInfoByPersonID(ref int UserID, int PersonID, ref string UserName,
                                         ref string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessStrings.connectionString);
            string query = @"Select * From Users  
                         Where PersonID= @PersonID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;

                    UserID = (int)Reader["UserID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                }
                else
                {
                    isFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

                Connection.Close();
            }
            return isFound;

        }

        public static bool GetUserInfoByUsernameAndPassword(ref int UserID, ref int PersonID, string UserName,
                                             string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessStrings.connectionString);
            string query = @"Select * From Users  
                         Where UserName= @UserName and Password = @Password";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                }
                else
                {
                    isFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

                Connection.Close();
            }
            return isFound;

        }
        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessStrings.connectionString);
            string query = @"insert into Users(PersonID,UserName, Password, IsActive)
                                               Values(@PersonID, @UserName, @Password, @IsActive)
                                               Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }

            } catch (Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();

            }
            return UserID;

        }
    
        public static bool UpdateUser(int UserID, int PersonID, string UserName,
                                      string Password, bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessStrings.connectionString);


            string query = @"Update  Users  
                            set 
                              PersonID = @PersonID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive, 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessStrings.connectionString);

            string query = @"Delete Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessStrings.connectionString);
            string query = @"Select Users.UserID,
                                    Users.PersonID,
  FullName= People.FirstName+' '+People.SecondName+' '+ People.ThirdName+' '+People.LastName,
	                                Users.UserName,
	                                Users.IsActive
                                    From Users inner join 
                                    People on  Users.PersonID= People.PersonID";

            SqlCommand Command = new SqlCommand(query, Connection);
            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessStrings.connectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessStrings.connectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessStrings.connectionString);
            string query = "Select Found = 1 from Users where PersonID = PersonID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                isFound = Reader.HasRows;

                Reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessStrings.connectionString);

            string query = @"Update  Users  
                            set Password = @Password
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


    }

}
