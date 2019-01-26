using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spirit : MonoBehaviour
{
    public enum SpiritState
    {
        None = -1,
        Dead = 1,
        Angry = 2,
        Normal = 3,
        Good = 4
    }
    public enum SpiritType
    {
        None = -1,
        Water = 1,
        Fire = 2,
        Earth = 3,
        Air = 4
    }


    public SpiritType _type;
    public SpiritState _state;
    public float _fillness;
    [SerializeField] private Image HealthBar;
    [SerializeField] private Image smile;
    [SerializeField] private List<Sprite> smileList;

    public Spirit(SpiritType type = SpiritType.None, float fillness = 0)
    {
        _type = type;
        _fillness = fillness;
    }

    public void SetFillness(float newFillness)
    {
        LeanTween.value(gameObject, _fillness, newFillness, SpiritController.FILLNESS_SPEED)
            .setOnUpdate((float val) => {
                HealthBar.fillAmount = val; 
            })
          .setOnComplete(() =>
          {
              //CheckState(); // Set Smile
          });
    }

    //private void CheckState()
    //{
    //    if (_fillness < 1)
    //    {
    //        _state = SpiritState.Dead;
    //        if (smileList[3] != null)
    //            smile.sprite = smileList[0];
    //        else
    //            smile.color = Color.black;
    //    }
    //    if (_fillness < 25)
    //    {
    //        _state = SpiritState.Angry;
    //        //if (smileList[3] != null)
    //        //    smile.sprite = smileList[1];
    //        //else
    //        //    smile.color = Color.red;
    //    }
    //    if (_fillness < 50)
    //    {
    //        _state = SpiritState.Normal;
    //        //if (smileList[3] != null)
    //        //    smile.sprite = smileList[2];
    //        //else
    //        //    smile.color = Color.yellow;

    //    }
    //    else
    //    {
    //        _state = SpiritState.Good;
    //        //if (smileList[3] != null)
    //        //    smile.sprite = smileList[3];
    //        //else
    //        //    smile.color = Color.green;
    //    }
    //}
}
