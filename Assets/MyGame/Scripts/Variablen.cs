using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    public GameObject x;
    Color farbe;
    int anzTuerenInstanz = 4;
    bool fahren;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(
            Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + "" +
            Himmelsrichtungen.West + " " + Himmelsrichtungen.Ost);

        //
        farbe = Color.red;
        Debug.Log("Red " + farbe.ToString());

        farbe = Color.yellow;
        Debug.Log("Yellow " +farbe.ToString());

        farbe = Color.white;
        Debug.Log("White " + farbe.ToString());

        Debug.Log(x.ToString());
        Debug.Log(anzTuerenInstanz.ToString());//nimm instanz
        Debug.Log("bool fahren " + fahren.ToString());

        //Lokal schlägt Instanz
        int anzTueren = int.Parse("4");
        float anzTuerenf = float.Parse("4");

        anzTueren = int.Parse("eins");


        Debug.Log(anzTueren + " " + anzTuerenf + " " + anzTuerenInstanz);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World");   
    }
}
