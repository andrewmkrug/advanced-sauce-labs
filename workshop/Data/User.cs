using System;

namespace workshop.Data
{
    public class User
    {
        private  String username { get; set; }
        private  String password { get; set; }

        public User()
        {
            username = "standard_user";
            password = "secret_sauce";
        }

        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public String getUsername() {
            return username;
        }

        public String getPassword() {
            return password;
        }
    }
}