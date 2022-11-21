namespace Kørselslog.Repos
{
    internal class ConnectionString
    {
        private string _connectionString = @"Server = DESKTOP-RDJ3VF9; Initial Catalog = Korselslog; persist security info = true; User ID=sa; Password=funnyHAHA";
        internal string ConnectionToSql
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
    }
}
