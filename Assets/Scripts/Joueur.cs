using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Joueur : MonoBehaviour
{
    //Time.deltaTime
    public GameObject prefabBullet;
    public int Score;
    public int Plus;
    public int Valeur;
    public int Valeur2;
    public int Valeur3;
    public int Valeur4;
    public TextMeshProUGUI Prix;
    public int Prixe;
    public Joueur monJoueur;
    public TextMeshProUGUI monUI;
    public TextMeshProUGUI nombreUI1;
    public TextMeshProUGUI nombreUI2;
    public TextMeshProUGUI nombreUI3;
    public TextMeshProUGUI nombreUI4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject jeViensDeNaitre = Instantiate(prefabBullet, transform.position, transform.rotation);
            jeViensDeNaitre.GetComponent<Bullet1>().monCreateur = this;
        }
    }

    public void Victoire()
    {
        if (Score >= 20000)
        {
            Debug.Log("félicitations tu as gagné :)");
        }
    }
    public void ChangeValeur()
    {

        if (Score >= 1000)
            if (Plus == 0)
            {
                AugmenteScore(-1000);
                Plus =+ 1;
                Prixe = 2000;
                Prix.text = Prixe.ToString();
            }
        if (Score >= 2000)
            if (Plus == 1)
            {
                AugmenteScore(-2000);
                Plus = 2;
                Prixe = 4000;
                Prix.text = Prixe.ToString();
            }
        if (Score >= 4000)
            if (Plus == 2)
            {
                AugmenteScore(-4000);
                Plus = 3;
                Prixe = 7000;
                Prix.text = Prixe.ToString();
            }
        if (Score >= 7000)
            if (Plus == 3)
            {
                AugmenteScore(-7000);
                Plus = 4;
                Prixe = 0000;
                Prix.text = Prixe.ToString();
            }

    }

    public void AugmenteScore(int monchiffreamoi)
    {
        Score+=monchiffreamoi;
        monUI.text = Score.ToString("0000");
        if (monchiffreamoi == 1)
        {
            Valeur += 1;
            nombreUI1.text = Valeur.ToString();
        }
        if (monchiffreamoi == 100)
        {
            Valeur2 += 1;
            nombreUI2.text = Valeur2.ToString();
        }
        if (monchiffreamoi == 500)
        {
            Valeur3 += 1;
            nombreUI3.text = Valeur3.ToString();
        }
        if (monchiffreamoi == 2500)
        {
            Valeur4 += 1;
            nombreUI4.text = Valeur4.ToString();
        }
    }
}
