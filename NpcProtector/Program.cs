#region

using System;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Noggog;

#endregion

namespace EnemyReleveler
{
    public class Program
    {
        private static readonly string[] npcsToProtect =
        {
            #region

            "Abelone",
            "AcolyteJenssen",
            "Adara",
            "Addvar",
            "Addvild",
            "Adeber",
            "Adelaisa",
            "Adisla",
            "AdonatoLeotelli",
            "AdrianneAvenicci ",
            "AduriSarethi",
            "AelaTheHuntress",
            "Aeri",
            "Aerin",
            "Agni",
            "Agnis",
            "Ahlam",
            "Ahtar",
            "AiaArria",
            "Aicantar",
            "Ainethach",
            "Alessandra",
            "AlexiaVici",
            "AlfhildBattleBorn",
            "Alvor",
            "AmaundMotierre",
            "AmaundMotierreEnd",
            "AmbarysRendar",
            "Amren",
            "Andurs",
            "AngelineMorrard",
            "Angrenor",
            "Angvid",
            "Annekke",
            "Anoriath",
            "Anton",
            "Anuriel",
            "Anwen",
            "AquilliusAeresius",
            "Arcadia",
            "Aringoth",
            "Arnbjorn",
            "Arngeir",
            "ArnielGane",
            "Arnskar",
            "Arob",
            "Asbjorn",
            "Asgeir",
            "Aslfur",
            "Assur",
            "Astrid",
            "AtAfAlan",
            "Atar",
            "Athis",
            "AvalAtheron",
            "AventusAretino",
            "AvrusaSarethi",
            "AvulsteinGrayMane",
            "AzzadaLylvieve",
            "Babette",
            "Badnir",
            "Bagrak",
            "BalagogGroNolob",
            "BalgruuftheGreater",
            "Balimund",
            "Banning",
            "BassianusAxius",
            "Beirand",
            "Belchimac",
            "Belethor",
            "BelynHlaalu",
            "Bendt",
            "Benor",
            "BergritteBattleBorn",
            "Bersi",
            "Birna",
            "Bjartur",
            "Bodil",
            "Bolar",
            "Bolfrida",
            "BolgeirBearclaw",
            "Bolli",
            "Bolund",
            "Bor",
            "Borgakh",
            "Borgny",
            "Borri",
            "Bothela",
            "Boti",
            "Braith",
            "BrandShei",
            "Brelas",
            "BrelynaMaryon",
            "Brenuin",
            "Briehl",
            "Brill",
            "BrinaMerilis",
            "Britte",
            "BrotherVerulus",
            "Brunwulf",
            "Bryling",
            "Brynjolf",
            "Bulfrek",
            "Burguk",
            "BYOHHouse1Bard",
            "BYOHHouse2Bard",
            "BYOHHouse3Bard",
            "BYOHRelationshipAdoptionCritter_Fox",
            "BYOHRelationshipAdoptionCritter_FoxArctic",
            "BYOHRelationshipAdoptionCritter_Hare",
            "BYOHRelationshipAdoptionCritter_Mudcrab",
            "BYOHRelationshipAdoptionCritter_Skeever",
            "BYOHUrchin_Alesan",
            "BYOHUrchin_Blaise",
            "BYOHUrchin_Lucia",
            "BYOHUrchin_Sofie",
            "Cairine",
            "Calcelmo",
            "CamillaValerius",
            "CaptainAldis",
            "CaptainLonelyGale",
            "CarlottaValentia",
            "Cedran",
            "Cicero",
            "CiceroDawnstar",
            "CiceroRoad",
            "ClintonLylvieve",
            "ColetteMarence",
            "CommanderCaius",
            "CommanderMaro",
            "ConstanceMichel",
            "CorpulusVinius",
            "Cosnach",
            "Curwe",
            "CWBattleGalmar",
            "CWBattleTullius",
            "CWBattleUlfric",
            "CWFieldCOImperialEastmarch",
            "CWFieldCOImperialFalkreath",
            "CWFieldCOImperialHaafingar",
            "CWFieldCOImperialHjaalmarch",
            "CWFieldCOImperialPale",
            "CWFieldCOImperialReach",
            "CWFieldCOImperialRift",
            "CWFieldCOImperialWhiterun",
            "CWFieldCOImperialWinterhold",
            "CWFieldCOSonsEastmarch",
            "CWFieldCOSonsFalkreath",
            "CWFieldCOSonsHaafingar",
            "CWFieldCOSonsHjaalmarch",
            "CWFieldCOSonsPale",
            "CWFieldCOSonsReach",
            "CWFieldCOSonsRift",
            "CWFieldCOSonsWhiterun",
            "CWFieldCOSonsWinterhold",
            "DA03Barbas",
            "DA05Sinding",
            "DA11Nimphaneth",
            "DA11Sanyon",
            "DA14Giant",
            "DA14Goat",
            "DA14Hagraven",
            "DA14Samwell",
            "Dagny",
            "Dagur",
            "Daighre",
            "DalanMerchad",
            "DanicaPureSpring",
            "DB05Lodi",
            "DBEncTroll",
            "DBInitiate1",
            "DBInitiate2",
            "DBLis",
            "DBRecurringContact10Rorikstead",
            "DBRecurringContact1Dawnstar",
            "DBRecurringContact2Riften",
            "DBRecurringContact3DragonBridge",
            "DBRecurringContact4Markarth",
            "DBRecurringContact5Windhelm",
            "DBRecurringContact6Whiterun",
            "DBRecurringContact7Solitude",
            "DBRecurringContact8Ivarstead",
            "DBRecurringContact9Heljarchen",
            "DBTortureVictim1",
            "DBTortureVictim2",
            "DBTortureVictim3",
            "DBTortureVictim4",
            "Deeja",
            "Degaine",
            "Delacourt",
            "Delphine",
            "DelvinMallory",
            "Dengeir",
            "Derkeethus",
            "Dervenin",
            "Dinya",
            "Dirge",
            "DLC1_WESC06_LvlDawnguardFleeing",
            "DLC1_WESC07_Outrider",
            "DLC1_WESC09TaronDreth",
            "DLC1Dexion",
            "DLC1Durnehviir",
            "DLC1DurnehviirSummon",
            "DLC1HireableVampireDeathhound1",
            "DLC1HireableVampireDeathhound2",
            "DLC1Ingjard",
            "DLC1RefugeeAlvide",
            "DLC1RefugeeBarknar",
            "DLC1RefugeeJayri",
            "DLC1RefugeeSern",
            "DLC1Serana",
            "DLC1Surgeon",
            "DLC1Valerica",
            "DLC1VigilantTolan",
            "DLC2DremoraButler",
            "DLC2DremoraMerchant",
            "DLC2Drovas",
            "DLC2dunFrostmoonAkar",
            "DLC2dunFrostmoonHjordis",
            "DLC2dunFrostmoonRakel",
            "DLC2dunHorkerIslandEncHorker",
            "DLC2dunKolbjornRalis",
            "DLC2dunNorthshoreLandingCrabBoss",
            "DLC2Frea",
            "DLC2MerchMerchant",
            "DLC2MH02Bilgemuck",
            "DLC2Mogrul",
            "DLC2Neloth",
            "DLC2Niyya",
            "DLC2RRAdrilArano",
            "DLC2RRCindiriArano",
            "DLC2RRCresciusCaerellius",
            "DLC2RRGeldisSadri",
            "DLC2RRGjalundSaltSageSolstheim",
            "DLC2RRGjalundSaltSageWindhelm",
            "DLC2RRGloverMallory",
            "DLC2RRLlerilMorvayn",
            "DLC2RRLygrleidSolstheim",
            "DLC2RRLygrleidWindhelm",
            "DLC2RRMirriSeverin",
            "DLC2RRModynVeleth",
            "DLC2RRSogrlafSolstheim",
            "DLC2RRSogrlafWindhelm",
            "DLC2RRTilisuSeverin",
            "DLC2RRVendilSeverin",
            "DLC2SiltStriderMerchant",
            "DLC2SV02Ancarion",
            "DLC2SVBaldorIronShaper",
            "DLC2SVOslaf",
            "DLC2SVTharstan",
            "DLC2SVYrsa",
            "DLC2WB01Torkild",
            "Donnel",
            "Dorthe",
            "DragonBridgeGoatLucky",
            "Drahff",
            "Dravin",
            "Dravynea",
            "DrevisNeloren",
            "Drifa",
            "Dryston",
            "Dulug",
            "dunAngiREF",
            "dunBlindcliffHagraven",
            "dunEldergleamPilgrimNordF",
            "dunEldergleamPilgrimNordM",
            "dunHunterChild",
            "dunMistwatchChrister",
            "dunMistwatchFjola",
            "dunPOITundraMarshDog",
            "dunSouthfringePetFox",
            "dunSouthfringeSelveniNethri",
            "dunTrevasWatchStalleosVanguardFemale",
            "dunTrevasWatchStalleosVanguardMale",
            "dunWhiteRiverWatch_BanditWatchman",
            "Dushnamub",
            "Edda",
            "Edith",
            "Eimar",
            "Einarth",
            "Eirid",
            "Elda",
            "Elenwen",
            "Elgrim",
            "ElisifTheFair",
            "Elrindir",
            "Eltrys",
            "Embry",
            "Endarie",
            "Endon",
            "Enmon",
            "Ennis",
            "Ennoc",
            "Enthir",
            "EorlundGrayMane",
            "Erandur",
            "Erdi",
            "Erikur",
            "Erith",
            "Esbern",
            "EtienneRarnis",
            "EvetteSan",
            "Eydis",
            "Faendal",
            "Faida",
            "Faleen",
            "Falion",
            "FalkFirebeard",
            "Faralda",
            "FarengarSecretFire",
            "Farkas",
            "FarylAtheron",
            "Fastred",
            "FelldirTheOld",
            "FestusKrex",
            "Fianna",
            "Fihada",
            "Filnjar",
            "Fjotra",
            "Frabbi",
            "FraliaGrayMane",
            "Francois",
            "Freir",
            "Frida",
            "Fridrika",
            "Frodnar",
            "FromDeepestFathoms",
            "Frothar",
            "Fruki",
            "Fultheim",
            "Gabriella",
            "GadbaGroLargash",
            "Gallus",
            "Galmar",
            "GannaUriel",
            "Garakh",
            "Garvey",
            "GatgroShargakh",
            "Geimund",
            "GemmaUriel",
            "GeneralTullius",
            "Gerda",
            "Gerdur",
            "GesturRockbreaker",
            "Ghak",
            "Ghamorz",
            "Gharol",
            "Ghorbash",
            "GhorzaGraBagol",
            "Gilfre",
            "GiraudGemane",
            "Gisli",
            "Gjak",
            "Gloth",
            "Gorm",
            "GormlaithGoldenHilt",
            "Gralnach",
            "Grelka",
            "Grelod",
            "Greta",
            "Grimvar",
            "Grisvar",
            "GrogmarGroBurzag",
            "Grosta",
            "GuardLoreiusFarmImperial",
            "GuardLoreiusFarmSons",
            "Gul",
            "Gularzob",
            "GulumEi",
            "Gunding",
            "Guthrum",
            "Gwendolyn",
            "Gwilin",
            "Hadring",
            "Hadvar",
            "Haelga",
            "Hafjorg",
            "HakonOneEye",
            "Hamal",
            "Haran",
            "Harrald",
            "Hathrasil",
            "Hefid",
            "Heimskr",
            "Heimvar",
            "Helgird",
            "Hemming",
            "HerluinLothaire",
            "Hermir",
            "Hern",
            "Hert",
            "Hewnon",
            "HHpilgrim01",
            "HHPilgrim02",
            "Hilde",
            "Hillevi",
            "Hjorunn",
            "Hod",
            "Hofgrir",
            "Horgeir",
            "HorikHalfhand",
            "Horm",
            "Hrefna",
            "Hreinn",
            "Hroar",
            "Hroggar",
            "Hroki",
            "Hrongar",
            "Hulda",
            "Iddra",
            "IdesaSadri",
            "IdgrodRavencrone",
            "IdgrodTheYounger",
            "IdolafBattleBorn",
            "Igmund",
            "Illdi",
            "Imedhnain",
            "IndaraCaerellia",
            "Indaryn",
            "IngeSixFingers",
            "Ingun",
            "Irgnir",
            "Irileth",
            "IrnskarIronhand",
            "Jala",
            "JareeRa",
            "Jawanan",
            "Jervar",
            "Jesper",
            "Jod",
            "Jofthor",
            "JonBattleBorn",
            "Jonna",
            "Jora",
            "Jorgen",
            "Joric",
            "Jorleif",
            "Jorn",
            "JouaneManette",
            "JulienneLylvieve",
            "Jzargo",
            "Karita",
            "Karl",
            "Karliah",
            "Katla",
            "Kayd",
            "Keerava",
            "KharagGroShurkul",
            "Kjar",
            "Kjeld",
            "KjeldtheYounger",
            "Kleppr",
            "Klimmek",
            "Knjakr",
            "Knud",
            "KodlakWhitemane",
            "Kodrir",
            "Korir",
            "Kraldar",
            "Kust",
            "Laila",
            "Lami",
            "Larak",
            "LarsBattleBorn",
            "LashGraDushnikh",
            "Leifur",
            "LeifWayfinder",
            "Leigelf",
            "Lemkil",
            "LeonaraArius",
            "LeontiusSalvius",
            "LillithMaidenLoom",
            "Lisbet",
            "Lisette",
            "Lob",
            "Lod",
            "Lodvar",
            "Logrolf",
            "LondNorthstrider",
            "Lortheim",
            "LouisLetrush",
            "Luaffyn",
            "LucanValerius",
            "Lurbuk",
            "Lynly",
            "Madena",
            "Madesi",
            "Mahk",
            "MaiqTheLiar",
            "Malborn",
            "MallusMaccius",
            "MalthyrElenil",
            "MalurSeloth",
            "Maramal",
            "Marise",
            "Mathies",
            "Mauhulakh",
            "Maul",
            "Maven",
            "Mazaka",
            "Melaran",
            "Mena",
            "MichelLylvieve",
            "Mikael",
            "MilaValentia",
            "MinetteVinius",
            "MirabelleErvine",
            "Mjoll",
            "Mogdurz",
            "Molgrom",
            "Morven",
            "MothgroBagol",
            "MQ201PartyCarriageSolitudeDriver",
            "MQ303Odahviing",
            "MQ304Galmar",
            "MQ304Kodlak",
            "MQ304Rikke",
            "MQ304Svaknir",
            "MQ304Torygg",
            "MQ304Ulfric",
            "Mralki",
            "MS03Horse",
            "MS08Kematu",
            "MS09Geirlund",
            "MS09Vidrald",
            "MS10Pirate1",
            "MS10Pirate2",
            "MS10Pirate3",
            "Muiri",
            "MulGroLargash",
            "MulushGroShugurz",
            "Murbul",
            "Nagrub",
            "Narfi",
            "Narri",
            "Nazeem",
            "Nazir",
            "NazirSancAttack",
            "Neetrenaza",
            "Nelacar",
            "Nelkir",
            "Nenya",
            "Nils",
            "Nilsine",
            "Niluva",
            "Nimriel",
            "Niranye",
            "Nivenor",
            "NjadaStonearm",
            "NosterOneEye",
            "Nura",
            "OctieveSan",
            "Odar",
            "Odfel",
            "Oengul",
            "Oglub",
            "Ogmund",
            "Ogol",
            "OlavatheFeeble",
            "Olda",
            "OlfinaGrayMane",
            "OlfridBattleBorn",
            "Olur",
            "Omluag",
            "Onmund",
            "Orgnar",
            "Orla",
            "Orthorn",
            "OrthusEndario",
            "Paarthurnax",
            "Pactur",
            "PanteaAteia",
            "ParatusDecimius",
            "PavoAttius",
            "Perth",
            "PhinisGestor",
            "ProventusAvenicci",
            "QuintusNavale",
            "Raerek",
            "Ragnar",
            "Ralof",
            "Ranmir",
            "RavamVerethi",
            "Reburrus",
            "Reldith",
            "RevynSadri",
            "Rexus",
            "Rhiada",
            "Rhorlak",
            "Ria",
            "Rikke",
            "Risaad",
            "Rogatus",
            "Roggi",
            "Rolff",
            "Romlyn",
            "Rondach",
            "Rorik",
            "Rorlund",
            "Runa",
            "Runil",
            "Rustleif",
            "Saadia",
            "SabineNytte",
            "Sabjorn",
            "Saerlund",
            "Saffir",
            "Safia",
            "SailorDorian",
            "SailorEris",
            "SailorXander",
            "Salvianus",
            "Samuel",
            "Sayma",
            "ScoutsManyMarshes",
            "Senna",
            "Seren",
            "Shadr",
            "Shahvee",
            "Sharamph",
            "Shel",
            "Shuftharz",
            "Sibbi",
            "Siddgeir",
            "Sifnar",
            "Sigrid",
            "Sigurd",
            "SilanaPetreia",
            "Silda",
            "SilusVesuius",
            "Sinmir",
            "Sirgar",
            "Sissel",
            "Skaggi",
            "SkaldtheElder",
            "Skuli",
            "SkulvarSableHilt",
            "Snilf",
            "Snilling",
            "Snorreid",
            "Solaf",
            "SondasDrenim",
            "SorexVinius",
            "Sorli",
            "Sosia",
            "StandsInShallows",
            "Stump",
            "Styrr",
            "Susanna",
            "SuvarisAtheron",
            "Svana",
            "Svari",
            "Sven",
            "Swanhvir",
            "SybilleStentor",
            "Sylgja",
            "SyndaLlanith",
            "Syndus",
            "T03Maurice",
            "Taarie",
            "TacitusSallustius",
            "TalenJei",
            "TalsgarTheWanderer",
            "TeebaEi",
            "Tekla",
            "TembaWideArm",
            "Terek",
            "TG04EECDockmaster",
            "TG04EECDockworker01",
            "TG04EECDockworker02",
            "Thadgeir",
            "Thaena",
            "Thongvor",
            "Thonjolf",
            "Thonnir",
            "ThoraldGrayMane",
            "Thorgar",
            "Thoring",
            "Threki",
            "TiberDog",
            "Tilma",
            "Tolfdir",
            "Tonilia",
            "Torbjorn",
            "Tormir",
            "Torom",
            "Torsten",
            "Torvar",
            "Tova",
            "TrainedDog",
            "Tulvur",
            "Tuthul",
            "Tynan",
            "Tyranus",
            "Tythis",
            "Uaile",
            "Ugor",
            "Ulfberth",
            "Ulfric",
            "Ulundil",
            "Umurn",
            "Una",
            "Ungrien",
            "Unmid",
            "UraggroShub",
            "Urog",
            "UrzogaGraShugurz",
            "Uthgerd",
            "Vald",
            "Valdr",
            "ValgaVinicia",
            "Valindor",
            "VanrythGatharian",
            "VantusLoreius",
            "VarniusJunius",
            "Veezara",
            "Vekel",
            "Verner",
            "Vex",
            "Viarmo",
            "Vigdis",
            "VigilantCarcette",
            "VignarGrayMane",
            "Vilkas",
            "ViolaGiordano",
            "Virkmund",
            "VittoriaVici",
            "VivienneOnis",
            "Voada",
            "VoldseaGiryon",
            "Vulwulf",
            "WEDL03PlautisCarvain",
            "WEDL03SaloniaCarvain",
            "WEDL04PlautisCarvain",
            "WEDL04SaloniaCarvain",
            "WEDL08DeepInHisCups",
            "WEFollowerDog",
            "WEJS02Balbus",
            "WEJS10Faldrus",
            "WEJS13Ardwen",
            "WERJ04Kid01",
            "WERJ04Kid02",
            "WhiterunTempleSicklyFarmer",
            "WhiterunTempleWoundedSoldier",
            "WICourierNPC",
            "Wilhelm",
            "Willem",
            "Wilmuth",
            "Wujeeta",
            "Wulfgar",
            "Wuunferth",
            "Wylandriah",
            "Yatul",
            "Yngvar",
            "YsgramorDog",
            "Ysolda",
            "Zaria",

            #endregion
        };

        public static int Main(string[] args)
        {
            return SynthesisPipeline.Instance.Patch<ISkyrimMod, ISkyrimModGetter>(
                args,
                RunPatch,
                new UserPreferences
                {
                    ActionsForEmptyArgs = new RunDefaultPatcher
                    {
                        IdentifyingModKey = "enemies_releveled.esp",
                        TargetRelease = GameRelease.SkyrimSE,
                        BlockAutomaticExit = true
                    }
                });
        }

        public static void RunPatch(SynthesisState<ISkyrimMod, ISkyrimModGetter> state)
        {
            foreach (var npc in state.LoadOrder.PriorityOrder.WinningOverrides<INpcGetter>())
            {
                //filter NPCs
                if (!npcsToProtect.Contains(npc.EditorID ?? ""))
                    // Console.WriteLine("[INFO] \"" + npc.EditorID + "\" is not in the list of NPCs to makr as protected.");
                    continue;

                if (npc.Configuration.Flags.HasFlag(NpcConfiguration.Flag.Essential))
                {
                    Console.WriteLine("[INFO] [Skipping] \"" + npc.EditorID + "\" is Essential and will be skipped.");
                    continue;
                }

                if (npc.Configuration.Flags.HasFlag(NpcConfiguration.Flag.Protected))
                {
                    Console.WriteLine("[INFO] [Skipping] \"" + npc.EditorID +
                                      "\" is already protected and will be skipped.");
                    continue;
                }

                Console.WriteLine("[INFO] [Processing] \"" + npc.EditorID + "\" will be flagged as Protected.");

                var npcPatch = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                npcPatch.Configuration.Flags |= NpcConfiguration.Flag.Protected;

                if (!npcPatch.Configuration.Flags.HasFlag(NpcConfiguration.Flag.Protected))
                    Console.WriteLine("[ERROR] \"" + npc.EditorID +
                                      "\" was not flagged as Protected for whatever reason.");
            }
        }
    }
}
