using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class CommandeDeDocument
    {
        public string id { get; }
        public string idDocument { get; }
        public Document document { get; }
        public string titreDocument { get { return document.Titre; } }
        public string quantite { get; }
        public string montant { get; }
        public string dateCommande { get; }
        public string idEtape { get; }
        public string etape { get; }

        public CommandeDeDocument(string id, string idDocument, Document document, string quantite, string montant, string dateCommande, string idEtape, string etape)
        {
            this.id = id;
            this.idDocument = idDocument;
            this.document = document;
            this.quantite = quantite;
            this.montant = montant;
            this.dateCommande = dateCommande;
            this.idEtape = idEtape;
            this.etape = etape;
        }

        private string[] etapes = {"en cours", "livree", "reglee", "relancee"};

        //constructeur allégé (sans id, sans date, sans etape
        public CommandeDeDocument(string idDocument, Document document, string quantite, string montant, string idEtape)
        {
            this.idDocument = idDocument;
            this.document = document;
            this.quantite = quantite;
            this.montant = montant;
            this.dateCommande = (DateTime.Today).ToString();
            this.idEtape = idEtape;
            this.etape = etapes[int.Parse(idEtape)];
        }
    }
}