using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class World : MonoBehaviour {
    public Text coinsText;
    public Text GGtext;

    public void AddCoin()
    {
        GameVaraibles.coins++;
        coinsText.text = "Coins : "+ GameVaraibles.coins;
        if (GameVaraibles.coins == GameVaraibles.coinsGoal)
        {
            GGtext.text = "Vous avez trouvé toutes les pièces! Vous puvez vous téléporter avec la tente";
        }
    }

    public void RemoveCoin()
    {
        GameVaraibles.coins--;
        coinsText.text = "Coins : " + GameVaraibles.coins;
        if (GameVaraibles.coins < GameVaraibles.coinsGoal)
        {
            GGtext.text = "";
        }
    }

}
