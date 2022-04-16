using UnityEngine;

public class KiraCatHax : Mod
{
    public void Start()
    {
        Debug.Log("Mod KiraCatHax has been loaded!");


    }

    [ConsoleCommand(name: "kira_giveMedKit", docs: "Gives you a medical kit to treat all ailments")]
    public static void GiveMedKit()
    {
        for (int i = 0; i < 2; i++)
        {
            Player.Get().AddItemToInventory("Honey_Dressing");
            Player.Get().AddItemToInventory("Tabaco_Dressing");
        }

        for (int i = 0; i < 4; i++)
        {
            Player.Get().AddItemToInventory("Fish_Bone");
        }

        Player.Get().AddItemToInventory("Painkillers");
        Player.Get().AddItemToInventory("Maggots");

        // Mushrooms
        for (int i = 0; i < 3; i++)
        {
            Player.Get().AddItemToInventory("Leaf_Bandage");
            Player.Get().AddItemToInventory("Charcoal");
            Player.Get().AddItemToInventory("indigo_blue_leptonia");
            Player.Get().AddItemToInventory("Gerronema_viridilucens");
            Player.Get().AddItemToInventory("Gerronema_retiarium");
            Player.Get().AddItemToInventory("copa_hongo");
            Player.Get().AddItemToInventory("marasmius_haematocephalus");
        }
    }

    [ConsoleCommand(name: "kira_unlockNotepad", docs: "Unlocks everything in the notepad")]
    public static void UnlockNotepad()
    {
        ItemsManager.Get().UnlockAllItemsInNotepad();
    }

    [ConsoleCommand(name: "kira_unlockAllInfo", docs: "Gives names to things that are unknown and shows their properties before picking up")]
    public static void UnlockAllInfo()
    {
        ItemsManager.Get().UnlockAllItemInfos();
    }

    [ConsoleCommand(name: "kira_giveStarterKit", docs: "Gives you a bounch of stuff to help you get started")]
    public static void GiveStarterKit()
    {
        Player.Get().AddItemToInventory("Machete");
        Player.Get().AddItemToInventory("Beef_Jerky");
        Player.Get().AddItemToInventory("Juice_Carton");
        Player.Get().AddItemToInventory("Chips");
        Player.Get().AddItemToInventory("Bidon");
        Player.Get().AddItemToInventory("Pot");
        for (int i = 1; i <= 3; i++)
        {
            Player.Get().AddItemToInventory("coffee_instant");
            Player.Get().AddItemToInventory("Nuts_" + i);
            Player.Get().AddItemToInventory("Candy_bar_" + i);
            Player.Get().AddItemToInventory("Bird_Nest");
        }
        Player.Get().AddItemToInventory("Fire_Bow");
    }

    [ConsoleCommand(name: "kira_giveAllMaps", docs: "Gives you all the maps")]
    public static void GiveAllMaps()
    {
        Player.Get().AddItemToInventory("QuestItem_Map_A");
        Player.Get().AddItemToInventory("QuestItem_Map_B");
        Player.Get().AddItemToInventory("QuestItem_Map_C");
        Player.Get().AddItemToInventory("QuestItem_Map_A_Survi");
        Player.Get().AddItemToInventory("QuestItem_Map_B_Survi");
        Player.Get().AddItemToInventory("QuestItem_Map_C_Survi");
        Player.Get().AddItemToInventory("QuestItem_Map_PVE");
        Player.Get().AddItemToInventory("QuestItem_Map_PVE2");
        Player.Get().AddItemToInventory("QuestItem_Map_PVE3_A");
        Player.Get().AddItemToInventory("QuestItem_Map_PVE3_B");
        Player.Get().AddItemToInventory("QuestItem_Map_PVE3_C");
    }

    [ConsoleCommand(name: "kira_giveItem", docs: "Gives you a specific item")]
    public static void GiveItem(string[] item)
    {
        Player.Get().AddItemToInventory(item[0]);
    }

    [ConsoleCommand(name: "kira_setCarryWeight", docs: "Change how much you weight you can carry")]
    public static void SetCarryWeight(string[] weight)
    {
        InventoryBackpack.Get().m_MaxWeight = float.Parse(weight[0]);
    }

    public void OnModUnload()
    {
        Debug.Log("Mod KiraCatHax has been unloaded!");
    }
}