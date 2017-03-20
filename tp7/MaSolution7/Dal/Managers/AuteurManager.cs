using Dal;
using System;
using System.Collections.Generic;
using System.Linq;

public class AuteurManager
{
    MultimediaEntities entities = new Dal.MultimediaEntities();
    public List<Auteur> GetAuteurs()
    {
        return entities.Auteur.ToList();
    }

    public Auteur GetAuteur(long id)
    {
        return entities.Auteur.Find(id);
    }

    public void AddAuteur(Auteur auteur)
    {
        entities.Auteur.Add(auteur);
    } 

    public void DeleteAuteur(long id)
    {
        entities.Auteur.Remove(GetAuteur(id));
    }
}
