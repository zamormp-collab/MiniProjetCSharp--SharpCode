using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rescent.Domaine.Enums;

namespace Rescent.Domaine.Entites
{
    public class Salle : Ressource //, IReservable, IUtilisable, IMaintenable, IEquipable, IDescriptible, IContactable, IDisponible
    {
    // Surcharge d'attributs de la classe fille Salle
        private int _capacite;

    // Surcharge de proprietés de la classe fille Salle
        public int Capacite
        {
            get => _capacite;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("La capacité ne peut pas être inférieure à 1.");
                }
                _capacite = value;
            }
        } 

    // Constructeur de la classe fille Salle
    // Instanciation du constructeur de la classe fille Salle
        public Salle(string nom, string responsable, StatutRessource statut, int capacite)
        : base(nom, responsable)
    {
        if (capacite <= 0)
            throw new ArgumentException("Capacité invalide.");

        Statut = statut;
        Capacite = capacite;
    }

    // Surcharge de la méthode AfficherInfos
        public override void AfficherInfos()
        { 	
            base.AfficherInfos();
            Console.WriteLine ($"=====      Statut : {Statut}.     =====");
		    Console.WriteLine ($"=====      La salle a une capacité de : {Capacite} place.     =====");
        }

    //Surcharge de la methode EstDisponible
        public override bool EstDisponible()
        {
            return Statut == StatutRessource.Disponible;
        }
    }
}