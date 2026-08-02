using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum ResultState
{
    Kazandınız,Beraberlik, Kaybettiniz
}
public class BattleArenaController :MonoBehaviour
{


    [SerializeField] private Image EnemyImage;
    [SerializeField] private Image PlayerImage;
    [SerializeField] private TextMeshProUGUI Text;

    public void Populate(Sprite Enemy, Sprite Player, ResultState state)
    {
        gameObject.SetActive(true);
        PlayerImage.sprite = Player; 
        EnemyImage.sprite = Enemy;
        
        Text.SetText(state.ToString());
    }

}


