using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public TMP_Text textTacadas;
    public TMP_Text textPar;
    public int tacadas;
    public int par;
    private int recorde;

    // Start is called before the first frame update
    void Start()
    {
        if (gm == null)
            gm = this.gameObject.GetComponent<GameManager>();

        tacadas = 0;
        //textTacadas.text = "Tacadas: 0";
        //textPar.text = "Par: " + par;
    }

    public void fimPartida()
    {
        Debug.Log("OI");
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
