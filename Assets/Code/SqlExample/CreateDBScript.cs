using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateDBScript : MonoBehaviour
{
    public Text DebugText;

    // Use this for initialization
    void Start()
    {
        var ds = new DataService("tempDatabase.db");
        ds.CreateDB();

        ds.ActualizaPrimerNombre("Pepe");

        var personas = ds.TodasLasPersonas();
        ToConsole(personas);

        var nombre = ds.NombreDelPrimero();
        ToConsole(nombre);

        // var people = ds.GetPersons();
        // ToConsole(people);

        // people = ds.GetPersonsNamedRoberto();
        // ToConsole("Searching for Roberto ...");
        // ToConsole(people);
    }

    private void ToConsole(IEnumerable<Person> people)
    {
        foreach (var person in people)
        {
            ToConsole(person.ToString());
        }
    }

    private void ToConsole(string msg)
    {
        DebugText.text += System.Environment.NewLine + msg;
        Debug.Log(msg);
    }
}
