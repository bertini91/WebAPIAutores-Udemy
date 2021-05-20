using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIAutores.Entidades;

namespace WebAPIAutores
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option): base(option)
        {

        }



        //Configuramos las tablas que vamos a generar
        public DbSet<Autor> Autores { get; set; } //Creame una tabla Autores con el esquema de Autor
        public DbSet<Libro> Libros { get; set; }

    }
}
