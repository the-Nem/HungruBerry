using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class BornCandies : MonoBehaviour
    {
        public List<GameObject> Feed = new List<GameObject>();

        [SerializeField] private GameObject Bone;
        [SerializeField] private GameObject Chili;
        [SerializeField] private GameObject Burger;
        [SerializeField] private GameObject Candy;
        [SerializeField] private GameObject Coocke;
        [SerializeField] private GameObject Meat;


        public int RandomCandy;

        public int burgerStatus;
        public int CandyStatus;
        public int CoockeStatus;
        public int MeatStatus;
       // private int LifeStatus;




        public static BornCandies instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
            CheckForFood();
        }

        // Start is called before the first frame update
        void Start()
        {
            AssingObjToArray();





        }
        private void Update()
        {
            Debug.Log("burgerStatus = " + burgerStatus);
            Debug.Log("CandyStatus = " + CandyStatus);
            Debug.Log("CoockeStatus = " + CoockeStatus);
            Debug.Log("MeatStatus = " + MeatStatus);

            if (Input.GetKeyDown(KeyCode.O)) { CandyStatus++; }
        }

        private void AssingObjToArray()
        {
            Feed.Add(Bone);
            Feed.Add(Chili);
            Feed.Add(Bone);
        }
        public void AddBurgr()
        {
            //Feed.Add(Burger);
            //Feed.Add(Bone);
            //Debug.Log("in button burgerStatus = " + burgerStatus);
            burgerStatus++;
            //Debug.Log("in butt after ++ burgerStatus = " + burgerStatus);
            CollectValues.instance.GetData();
            CollectValues.instance.SavePlayerData();
        }


        public void AddCandy()
        {
            //Feed.Add(Candy);
            //Feed.Add(Bone);
            CandyStatus++;

            CollectValues.instance.GetData();
            CollectValues.instance.SavePlayerData();
        }


        public void AddCoocke()
        {
            //Feed.Add(Coocke);
            //Feed.Add(Bone);
            Debug.Log("in button CoockeStatus = " + CoockeStatus);

            CoockeStatus++;
            Debug.Log("in butt after ++ CoockeStatus = " + CoockeStatus);

            CollectValues.instance.GetData();
            CollectValues.instance.SavePlayerData();
        }


        public void AddMeat()
        {
            //Feed.Add(Meat);
            //Feed.Add(Bone);
            MeatStatus++;
            CollectValues.instance.GetData();
            CollectValues.instance.SavePlayerData();
        }
        public void CheckForFood()
        {
            if (burgerStatus >0)
            {
                Feed.Add(Burger);
                Feed.Add(Bone);
            }
            if (CandyStatus > 0)
            {
                Feed.Add(Candy);
                Feed.Add(Bone);
            }
            if (CoockeStatus > 0)
            {
                Feed.Add(Coocke);
                Feed.Add(Bone);
            }
            if (MeatStatus > 0)
            {
                Feed.Add(Meat);
                Feed.Add(Bone);
            }
        }
    }
}
