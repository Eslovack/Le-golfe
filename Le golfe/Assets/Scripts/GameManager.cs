using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public Text textTacadas;
    public Text textPar;
    public int tacadas;
    public int par;
    private int recorde;

    // Start is called before the first frame update
    void Start()
    {
        if (gm == null)
            gm = this.gameObject.GetComponent<GameManager>();

        tacadas = 0;
        textTacadas.text = "Tacadas: 0";
        textPar.text = "Par: " + par;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tacada()
    {
        Debug.Log("tacada++");
        tacadas++;
        textTacadas.text = "Tacadas: "+tacadas;
    }

}
