using UnityEngine;

namespace EdkoCorpLD40.Managers 
{
    public class LevelManager : MonoBehaviour 
    {
        public float trainSpeed = 120f;
        public int trainHp = 1000;
        public int score = 0;

        private int currentLvl = 1;
        private int nbSpawners;

        public Transform boardHolder { get; private set; }

        private GameObject player;

        public void Init()
        {
            LevelSetup();
            
            player = GameObject.FindGameObjectWithTag("Player");
            boardHolder = player.transform.parent;
            CameraManager.instance.Follow(player);
        }

        public void OnSpawnerDestroyed()
        {
            nbSpawners--;
            if(nbSpawners == 0) {
                currentLvl++;
                GameManager.instance.OnLevelClear();
            }
        }

        private void LevelSetup()
        {
            // TODO : stuff
            // nbSpawners = currentLvl;

        }

        
    }
}