using System;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;

namespace security_app
{
    class Activation
    {
        //SWQ45-78ASD-SD41Q-45EED

        /// <summary>
        /// this property to store messages
        /// </summary>
        public static string message;
        public static bool check = false;

        /// <summary>
        /// return true if key valide and active, false for others
        /// </summary>
        /// <param name="key_activate"></param>
        /// <returns></returns>
        public static bool is_activate(string key_activate)
        {
            try
            {
                var command = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "SELECT isActivate FROM activation WHERE [key] = @key"
                };
                command.Parameters.AddWithValue("@key", key_activate);
                int res = Convert.ToInt32(command.ExecuteScalar());
                command = null;
                Connection.closeConnection();
                return res > 0 ? true : false;
            }
            catch (Exception ex)
            {
                Connection.closeConnection();
                LogFile.Message(ex);
                return false;
            }
        }

        /// <summary>
        /// to activate software when valide key
        /// </summary>
        /// <param name="key_activate"></param>
        public static void activate_software(string key_activate)
        {
            try
            {
                var command = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "SELECT [key] FROM activation"
                };

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Crypt.DecrypterPassWord(reader[0].ToString()).Equals(key_activate))
                    {
                        if (!is_activate(reader[0].ToString()))
                        {
                            update_sctivation(reader[0].ToString());
                            using (var isolated = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                            {
                                using (var stream = new IsolatedStorageFileStream("setting.txt", System.IO.FileMode.OpenOrCreate, isolated))
                                {
                                    using (var sw = new System.IO.StreamWriter(stream))
                                    {
                                        sw.Write(reader[0]);
                                    }
                                }
                            }
                            message = "your key is Correct";
                            return;
                        }
                        else
                        {
                            check = true;
                            message = "your software already activated";
                        }
                    }
                }

                if (!check)
                    message = "your key is incorrect";

                Connection.closeConnection();
                command = null;
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        /// <summary>
        /// update a valide key on database
        /// </summary>
        /// <param name="key_activate"></param>
        private static void update_sctivation(string key_activate)
        {
            try
            {
                var command = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "UPDATE activation SET isActivate = 1 WHERE [key] = @key"
                };
                command.Parameters.AddWithValue("@key", key_activate);
                command.ExecuteNonQuery();
                command = null;
                Connection.closeConnection();
                message = "Your Software has been Activated";
            }
            catch (Exception ex)
            {
                Connection.closeConnection();
                LogFile.Message(ex);
                message = "Faild to connect";
            }
        }
    }
}
