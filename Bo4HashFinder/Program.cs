
using SELib;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Bo4HashFinder
{
    internal class Program
    {
        static string[] AnimTypes = 
        {
      "",
      "_crawl_in",
      "_crawl_out",
      "_crawl_l",
      "_crawl_r",
      "_crawl_b",
      "_crawl_f",
      "_ads",
      "_ads_base_up",
      "_ads_base_down",
      "_fall",
      "_wallrun_in",
      "_fire",
      "_fire_ads",
      "_first_raise",
      "_gunbutt_swipe",
      "_pullout",
      "_pullout_quick",
      "_putaway",
      "_putaway_quick",
      "_rechamber",
      "_rechamber_ads",
      "_wallrun_out",
      "_reload",
      "_reload_empty",
      "_inspect",
      "_sprint_in",
      "_sprint_loop",
      "_sprint_out",
      "_idle",
      "_ads_acog_down",
      "_ads_acog_up",
      "_ads_holo_down",
      "_ads_down_holo",
      "_wallrun_loop",
      "_ads_holo_up",
      "_reload_quick",
      "_reload_empty_quick",
      "_ads_up",
      "_ads_down",
      "_ads_up_base",
      "_ads_down_base",
      "_ads_reflex_down",
      "_ads_down_reflex",
      "_ads_reflex_up",
      "_jump",
      "_jump_land",
      "_crawl_left",
      "_crawl_right",
      "_crawl_back",
      "_crawl_forward",
      "_ads_fire",
      "_ads_reddot_up",
      "_ads_reddot_down",
      "_ads_thermal_down",
      "_ads_thermal_up",
      "_fire_ads_acog",
      "_fire_ads_hybrid",
      "_fire_ads_holo",
      "_fire_ads_reflex",
      "_fire_ads_reddot",
      "_mantle_over",
      "_mantle_over_l",
      "_mantle_over_r",
      "_putaway_empty",
      "_pullout_empty",
      "_reload_ext_empty",
      "_reload_dm",
      "_reload_dm_quick",
      "_reload_empty_dm",
      "_reload_empty_dm_quick",
      "_reload_empty_ext",
      "_reload_ext",
      "_slide_in",
      "_slide_loop",
      "_slide_out",
      "_slide_air_in",
      "_slide_air_in",
      "_swim_from_land",
      "_swim_to_land",
      "_gunbutt_strike",
      "_juke_ads_l",
      "_juke_ads_r",
      "_juke_l",
      "_juke_r",
      "_sprint_pullout",
      "_taunt",
      "_sprint_putaway",
      "_swim_uw_b",
      "_swim_uw_f",
      "_swim_uw_idle",
      "_swim_uw_in",
      "_swim_uw_l",
      "_swim_uw_out",
      "_swim_uw_pullout",
      "_swim_uw_putaway",
      "_swim_uw_r",
      "_swim_uw_sprint_in",
      "_swim_uw_sprint_out",
      "_swim_uwc_fire",
      "_swim_uwc_fire_ads",
      "_walk_f",
      "_reload_start",
      "_reload_loop",
      "_reload_end",
      "_sprint_start",
      "_sprint_end",
      "_reload_in",
      "_reload_out",
      "_idle_le",
      "_idle_ri",
      "_fire_le",
      "_fire_ri",
      "_reload_le",
      "_reload_ri",
      "_mantle_wall_in",
      "_mantle_wall_in_low",
      "_swim_uw_raise",
      "_lh_idle",
      "_rh_idle",
      "_lh_fire",
      "_rh_fire",
      "_lh_reload",
      "_rh_reload",
      "_lh_reload_empty",
      "_rh_reload_empty",
      "_fire_l",
      "_fire_r",
      "_idle_l",
      "_idle_r",
      "_reload_l",
      "_reload_r",
      "_reload_empty_l",
      "_reload_empty_r",
      "_fire_lh",
      "_fire_rh",
      "_idle_lh",
      "_idle_rh",
      "_pullout_empty",
      "_putaway_empty",
      "_sprint_in_empty",
      "_reload_lh",
      "_reload_rh",
      "_reload_empty_lh",
      "_reload_empty_rh",
      "_idle_empty",
      "_lastfire",
      "_lastfire_ads",
      "_reload_quick_ext",
      "_reload_empty_quick_ext",
      "_reload_adv",
      "_reload_empty_adv",
      "_reload_am",
      "_reload_fm",
      "_reload_empty_am",
      "_reload_empty_fm",
      "_melee_in",
      "_melee_miss",
      "_melee_out",
      "_swim_in",
      "_swim_out",
      "_draw",
      "_draw_cancel",
      "_draw_loop",
      "_drop_attack",
      "_melee_fatal",
      "_melee_fatal_l",
      "_melee_in_l",
      "_melee_out_l",
      "_melee_out_l_miss",
      "_melee_swipe",
      "_melee_swipe_l",
      "_showcase_in",
      "_swim_tw_sprint_loop",
      "_lh_swim_uw_idle",
      "_rh_swim_uw_idle",
      "_swim_uw_idle_l",
      "_swim_uw_idle_r",
      "_idle_foregrip",
      "_fire_ads_thermal"
        };
        static string[] AnimVariants = 
        {
      "",
      "_dw",
      "_foregrip"
        };
        static string[] ModelTypes = 
        {
      "",
      "_view",
      "_world",
      "_prop_animate",
      "_mag_view",
      "_clip_view",
      "_view_le",
      "_world_le",
      "_clip_view_le",
      "_mag_view_le",
      "_mag_world",
      "_clip_world",
      "_paint_shop",
      "_fast_mag_view",
      "_fast_mag_world",
      "_ext_mag_view",
      "_ext_mag_world",
      "_scope",
      "_scope_ads",
      "_ads_scope"
        };
        static string[] AttachmentVariants = 
        {
      "",
      "_bolt",
      "_mag",
      "_upper",
      "_lower",
      "_stock",
      "_handguard",
      "_silencer",
      "_barrel",
      "_coupler",
      "_dbal",
      "_foregrip",
      "_grip",
      "_muzzle",
      "_handgrd",
      "_ext_mag",
      "_adv_mag",
      "_ext_fast_mag",
      "_fast_mag",
      "_rapidfire",
      "_rail_cover",
      "_counterweight",
      "_lid",
      "_gastube",
      "_mount",
      "_handle",
      "_fmj",
      "_hi_cal",
      "_hamer",
      "_rail",
      "_forend",
      "_foreend",
      "_mag_view",
      "_mag_world",
      "_ext_mag_full",
      "_ext_fast_mag_full",
      "_fast_loader",
      "_fast_load",
      "_hammer",
      "_magwell",
      "_mag_release",
      "_fmj_grip",
      "_cpu",
      "_scope",
      "_scope_ads",
      "_ads_scope",
      "_bolt_pivot_animate",
      "_sight",
      "_coupler",
      "_foregrip_vert",
      "_extmag",
      "_fastmag",
      "_extmag_cover",
      "_ext_mag_cover",
      "_counterweight",
      "_fast_mag_guard",
      "_gastube",
      "_upper_ring",
      "_stock_mag_release",
      "_dbal_fmj_strap",
      "_dbal_strap",
      "_barrel_sight",
      "_foregrip_bracket",
      "_bolt_animate",
      "_iron_sight",
      "_silencer_fmj",
      "_dbal_attach",
      "_rapid_fire_attach",
      "_uber",
      "_bracket",
      "_slide",
      "_hical"
        };

        static string greyhoundExportFolder;

        static void Main(string[] args)
        {
            Console.WriteLine("Greyhound BO4 Export Folder: ");
            greyhoundExportFolder = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Xmodel(1) / Xanim(2) / Specific Gun(3) / Check Name(4): ");
                string searchType = Console.ReadLine();
                if (searchType == "1")
                {
                    Console.WriteLine("Before random stuff: ");
                    string BeforeRandom = Console.ReadLine();
                    Console.WriteLine("After random stuff: ");
                    string AfterRandom = Console.ReadLine();
                    Console.WriteLine("Searching for Xmodels... start at " + DateTime.Now.ToString("h:mm:ss tt"));
                    Task.Factory.StartNew(() => SearchForModels(0, BeforeRandom, AfterRandom));
                    Task.Factory.StartNew(() => SearchForModels(1, BeforeRandom, AfterRandom));
                    Task.Factory.StartNew(() => SearchForModels(2, BeforeRandom, AfterRandom));
                }
                else if (searchType == "2")
                {
                    Console.WriteLine("Before random stuff: ");
                    string BeforeRandom = Console.ReadLine();
                    Console.WriteLine("After random stuff: ");
                    string AfterRandom = Console.ReadLine();
                    Console.WriteLine("Searching for Xanims... start at " + DateTime.Now.ToString("h:mm:ss tt"));
                    Task.Factory.StartNew(() => SearchForAnims(0, BeforeRandom, AfterRandom));
                    Task.Factory.StartNew(() => SearchForAnims(1, BeforeRandom, AfterRandom));
                    Task.Factory.StartNew(() => SearchForAnims(2, BeforeRandom, AfterRandom));
                }
                else if (searchType == "3")
                {
                    Console.WriteLine("Specific Gun: ");
                    string gun = Console.ReadLine();
                    Console.WriteLine("Searching for Assets... start at " + DateTime.Now.ToString("h:mm:ss tt"));
                    Task.WaitAll(Task.Factory.StartNew(() => SearchForSpecificGun(gun)));
                    Console.WriteLine("Done with exporting, press ENTER to continue");
                }
                else if (searchType == "4")
                {
                    Console.WriteLine("Search name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Searching for Assets... start at " + DateTime.Now.ToString("h:mm:ss tt"));
                    Task.WaitAll(Task.Factory.StartNew(() => SearchForSpecificName(name)));
                    Console.WriteLine("Done with searching, press ENTER to continue");
                }
                Console.ReadLine();
            }
        }

        static void SearchForModels(int index, string BeforeRandom, string AfterRandom)
        {
            while (true)
            {
                CheckModelName(BeforeRandom + GetNumberToString(index).ToLower().Replace("@", "_") + AfterRandom);
                index += 3;
            }
        }

        static void SearchForAnims(int index, string BeforeRandom, string AfterRandom)
        {
            while (true)
            {
                CheckAnimName(BeforeRandom + GetNumberToString(index).ToLower().Replace("@", "_") + AfterRandom);
                index += 3;
            }
        }

        static void SearchForSpecificGun(string specificGun)
        {
            string[] animTypes = AnimTypes;
            Array.Sort(animTypes, StringComparer.InvariantCulture);
            foreach (string animVariant in AnimVariants)
            {
                foreach (string animType in animTypes)
                {
                    CheckAnimName("vm_" + specificGun + animVariant + animType, true);
                }
            }
            foreach (string modelType in ModelTypes)
            {
                CheckModelName("wpn_t8_" + specificGun + modelType);
            }
            foreach (string attachmentVariant in AttachmentVariants)
            {
                CheckModelName("attach_t8_" + specificGun + attachmentVariant + "_view");
                CheckModelName("attach_t8_" + specificGun + attachmentVariant + "_world");
                for (int i = 0; i < 6; ++i)
                {
                    CheckModelName("attach_t8_" + specificGun + attachmentVariant + "_0" + i + "_view");
                    CheckModelName("attach_t8_" + specificGun + attachmentVariant + "_0" + i + "_world");
                }
            }
        }

        static void SearchForSpecificName(string SpecificName)
        {
            CheckModelName(SpecificName);
            CheckAnimName(SpecificName);
        }

        static void CheckModelName(string modelName)
        {
            string hashName = string.Format("{0:x}", HashUtil.Hash(modelName));
            if (Directory.Exists(greyhoundExportFolder + "\\xmodels\\xmodel_" + hashName + "\\"))
            {
                Console.WriteLine("Found asset: {0:x}", modelName.PadRight(40) + hashName);
                File.AppendAllText(greyhoundExportFolder + "\\ModelsFound.txt", hashName + "," + modelName + Environment.NewLine);
            }
        }

        static void CheckAnimName(string animName, Boolean patchAnim = false)
        {
            string hashName = string.Format("{0:x}", HashUtil.Hash(animName));
            string hashFilePath = greyhoundExportFolder + "\\xanims\\xanim_" + hashName + ".seanim";
            if (File.Exists(hashFilePath))
            {
                Console.WriteLine("Found asset: {0:x}", animName.PadRight(40) + hashName);
                File.AppendAllText(greyhoundExportFolder + "\\AnimsFound.txt", hashName + "," + animName + Environment.NewLine);
                string destFileName = greyhoundExportFolder + "\\xanims\\" + animName + ".seanim";
                File.Copy(hashFilePath, destFileName, true);
                if (patchAnim)
                {
                    SEAnim seAnim = SEAnim.Read(destFileName);
                    seAnim.AnimType = AnimationType.Absolute;
                    seAnim.AnimationBoneModifiers["tag_weapon"] = AnimationType.Relative;
                    seAnim.AnimationBoneModifiers["tag_weapon_le"] = AnimationType.Relative;
                    seAnim.Write(destFileName, false);
                }
            }
        }

        static string GetNumberToString(long index)
        {
            string str = "";
            while (index > 0)
            {
                str = GetNumberToChar(index % 37) + str;
                index /= 37;
            }
            return str;
        }

        static string GetNumberToChar(long index)
        {
            if (index < 27)
                return char.ConvertFromUtf32(64 + (int)index);
            if (index < 37)
                return (index - 27).ToString();
            return index == 37 ? "_" : "";
        }
    }
}
