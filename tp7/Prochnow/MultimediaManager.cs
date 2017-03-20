using System;

public class MultimediaManager
{
    public List<Multimedia> GetMultimedia()
    {
        AdventureWorksEntities context = new AdventureWorksEntities();
        IQueryable<MultimediaManager> multimediaQuery = from Multimedia in context.Multimedia select Multimedia;
        Console.WriteLine("Multimedia valeurs :");
        foreach(var multi in multimediaQuery)
        {
            Console.WriteLine(multi.MultimediaId + "<>"+multi.AuteurId + "<>" +
                multi.Titre + "<>"+ multi.Type);
        }
    }

    public Multimedia GetMultimedia(long id)
    {

    }

    public void AddMultimedia(Multimedia multimedia)
    {

    }

    public void DeleteMultimedia(long id)
    {

    }
}
