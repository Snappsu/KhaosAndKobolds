using System;
using System.Collections.Generic;
using System.Text;
class Character
{
    public Character()
    {
        this.name = "Wow";
    }

    private string name;
    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    private Species species = new Species( new string[2] { "null", "null" } );
    public Species getSpecies() {
        return species;
    }
    public void setSpecies(string name, List<Species> speciesList)
    {
        foreach (Species spec in speciesList)
        {
            if (name == spec.getId()) species = spec;

        }
    }
}

class Species
{
    public static List<Species> loadSpecies()
    {
        List<Species> species = new List<Species>();
        string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + "\\data\\species.txt");
        foreach (string line in lines)
        {
            String[] speciesData = line.Split(',');
            Species tempSpecies = new Species(speciesData);
            Console.WriteLine(tempSpecies.stringSummary());
            species.Add(tempSpecies);
        }
        return species;
    }

    public Species(string[] data)
    {
        id = data[0];
        name = data[1];
    }

    private string id;
    public string getId()
    {
        return id;
    }

    private string name;
    public string getName()
    {
        return name;
    }




    string stringSummary() {
        return id + ":" + name;
    }
}
