using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rescent.Domaine.Enums;

namespace Rescent.Domaine.Entites
{
    public abstract class Ressource
    {
    // Declaration des attributs de la classe abstraite Ressources
        private string _nom;
        private string _responsable;
        private StatutRessource _statut;

    // Definition des proprietes de la classe Ressources
        // La propriété Nom avec validation
        public string Nom 
        {
            get => _nom; 
                protected set
                {
                    if (value.Length < 3 || value.Length > 30 || value.All(c => char.IsDigit(c)) || char.IsWhiteSpace(value[0]))
                    {   
                        throw new ArgumentException("Le nom ne peut être composé de chiffre ou d'espace seulement.\nIl ne peut pas non plus être inférieur à 3 caractères ou supérieur à 30 caractère.");
                    }
                    _nom = value;
                }
        }
        // La propriété Responsable avec validation
        public string Responsable
        {  
            get => _responsable;    
                protected set
                {
                    if (value.Length < 3 || value.Length > 30 || value.All(c => char.IsDigit(c)) || char.IsWhiteSpace(value[0]))
                    {   
                        throw new ArgumentException("Le nom ne peut pas être composé de chiffre ou d'espace seulement.\nIl ne peut pas non plus être inférieur à 3 caractères ou supérieur à 30 caractère.");
                    }
                    _responsable = value;
                }
        }
        // La propriété Statut avec validation
        public StatutRessource Statut
        {  
            get => _statut; 
                protected set
                {
                    switch (value)
                    {
                        case StatutRessource.EnReparation:
                            _statut = value;
                            break;
                        case StatutRessource.Reserve:
                            _statut = value;
                            break;
                        case StatutRessource.Occupe:
                            _statut = value;
                            break;
                        case StatutRessource.Disponible:
                            _statut = value;
                            break;
                        default:
                            throw new ArgumentException("Statut de ressource invalide.");
                    }
                }
                
        }

    protected Ressource(string nom, string responsable)
        {
            Nom = nom;
            Responsable = responsable;
            Statut = StatutRessource.Disponible;
        }

        //Declaration d'une méthode abstraite EstDisponible --- IGNORE ---
        public abstract bool EstDisponible();
        
        // Implementation d'une methode concrète AfficherInfos --- IGNORE ---
        public virtual void AfficherInfos()
        { 	
		Console.WriteLine ($"=====      Ressource : {Nom.ToUpper()}.     =====");
		Console.WriteLine ($"=====      Nom responsable : {Responsable}.     =====");
	    }
    }
}