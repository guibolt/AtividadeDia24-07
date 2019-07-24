using JsonApp.Entidades.JsonClass.Auxi;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonApp.Entidades.JsonClass
{
   public class Register
    {
        public string _Id { get; set; }
        public int Index { get; set; }
        public string Guid { get; set; }
        public bool IsActive { get; set; }
        public string Balance { get; set; }
        public string Picture { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string Registered { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public List<Friend> Friends { get; set; } = new List<Friend>();
        public string Greeting { get; set; }
        public string FavoriteFruit { get; set; }
        public EmissaoDigital EmissaoDigital { get; set; }

        public override string ToString()
        {
            return $"NAME: {Name} Age: {Age} Gender: {Gender}  Company: {Company}  Index: {Index}* ".ToUpper();
        }
    }
}
