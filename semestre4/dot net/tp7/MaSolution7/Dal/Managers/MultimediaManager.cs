using Dal;
using System;
using System.Collections.Generic;
using System.Linq;

public class MultimediaManager
{
    MultimediaEntities entities = new Dal.MultimediaEntities();
    public List<Multimedia> GetMultimedia()
    {
        return entities.Multimedia.ToList();
    }

    public Multimedia GetMultimedia(long id)
    {
        return entities.Multimedia.Find(id);
    }

    public void AddMultimedia(Multimedia multimedia)
    {
        entities.Multimedia.Add(multimedia);
    }

    public void DeleteMultimedia(long id)
    {
        entities.Multimedia.Remove(GetMultimedia(id));
    }
}
