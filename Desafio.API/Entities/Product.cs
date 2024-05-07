using Desafio.API.AbstractModels;
using System.Security.Cryptography.X509Certificates;

namespace Desafio.API.Entities
{
    public class Product : IEntity
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public Product(int ID, string? Name)
        {
            this.ID = ID;
            this.Name = Name;
        }


    }
}
