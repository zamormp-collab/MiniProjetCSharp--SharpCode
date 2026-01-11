/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rescent.Domaine.Enums;
using Rescent.Domaine.Entites;

namespace Rescent.Domaine.Services
{
    public class GestionRessources
    {
    // Liste pour stocker les ressources
        private List<Ressource> _ressources = new List<Ressource>();

    // Constructeur de la classe GestionRessources
        public GestionRessources()
        {
            _ressources = new List<Ressource>()
            {
                new Salle("Auditorium", "Edwin Satire", StatutRessource.Disponible, 50),
                new ChambrePassage("VIP", "Marcus Jonassaint", StatutRessource.Disponible, 2),
                new Equipement("Projecteur", "Claude Mars", StatutRessource.Disponible, "Projecteur Epson LED 4K, HDMI, Blanc", "09AMS63K", 2)
            };
        }
    // Propriété pour accéder à la liste des ressources
        public List<Ressource> Ressources 
        {
            get => _ressources;
        }
    // Méthode pour ajouter une ressource à la liste
        public void AjouterRessource(Ressource ressource)
        {
            _ressources.Add(ressource);
        }
    }
}*/