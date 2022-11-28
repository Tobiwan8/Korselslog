namespace Kørselslog.Model
{
    internal class User
    {
        //Fields
        private string? userName;
        private string? password;
        private string? name;
        private string? lastName;
        private string? email;
        
        //Properties
        internal string? UserName 
        { 
            get { return userName; } 
            set { userName = value; } 
        }
        internal string? Password
        {
            get { return password; }
            set { password = value; }
        }
        internal string? Name
        {
            get { return name; }
            set { name = value; }
        }
        internal string? LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        internal string? Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
