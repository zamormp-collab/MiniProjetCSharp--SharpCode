using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescent.Domaine.Entites
{
    public class ChambrePassage : Ressources //, IReservable, IUtilisable, IMaintenable, IEquipable, IDescriptible, IContactable, IDisponible
    {
    // Surcharge d'attributs de la classe fille ChambrePassage
        private int _capacite;

    // Surcharge de proprietés de la classe fille ChambrePassage
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

    // Constructeur de la classe fille ChambrePassage
    // Instanciation du constructeur de la classe fille ChambrePassage
        public ChambrePassage(string nom, string responsable, StatutRessource statut, int capacite) : base()
        {
            this.Nom = nom;
            this.Responsable = responsable;
            this.Statut = statut;
            this.Capacite = capacite;
        }

    // Surcharge de la méthode AfficherInfos
        public override void AfficherInfos(string nom, string responsable, StatutRessource statut)
        { 	
            base.AfficherInfos(base.Nom, base.Responsable, base.Statut);
		    Console.WriteLine ($"La salle a une capacité de : {Capacite} place.");
        }

    //Surcharge de la methode EstDisponible
        public override bool EstDisponible()
        {
            return base.EstDisponible();
        }
    }
}