public class LevelSelectionDB
{
    private static LevelSelectionDB instance;

    private LevelSelectionDB(){

    }

    public static LevelSelectionDB GetInstance(){
        if (instance == null) {  
            instance = new LevelSelectionDB();  
        }  

        return instance;  
    }


    private int levelUnlocked = 1;

    public int LevelUnlocked{
        get{
            return levelUnlocked;
        }
    }

    public void LevelUnlockIncrease(){
        levelUnlocked++;
    }

}
