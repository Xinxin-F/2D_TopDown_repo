using System.IO;
using UnityEngine;

public static class SaveSystem
{
    public static readonly string SAVE_FOLDER = Application.persistentDataPath + "/saves";
    public static readonly string FILE_EXT = ".json";

    public static void Initialise(){
        if(!Directory.Exists(SAVE_FOLDER)){
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }

    public static void Save(string filename, string data){
        // File.WriteAllText(SAVE_FOLDER + filename + FILE_EXT, data);

        //File.WriteAllText(SAVE_FOLDER + "/" + filename + FILE_EXT, data);

        // Debug.Log("Saved");
        // Debug.Log("Saving to: " + fullPath);
        // File.WriteAllText(fullPath, data);
        // Debug.Log("Saved");

        string fullPath = SAVE_FOLDER + "/" + filename + FILE_EXT;
        Debug.Log("Saving to: " + fullPath);
        File.WriteAllText(fullPath, data);
        Debug.Log("Saved");
    }

    public static string Load (string filename){
        //string fileLocation = SAVE_FOLDER + filename + FILE_EXT;
        //  string fileLocation = SAVE_FOLDER + "/" + filename + FILE_EXT;
        // if(File.Exists(fileLocation)){
        //     string loadedData = File.ReadAllText(fileLocation);
        //     Debug.Log("Loaded");
        //     return loadedData;
            
        // }
        // else{
        //     return null;
        // }
        
        string fileLocation = SAVE_FOLDER + "/" + filename + FILE_EXT;
          if(File.Exists(fileLocation)){
            string loadedData = File.ReadAllText(fileLocation);
            Debug.Log("Loaded from: " + fileLocation);
            return loadedData;
        }
        else{
            Debug.Log("No file to load from at: " + fileLocation);
            return null;
        }
    }
}
