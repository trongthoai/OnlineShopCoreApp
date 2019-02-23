namespace WebCoreApp.Data.Entities
{
    public class IdentityRole<T>
    {
        private string name;

        public IdentityRole()
        {
        }

        public IdentityRole(string name)
        {
            this.name = name;
        }
    }
}