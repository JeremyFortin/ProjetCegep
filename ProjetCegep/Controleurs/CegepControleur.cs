using ProjetCegep.DTOs;
using ProjetCegep.Modeles;
using System.IO;
using System.Xml.Serialization;

namespace ProjetCegep.Controleurs
{
    public class CegepControleur
    {
        private static CegepControleur instance;

        private Cegep monCegep;  //Objet Cégep qui comprend la structure complète d'un cégep...

        public static CegepControleur Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new CegepControleur();
                }
                return instance;
            }
        }

        private CegepControleur()
        {

        }

        public bool CreerCegep(CegepDTO cegep)
        {
            monCegep = new Cegep(cegep.Nom, cegep.Adresse, cegep.Ville, cegep.Province, cegep.CodePostal, cegep.Telephone, cegep.Courriel);
            return monCegep != null;
        }

        public bool ModifierCegep(CegepDTO cegep)
        {
            monCegep.Nom = cegep.Nom;
            monCegep.Adresse = cegep.Adresse;
            monCegep.Ville = cegep.Ville;
            monCegep.Province = cegep.Province;
            monCegep.CodePostal = cegep.CodePostal;
            monCegep.Telephone = cegep.Telephone;
            monCegep.Courriel = cegep.Courriel;
            return true;
        }

        public void ChargerDonneesFichier()
        {
            if (File.Exists("Cegep.xml"))
            {
                XmlSerializer leFichierCegep = new XmlSerializer(typeof(Cegep));
                FileStream fichierLogique;

                fichierLogique = File.OpenRead("Cegep.xml");
                monCegep = (Cegep)leFichierCegep.Deserialize(fichierLogique);
                fichierLogique.Close();
            }
        }

        public void SauvegarderDonneesFichier()
        {
            if (File.Exists("Cegep.xml"))
            {
                File.Delete("Cegep.xml");
            }
            XmlSerializer leFichierCegep = new XmlSerializer(typeof(Cegep));
            FileStream fichierLogique;

            using (fichierLogique = File.OpenWrite("Cegep.xml"))
            {
                leFichierCegep.Serialize(fichierLogique, monCegep);
            }
        }
    }
}
