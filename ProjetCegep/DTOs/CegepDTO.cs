
using ProjetCegep.Modeles;

namespace ProjetCegep.DTOs
{
    public class CegepDTO
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Province { get; set; }
        public string CodePostal { get; set; }
        public string Telephone { get; set; }
        public string Courriel { get; set; }

        public CegepDTO(Cegep cegep)
        {
            Nom = cegep.Nom;
            Adresse = cegep.Adresse;
            Ville = cegep.Ville;
            Province = cegep.Province;
            CodePostal = cegep.CodePostal;
            Telephone = cegep.Telephone;
            Courriel = cegep.Courriel;
        }

        public CegepDTO(string unNom = "", string uneAdresse = "", string uneVille = "", string uneProvince = "", string unCodePostal = "", string unTelephone = "", string unCourriel = "")
        {
            Nom = unNom;
            Adresse = uneAdresse;
            Ville = uneVille;
            Province = uneProvince;
            CodePostal = unCodePostal;
            Telephone = unTelephone;
            Courriel = unCourriel;
        }
    }
}
