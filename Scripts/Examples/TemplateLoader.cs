
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
		Debug.Log("Trying to load all BarTemplates by accessing one by name...");
    	
    	BarTemplate.data.TryGetValue(templateNameSpell.GetDeterministicHashCode(), out BarTemplate template);
    	
        if (template)
        	Debug.Log("The BarTemplate '"+template.title+"' was found in the 'BarTemplates' Dictionary");
        else
        	Debug.Log("No BarTemplate named '"+templateNameSpell+"' was found!");
        
        Debug.Log("A total of '"+BarTemplate.data.Count+"' templates have been cached from '"+BarTemplate._folderName+"' into the Dictionary.");
	}
	
	
	void LoadItems()
	{
	
		Debug.Log("----- LOAD ITEMS -----");
		Debug.Log("Trying to load all FooTemplates by accessing one by name...");
    	
    	FooTemplate.data.TryGetValue(templateNameItem.GetDeterministicHashCode(), out FooTemplate template);
    	
        if (template)
        	Debug.Log("The FooTemplate '"+template.title+"' was found in the 'FooTemplates' Dictionary");
        else
        	Debug.Log("No FooTemplate named '"+templateNameItem+"' was found!");
        
        Debug.Log("A total of '"+FooTemplate.data.Count+"' templates have been cached from '"+FooTemplate._folderName+"' into the Dictionary.");
	}

}
