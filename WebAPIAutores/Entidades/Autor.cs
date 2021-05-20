using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
