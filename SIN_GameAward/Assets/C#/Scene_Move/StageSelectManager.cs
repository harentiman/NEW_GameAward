using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectManager : MonoBehaviour
{
    public int stage_num;   //スコア変数

    //public Button stage1;
    //public Button stage2;
    //public Button stage3;
    //public Button stage4;
    //public Button stage5;
    //public Button stage6;
    //public Button stage7;
    //public Button stage8;
    //public Button stage9;
    //public Button stage10;
    //public Button stage11;
    //public Button stage12;
    //public Button stage13;
    //public Button stage14;
    //public Button stage15;

    public Button[] stage;
   

    // Start is called before the first frame update
    void Start()
    {
        stage_num = PlayerPrefs.GetInt("SCORE", 0);
        //stage_num = 0;

    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<15;i++)
        {
            if (stage_num >= i + 1)
            {
                stage[i + 1].interactable = true;
               
            }
            if (gole.stagenumber >= i + 2)
            {
                stage[i+1].interactable = true;
                PlayerPrefs.SetInt("SCORE", i+2);
                PlayerPrefs.Save();
            }

        }


        //if (stage_num >= 2)
        //{
        //    stage2.interactable = true;
        //}
        //if (stage_num >= 3)
        //{
        //    stage3.interactable = true;
        //}
        //if (stage_num >= 4)
        //{
        //    stage4.interactable = true;

        //}
        //if (stage_num >= 5)
        //{
        //    stage5.interactable = true;

        //}
        //if (stage_num >= 6)
        //{
        //    stage6.interactable = true;

        //}
        //if (stage_num >= 7)
        //{
        //    stage7.interactable = true;

        //}
        //if (stage_num >= 8)
        //{
        //    stage8.interactable = true;

        //}
        //if (stage_num >= 9)
        //{
        //    stage9.interactable = true;
           

        //}
        //if (stage_num >= 10)
        //{
        //    stage10.interactable = true;
            

        //}
        //if (stage_num >= 11)
        //{
        //    stage11.interactable = true;
            
        //}
        //if (stage_num >= 12)
        //{
        //    stage12.interactable = true;
            

        //}
        //if (stage_num >= 13)
        //{
        //    stage13.interactable = true;
            

        //}
        //if (stage_num >= 14)
        //{
        //    stage14.interactable = true;
            

        //}
        //if (stage_num >= 15)
        //{
        //    stage15.interactable = true;
        //}

        //if(gole.stagenumber>=2)
        //{
        //    stage2.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 2);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 3)
        //{
        //    stage3.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 3);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 4)
        //{
        //    stage4.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 4);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 5)
        //{
        //    stage5.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 6);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 6)
        //{
        //    stage6.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 6);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 7)
        //{
        //    stage7.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 7);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 8)
        //{
        //    stage8.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 8);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 9)
        //{
        //    stage9.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 9);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 10)
        //{
        //    stage10.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 10);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 11)
        //{
        //    stage11.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 11);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 12)
        //{
        //    stage12.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 12);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 13)
        //{
        //    stage13.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 13);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 14)
        //{
        //    stage14.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 14);
        //    PlayerPrefs.Save();
        //}
        //if (gole.stagenumber >= 15)
        //{
        //    stage15.interactable = true;
        //    PlayerPrefs.SetInt("SCORE", 15);
        //    PlayerPrefs.Save();
        //}
    }
}

