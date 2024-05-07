using Desafio.API.Data;
using Desafio.API.Entities;
using Desafio.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel;

namespace Desafio.API.Repositories
{
    public class Inventory : RepositoryModel<Product, DataContext> 
    {

        public Inventory(DataContext context) : base(context) { }


    }
}
