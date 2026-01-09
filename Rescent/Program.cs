using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rescent.Domaine.Entites;
using Rescent.Domaine.Enums;

namespace Rescent.Domaine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rescent");
            Console.WriteLine("The reservation system of CENTRALEO Services!");
            Console.WriteLine();
            Console.WriteLine("Bienvenue au système de gestion de réservations de la CENTRALEO Services!");
        }
        Ressources salle = new Salle("Auditorium", "Edwin Satire", StatutRessource.Disponible, 50);
    }
}