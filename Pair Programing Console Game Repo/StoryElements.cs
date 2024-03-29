﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StoryElements
    {
        public string RockyOutcrop()
        {
            return "The crows nest sees a rocky outcropping ahead! 'Backtrack or cross the gallows,' crosses your mind. \n" + 
                "However, there might be treasure located among the wreckages of those who dared to tread its waters. Do you continue?";
        }

        public string MysteriousIsland() //Save Point A
        {
            return "A mysterious island arises out of the mist. Its mountain overcasts the jungle below. Charles *squawks* 'Turn back! Turn back!' Do you continue?";
        }

        public string GiantWhirlpool()
        {
            return "A whirlpool the size of three ships lies ahead of the Ruby. Its water is choppy and you the see the remnants of an old Spanish vessel.\n" +
                "Do you risk going after the gold you know is awaiting you?";
        }

        public string Kraken()
        {
            return "Over the horizon you see the waves start to move in a forboding motion.\n" + 
                "A dark shape appears and slowly moves toward the Ruby. Do you continue?";
        }

        public string IslandShipReturn()
        {
            return "You venture into the jungle, and after a day's march you arrive back at your boat. Confused, you wonder if this is all the island has to offer?";
        }

        public string IslandCave()
        {
            return "Gathering your supplies, you and your crew venture to the junge towards the mountain.\n" +
                "Chopping through the dense vegetation, you eventually find the entrance to a long forgotten cave.\n" +
                "Your crew wants to turn around, but Sir-Hooks-Alot wants to press onaward. Do you continue?";
        }

        public string Skeleton()
        {
            return "As you and your crew make your way deeper and deeper into the cave you eventually come across the bones of old sailor.\n" +
                "The sailor appears to have been holding on to some things before he died. Do you want to take a look?\n";
        }

        public string MapAndJournal()
        {
            return "Looking around where the old sailor parished, Sir-Hooks-Alot finds a beat up journel and a fade map. \n" +
            "You quickly yell out to Sir-Hooks-Alot, bring those here ya scally-wag!\n" +
            "You breeze through the journal and throw it to the ground where it becomes covered in dust and sand. \n" +
            "With the map however you quickly recognize the old Spanish markings. In fact many of teh marking were known to you from throughout your travels! \n" +
            "*Sqwak* 'lets go back home! Go back home!' Says Chester. \n" +
            "You crew agree and you all start fleeing from the cave, releived to get off of the island.\n" +
            "Before you exit the cave however you cannot seem to forget about the bones of that old sailor and what he was doing there. Perhaps that was more then meets the eye.\n" +
            "*Sqwak* 'Don't forget the journel, the journel' yells Chester, but you can already see your boat bobbying on the shore. Do you turn back, for what coudl ammount to nothing? Or continue to the safehaven of the Ruby?";
        }

        public string Journal()
        {
            return "You decided to double back with Sir-Hooks-Alot. Together the two of you venture back into the cave to search for the old journal. \n" +
                "After fumbeling around in the dark eventually the two of you find the old leather bound book. With it in hand you and Sir-Hooks-Alot scurry back to the cave enterance. \n" +
                "The daylight seems to illuminate the journal in a way a simple tourch couldn't. Cracking open the jounral you notice text appearing along the edges that was not visible while in the cave. Almost as if the old sailor had tried to keep it hidden. \n" +
                "Flipping through the pages you see the final moments of the old sailer life.\n" +
                "'I have lost track of the both the day and year, on this god forsaken island.'\n" +
                "'Despite the rumors there seems to nothing of note here. Why did I decdied to come to this devil land!'\n" +
                "'The Mermaid she haunts my dreams! Why o why does she haunt me so!'\n" +
                "'I will die soon. I know I will. I have run out of both food and water days ago and the cave collapsed inward. I can only hope to see the sea one more time.'\n" +
                "'That blasted mermaid, hopefully with the sweat release of death I will be able to escape her!'\n" +
                "Comming to you come to the conclusion that these are nothing but the rantings of a mad man. You know from your travels that mermaids are not real.\n" +
                "Besides you havnt come accross anything that has to do with a mermaid on this island. You shake your head and throw the book away for you dont have time for childhood fantasies.\n" +
                "You return to the Ruby and continue your journey. Little do you know Sir-Hooks-Alot retreived the journal after you threw it away, and has been pouring over its contents.";
        }

        public string Ruins() //Save Point B
        {
            return "On the Southern edge of the island there is a old set of Ruins. There have obviously been people here before.\n" +
                "You go an investigate the ruins, and find an ornate courtyard.\n" +
                "Inside the courtyard in every cardinal direction there statues depicating battles of the past.\n" +
                "As you and your crew marvel at the statues, you cannot help and wonder if there something important here.\n";
        }

        public string DenseJungle()
        {
            return "A dense jungle lies ahead. You think you and your crew could probably cut your way through.\n" +
                "However, you also get a gut feeling that something sinister lurks in there. Do you wish to continue?\n";
        }

        public string MermaidStatue()
        {
            return "To the North there is a Mermaid statue, with her hand pointing towards a mostly-intact wall of the ruins. \n" +
                "Aside from the statue's great beauty, there doesn't seem to be much of value over here.\n";
        }

        public string Skull()
        {
            return "On the Southern end of the courtyard directly accross from the mermaid, there lie an ornate skull stature. While the smallest of all teh statues, it is jewel and gold encrusted. Your crew drools with greedy intent, at the emerands in the eye sockets. As you reach towards the skull you cant help but wonder if there is more then meets the eye?";
        }

        public string SnakeTreasure()
        {
            return "The Eastern side of the room is a innately carved Statue of a snake. the staute has been carve in such a way to appear coiled around a chest. You and your crew cannot believe it! There is no way that a treasure would be this each to get! Do you claim the treasure for yourself?";
        }

        public string BeachDoor()
        {
            return "On the west side of the room there is a door that is oddly out of place. It seems to be made of an uninspiring wood, with no carvings. While not as inviting as the three statues, there is a slight breeze comming from behind the door. Inviting you and your crew to enter through it.Do you abandon the statues and continue through the door?";
        }

        public string MermaidDoor() //Save point c
        {
            return "You decide that the statue is worth looking into. Suddenly it hits you! The rambelings of the old sailor, he must have been speaking of this statue! Excitedly you start to examine teh statue, but this angers your crew. They did not read the journel.\n" +
                "Sir-Hooks-Alot, makes the same realization as you. Without warning he pushes the staue over, crashing it into the wall that it point at. \n" +
                "After a thunderous crash, the statue and wall are both gone. Replacing them is a pitch black passageway.\n" +
                "Peering into the pitch black you sense that there is treasure to be had! However where there is treaure there is also danger. Do you continue inward, with your crew in-tow?";
        }

        public string UndergroundTemple ()
        {
            return "As you and you crew venture deep into the passage the air starts to become heavy. Eventually you stumble upon a vast cavern. \n"+
                "Uptop a old alter, in the middle of the cavern, from a civilization that you have never seen or heard of, there is a vast array of gold and jewels!\n"+
                "Flashes of riches and fame danced accross your eyes, and you pervay the gold in front of you.\n"+
                "You shout out to your crew, 'Aye mi harties this is what we have been waiting for! Take all ye can carry and then some! Load up the Ruby and then come back and load some more! Leave nothing behind'\n" +
                "Suddenly Sir-Hooks-Alot, jumps out from behind you and shouts, \n" +
                "'Captain, did you really think that you lead us here on purpose? Aye, mi mate twas I Sir-Hooks-Alot who lead you to your fortune! Not this yellow-belly!\n" +
                "'If it were for me we would have been swallowed by the kracken for met Davy Jones on the rocks!'\n" +
                "'I Sir-Hooks-Alot, challenge ya Captain to a dual to determine who get to lead this mangy lot and take the treasure for themselves!'\n" +
                "Realizing the situation you are in you decdie to accept Sir-Hooks-Alot dual, and draw a weapon.\n" +
                "However, you have to choose which weapon you use. For you only brought a dager, sword, or pistol. Choose wisely for this could be your last adventure!";
                //Need to put a switch case or if / else here
        }

        public string Escape ()
        {
            return "Choosing the pistol was the right choice, as Sir-Hooks-Alot lay dead in front of you. You have now gained the respect and admiration of your crew.\n"+
                "Together with your loyal crew you retreive the treasure and leave the dreaded island.\n" +
                "You set sail, and the adventure continues!";
        }
    }
}
