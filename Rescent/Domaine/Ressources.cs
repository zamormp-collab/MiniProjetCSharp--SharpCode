using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescent.Domaine
{
    public abstract class Ressources
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
                    switch (_statut)
                    {
                        case StatutRessource.EnReparation:
                            _statut = value;
                            break;
                        case StatutRessource.Reservee:
                            _statut = value;
                            break;
                        case StatutRessource.Occupee:
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

        // Implementation d'une methode concrete AfficherInfos --- IGNORE ---
        public virtual void AfficherInfos(string nom, string responsable, StatutRessource statut)
        { 	
		Console.WriteLine ($"=====      Nom de la ressource : {nom.ToUpper()}.     =====\n=====      Nom du responsable : {responsable}.     =====\n=====      Statut de la ressource : {statut}.     =====");
	    }
    }
}