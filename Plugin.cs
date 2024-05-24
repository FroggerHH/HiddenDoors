using System.Diagnostics.CodeAnalysis;
using BepInEx;
using HiddenDoors.PieceManager;

namespace HiddenDoors;

[BepInPlugin(ModGUID, ModName, ModVersion)] [SuppressMessage("ReSharper", "StringLiteralTypo")]
internal class Plugin : BaseUnityPlugin
{
    private const string ModName = "HiddenDoors",
        ModAuthor = "Frogger",
        ModVersion = "1.1.2",
        ModGUID = $"com.{ModAuthor}.{ModName}";
 
    private void Awake()
    {
        CreateMod(this, ModName, ModAuthor, ModVersion, ModGUID);
        LoadAssetBundle("door");
        var stoneDoor2x2BuildPiece = new BuildPiece(bundle, "Hideen_Door_Stone_2x2");
        stoneDoor2x2BuildPiece.Name
            .English("Hidden stone door 2x2")
            .Swedish("Dold stendörr 2x2")
            .French("Porte en pierre cachée 2x2")
            .Italian("Porta in pietra nascosta 2x2")
            .German("Versteckte Steintür 2x2")
            .Spanish("Puerta de piedra oculta 2x2")
            .Russian("Скрытая каменная дверь 2x2")
            .Romanian("Ușă de piatră ascunsă 2x2")
            .Bulgarian("Скрита каменна врата 2x2")
            .Macedonian("Скриена камена врата 2х2")
            .Finnish("Piilotettu kiviovi 2x2")
            .Danish("Skjult stendør 2x2")
            .Norwegian("Skjult steindør 2x2")
            .Icelandic("Falin steinhurð 2x2")
            .Turkish("Gizli taş kapı 2x2")
            .Lithuanian("Paslėptos akmeninės durys 2x2")
            .Czech("Skryté kamenné dveře 2x2")
            .Hungarian("Rejtett kőajtó 2x2")
            .Slovak("Skryté kamenné dvere 2x2")
            .Polish("Ukryte kamienne drzwi 2x2")
            .Dutch("Verborgen stenen deur 2x2")
            .Chinese("隐藏石门 2x2")
            .Japanese("隠し石扉 2x2")
            .Korean("숨겨진 돌문 2x2")
            .Hindi("छिपा हुआ पत्थर का दरवाजा 2x2")
            .Thai("ประตูหินซ่อน 2x2")
            .Croatian("Skrivena kamena vrata 2x2")
            .Georgian("დამალული ქვის კარი 2x2")
            .Greek("Κρυφή πέτρινη πόρτα 2x2")
            .Serbian("Скривена камена врата 2к2")
            .Ukrainian("Приховані кам'яні двері 2x2");
        stoneDoor2x2BuildPiece.Category.Set(BuildPieceCategory.BuildingStonecutter);
        stoneDoor2x2BuildPiece.RequiredItems.Add("Stone", 8, true);
        stoneDoor2x2BuildPiece.SpecialProperties.NoConfig = false;
        var stoneDoor2x3BuildPiece = new BuildPiece(bundle, "Hideen_Door_Stone_2x3");
        stoneDoor2x3BuildPiece.Name
            .English("Hidden stone door 2x3")
            .Swedish("Dold stendörr 2x3")
            .French("Porte en pierre cachée 2x3")
            .Italian("Porta in pietra nascosta 2x3")
            .German("Versteckte Steintür 2x3")
            .Spanish("Puerta de piedra oculta 2x3")
            .Russian("Скрытая каменная дверь 2x3")
            .Romanian("Ușă de piatră ascunsă 2x3")
            .Bulgarian("Скрита каменна врата 2x3")
            .Macedonian("Скриена камена врата 2x3")
            .Finnish("Piilotettu kiviovi 2x3")
            .Danish("Skjult stendør 2x3")
            .Norwegian("Skjult steindør 2x3")
            .Icelandic("Falin steinhurð 2x3")
            .Turkish("Gizli taş kapı 2x3")
            .Lithuanian("Paslėptos akmeninės durys 2x3")
            .Czech("Skryté kamenné dveře 2x3")
            .Hungarian("Rejtett kőajtó 2x3")
            .Slovak("Skryté kamenné dvere 2x3")
            .Polish("Ukryte kamienne drzwi 2x3")
            .Dutch("Verborgen stenen deur 2x3")
            .Chinese("隐藏石门 2x3")
            .Japanese("隠し石扉 2x3")
            .Korean("숨겨진 돌문 2x3")
            .Hindi("छिपा हुआ पत्थर का दरवाजा 2x3")
            .Thai("ประตูหินซ่อน 2x3")
            .Croatian("Skrivena kamena vrata 2x3")
            .Georgian("დამალული ქვის კარი 2x3")
            .Greek("Κρυφή πέτρινη πόρτα 2x3")
            .Serbian("Скривена камена врата 2к3")
            .Ukrainian("Приховані кам'яні двері 2x3");
        stoneDoor2x3BuildPiece.Category.Set(BuildPieceCategory.BuildingStonecutter);
        stoneDoor2x3BuildPiece.RequiredItems.Add("Stone", 8, true);
        stoneDoor2x3BuildPiece.SpecialProperties.NoConfig = false;
        var stoneDoor4x2BuildPiece = new BuildPiece(bundle, "Hideen_Door_Stone_4x2");
        stoneDoor4x2BuildPiece.Name
            .English("Hidden stone door 4x2")
            .Swedish("Dold stendörr 4x2")
            .French("Porte en pierre cachée 4x2")
            .Italian("Porta in pietra nascosta 4x2")
            .German("Versteckte Steintür 4x2")
            .Spanish("Puerta de piedra oculta 4x2")
            .Russian("Скрытая каменная дверь 4x2")
            .Romanian("Ușă de piatră ascunsă 4x2")
            .Bulgarian("Скрита каменна врата 4x2")
            .Macedonian("Скриена камена врата 4х2")
            .Finnish("Piilotettu kiviovi 4x2")
            .Danish("Skjult stendør 4x2")
            .Norwegian("Skjult steindør 4x2")
            .Icelandic("Falin steinhurð 4x2")
            .Turkish("Gizli taş kapı 4x2")
            .Lithuanian("Paslėptos akmeninės durys 4x2")
            .Czech("Skryté kamenné dveře 4x2")
            .Hungarian("Rejtett kőajtó 4x2")
            .Slovak("Skryté kamenné dvere 4x2")
            .Polish("Ukryte kamienne drzwi 4x2")
            .Dutch("Verborgen stenen deur 4x2")
            .Chinese("隐藏石门 4x2")
            .Japanese("隠し石扉 4x2")
            .Korean("숨겨진 돌문 4x2")
            .Hindi("छिपा हुआ पत्थर का दरवाजा 4x2")
            .Thai("ประตูหินซ่อน 4x2")
            .Croatian("Skrivena kamena vrata 4x2")
            .Georgian("დამალული ქვის კარი 4x2")
            .Greek("Κρυφή πέτρινη πόρτα 4x2")
            .Serbian("Скривена камена врата 4к2")
            .Ukrainian("Приховані кам'яні двері 4x2");
        stoneDoor4x2BuildPiece.Category.Set(BuildPieceCategory.BuildingStonecutter);
        stoneDoor4x2BuildPiece.RequiredItems.Add("Stone", 8, true);
        stoneDoor4x2BuildPiece.SpecialProperties.NoConfig = false;
        var woodDoorBuildPiece = new BuildPiece(bundle, "Hideen_Door_Wood");
        woodDoorBuildPiece.Name
            .English("Hidden wooden door")
            .Swedish("Dold trädörr")
            .French("Porte en bois cachée")
            .Italian("Porta di legno nascosta")
            .German("Versteckte Holztür")
            .Spanish("Puerta de madera oculta")
            .Russian("Скрытая деревянная дверь")
            .Romanian("Ușă de lemn ascunsă")
            .Bulgarian("Скрита дървена врата")
            .Macedonian("Скриена дрвена врата")
            .Finnish("Piilotettu puinen ovi")
            .Danish("Skjult trædør")
            .Norwegian("Skjult tredør")
            .Icelandic("Falin viðarhurð")
            .Turkish("Gizli ahşap kapı")
            .Lithuanian("Paslėptos medinės durys")
            .Czech("Skryté dřevěné dveře")
            .Hungarian("Rejtett fa ajtó")
            .Slovak("Skryté drevené dvere")
            .Polish("Ukryte drewniane drzwi")
            .Dutch("Verborgen houten deur")
            .Chinese("隐藏式木门")
            .Japanese("隠し木製ドア")
            .Korean("숨겨진 나무 문")
            .Hindi("छिपा हुआ लकड़ी का दरवाज़ा")
            .Thai("ประตูไม้ที่ซ่อนอยู่")
            .Croatian("Skrivena drvena vrata")
            .Georgian("დამალული ხის კარი")
            .Greek("Κρυφή ξύλινη πόρτα")
            .Serbian("Скривена дрвена врата")
            .Ukrainian("Приховані дерев'яні двері");
        woodDoorBuildPiece.Category.Set(BuildPieceCategory.BuildingWorkbench);
        woodDoorBuildPiece.RequiredItems.Add("Wood", 2, true);
        woodDoorBuildPiece.SpecialProperties.NoConfig = false;
        // MaterialReplacer.RegisterGameObjectForShaderSwap(stoneDoor2x2BuildPiece.Prefab,
        //     MaterialReplacer.ShaderType.PieceShader);
        // MaterialReplacer.RegisterGameObjectForShaderSwap(stoneDoor2x3BuildPiece.Prefab,
        //     MaterialReplacer.ShaderType.PieceShader);
        // MaterialReplacer.RegisterGameObjectForShaderSwap(stoneDoor4x2BuildPiece.Prefab,
        //     MaterialReplacer.ShaderType.PieceShader);
        // MaterialReplacer.RegisterGameObjectForShaderSwap(woodDoorBuildPiece.Prefab,
        //     MaterialReplacer.ShaderType.PieceShader);

        bundle.Unload(false);
    }
}