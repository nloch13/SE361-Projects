using System.Data.SqlClient;
using System.Windows.Forms;
public class Database
{
    private string connectionString_;
    private string tableName_;
    SqlConnection connection_;

    public Database()
    {
        connectionString_ = @"Data Source=se361sam.database.windows.net;Initial Catalog=SAAAMM;User ID=SAAAMM;Password=SE361#sam";
        tableName_ = "logins";
        connection_ = new SqlConnection(connectionString_);
        connection_.Open();
    }

    public bool Query(string username, string password)
    {
        string queryString = "SELECT * FROM " + tableName_ + " WHERE username = \'" + username + "\' AND password = \'" + password + "\'";

        SqlCommand command = new SqlCommand(queryString, connection_);

        SqlDataReader result = command.ExecuteReader();

        if (result.HasRows)
        {
            result.Close();
            return true;
        }
        else
        {
            result.Close();
            return false;
        }
    }
}
