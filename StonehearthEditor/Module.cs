﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace StonehearthEditor
{
   public class Module
   {
      private string mPath;
      private string mName;
      private JObject mManifestJson;
      private Dictionary<String, ModuleFile> mAliases = new Dictionary<String, ModuleFile>();
      private JObject mEnglishLocalizationJson;
      public Module(string modPath)
      {
         mPath = modPath;
         mName = modPath.Substring(modPath.LastIndexOf('/') + 1);
      }
      public ICollection<String> GetAliasNames()
      {
         return mAliases.Keys;
      }
      public ICollection<ModuleFile> GetAliases()
      {
         return mAliases.Values;
      }
      public String Name
      {
         get { return mName; }
      }
      public String Path
      {
         get { return mPath; }
      }

      public JObject EnglishLocalizationJson
      {
         get { return mEnglishLocalizationJson; }
      }
      public void InitializeFromManifest()
      {
         string stonehearthModManifest = Path + "/manifest.json";

         if (System.IO.File.Exists(stonehearthModManifest))
         {
            using (StreamReader sr = new StreamReader(stonehearthModManifest, Encoding.UTF8))
            {
               string fileString = sr.ReadToEnd();
               mManifestJson = JObject.Parse(fileString);
               
               JToken aliases = mManifestJson["aliases"];
               if (aliases != null)
               {
                  foreach (JToken item in aliases.Children())
                  {
                     JProperty alias = item as JProperty;
                     string name = alias.Name.Trim();
                     string value = alias.Value.ToString().Trim();

                     ModuleFile moduleFile = new ModuleFile(this, name, value);
                     mAliases.Add(name, moduleFile);
                  }
               }
            }
         }

         string englishLocalizationFilePath = Path + "/locales/en.json";
         if (System.IO.File.Exists(englishLocalizationFilePath))
         {
            using (StreamReader sr = new StreamReader(englishLocalizationFilePath, Encoding.UTF8))
            {
               string fileString = sr.ReadToEnd();
               mEnglishLocalizationJson = JObject.Parse(fileString);
            }
         }
      }
      public void LoadFiles()
      {
         foreach (ModuleFile moduleFile in mAliases.Values) { 
            moduleFile.TryLoad();
         }
      }
      public ModuleFile GetAliasFile(string alias)
      {
         ModuleFile returned = null;
         mAliases.TryGetValue(alias, out returned);
         return returned;
      }
      public void WriteToManifestJson(string alias, string path)
      {
         JToken aliases = mManifestJson["aliases"];
         if (aliases == null)
         {
            mManifestJson.Add("aliases", null);
            aliases = mManifestJson["aliases"];
         }
         (aliases as JObject).Add(alias, path);
         string manifestPath = Path + "/manifest.json";
         using (StreamWriter wr = new StreamWriter(manifestPath, false, new UTF8Encoding(false)))
         {
            using (JsonTextWriter jsonTextWriter = new JsonTextWriter(wr))
            {
               jsonTextWriter.Formatting = Newtonsoft.Json.Formatting.Indented;
               jsonTextWriter.Indentation = 3;
               jsonTextWriter.IndentChar = ' ';

               JsonSerializer jsonSeralizer = new JsonSerializer();
               jsonSeralizer.Serialize(jsonTextWriter, mManifestJson);
            }
         }
      }
   }
}
