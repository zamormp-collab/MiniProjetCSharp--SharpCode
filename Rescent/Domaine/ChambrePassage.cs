using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rescent.Domaine.Enums;

namespace Rescent.Domaine.Entites
{
    public class ChambrePassage : Ressources //, IReservable, IUtilisable, IMaintenable, IEquipable, IDescriptible, IContactable, IDisponible
    {
    // Surcharge d'attributs de la classe fille ChambrePassage
        private int _nombrelit;

    // Surcharge de proprietés de la classe fille ChambrePassage
        public int NombreLit
        {
            get => _nombrelit;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Le nombre de lits ne peut pas être inférieur à 1.");
                }
                _nombrelit = value;
            }
        } 

    // Constructeur de la classe fille ChambrePassage
    // Instanciation du constructeur de la classe fille ChambrePassage
        /*public ChambrePassage(string nom, string responsable, StatutRessource statut, int nombrelit) : base()
        {
            this.Nom = nom;
            this.Responsable = responsable;
            this.Statut = statut;
            this.NombreLit = nombrelit;
        }*/

    // Surcharge de la méthode AfficherInfos
        public override void AfficherInfos(string nom, string responsable, StatutRessource statut)
        { 	
            base.AfficherInfos(base.Nom, base.Responsable, base.Statut);
		    Console.WriteLine ($"La chambre a {NombreLit} lit(s).");
        }

    //Surcharge de la methode EstDisponible
        public override bool EstDisponible()
        {
            return Statut == StatutRessource.Disponible;
        }
    }
}