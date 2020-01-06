
using wovencode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateLoader : MonoBehaviour
{
	
	/*
	
		This is just a example to demonstrate how template loading and caching works
		
		In a real project you do not require the TemplateLoader, as the templates are
		simply loaded into memory the first time they are accessed.
	
		Add this script to a GameObject in your scene and hit Play, then take a look
		at the log.
		
	*/
	
	public string templateNameItem 	= "ExampleItem";
	public string templateNameSpell = "ExampleSpell";
	
    void Awake()
    {
    	LoadItems();
    	LoadSpells();
    	
    }

	void LoadSpells()
	{
	
		Debug.Log("----- LOAD SPELLS -----");
		Debug.Log("Trying to load all SpellTemplates by accessing one by name...");
    	
    	SpellTemplate.data.TryGetValue(templateNameSpell.GetDeterministicHashCode(), out SpellTemplate template);
    	
        if (template)
        	Debug.Log("The SpellTemplate '"+template.title+"' was found in the 'SpellTemplates' Dictionary");
        else
        	Debug.Log("No SpellTemplate named '"+templateNameSpell+"' was found!");
        
        Debug.Log("A total of '"+SpellTemplate.data.Count+"' templates have been cached from '"+SpellTemplate._folderName+"' into the Dictionary.");
	}
	
	
	void LoadItems()
	{
	
		Debug.Log("----- LOAD ITEMS -----");
		Debug.Log("Trying to load all ItemTemplates by accessing one by name...");
    	
    	ItemTemplate.data.TryGetValue(templateNameItem.GetDeterministicHashCode(), out ItemTemplate template);
    	
        if (template)
        	Debug.Log("The ItemTemplate '"+template.title+"' was found in the 'ItemTemplates' Dictionary");
        else
        	Debug.Log("No ItemTemplate named '"+templateNameItem+"' was found!");
        
        Debug.Log("A total of '"+ItemTemplate.data.Count+"' templates have been cached from '"+ItemTemplate._folderName+"' into the Dictionary.");
	}

}
