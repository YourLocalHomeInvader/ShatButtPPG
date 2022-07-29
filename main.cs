using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

namespace Shit
{
        public class Shit
    {

        public static void Main()
        {

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"), 
                    NameOverride = "<color=blue> Shit Ass (Robot Flesh)", 
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "<color=blue> Oh No", 
                    CategoryOverride = ModAPI.FindCategory("<color=green> Dream"),
                    ThumbnailOverride = ModAPI.LoadSprite("sprites/shitR.png"), 
                    AfterSpawn = (Instance) => 
                    {
                        var skin = ModAPI.LoadTexture("sprites/skin.png");
                        var flesh = ModAPI.LoadTexture("sprites/flesh.png");
                        var bone = ModAPI.LoadTexture("sprites/bone.png");

                        var person = Instance.GetComponent<PersonBehaviour>();

                        person.SetBodyTextures(skin, flesh, bone, 1);

						
                    }
                }
            );
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"), 
                    NameOverride = "<color=blue> Shit Ass (Human Flesh)", 
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "<color=blue> Oh No", 
                    CategoryOverride = ModAPI.FindCategory("<color=green> Dream"),
                    ThumbnailOverride = ModAPI.LoadSprite("sprites/shitH.png"), 
                    AfterSpawn = (Instance) => 
                    {
                        var skin = ModAPI.LoadTexture("sprites/skin.png");
                        var flesh = ModAPI.LoadTexture("sprites/flesh2.png");
                        var bone = ModAPI.LoadTexture("sprites/bone.png");

                        var person = Instance.GetComponent<PersonBehaviour>();

                        person.SetBodyTextures(skin, flesh, bone, 1);
                    }
                }
            );

     }
    }
}
