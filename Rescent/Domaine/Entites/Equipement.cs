using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rescent.Domaine.Enums;

namespace Rescent.Domaine.Entites
{
    public class Equipement : Ressource //, IReservable, IUtilisable, IMaintenable, IEquipable, IDescriptible, IContactable, IDisponible
    {
    // Surcharge d'attributs de la classe fille Equipement
        private string _specifications;
        private string _serialNumber;
        private int _quantite;

    // Surcharge de proprietés de la classe fille Equipement
        public string Specifications
        {
            get => _specifications;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Les spécifications ne peuvent pas être vides.");
                }
                _specifications = value;
            }
        } 
        public string SerialNumber
        {
            get => _serialNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le numéro de série ne peut pas être vide.");
                }
                _serialNumber = value;
            }
        }
        public int Quantite
        {
            get => _quantite;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("La quantité ne peut pas être inférieure à 1.");
                }
                _quantite = value;
            }
        } 

    // Constructeur de la classe fille Equipement
    // Instanciation du constructeur de la classe fille Equipement
        public Equipement(
            string nom, 
            string responsable, 
            StatutRessource statut, 
            string specifications, 
            string serialNumber, 
            int quantite) : base(nom, responsable)
        {
            this.Statut = statut;
            this.Specifications = specifications;
            this.SerialNumber = serialNumber;
            this.Quantite = quantite;
        }

    // Surcharge de la méthode AfficherInfos
        public override void AfficherInfos()
        { 	
            base.AfficherInfos();
            Console.WriteLine ($"=====      Statut : {Statut}.     =====");
		    Console.WriteLine ($"=====      Spécifications : {Specifications}.     =====");
            Console.WriteLine ($"=====      Numéro de série : {SerialNumber}.     =====");
            Console.WriteLine ($"=====      Il y a {Quantite} unité(s) de cet équipement.     =====");
        }

    //Surcharge de la methode EstDisponible
        public override bool EstDisponible()
        {
            return Statut == StatutRessource.Disponible;
        }
    }
}