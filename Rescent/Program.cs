using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rescent.Domaine.Entites;
using Rescent.Domaine.Enums;
//using Rescent.Services;

namespace Rescent.Domaine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rescent");
            Console.WriteLine("The reservation system of CENTRALEO Services!");
            Console.WriteLine();
            Console.WriteLine("Bienvenue au système de gestion de réservations de CENTRALEO Services!\n\n");
       
            //Liste de Ressources
            List<Ressource> ressources = new List<Ressource>
		    {
			    new Salle ("Auditorium", "Edwin Satire", StatutRessource.Disponible, 50),
                new ChambrePassage ("VIP", "Marcus Jonassaint", StatutRessource.Disponible, 2),
                new Equipement(
                    "Projecteur",
                    "Claude Mars", 
                    StatutRessource.Disponible, 
                    "Projecteur Epson, LED, 4K, HDMI, Blanc", 
                    "09AMS63K", 
                    2)
		    };

            Console.WriteLine("--  AFFICHAGE DES RESSOURCES  --\n\n");
            foreach (Ressource ressource in ressources)
            {   
                ressource.AfficherInfos(); // polymorphisme via la classe de base
                Console.WriteLine();
            } 
        }
    }
}