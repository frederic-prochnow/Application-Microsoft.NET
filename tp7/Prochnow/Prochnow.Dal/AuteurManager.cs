using Prochnow.Dal;
using System;

public class AuteurManager
{
    public List<Auteur> GetAuteurs()
    {
        WebApplicationEntities entities = new WebApplicationEntities();
        entities.Auteur.t 
        /*SqlConnection sqlConnection1 = new SqlConnection("Ma connection");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = "SELECT * FROM Auteur";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = sqlConnection1;

        sqlConnection1.Open();

        reader = cmd.ExecuteReader();

        sqlConnection1.close();*/
        AdventureWorksEntities context = new AdventureWorksEntities();
        IQueryable<Auteur> auteurQuery = from Auteur in context.Auteur select Auteur;
        Console.WriteLine("Auteur valeurs :");
        foreach (var auteur in auteurQuery)
        {
            Console.WriteLine(auteur.AuteurId + "<>" + auteur.NomAuteur + "<>" +
                auteur.Nom + "<>" + auteur.Prenom);
        }

    }

    public Auteur GetAuteur(long id)
    {

    }

    public void AddAuteur(Auteur auteur)
    {

    } 

    public void DeleteAuteur(long id)
    {

    }
}
