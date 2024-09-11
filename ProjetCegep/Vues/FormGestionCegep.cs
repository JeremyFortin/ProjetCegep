﻿using System;
using System.Windows.Forms;
using ProjetCegep.Modeles;
using ProjetCegep.Controleurs;
using ProjetCegep.DTOs;

namespace ProjetCegep.Vues
{
   public partial class FormGestionCegep : Form
   {
        
        /// <summary>
        /// Constructeur du formulaire Gestion Cégep
        /// </summary>
        public FormGestionCegep()
        {
            InitializeComponent();
            CegepControleur.Instance.ChargerDonneesFichier();
            RemplirListes();
        }

        /// <summary>
        /// Méthode qui permet d'enregistrer le cégep et les listes dans un fichier XML.  Par la suite, on quitte l'application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CegepControleur.Instance.SauvegarderDonneesFichier();
            Application.Exit();
        }

        /// <summary>
        /// Permet de remplir les différentes listes du formulaire 
        /// </summary>
        public void RemplirListes()
        {
             //lbxDepartement.Items.Clear();
             //lbxDepartementInfoCegep.Items.Clear();
             //cbxDepartementEnseingant.Items.Clear();
             //if (monCegep != null)
             //    foreach (Departement departement in monCegep.ObtenirListeDepartement())
             //    {
             //       lbxDepartement.Items.Add(departement.ToString());
             //       lbxDepartementInfoCegep.Items.Add(departement.ToString());
             //       cbxDepartementEnseingant.Items.Add(departement.ToString());
             //    }
        }

        //Onglet Gestion enseignants...

        /// <summary>
        /// Méthode qui permet de mettre à jour les différentes listes d'enseignants
        /// </summary>
        /// <param name="unDepartement">Le département qui à été sélectionné</param>
        public void AfficherListeEnseignantGestionEnseignant(Departement unDepartement)
        {
            lbxEnseignantsSaisie.Items.Clear();
            foreach (Enseignant enseignant in unDepartement.ObtenirListeEnseignant())
            {
                lbxEnseignantsSaisie.Items.Add(enseignant.NoEmploye + "  " + enseignant.Prenom + " " + enseignant.Nom);
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter un enseignant dans un département qui a été sélectionné dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterEnseignant_Click(object sender, EventArgs e)
        {
            //Departement monDepartement, leDepartementAChercher;

            //leDepartementAChercher = new Departement("", cbxDepartementEnseingant.Text, "");

            //monDepartement = monCegep.ObtenirDepartement(leDepartementAChercher);

            //if (monDepartement != null)
            //{
            //    monDepartement.AjouterEnseignant(new Enseignant(int.Parse(edtNoEmploye.Text), edtPrenomEnseignant.Text, edtNomEnseignant.Text, edtAdresseEnseignant.Text, edtVilleEnseignant.Text, EdtProvinceEnseignant.Text, edtCodePostalEnseignant.Text, edtTelephoneEnseignant.Text, edtCourrielEnseignant.Text, dtpDateEmbaucheEnseignant.Value.ToShortDateString()));

            //    AfficherListeEnseignantGestionEnseignant(monDepartement);
            //}
            //else
            //{
            //    MessageBox.Show("Erreur dans la sélection du département.");
            //}
        }

        /// <summary>
        /// Méthode qui permet d'afficher la liste des enseignants après avoir sélectionner un département dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxDepartementEnseignant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Departement monDepartement, leDepartementAChercher;

            //leDepartementAChercher = new Departement("", cbxDepartementEnseingant.Text, "");

            //monDepartement = monCegep.ObtenirDepartement(leDepartementAChercher);

            //AfficherListeEnseignantGestionEnseignant(monDepartement);
        }


        /// <summary>
        /// Méthode qui permet de modifier un enseignant déjà dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifierEnseignant_Click(object sender, EventArgs e)
        {
            //Departement monDepartement, leDepartementAChercher;
            //Enseignant unEnseignant;

            //leDepartementAChercher = new Departement("", cbxDepartementEnseingant.Text, "");

            //monDepartement = monCegep.ObtenirDepartement(leDepartementAChercher);

            //if (monDepartement != null)
            //{
            //    unEnseignant = monDepartement.ObtenirEnseignant(new Enseignant(int.Parse(edtNoEmploye.Text), edtPrenomEnseignant.Text, edtNomEnseignant.Text, edtAdresseEnseignant.Text, edtVilleEnseignant.Text, EdtProvinceEnseignant.Text, edtCodePostalEnseignant.Text, edtTelephoneEnseignant.Text, edtCourrielEnseignant.Text, dtpDateEmbaucheEnseignant.Value.ToShortDateString()));

            //    unEnseignant.NoEmploye = int.Parse(edtNoEmploye.Text);
            //    unEnseignant.Prenom = edtPrenomEnseignant.Text;
            //    unEnseignant.Adresse = edtAdresseEnseignant.Text;
            //    unEnseignant.Ville = edtVilleEnseignant.Text;
            //    unEnseignant.Province = EdtProvinceEnseignant.Text;
            //    unEnseignant.CodePostal = edtCodePostalEnseignant.Text;
            //    unEnseignant.Telephone = edtTelephoneEnseignant.Text;
            //    unEnseignant.Courriel = edtCourrielEnseignant.Text;
            //    unEnseignant.DateEmbauche = dtpDateEmbaucheEnseignant.Value.ToShortDateString();
            //    unEnseignant.DateArret = dtpDateArretEnseignant.Value.ToShortDateString();

            //    AfficherListeEnseignantGestionEnseignant(monDepartement);
            //}
            //else
            //{
            //    MessageBox.Show("Erreur dans la sélection du département.");
            //}
        }

        /// <summary>
        /// Méthode pour supprimer un enseignant de la liste de sont département
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimerEnseignant_Click(object sender, EventArgs e)
        {
            //Departement monDepartement, leDepartementAChercher;

            //leDepartementAChercher = new Departement("", cbxDepartementEnseingant.Text, "");

            //monDepartement = monCegep.ObtenirDepartement(leDepartementAChercher);

            //if (monDepartement != null)
            //{
            //    monDepartement.EnleverEnseignant(new Enseignant(int.Parse(edtNoEmploye.Text), edtPrenomEnseignant.Text, edtNomEnseignant.Text, edtAdresseEnseignant.Text, edtVilleEnseignant.Text, EdtProvinceEnseignant.Text, edtCodePostalEnseignant.Text, edtTelephoneEnseignant.Text, edtCourrielEnseignant.Text, dtpDateEmbaucheEnseignant.Value.ToShortDateString()));

            //    AfficherListeEnseignantGestionEnseignant(monDepartement);
            //}
            //else
            //{
            //    MessageBox.Show("Erreur dans la sélection du département.");
            //}
        }

        //Onglet Gestion départements

        /// <summary>
        /// Méthode qui permet d'ajouter un départemetn à la liste des départements du cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterDepartement_Click(object sender, EventArgs e)
        {
            //Departement unDepartement;

            //unDepartement = new Departement(edtNoDepartement.Text, edtNomDepartement.Text, edtDescriptionDepartement.Text);

            //if (monCegep.AjouterDepartement(unDepartement))
            //{
            //    RemplirListes();
            //    MessageBox.Show(unDepartement.ToString() + "\na bien été crée.");
            //}
            //else
            //{
            //    MessageBox.Show("Le département existe déjà et n'a pas été crée.");
            //}
            Refresh();
        }

        /// <summary>
        /// Métode qui permet de supprimer un département de la liste des département du cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimerGestionDepartement_Click(object sender, EventArgs e)
        {
            //Departement unDepartement;

            //unDepartement = new Departement(edtNoDepartement.Text, edtNomDepartement.Text, edtDescriptionDepartement.Text);

            //if (monCegep.EnleverDepartement(unDepartement))
            //{
            //    RemplirListes();
            //    MessageBox.Show(unDepartement.ToString() + "\na bien été enlevé.");
            //}
            //else
            //{
            //    MessageBox.Show("Le département entré n'est pas dans la liste et n'a pas pu être enlevé.");
            //}
            Refresh();
        }

        //Onglet Info Cégep

        /// <summary>
        /// Méthode qui permet de créer un cégep avec le constructeur paramétré.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterCegep_Click(object sender, EventArgs e)
        {
            CegepControleur.Instance.CreerCegep(new CegepDTO(edtNomCegep.Text, edtAdresseCegep.Text, edtVilleCegep.Text, edtProvinceCegep.Text, edtCodePostalCegep.Text, edtTelephoneCegep.Text, edtCourrielCegep.Text));
            MessageBox.Show(edtNomCegep.Text + "\n a bien été crée.");
        }

        /// <summary>
        /// Méthode qui permet de modifier les informations du cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifierCegep_Click(object sender, EventArgs e)
        {
            CegepControleur.Instance.ModifierCegep(new CegepDTO(edtNomCegep.Text, edtAdresseCegep.Text, edtVilleCegep.Text, edtProvinceCegep.Text, edtCodePostalCegep.Text, edtTelephoneCegep.Text, edtCourrielCegep.Text));
            MessageBox.Show(edtNomCegep.Text + "\na bien été modifié.");
        }

        /// <summary>
        /// Méthode qui permet de suprimmer l'objet cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimerCegep_Click(object sender, EventArgs e)
        {
            //string nomCegep;
            //nomCegep = monCegep.Nom;

            //monCegep = null;
            //MessageBox.Show(nomCegep + " a bien été supprimé.");
            //RemplirListes();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestionCegep_FormClosing(object sender, FormClosingEventArgs e)
        {
            QuitterToolStripMenuItem_Click(this, null);
        }
    }
}
