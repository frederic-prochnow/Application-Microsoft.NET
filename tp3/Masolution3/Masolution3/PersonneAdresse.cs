namespace Masolution3
{
    class PersonneAdresse
    {
        int Identifiant;
        string Adresse1;
        string Adresse2;
        string Adresse3;
        string Adresse4;
        string CodePostal;
        string Ville;

        public PersonneAdresse(int Identifiant,string Adresse1,string Adresse2,string Adresse3,string Adresse4,string CodePostal,string Ville)
        {
            this.Identifiant = Identifiant;
            this.Adresse1 = Adresse1;
            this.Adresse2 = Adresse2;
            this.Adresse3 = Adresse3;
            this.Adresse4 = Adresse4;
            this.CodePostal = CodePostal;
            this.Ville = Ville;
        }
    }
}