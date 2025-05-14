// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Media;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;
using System.Net;
using System.Reflection.Metadata;
using System.Threading;
using System.Configuration;
using System.Drawing;
using System.Linq;
using static ConsoleHelper;
using System.Windows.Forms;

Console.Title = "Запиздоха!";

string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "zapizdoha.dll.config");

if (!File.Exists(configFilePath))
{
    // cоздание файла конфигурации
    using (StreamWriter conf_file = new StreamWriter(configFilePath))
    {
        conf_file.WriteLine(@"<?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
	<appSettings>
		<add key=""DLC_1"" value="""" />
		<add key=""DLC_2"" value="""" />
		<add key=""DLC_3"" value="""" />
		<add key=""DLC_4"" value="""" />
		<add key=""DLC_5"" value="""" />
		<add key=""DLC_6"" value="""" />
		<add key=""insetup"" value=""0"" />
		<add key=""fullscreen"" value=""1"" />
		<add key=""fontsize"" value=""16"" />
		<add key=""theme"" value=""dark"" />
		<add key=""user_foreground_color_1"" value=""15"" />
		<add key=""user_foreground_color_2"" value=""8"" />
		<add key=""music"" value=""1"" />
		<add key=""sound"" value=""1"" />
		<add key=""end_1"" value="""" />
		<add key=""end_2"" value="""" />
		<add key=""end_3"" value="""" />
		<add key=""end_4"" value="""" />
		<add key=""end_5"" value="""" />
		<add key=""end_6"" value="""" />
		<add key=""end_7"" value="""" />
		<add key=""end_8"" value="""" />
		<add key=""end_9"" value="""" />
		<add key=""end_10"" value="""" />
		<add key=""end_11"" value="""" />
		<add key=""end_12"" value="""" />
		<add key=""end_13"" value="""" />
		<add key=""end_14"" value="""" />
		<add key=""end_15"" value="""" />
		<add key=""end_16"" value="""" />
		<add key=""end_17"" value="""" />
		<add key=""end_18"" value="""" />
		<add key=""end_19"" value="""" />
		<add key=""end_20"" value="""" />
		<add key=""end_21"" value="""" />
		<add key=""end_22"" value="""" />
		<add key=""end_23"" value="""" />
		<add key=""end_24"" value="""" />
		<add key=""end_25"" value="""" />
		<add key=""end_26"" value="""" />
		<add key=""end_27"" value="""" />
		<add key=""end_28"" value="""" />
		<add key=""end_29"" value="""" />
		<add key=""end_30"" value="""" />
		<add key=""end_31"" value="""" />
		<add key=""end_32"" value="""" />
		<add key=""end_33"" value="""" />
		<add key=""end_34"" value="""" />
		<add key=""end_35"" value="""" />
		<add key=""end_36"" value="""" />
		<add key=""end_37"" value="""" />
		<add key=""end_38"" value="""" />
		<add key=""end_39"" value="""" />
		<add key=""end_40"" value="""" />
		<add key=""end_41"" value="""" />
		<add key=""end_42"" value="""" />
		<add key=""end_43"" value="""" />
		<add key=""end_44"" value="""" />
		<add key=""end_45"" value="""" />
		<add key=""end_46"" value="""" />
		<add key=""end_47"" value="""" />
		<add key=""end_48"" value="""" />
		<add key=""end_49"" value="""" />
		<add key=""end_50"" value="""" />
		<add key=""end_51"" value="""" />
		<add key=""end_52"" value="""" />
		<add key=""end_53"" value="""" />
		<add key=""end_54"" value="""" />
		<add key=""end_55"" value="""" />
		<add key=""end_56"" value="""" />
		<add key=""end_57"" value="""" />
		<add key=""end_58"" value="""" />
		<add key=""end_59"" value="""" />
		<add key=""end_60"" value="""" />
		<add key=""end_61"" value="""" />
		<add key=""end_62"" value="""" />
		<add key=""end_63"" value="""" />
		<add key=""end_64"" value="""" />
		<add key=""end_65"" value="""" />
		<add key=""end_66"" value="""" />
		<add key=""end_67"" value="""" />
		<add key=""end_68"" value="""" />
		<add key=""end_69"" value="""" />
		<add key=""end_70"" value="""" />
		<add key=""end_71"" value="""" />
		<add key=""end_72"" value="""" />
		<add key=""end_73"" value="""" />
		<add key=""end_74"" value="""" />
		<add key=""end_75"" value="""" />
		<add key=""end_76"" value="""" />
		<add key=""end_77"" value="""" />
		<add key=""end_78"" value="""" />
		<add key=""end_79"" value="""" />
		<add key=""end_80"" value="""" />
		<add key=""end_81"" value="""" />
		<add key=""end_82"" value="""" />
		<add key=""end_83"" value="""" />
		<add key=""end_84"" value="""" />
		<add key=""end_85"" value="""" />
		<add key=""end_86"" value="""" />
		<add key=""end_87"" value="""" />
		<add key=""end_88"" value="""" />
		<add key=""end_89"" value="""" />
		<add key=""end_90"" value="""" />
		<add key=""end_91"" value="""" />
		<add key=""end_92"" value="""" />
		<add key=""end_93"" value="""" />
		<add key=""end_94"" value="""" />
		<add key=""end_95"" value="""" />
		<add key=""end_96"" value="""" />
		<add key=""end_97"" value="""" />
		<add key=""end_98"" value="""" />
		<add key=""end_99"" value="""" />
		<add key=""end_100"" value="""" />
		<add key=""end_101"" value="""" />
		<add key=""end_102"" value="""" />
		<add key=""end_103"" value="""" />
		<add key=""end_104"" value="""" />
		<add key=""end_105"" value="""" />
		<add key=""end_106"" value="""" />
		<add key=""end_107"" value="""" />
		<add key=""end_108"" value="""" />
		<add key=""end_109"" value="""" />
		<add key=""end_110"" value="""" />
		<add key=""end_111"" value="""" />
		<add key=""end_112"" value="""" />
		<add key=""end_113"" value="""" />
		<add key=""end_114"" value="""" />
		<add key=""end_115"" value="""" />
		<add key=""end_116"" value="""" />
		<add key=""end_117"" value="""" />
		<add key=""end_118"" value="""" />
		<add key=""end_119"" value="""" />
		<add key=""end_120"" value="""" />
		<add key=""end_121"" value="""" />
		<add key=""end_122"" value="""" />
		<add key=""end_123"" value="""" />
		<add key=""end_124"" value="""" />
		<add key=""end_125"" value="""" />
		<add key=""end_126"" value="""" />
		<add key=""end_127"" value="""" />
		<add key=""end_128"" value="""" />
		<add key=""end_129"" value="""" />
		<add key=""end_130"" value="""" />
		<add key=""end_131"" value="""" />
		<add key=""end_132"" value="""" />
		<add key=""end_133"" value="""" />
		<add key=""end_134"" value="""" />
		<add key=""end_135"" value="""" />
		<add key=""end_136"" value="""" />
		<add key=""end_137"" value="""" />
		<add key=""end_138"" value="""" />
		<add key=""end_139"" value="""" />
		<add key=""end_140"" value="""" />
		<add key=""end_141"" value="""" />
		<add key=""end_142"" value="""" />
		<add key=""end_143"" value="""" />
		<add key=""end_144"" value="""" />
		<add key=""end_145"" value="""" />
		<add key=""end_146"" value="""" />
		<add key=""end_147"" value="""" />
		<add key=""end_148"" value="""" />
		<add key=""end_149"" value="""" />
		<add key=""end_150"" value="""" />
		<add key=""end_151"" value="""" />
		<add key=""end_152"" value="""" />
		<add key=""end_153"" value="""" />
		<add key=""end_154"" value="""" />
		<add key=""end_155"" value="""" />
		<add key=""end_156"" value="""" />
	</appSettings>
</configuration>
");
    }
    //Console.WriteLine($"Файл конфигурации создан: {configFilePath}");
}
else
{
    //Console.WriteLine($"Файл конфигурации уже существует: {configFilePath}");
}

string conf_end_1 = ConfigurationManager.AppSettings["end_1"];
string conf_end_2 = ConfigurationManager.AppSettings["end_2"];
string conf_end_3 = ConfigurationManager.AppSettings["end_3"];
string conf_end_4 = ConfigurationManager.AppSettings["end_4"];
string conf_end_5 = ConfigurationManager.AppSettings["end_5"];
string conf_end_6 = ConfigurationManager.AppSettings["end_6"];
string conf_end_7 = ConfigurationManager.AppSettings["end_7"];
string conf_end_8 = ConfigurationManager.AppSettings["end_8"];
string conf_end_9 = ConfigurationManager.AppSettings["end_9"];
string conf_end_10 = ConfigurationManager.AppSettings["end_10"];
string conf_end_11 = ConfigurationManager.AppSettings["end_11"];
string conf_end_12 = ConfigurationManager.AppSettings["end_12"];
string conf_end_13 = ConfigurationManager.AppSettings["end_13"];
string conf_end_14 = ConfigurationManager.AppSettings["end_14"];
string conf_end_15 = ConfigurationManager.AppSettings["end_15"];
string conf_end_16 = ConfigurationManager.AppSettings["end_16"];
string conf_end_17 = ConfigurationManager.AppSettings["end_17"];
string conf_end_18 = ConfigurationManager.AppSettings["end_18"];
string conf_end_19 = ConfigurationManager.AppSettings["end_19"];
string conf_end_20 = ConfigurationManager.AppSettings["end_20"];
string conf_end_21 = ConfigurationManager.AppSettings["end_21"];
string conf_end_22 = ConfigurationManager.AppSettings["end_22"];
string conf_end_23 = ConfigurationManager.AppSettings["end_23"];
string conf_end_24 = ConfigurationManager.AppSettings["end_24"];
string conf_end_25 = ConfigurationManager.AppSettings["end_25"];
string conf_end_26 = ConfigurationManager.AppSettings["end_26"];
string conf_end_27 = ConfigurationManager.AppSettings["end_27"];
string conf_end_28 = ConfigurationManager.AppSettings["end_28"];
string conf_end_29 = ConfigurationManager.AppSettings["end_29"];
string conf_end_30 = ConfigurationManager.AppSettings["end_30"];
string conf_end_31 = ConfigurationManager.AppSettings["end_31"];
string conf_end_32 = ConfigurationManager.AppSettings["end_32"];
string conf_end_33 = ConfigurationManager.AppSettings["end_33"];
string conf_end_34 = ConfigurationManager.AppSettings["end_34"];
string conf_end_35 = ConfigurationManager.AppSettings["end_35"];
string conf_end_36 = ConfigurationManager.AppSettings["end_36"];
string conf_end_37 = ConfigurationManager.AppSettings["end_37"];
string conf_end_38 = ConfigurationManager.AppSettings["end_38"];
string conf_end_39 = ConfigurationManager.AppSettings["end_39"];
string conf_end_40 = ConfigurationManager.AppSettings["end_40"];
string conf_end_41 = ConfigurationManager.AppSettings["end_41"];
string conf_end_42 = ConfigurationManager.AppSettings["end_42"];
string conf_end_43 = ConfigurationManager.AppSettings["end_43"];
string conf_end_44 = ConfigurationManager.AppSettings["end_44"];
string conf_end_45 = ConfigurationManager.AppSettings["end_45"];
string conf_end_46 = ConfigurationManager.AppSettings["end_46"];
string conf_end_47 = ConfigurationManager.AppSettings["end_47"];
string conf_end_48 = ConfigurationManager.AppSettings["end_48"];
string conf_end_49 = ConfigurationManager.AppSettings["end_49"];
string conf_end_50 = ConfigurationManager.AppSettings["end_50"];
string conf_end_51 = ConfigurationManager.AppSettings["end_51"];
string conf_end_52 = ConfigurationManager.AppSettings["end_52"];
string conf_end_53 = ConfigurationManager.AppSettings["end_53"];
string conf_end_54 = ConfigurationManager.AppSettings["end_54"];
string conf_end_55 = ConfigurationManager.AppSettings["end_55"];
string conf_end_56 = ConfigurationManager.AppSettings["end_56"];
string conf_end_57 = ConfigurationManager.AppSettings["end_57"];
string conf_end_58 = ConfigurationManager.AppSettings["end_58"];
string conf_end_59 = ConfigurationManager.AppSettings["end_59"];
string conf_end_60 = ConfigurationManager.AppSettings["end_60"];
string conf_end_61 = ConfigurationManager.AppSettings["end_61"];
string conf_end_62 = ConfigurationManager.AppSettings["end_62"];
string conf_end_63 = ConfigurationManager.AppSettings["end_63"];
string conf_end_64 = ConfigurationManager.AppSettings["end_64"];
string conf_end_65 = ConfigurationManager.AppSettings["end_65"];
string conf_end_66 = ConfigurationManager.AppSettings["end_66"];
string conf_end_67 = ConfigurationManager.AppSettings["end_67"];
string conf_end_68 = ConfigurationManager.AppSettings["end_68"];
string conf_end_69 = ConfigurationManager.AppSettings["end_69"];
string conf_end_70 = ConfigurationManager.AppSettings["end_70"];
string conf_end_71 = ConfigurationManager.AppSettings["end_71"];
string conf_end_72 = ConfigurationManager.AppSettings["end_72"];
string conf_end_73 = ConfigurationManager.AppSettings["end_73"];
string conf_end_74 = ConfigurationManager.AppSettings["end_74"];
string conf_end_75 = ConfigurationManager.AppSettings["end_75"];
string conf_end_76 = ConfigurationManager.AppSettings["end_76"];
string conf_end_77 = ConfigurationManager.AppSettings["end_77"];
string conf_end_78 = ConfigurationManager.AppSettings["end_78"];
string conf_end_79 = ConfigurationManager.AppSettings["end_79"];
string conf_end_80 = ConfigurationManager.AppSettings["end_80"];
string conf_end_81 = ConfigurationManager.AppSettings["end_81"];
string conf_end_82 = ConfigurationManager.AppSettings["end_82"];
string conf_end_83 = ConfigurationManager.AppSettings["end_83"];
string conf_end_84 = ConfigurationManager.AppSettings["end_84"];
string conf_end_85 = ConfigurationManager.AppSettings["end_85"];
string conf_end_86 = ConfigurationManager.AppSettings["end_86"];
string conf_end_87 = ConfigurationManager.AppSettings["end_87"];
string conf_end_88 = ConfigurationManager.AppSettings["end_88"];
string conf_end_89 = ConfigurationManager.AppSettings["end_89"];
string conf_end_90 = ConfigurationManager.AppSettings["end_90"];
string conf_end_91 = ConfigurationManager.AppSettings["end_91"];
string conf_end_92 = ConfigurationManager.AppSettings["end_92"];
string conf_end_93 = ConfigurationManager.AppSettings["end_93"];
string conf_end_94 = ConfigurationManager.AppSettings["end_94"];
string conf_end_95 = ConfigurationManager.AppSettings["end_95"];
string conf_end_96 = ConfigurationManager.AppSettings["end_96"];
string conf_end_97 = ConfigurationManager.AppSettings["end_97"];
string conf_end_98 = ConfigurationManager.AppSettings["end_98"];
string conf_end_99 = ConfigurationManager.AppSettings["end_99"];
string conf_end_100 = ConfigurationManager.AppSettings["end_100"];
string conf_end_101 = ConfigurationManager.AppSettings["end_101"];
string conf_end_102 = ConfigurationManager.AppSettings["end_102"];
string conf_end_103 = ConfigurationManager.AppSettings["end_103"];
string conf_end_104 = ConfigurationManager.AppSettings["end_104"];
string conf_end_105 = ConfigurationManager.AppSettings["end_105"];
string conf_end_106 = ConfigurationManager.AppSettings["end_106"];
string conf_end_107 = ConfigurationManager.AppSettings["end_107"];
string conf_end_108 = ConfigurationManager.AppSettings["end_108"];
string conf_end_109 = ConfigurationManager.AppSettings["end_109"];
string conf_end_110 = ConfigurationManager.AppSettings["end_110"];
string conf_end_111 = ConfigurationManager.AppSettings["end_111"];
string conf_end_112 = ConfigurationManager.AppSettings["end_112"];
string conf_end_113 = ConfigurationManager.AppSettings["end_113"];
string conf_end_114 = ConfigurationManager.AppSettings["end_114"];
string conf_end_115 = ConfigurationManager.AppSettings["end_115"];
string conf_end_116 = ConfigurationManager.AppSettings["end_116"];
string conf_end_117 = ConfigurationManager.AppSettings["end_117"];
string conf_end_118 = ConfigurationManager.AppSettings["end_118"];
string conf_end_119 = ConfigurationManager.AppSettings["end_119"];
string conf_end_120 = ConfigurationManager.AppSettings["end_120"];
string conf_end_121 = ConfigurationManager.AppSettings["end_121"];
string conf_end_122 = ConfigurationManager.AppSettings["end_122"];
string conf_end_123 = ConfigurationManager.AppSettings["end_123"];
string conf_end_124 = ConfigurationManager.AppSettings["end_124"];
string conf_end_125 = ConfigurationManager.AppSettings["end_125"];
string conf_end_126 = ConfigurationManager.AppSettings["end_126"];
string conf_end_127 = ConfigurationManager.AppSettings["end_127"];
string conf_end_128 = ConfigurationManager.AppSettings["end_128"];
string conf_end_129 = ConfigurationManager.AppSettings["end_129"];
string conf_end_130 = ConfigurationManager.AppSettings["end_130"];
string conf_end_131 = ConfigurationManager.AppSettings["end_131"];
string conf_end_132 = ConfigurationManager.AppSettings["end_132"];
string conf_end_133 = ConfigurationManager.AppSettings["end_133"];
string conf_end_134 = ConfigurationManager.AppSettings["end_134"];
string conf_end_135 = ConfigurationManager.AppSettings["end_135"];
string conf_end_136 = ConfigurationManager.AppSettings["end_136"];
string conf_end_137 = ConfigurationManager.AppSettings["end_137"];
string conf_end_138 = ConfigurationManager.AppSettings["end_138"];
string conf_end_139 = ConfigurationManager.AppSettings["end_139"];
string conf_end_140 = ConfigurationManager.AppSettings["end_140"];
string conf_end_141 = ConfigurationManager.AppSettings["end_141"];
string conf_end_142 = ConfigurationManager.AppSettings["end_142"];
string conf_end_143 = ConfigurationManager.AppSettings["end_143"];
string conf_end_144 = ConfigurationManager.AppSettings["end_144"];
string conf_end_145 = ConfigurationManager.AppSettings["end_145"];
string conf_end_146 = ConfigurationManager.AppSettings["end_146"];
string conf_end_147 = ConfigurationManager.AppSettings["end_147"];
string conf_end_148 = ConfigurationManager.AppSettings["end_148"];
string conf_end_149 = ConfigurationManager.AppSettings["end_149"];
string conf_end_150 = ConfigurationManager.AppSettings["end_150"];
string conf_end_151 = ConfigurationManager.AppSettings["end_151"];
string conf_end_152 = ConfigurationManager.AppSettings["end_152"];
string conf_end_153 = ConfigurationManager.AppSettings["end_153"];
string conf_end_154 = ConfigurationManager.AppSettings["end_154"];
string conf_end_155 = ConfigurationManager.AppSettings["end_155"];
string conf_end_156 = ConfigurationManager.AppSettings["end_156"];

string conf_insetup = ConfigurationManager.AppSettings["insetup"];
string conf_fullscreen = ConfigurationManager.AppSettings["fullscreen"];
string conf_fontsize = ConfigurationManager.AppSettings["fontsize"];
string conf_theme = ConfigurationManager.AppSettings["theme"];
string conf_user_foreground_color_1 = ConfigurationManager.AppSettings["user_foreground_color_1"];
string conf_user_foreground_color_2 = ConfigurationManager.AppSettings["user_foreground_color_2"];
string conf_music = ConfigurationManager.AppSettings["music"];
string conf_sound = ConfigurationManager.AppSettings["sound"];


[DllImport("kernel32.dll", ExactSpelling = true)]
static extern IntPtr GetConsoleWindow();

[DllImport("User32.dll", CharSet = CharSet.Auto)]
static extern bool PostMessage(IntPtr hWnd, int Msg,
                                         IntPtr wParam, IntPtr lParam);

const int WM_KEYDOWN = 0x0100;
const int VK_F11 = 0x7A;


if (conf_fullscreen == "1")
{
    IntPtr handle = GetConsoleWindow();
    PostMessage(handle, WM_KEYDOWN, (IntPtr)VK_F11, IntPtr.Zero);
}

ConsoleKeyInfo KeyOtvet;
Console.OutputEncoding = Encoding.UTF8;
int keyInt = 0;
short int_conf_fontsize;

if (short.TryParse(conf_fontsize, out int_conf_fontsize))
{
    int_conf_fontsize = Convert.ToInt16(conf_fontsize);
}
else
{
    int_conf_fontsize = 16;
    conf_fontsize = "16";
    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    config.AppSettings.Settings["fontsize"].Value = conf_fontsize;
    config.Save(ConfigurationSaveMode.Modified);

    ConfigurationManager.RefreshSection("appSettings");
}

if (conf_insetup != "1")
{
    Insetup();
}

ConsoleColor black_text;
ConsoleColor user_foreground_color_1;
ConsoleColor user_foreground_color_2;
ConsoleColor ending_text;
int int_user_foreground_color_1;
int int_user_foreground_color_2;
bool music_value;
bool sound_value;

ConsoleHelper.SetCurrentFont("Consolas", int_conf_fontsize);
if (conf_theme == "light")
{
    conf_theme = "light";
    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    config.AppSettings.Settings["theme"].Value = conf_theme;
    config.Save(ConfigurationSaveMode.Modified);

    ConfigurationManager.RefreshSection("appSettings");

    Console.BackgroundColor = ConsoleColor.White;
    user_foreground_color_1 = ConsoleColor.Black;
    user_foreground_color_2 = ConsoleColor.Black;
    ending_text = ConsoleColor.DarkYellow;
    black_text = ConsoleColor.Black;
}
else if (conf_theme == "dark")
{
    conf_theme = "dark";
    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    config.AppSettings.Settings["theme"].Value = conf_theme;
    config.Save(ConfigurationSaveMode.Modified);

    ConfigurationManager.RefreshSection("appSettings");
    Console.BackgroundColor = ConsoleColor.Black;
    user_foreground_color_1 = ConsoleColor.White;
    user_foreground_color_2 = ConsoleColor.White;
    ending_text = ConsoleColor.Yellow;
    black_text = ConsoleColor.White;
}
else
{
    conf_theme = "dark";
    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    config.AppSettings.Settings["theme"].Value = conf_theme;
    config.Save(ConfigurationSaveMode.Modified);

    ConfigurationManager.RefreshSection("appSettings");
    Console.BackgroundColor = ConsoleColor.Black;
    conf_user_foreground_color_1 = "0";
    var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
    config1.Save(ConfigurationSaveMode.Modified);

    ConfigurationManager.RefreshSection("appSettings");
    user_foreground_color_1 = ConsoleColor.White;
    conf_user_foreground_color_2 = "0";
    var config2 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    config2.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
    config2.Save(ConfigurationSaveMode.Modified);

    ConfigurationManager.RefreshSection("appSettings");
    user_foreground_color_2 = ConsoleColor.White;
    ending_text = ConsoleColor.Yellow;
    black_text = ConsoleColor.White;
}

switch (conf_user_foreground_color_1)
{
    case "0":
        user_foreground_color_1 = ConsoleColor.Black;
        if (conf_theme == "dark")
        {
            conf_user_foreground_color_1 = "1";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_1 = ConsoleColor.White;
        }
        break;
    case "1":
        user_foreground_color_1 = ConsoleColor.White;
        if (conf_theme == "light")
        {
            conf_user_foreground_color_1 = "0";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_1 = ConsoleColor.Black;
        }
        break;
    case "2":
        user_foreground_color_1 = ConsoleColor.DarkGray;
        break;
    case "3":
        user_foreground_color_1 = ConsoleColor.DarkBlue;
        break;
    case "4":
        user_foreground_color_1 = ConsoleColor.DarkGreen;
        break;
    case "5":
        user_foreground_color_1 = ConsoleColor.DarkCyan;
        break;
    case "6":
        user_foreground_color_1 = ConsoleColor.DarkRed;
        break;
    case "7":
        user_foreground_color_1 = ConsoleColor.DarkMagenta;
        break;
    case "8":
        user_foreground_color_1 = ConsoleColor.DarkYellow;
        break;
    case "9":
        user_foreground_color_1 = ConsoleColor.DarkGray;
        break;
    case "10":
        user_foreground_color_1 = ConsoleColor.Blue;
        break;
    case "11":
        user_foreground_color_1 = ConsoleColor.Green;
        break;
    case "12":
        user_foreground_color_1 = ConsoleColor.Cyan;
        break;
    case "13":
        user_foreground_color_1 = ConsoleColor.Red;
        break;
    case "14":
        user_foreground_color_1 = ConsoleColor.Magenta;
        break;
    case "15":
        user_foreground_color_1 = ConsoleColor.Yellow;
        if (conf_theme == "light")
        {
            conf_user_foreground_color_1 = "0";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_1 = ConsoleColor.Black;
        }
        break;
    default:
        if (conf_theme == "dark")
        {
            conf_user_foreground_color_1 = "1";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_1 = ConsoleColor.White;
        }
        else if (conf_theme == "light")
        {
            conf_user_foreground_color_1 = "0";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_1 = ConsoleColor.Black;
        }
        break;
}
switch (conf_user_foreground_color_2)
{
    case "0":
        user_foreground_color_2 = ConsoleColor.Black;
        if (conf_theme == "dark")
        {
            conf_user_foreground_color_2 = "1";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_2 = ConsoleColor.White;
        }
        break;
    case "1":
        user_foreground_color_2 = ConsoleColor.White;
        if (conf_theme == "light")
        {
            conf_user_foreground_color_2 = "0";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_2 = ConsoleColor.Black;
        }
        break;
    case "2":
        user_foreground_color_2 = ConsoleColor.DarkGray;
        break;
    case "3":
        user_foreground_color_2 = ConsoleColor.DarkBlue;
        break;
    case "4":
        user_foreground_color_2 = ConsoleColor.DarkGreen;
        break;
    case "5":
        user_foreground_color_2 = ConsoleColor.DarkCyan;
        break;
    case "6":
        user_foreground_color_2 = ConsoleColor.DarkRed;
        break;
    case "7":
        user_foreground_color_2 = ConsoleColor.DarkMagenta;
        break;
    case "8":
        user_foreground_color_2 = ConsoleColor.DarkYellow;
        break;
    case "9":
        user_foreground_color_2 = ConsoleColor.DarkGray;
        break;
    case "10":
        user_foreground_color_2 = ConsoleColor.Blue;
        break;
    case "11":
        user_foreground_color_2 = ConsoleColor.Green;
        break;
    case "12":
        user_foreground_color_2 = ConsoleColor.Cyan;
        break;
    case "13":
        user_foreground_color_2 = ConsoleColor.Red;
        break;
    case "14":
        user_foreground_color_2 = ConsoleColor.Magenta;
        break;
    case "15":
        user_foreground_color_2 = ConsoleColor.Yellow;
        if (conf_theme == "light")
        {
            conf_user_foreground_color_2 = "0";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_2 = ConsoleColor.Black;
        }
        break;
    default:
        if (conf_theme == "dark")
        {
            conf_user_foreground_color_2 = "1";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_2 = ConsoleColor.White;
        }
        else if (conf_theme == "light")
        {
            conf_user_foreground_color_2 = "0";
            var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
            config1.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            user_foreground_color_2 = ConsoleColor.Black;
        }
        break;
}

if (conf_music == "0")
{
    music_value = false;
}
else if (conf_music == "1")
{
    music_value = true;
}
else
{
    Console.WriteLine("Вкл.");
    conf_music = "1";
    music_value = true;
    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    config.AppSettings.Settings["music"].Value = conf_music;
    config.Save(ConfigurationSaveMode.Modified);

    ConfigurationManager.RefreshSection("appSettings");
}


if (conf_sound == "0")
{
    sound_value = false;
}
else if (conf_sound == "1")
{
    sound_value = true;
}
else
{
    conf_sound = "1";
    sound_value = true;
    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    config.AppSettings.Settings["sound"].Value = conf_sound;
    config.Save(ConfigurationSaveMode.Modified);

    ConfigurationManager.RefreshSection("appSettings");
}

[DllImport("user32.dll")]
static extern short GetAsyncKeyState(int vKey);

const int VK_F4 = 0x73;
const int VK_ALT = 0x12;

Thread keyListenerThread;
void CheckAltF4()
{
    while (true)
    {
        if ((GetAsyncKeyState(VK_ALT) & 0x8000) != 0 &&
            (GetAsyncKeyState(VK_F4) & 0x8000) != 0)
        {
            if (music_value)
            {
                foreach (Process proc in Process.GetProcessesByName("music_zapizdoha.bin"))
                {
                    proc.Kill();
                }
            }
            foreach (Process proc in Process.GetProcessesByName("zapizdoha"))
            {
                proc.Kill();
            }
            SendKeys.SendWait("%{F4}"); ;
        }
    }
}


Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(@"
  ████████▄   ▄█     ▄████████  ▄████████  ▄█          ▄████████  ▄█    ▄▄▄▄███▄▄▄▄      ▄████████    ▄████████ 
  ███   ▀███ ███    ███    ███ ███    ███ ███         ███    ███ ███  ▄██▀▀▀███▀▀▀██▄   ███    ███   ███    ███ 
  ███    ███ ███▌   ███    █▀  ███    █▀  ███         ███    ███ ███▌ ███   ███   ███   ███    █▀    ███    ███ 
  ███    ███ ███▌   ███        ███        ███         ███    ███ ███▌ ███   ███   ███  ▄███▄▄▄      ▄███▄▄▄▄██▀ 
  ███    ███ ███▌ ▀███████████ ███        ███       ▀███████████ ███▌ ███   ███   ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   
  ███    ███ ███           ███ ███    █▄  ███         ███    ███ ███  ███   ███   ███   ███    █▄  ▀███████████ 
  ███   ▄███ ███     ▄█    ███ ███    ███ ███▌    ▄   ███    ███ ███  ███   ███   ███   ███    ███   ███    ███ 
  ████████▀  █▀    ▄████████▀  ████████▀  █████▄▄██   ███    █▀  █▀    ▀█   ███   █▀    ██████████   ███    ███ 
                                          ▀                                                          ███    ███
                                  ");
Console.ForegroundColor = black_text;
Console.WriteLine(@"

    Данная игра полностью является художественным вымыслом. Любые совпадения с реальными людьми, событиями или
  местами совершенно случайны и не имеют намеренного характера, у игры нет цели оскорбить/высмеять чувства
  верующих, власть, ветеранов, инвалидов и др. социальные группы/меньшинства. Все персонажи, представленные в
  игре, являются совершеннолетними и не имеют реальных прототипов.

    Игра содержит ненормативную лексику, постельные сцены, наготу, сцены убийств, сцены насилия, сцены
  с запрещенными веществами, сцены с алкоголем, сцены с табакокурением, и ориентирована для лиц, достигших
  совершеннолетия, в России этот возраст составляет 18 лет (18+). Лицам недостигшим этого возраста допуск к игре
  осуществляется только в присутствии родителей/опекунов.

    Мы против насилия, наркотиков, алкоголя и табака. Мы настоятельно просим не повторять увиденное/прочитанное
  в этой игре, мы не несем ответственности за возможные последствия, связанные с игрой, а также за интерпретацию
  её содержания игроками.

    Продолжая игру, вы подтверждаете, что ознакомлены с этим дисклеймером и соглашаетесь с его условиями.


    Для продолжения нажмите любую клавишу.");

Console.ReadKey();

Console.Clear();
Console.WriteLine(@"
                                                Напутствие
    Это кривая игра на кривом движке и создавал я её от нехуй делать под бутылку балтики девятки, посему качество
  ""продукта"" - полная хуйня. Тот факт что она закончена и увидела свет, не иначе как чудо. Эта срань может не
  зайти и не зайдет тебе, по причине: скучный геймплей несмешно много буков. Если же по какой-то неведомой причине
  решительность поиграть усилилась, то приготовься пожирать килотонны дерьма без удовольствия, так как даже я,
  создатель, считаю это абсолютным безыдейным и бестолковым мусором, который создавался по шаблону ""мама не
  хотела, папа не старался"".

    Напоследок хочу выразить огромную благодарность анону Ежеча, а также отдельное спасибо Куклобунту и в частности
  Оператору ПВД (Как бы я к нему не относился, он заслуживает большого уважения) за создание такой замечательной
  борды, ведь если бы не все вы, я бы окончательно забил хуй на сие подзалупное творожение.


















    Для продолжения нажмите любую клавишу.");
Console.ReadKey();

bool stopAnimation = false;

SoundPlayer zvuk1 = new SoundPlayer("zvuk1.wav");
SoundPlayer zvuk2 = new SoundPlayer("zvuk2.wav");
SoundPlayer zvuk3 = new SoundPlayer("zvuk3.wav");
SoundPlayer zvuk4 = new SoundPlayer("zvuk4.wav");
SoundPlayer zvuk7 = new SoundPlayer("zvuk7.wav");
SoundPlayer zvuk8 = new SoundPlayer("zvuk8.wav");
SoundPlayer zvuk9 = new SoundPlayer("zvuk9.wav");

//гонки
Thread formThread = new Thread(Gonki_Upravlenie_Forms);

int trackLength = 50;

ConsoleColor enemyColor1;
ConsoleColor enemyColor2;

Random rnd_color = new Random();
string roadMarkings = "  -  -  -  -  -  -";

int player2SpeedCounter = 0;




//Оператор
bool oper_dovolen = true; // настроение опера в зависимости как ты проник в кабинку
bool tualet_byl_li = false; // переменная отвечающая за то, был ли гг уже в туалете или нет.
bool oper_byl_li = false; // переменная отвечающая за то, был ли гг уже у оператора или нет.
int op_quest_zad = 0;
int op_quest_mud = 0;
int op_quest_prohodimcy = 0;
int op_quest_ataka = 0;
int op_quest_zadanie = 0;
int operator_secret_end = 0;

bool kuhnya_byl_li = false;

//Река, пляж, лес
bool zagar_byl_li = false;
bool reka_end = false;
bool reka_podumat = true;
bool reka_poplavat = true;
bool reka_zabluditsa = true;
bool reka_zagar = true;

//Рэмбо
int R_quest_cel = 0;
int R_quest_fed = 0;
int R_quest_vet = 0;
int R_quest_yes = 0;
int R_quest_DALSHE = 0;
int Rambo_pobil = 0;

bool future_trans = false;
int zhiguli_zavedenie = 0;
bool zhiguli_Y = false; 
bool zhiguli_F = false;
bool zhiguli_Z = false;
bool zhiguli_kapot = false;
bool car = false;
string car_str = "";
int Red_Alert = 0;
int tea = 0; //чай президента
int pol = 0; // направление политики -либ +конс
bool par_q_1 = false;
bool par_q_2 = false;
bool par_q_3 = false;
bool par_q_4 = false;
int fighter = 0;// 1-кавказец 2-великан 3-прараб 4-сатана 5-зомби
int vrag_hp = 0;
int u_hp = 20;
int stop_fight = 0;
int u_stop_fight = 0;
bool start_fight = false;
int gigant_love = 0;

//Сатана
int satana = 0;
int satana_int = 0;
bool satana_who = false;
bool satana_x = true; //костыль для диалога с сатаной

//Бизнесмен
int biznessmen = 1;
bool biznesmen_1_byl_li = false;

//разводила
long stavka = 0;
bool trenirovochniy = true;
long rub_razvodila = 500000;

//плакса
bool plaksa_killed = false;
bool plaksa_end_good = true;

//опасный поцык
bool pocyk_1 = true;
bool pocyk_2 = true;

//предметы
bool karty = true;
bool spichki = true; //спички в начале игры
bool pesok = false; //песок в начале игры
bool zaryadka = true; //зарядка в начале игры
bool gold_key = false; //золотой ключ в морге
bool gold_lopata = false; //золотая лопата прораба
bool kolco_vsemogushestva = false; //кольцо всемогущества
bool odejda = true; // одежда главного героя
int vid_odejdy = 0; // 0 - лохмотья
                    // 1 - смокинг
                    // 2 - халат

bool povareshka = false; //поварешка чтобы приготовить борщ на Kuhnya()
int povareshka_int = 0;

long rubli = 0; // количество рублей у гг

//камень ножницы бумага
int knb_wins_all = 0;
int u_wins = 0;
int vrag_wins = 0;
int u_zhest = 0;
int vrag_zhest = 0; //1-камень 2-ножницы 3-бумага 4-ящерица 5-спок
string name_knb = "";
string name_zhest_vrag = "";
string name_zhest_u = "";
string knb_znak = "";

int mine = 0;

bool nachalo_byl_li = false;

//дежавю
bool deja_1 = false;
bool deja_2 = false;
bool deja_3 = false;

//лабиринт бункера
int pred_komnata = 1;

bool gor_step = false; //горящая степь

int vkus_borsha = 0; //вкус борща

int hod_pasyans = 0;

bool Norilsk_Secret_1 = false;
bool Norilsk_Secret_2 = false;
bool Norilsk_Secret_3 = false;

 //зомби апокалипсис
int zombi_lvl = 0;
int zombi_xp = 0;
bool megapulemet_jiv = true;
bool vertolet_li = true;
int vertolet_end = 0;
int qte_score = 0;

//technology
int black_vhod = 0;
bool kod_1 = false;
bool sloman_shattl = false;
bool alkash_ushel = false;

bool idiot = false;

Console.Clear();
Thread.Sleep(200);

        // массив кадров анимки лого
        string[] frames = new string[]
        {
            @"

   :~""""""88hx.
 .~      ?888x
 X       '8888k
   H8h    8888X
  ?888~   8888
   %X   .X8*""
   .-""``""tnx.
  :~      8888.
  ~       X8888
 ...      '8888L
'888k     '8888f
 8888>    <8888
 `888>    X888~
  '""88...x8""""
            ",
            @"
                            
   :~""""""88hx.                                                                                                         
 .~      ?888x                 
 X       '8888k        u     
   H8h    8888X     us888u.  
  ?888~   8888   .@88 ""8888""  
   %X   .X8*""    9888  9888   
   .-""``""tnx.    9888  9888   
  :~      8888.  9888  9888   
  ~       X8888  9888  9888   
 ...      '8888L ""888*""""888""    
'888k     '8888f  ^Y""   ^Y'                               
 8888>    <8888                                                                         
 `888>    X888~                                                                                     
  '""88...x8""""                                                     
",
        @"
                                                                                                             
   :~""""""88hx.                                                                                                         
 .~      ?888x                  u.    u.    
 X       '8888k        u      x@88k u@88c.  
   H8h    8888X     us888u.  ^""8888""""8888"" 
  ?888~   8888   .@88 ""8888""   8888  888R    
   %X   .X8*""    9888  9888    8888  888R   
   .-""``""tnx.    9888  9888    8888  888R  
  :~      8888.  9888  9888    8888  888R   
  ~       X8888  9888  9888   ""*88*"" 8888"" 
 ...      '8888L ""888*""""888""    """"   'Y""     
'888k     '8888f  ^Y""   ^Y'                             
 8888>    <8888                                                                         
 `888>    X888~                                                                             
  '""88...x8""""                                                        
                                    


",
        @"
                                                                                                                      
   :~""""""88hx.                                                                                                          
 .~      ?888x                  u.    u.      x.    .         
 X       '8888k        u      x@88k u@88c.  .@88k  z88u      
   H8h    8888X     us888u.  ^""8888""""8888"" ~""8888 ^8888     
  ?888~   8888   .@88 ""8888""   8888  888R    8888  888R       
   %X   .X8*""    9888  9888    8888  888R    8888  888R     
   .-""``""tnx.    9888  9888    8888  888R    8888  888R    
  :~      8888.  9888  9888    8888  888R    8888 ,888B .   
  ~       X8888  9888  9888   ""*88*"" 8888""  ""8888Y 8888""  
 ...      '8888L ""888*""""888""    """"   'Y""     `Y""   'YP
'888k     '8888f  ^Y""   ^Y'                              
 8888>    <8888                                                                               
 `888>    X888~                                                                          
  '""88...x8""""                                                     
                                                    


",
        @"
                                                                                                                      
   :~""""""88hx.                                                                         
 .~      ?888x                  u.    u.      x.    .          ..                     
 X       '8888k        u      x@88k u@88c.  .@88k  z88u      .@88i       
   H8h    8888X     us888u.  ^""8888""""8888"" ~""8888 ^8888     """"%888>  
  ?888~   8888   .@88 ""8888""   8888  888R    8888  888R       '88% 
   %X   .X8*""    9888  9888    8888  888R    8888  888R     ..dILr~`
   .-""``""tnx.    9888  9888    8888  888R    8888  888R    '"".-%88b 
  :~      8888.  9888  9888    8888  888R    8888 ,888B .   @  '888k
  ~       X8888  9888  9888   ""*88*"" 8888""  ""8888Y 8888""   8F   8888
 ...      '8888L ""888*""""888""    """"   'Y""     `Y""   'YP    '8    8888
'888k     '8888f  ^Y""   ^Y'                               '8    888F 
 8888>    <8888                                            %k  <88F                                     
 `888>    X888~                                             ""+:*%`                                     
  '""88...x8""""                                                       
                                                                        
",
        @"
                                                                                                                       
   :~""""""88hx.                                                                                                        
 .~      ?888x                  u.    u.      x.    .          ..                     
 X       '8888k        u      x@88k u@88c.  .@88k  z88u      .@88i        uL     
   H8h    8888X     us888u.  ^""8888""""8888"" ~""8888 ^8888     """"%888>   .ue888Nc.. 
  ?888~   8888   .@88 ""8888""   8888  888R    8888  888R       '88%   d88E`""888E` 
   %X   .X8*""    9888  9888    8888  888R    8888  888R     ..dILr~` 888E  888E  
   .-""``""tnx.    9888  9888    8888  888R    8888  888R    '"".-%88b  888E  888E  
  :~      8888.  9888  9888    8888  888R    8888 ,888B .   @  '888k 888E  888E 
  ~       X8888  9888  9888   ""*88*"" 8888""  ""8888Y 8888""   8F   8888 888& .888E  
 ...      '8888L ""888*""""888""    """"   'Y""     `Y""   'YP    '8    8888 *888"" 888&   
'888k     '8888f  ^Y""   ^Y'                               '8    888F  `""   ""888E                          
 8888>    <8888                                            %k  <88F  .dWi   `88E                                             
 `888>    X888~                                             ""+:*%`   4888~  J8%                                              
  '""88...x8""""                                                         ^""===*""`
                                                                                


",
        @"
                                                                                                                        
   :~""""""88hx.                                                                                                          
 .~      ?888x                  u.    u.      x.    .          ..                       u.     
 X       '8888k        u      x@88k u@88c.  .@88k  z88u      .@88i        uL      ...ue888b  
   H8h    8888X     us888u.  ^""8888""""8888"" ~""8888 ^8888     """"%888>   .ue888Nc..  888R Y888r
  ?888~   8888   .@88 ""8888""   8888  888R    8888  888R       '88%   d88E`""888E`  888R I888>   
   %X   .X8*""    9888  9888    8888  888R    8888  888R     ..dILr~` 888E  888E   888R I888>    
   .-""``""tnx.    9888  9888    8888  888R    8888  888R    '"".-%88b  888E  888E   888R I888>    
  :~      8888.  9888  9888    8888  888R    8888 ,888B .   @  '888k 888E  888E  u8888cJ888   
  ~       X8888  9888  9888   ""*88*"" 8888""  ""8888Y 8888""   8F   8888 888& .888E   ""*888*P""  
 ...      '8888L ""888*""""888""    """"   'Y""     `Y""   'YP    '8    8888 *888"" 888&     'Y""   
'888k     '8888f  ^Y""   ^Y'                               '8    888F  `""   ""888E                        
 8888>    <8888                                            %k  <88F  .dWi   `88E                                             
 `888>    X888~                                             ""+:*%`   4888~  J8%                                              
  '""88...x8""""                                                         ^""===*""`
                                                                                 


",
        @"
                                                                                                                        
   :~""""""88hx.                                                                                                         
 .~      ?888x                  u.    u.      x.    .          ..                       u.      uL   ..              
 X       '8888k        u      x@88k u@88c.  .@88k  z88u      .@88i        uL      ...ue888b   .@88b  @88R    
   H8h    8888X     us888u.  ^""8888""""8888"" ~""8888 ^8888     """"%888>   .ue888Nc..  888R Y888r '""Y888k/""*P   
  ?888~   8888   .@88 ""8888""   8888  888R    8888  888R       '88%   d88E`""888E`  888R I888>    Y888L   
   %X   .X8*""    9888  9888    8888  888R    8888  888R     ..dILr~` 888E  888E   888R I888>     8888    
   .-""``""tnx.    9888  9888    8888  888R    8888  888R    '"".-%88b  888E  888E   888R I888>     `888N   
  :~      8888.  9888  9888    8888  888R    8888 ,888B .   @  '888k 888E  888E  u8888cJ888   .u./""888&  
  ~       X8888  9888  9888   ""*88*"" 8888""  ""8888Y 8888""   8F   8888 888& .888E   ""*888*P""   d888"" Y888*"" 
 ...      '8888L ""888*""""888""    """"   'Y""     `Y""   'YP    '8    8888 *888"" 888&     'Y""      ` ""Y   Y""   
'888k     '8888f  ^Y""   ^Y'                               '8    888F  `""   ""888E                         
 8888>    <8888                                            %k  <88F  .dWi   `88E                                             
 `888>    X888~                                             ""+:*%`   4888~  J8%                                              
  '""88...x8""""                                                         ^""===*""`
                                                                                


",
        @"
                                                                                                                       
   :~""""""88hx.                                                                                                         
 .~      ?888x                  u.    u.      x.    .          ..                       u.      uL   ..               
 X       '8888k        u      x@88k u@88c.  .@88k  z88u      .@88i        uL      ...ue888b   .@88b  @88R       u    
   H8h    8888X     us888u.  ^""8888""""8888"" ~""8888 ^8888     """"%888>   .ue888Nc..  888R Y888r '""Y888k/""*P     us888u.  
  ?888~   8888   .@88 ""8888""   8888  888R    8888  888R       '88%   d88E`""888E`  888R I888>    Y888L     .@88 ""8888""  
   %X   .X8*""    9888  9888    8888  888R    8888  888R     ..dILr~` 888E  888E   888R I888>     8888     9888  9888    
   .-""``""tnx.    9888  9888    8888  888R    8888  888R    '"".-%88b  888E  888E   888R I888>     `888N    9888  9888   
  :~      8888.  9888  9888    8888  888R    8888 ,888B .   @  '888k 888E  888E  u8888cJ888   .u./""888&   9888  9888      
  ~       X8888  9888  9888   ""*88*"" 8888""  ""8888Y 8888""   8F   8888 888& .888E   ""*888*P""   d888"" Y888*"" 9888  9888   
 ...      '8888L ""888*""""888""    """"   'Y""     `Y""   'YP    '8    8888 *888"" 888&     'Y""      ` ""Y   Y""    ""888*""""888""
'888k     '8888f  ^Y""   ^Y'                               '8    888F  `""   ""888E                           ^Y""   ^Y'   
 8888>    <8888                                            %k  <88F  .dWi   `88E                                             
 `888>    X888~                                             ""+:*%`   4888~  J8%                                              
  '""88...x8""""                                                         ^""===*""`
                                                                                


",
        @"Внимание! Игра работает в режиме бета-тестирования.
                                                                                                                        ..   TM
   :~""""""88hx.                                                                                                          888B. 
 .~      ?888x                  u.    u.      x.    .          ..                       u.      uL   ..               48888E 
 X       '8888k        u      x@88k u@88c.  .@88k  z88u      .@88i        uL      ...ue888b   .@88b  @88R       u     '8888' 
   H8h    8888X     us888u.  ^""8888""""8888"" ~""8888 ^8888     """"%888>   .ue888Nc..  888R Y888r '""Y888k/""*P     us888u.   Y88F  
  ?888~   8888   .@88 ""8888""   8888  888R    8888  888R       '88%   d88E`""888E`  888R I888>    Y888L     .@88 ""8888""  '88   
   %X   .X8*""    9888  9888    8888  888R    8888  888R     ..dILr~` 888E  888E   888R I888>     8888     9888  9888    8F   
   .-""``""tnx.    9888  9888    8888  888R    8888  888R    '"".-%88b  888E  888E   888R I888>     `888N    9888  9888    4    
  :~      8888.  9888  9888    8888  888R    8888 ,888B .   @  '888k 888E  888E  u8888cJ888   .u./""888&   9888  9888    .    
  ~       X8888  9888  9888   ""*88*"" 8888""  ""8888Y 8888""   8F   8888 888& .888E   ""*888*P""   d888"" Y888*"" 9888  9888   u8N.  
 ...      '8888L ""888*""""888""    """"   'Y""     `Y""   'YP    '8    8888 *888"" 888&     'Y""      ` ""Y   Y""    ""888*""""888"" ""*88%  
'888k     '8888f  ^Y""   ^Y'                               '8    888F  `""   ""888E                           ^Y""   ^Y'    """"   
 8888>    <8888                                            %k  <88F  .dWi   `88E                                             
 `888>    X888~                                             ""+:*%`   4888~  J8%                                              
  '""88...x8""""                                                         ^""===*""`
                                                                             тм
                                               М   А   Л   Ь   В   И   Н   А


"};

Console.CursorVisible = false;

Thread inputThread = new Thread(CheckForKeyPress);
inputThread.Start();

// анимация кадров
int topPosition = Console.CursorTop;
foreach (string frame in frames)
{
    if (stopAnimation) // Проверка флага остановки
    {
        Console.SetCursorPosition(0, topPosition); // Устанавливаем курсор в начальную позицию
        Console.Write(frames[frames.Length - 1]); // Вывод последнего кадра
        break;
    }

    Thread.Sleep(130); // Задержка в мс
    Console.SetCursorPosition(0, topPosition); // Устанавливаем курсор в начальную позицию
    if (sound_value){ zvuk1.Play(); }
    Console.Write(frame); // Вывод текущего кадра
}
stopAnimation = true;
inputThread.Join();
Console.CursorVisible = true;

void CheckForKeyPress()
{
    // Проверяем, была ли нажата клавиша
    while (!stopAnimation)
    {
        if (Console.KeyAvailable)
        {
            Console.ReadKey(true); // Считываем клавишу, чтобы очистить буфер ввода
            stopAnimation = true; // Устанавливаем флаг остановки
        }
    }
}

//zvuk1.Play();
if (music_value)
{
    Process.Start("soundtracks/music2_zapizdoha.bin");
}
Main_menu_buttons();

void Insetup()
{
    Console.Clear();
    ConsoleHelper.SetCurrentFont("Consolas", int_conf_fontsize);
    keyInt = 0;
    Console.ForegroundColor = ConsoleColor.Green; Console.Write("<<"); Console.ResetColor(); Console.Write("----------------------------------------------------------------------------------------------------------------------------"); Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine(">>"); Console.ResetColor();
    Console.WriteLine("Первоначальная настройка");
    Console.WriteLine(@"Отрегулируйте стрелками на клавиатуре размер текста так, чтобы зеленые стрелки были максимально близко к краям экрана и их полностью было видно. Когда все отрегулируете, нажмите клавишу Enter.");
    Console.WriteLine(@"
<--| "+ int_conf_fontsize + " |-->");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                if (int_conf_fontsize<72)
                {
                    keyInt++;
                    int_conf_fontsize++;
                    conf_fontsize = int_conf_fontsize.ToString();
                    var config2 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config2.AppSettings.Settings["fontsize"].Value = conf_fontsize;
                    config2.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Insetup();
                }
                break;
            case ConsoleKey.LeftArrow:
                if (int_conf_fontsize > 12)
                {
                    keyInt++;
                    int_conf_fontsize--;
                    conf_fontsize = int_conf_fontsize.ToString();
                    var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config1.AppSettings.Settings["fontsize"].Value = conf_fontsize;
                    config1.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Insetup();
                }
                break;
            case ConsoleKey.Enter:
                keyInt++;
                conf_insetup = "1";
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["insetup"].Value = conf_insetup;
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");

                Process.Start(Process.GetCurrentProcess().MainModule.FileName);
                Console.Clear();
                if (conf_fullscreen == "1")
                {
                    IntPtr handle = GetConsoleWindow();
                    PostMessage(handle, WM_KEYDOWN, (IntPtr)VK_F11, IntPtr.Zero);
                }
                Environment.Exit(0);
                break;

        }
    }
}
void Main_menu()
{
    Console.ForegroundColor = black_text;
    Console.Clear();
    ConsoleHelper.SetCurrentFont("Consolas", int_conf_fontsize);
    Console.WriteLine(@"Внимание! Игра работает в режиме бета-тестирования.
                                                                                                                        ..   TM
   :~""""""88hx.                                                                                                          888B. 
 .~      ?888x                  u.    u.      x.    .          ..                       u.      uL   ..               48888E 
 X       '8888k        u      x@88k u@88c.  .@88k  z88u      .@88i        uL      ...ue888b   .@88b  @88R       u     '8888' 
   H8h    8888X     us888u.  ^""8888""""8888"" ~""8888 ^8888     """"%888>   .ue888Nc..  888R Y888r '""Y888k/""*P     us888u.   Y88F  
  ?888~   8888   .@88 ""8888""   8888  888R    8888  888R       '88%   d88E`""888E`  888R I888>    Y888L     .@88 ""8888""  '88   
   %X   .X8*""    9888  9888    8888  888R    8888  888R     ..dILr~` 888E  888E   888R I888>     8888     9888  9888    8F   
   .-""``""tnx.    9888  9888    8888  888R    8888  888R    '"".-%88b  888E  888E   888R I888>     `888N    9888  9888    4    
  :~      8888.  9888  9888    8888  888R    8888 ,888B .   @  '888k 888E  888E  u8888cJ888   .u./""888&   9888  9888    .    
  ~       X8888  9888  9888   ""*88*"" 8888""  ""8888Y 8888""   8F   8888 888& .888E   ""*888*P""   d888"" Y888*"" 9888  9888   u8N.  
 ...      '8888L ""888*""""888""    """"   'Y""     `Y""   'YP    '8    8888 *888"" 888&     'Y""      ` ""Y   Y""    ""888*""""888"" ""*88%  
'888k     '8888f  ^Y""   ^Y'                               '8    888F  `""   ""888E                           ^Y""   ^Y'    """"   
 8888>    <8888                                            %k  <88F  .dWi   `88E                                             
 `888>    X888~                                             ""+:*%`   4888~  J8%                                              
  '""88...x8""""                                                         ^""===*""`
                                                                             тм
                                               М   А   Л   Ь   В   И   Н   А


");
    Main_menu_buttons();
}
void Main_menu_buttons()
{
    keyInt = 0;
    Console.WriteLine(@"1) Дорога, солнце, жар, безумство.
2) DLC
3) Настройки
4) Достижения
5) Авторы
6) Выход");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.D1:
                keyInt++;
                if (music_value)
                {
                    try
                    {
                        foreach (Process proc in Process.GetProcessesByName("music2_zapizdoha.bin"))
                        {
                            proc.Kill();
                            Process.Start("soundtracks/music_zapizdoha.bin");
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("ОШИБКА " + ex + ": СКРИПТ АУДИО НЕ БЫЛ ПРЕРВАН. ВОЗМОЖНО ОН УЖЕ БЫЛ ЗАВЕРШЕН ИЛИ НЕ БЫЛ ЗАПУЩЕН. ПРОГРАММА НЕ БУДЕТ ЗАВЕРШЕНА.");
                        Console.WriteLine("press any key to continue.");
                        Console.ReadLine();
                    }
                }
                //Gonki();
                keyListenerThread = new Thread(CheckAltF4);
                keyListenerThread.IsBackground = false;
                keyListenerThread.Start();
                Nachalo();
                break;
            case ConsoleKey.D2:
                keyInt++;
                DLC_menu();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Settings_menu();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Achivement_menu();
                break;
            case ConsoleKey.D5:
                keyInt++;
                Autors_menu();
                break;
            case ConsoleKey.D6:
                keyInt++;
                Exit_menu();
                break;
        }
    }
}
void ToMainMenu()
{
    povareshka = false;
    povareshka_int = 0;
    satana = 0;
    satana_int = 0;
    nachalo_byl_li = false;
    if (music_value)
    {
        try
        {
            foreach (Process proc in Process.GetProcessesByName("music_zapizdoha.bin"))
            {
                proc.Kill();
                Process.Start("soundtracks/music2_zapizdoha.bin");
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine("ОШИБКА " + ex + ": СКРИПТ АУДИО НЕ БЫЛ ПРЕРВАН. ВОЗМОЖНО ОН УЖЕ БЫЛ ЗАВЕРШЕН ИЛИ НЕ БЫЛ ЗАПУЩЕН. ПРОГРАММА НЕ БУДЕТ ЗАВЕРШЕНА.");
            Console.WriteLine("press any key to continue.");
            Console.ReadLine();
        }
    }
    Main_menu();
}
void Exit_menu()
{
    Console.Clear();
    keyInt = 0;
    Console.Write(@"                       
        .-----..____,___.....___
        \:`.             _...._ )
         :  )          /     / /
          ;'          ' ;   / :          Уже уходишь...
          )..      .. .:.`.;  :
         /::...  .:::...   ` ;         Y) Да
         ; _/     \_        /:\        N) Нет
         `:");Console.ForegroundColor = ConsoleColor.Blue; Console.Write(@"~~,"); Console.ForegroundColor = black_text; Console.Write(@"  /");Console.ForegroundColor = ConsoleColor.Blue; Console.Write(@",~~~."); Console.ForegroundColor = black_text; Console.Write(@"     ;:. `.
        `-`.__ ;   __..--- /:.   \
        === \_/   ;=====_.':.     ;
         ,/'`--'...`--....        ;
              ;                    ;
            .'                      ;
          .'                        ;
        .'     ..     ,      .       ;
       :       ::..  /      ;::.     |
      /      `.;::.  |       ;:..    ;
     :         |:.   :       ;:.    ;
     :         ::     ;:..   |.    ;
      :       :;      :::....|     |
      /\     ,/ \      ;:::::;     ;
    .:. \:..|    :     ; '.--|     ;
   ::.  :''  `-.,,;     ;'   ;     ;
.-'. _.'\      / `;      \,__:      \
`---'    `----'   ;      /    \,.,,,/
                   `----`              ");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Y:
                keyInt++;
                if (music_value)
                {
                    foreach (Process proc in Process.GetProcessesByName("music2_zapizdoha.bin"))
                    {
                        proc.Kill();
                    }
                }
                foreach (Process proc in Process.GetProcessesByName("zapizdoha"))
                {
                    proc.Kill();
                }
                break;
            case ConsoleKey.N:
                keyInt++;
                Main_menu();
                break;
        }
    }
}
void Autors_menu()
{
    Console.Clear();
    keyInt = 0;
    Console.WriteLine("Код, задумка, текст, диалоги, оформление: Мальвина");
    Console.WriteLine("");
    Console.WriteLine("Название: Батя Мальвины");
    Console.WriteLine("");
    Console.WriteLine("Музыка в главном меню: Пузантос - Каропка");
    Console.WriteLine("Музыка в игре: всех заебавший Kevin MacLeod");
    Console.WriteLine(@"
Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.D1:
                keyInt++;
                Achivement_menu_Ejchan();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Achivement_menu_Endings1();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Main_menu();
                break;
        }
    }
}
void DLC_menu()
{
    Console.Clear();
    keyInt = 0;
    int dlc = 0;
    bool dlc_1 = false;
    bool dlc_2 = false;
    bool dlc_3 = false;
    bool dlc_4 = false;
    bool dlc_5 = false;
    Console.WriteLine("Проверка установленных дополнений...");
    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "dlcs", "hell_yeah7834.bin")))
    {
        dlc++;
        dlc_1 = true;
        //Console.WriteLine("hell_yeah7834.bin найден в папке dlcs!");
    }
    else
    {
        //Console.WriteLine("hell_yeah7834.bin НЕ найден в папке dlcs.");
    }

    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "dlcs", "knights_9354.bin")))
    {
        dlc_2 = true;
        dlc++;
        //Console.WriteLine("knights_9354.bin найден в папке dlcs!");
    }
    else
    {
        //Console.WriteLine("knights_9354.bin НЕ найден в папке dlcs.");
    }

    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "dlcs", "slammer_5239.bin")))
    {
        dlc_3 = true;
        dlc++;
        //Console.WriteLine("slammer_5239.bin найден в папке dlcs!");
    }
    else
    {
       // Console.WriteLine("slammer_5239.bin НЕ найден в папке dlcs.");
    }

    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "dlcs", "spaccce_9247.bin")))
    {
        dlc_4 = true;
        dlc++;
        //Console.WriteLine("spaccce_9247.bin найден в папке dlcs!");
    }
    else
    {
       // Console.WriteLine("spaccce_9247.bin НЕ найден в папке dlcs.");
    }

    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "dlcs", "happy_new_year_05394.bin")))
    {
        dlc_5 = true;
        dlc++;
        //Console.WriteLine("happy_new_year_05394.bin найден в папке dlcs!");
    }
    else
    {
        //Console.WriteLine("happy_new_year_05394.bin НЕ найден в папке dlcs.");
    }
    Console.Clear();
    if (dlc==0)
    {
        Console.WriteLine("Дополнений не установлено :(");
        Console.WriteLine(@"
Esc) Назад");
        while (keyInt <= 0)
        {
            KeyOtvet = Console.ReadKey();
            switch (KeyOtvet.Key)
            {
                case ConsoleKey.P:
                    if (dlc_1)
                    {
                        keyInt++;
                        Process.Start("dlcs/hell_yeah7834.bin");
                    }
                    break;
                case ConsoleKey.I:
                    if (dlc_2)
                    {
                        keyInt++;
                        Process.Start("dlcs/knights_9354.bin");
                    }
                    break;
                case ConsoleKey.Z:
                    if (dlc_3)
                    {
                        keyInt++;
                        Process.Start("dlcs/slammer_5239.bin");
                    }
                    break;
                case ConsoleKey.D:
                    if (dlc_4)
                    {
                        keyInt++;
                        Process.Start("dlcs/spaccce_9247.bin");
                    }
                    break;
                case ConsoleKey.A:
                    if (dlc_5)
                    {
                        keyInt++;
                        Process.Start("dlcs/happy_new_year_05394.bin");
                    }
                    break;
                case ConsoleKey.Escape:
                    keyInt++;
                    Main_menu();
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("Список установленных ДЛС:");
        if (dlc_1)
        {
            Console.WriteLine("p) Невозможные приключения в аду!");
        }
        if (dlc_2)
        {
            Console.WriteLine("i) Мечи и Рыцари");
        }
        if (dlc_3)
        {
            Console.WriteLine("z) Чифирнем?");
        }
        if (dlc_4)
        {
            Console.WriteLine("d) Космоспайс");
        }
        if (dlc_5)
        {
            Console.WriteLine("a) Новогодний спешл");
        }
        Console.WriteLine(@"
Esc) Назад");
        while (keyInt <= 0)
        {
            KeyOtvet = Console.ReadKey();
            switch (KeyOtvet.Key)
            {
                case ConsoleKey.P:
                    keyInt++;
                    Process.Start("dlcs/hell_yeah7834.bin");
                    break;
                case ConsoleKey.I:
                    keyInt++;
                    Process.Start("dlcs/knights_9354.bin");
                    break;
                case ConsoleKey.Z:
                    keyInt++;
                    Process.Start("dlcs/slammer_5239.bin");
                    break;
                case ConsoleKey.D:
                    keyInt++;
                    Process.Start("dlcs/spaccce_9247.bin");
                    break;
                case ConsoleKey.A:
                    keyInt++;
                    Process.Start("dlcs/happy_new_year_05394.bin");
                    break;
                case ConsoleKey.Escape:
                    keyInt++;
                    Main_menu();
                    break;
            }
        }
    }
}
void Settings_menu()
{
    if (idiot)
    {
        zvuk9.Play();
        idiot = false;
    }
    Console.ForegroundColor = black_text;
    ConsoleHelper.SetCurrentFont("Consolas", int_conf_fontsize);
    Console.Clear();
    keyInt = 0;

    Console.Write("1) Полноэкранный режим: ");
    if (conf_fullscreen == "1")
    {
        Console.WriteLine("Вкл.");
    }
    else if (conf_fullscreen == "0")
    {
        Console.WriteLine("Выкл.");
    }

    Console.Write("2) Тема: ");
    if (conf_theme == "dark")
    {
        Console.WriteLine("Тёмная");
    }
    else if (conf_theme == "light")
    {
        Console.WriteLine("Светлая");
    }
    else
    {
        conf_theme = "dark";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["theme"].Value = conf_theme;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        Console.WriteLine("Тёмная");
    }
    Console.Write("3) Цвет текста рассказчика: ");
    switch (conf_user_foreground_color_1)
    {
        case "0":
            user_foreground_color_1 = ConsoleColor.Black;
            break;
        case "1":
            user_foreground_color_1 = ConsoleColor.White;
            break;
        case "2":
            user_foreground_color_1 = ConsoleColor.DarkGray;
            break;
        case "3":
            user_foreground_color_1 = ConsoleColor.DarkBlue;
            break;
        case "4":
            user_foreground_color_1 = ConsoleColor.DarkGreen;
            break;
        case "5":
            user_foreground_color_1 = ConsoleColor.DarkCyan;
            break;
        case "6":
            user_foreground_color_1 = ConsoleColor.DarkRed;
            break;
        case "7":
            user_foreground_color_1 = ConsoleColor.DarkMagenta;
            break;
        case "8":
            user_foreground_color_1 = ConsoleColor.DarkYellow;
            break;
        case "9":
            user_foreground_color_1 = ConsoleColor.DarkGray;
            break;
        case "10":
            user_foreground_color_1 = ConsoleColor.Blue;
            break;
        case "11":
            user_foreground_color_1 = ConsoleColor.Green;
            break;
        case "12":
            user_foreground_color_1 = ConsoleColor.Cyan;
            break;
        case "13":
            user_foreground_color_1 = ConsoleColor.Red;
            break;
        case "14":
            user_foreground_color_1 = ConsoleColor.Magenta;
            break;
        case "15":
            user_foreground_color_1 = ConsoleColor.Yellow;
            if (conf_theme == "light")
            {
                conf_user_foreground_color_1 = "0";
                var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                config1.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                user_foreground_color_1 = ConsoleColor.Black;
            }
            break;
        default:
            if (conf_theme == "dark")
            {
                conf_user_foreground_color_1 = "1";
                var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                config1.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                user_foreground_color_1 = ConsoleColor.White;
            }
            else if (conf_theme == "light")
            {
                conf_user_foreground_color_1 = "0";
                var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                config1.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                user_foreground_color_1 = ConsoleColor.Black;
            }
            break;
    }
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты вышел где-то в джунглях, вокруг ходят какие-то парни в розовых париках... Твои действия?");
    Console.ForegroundColor = black_text;
    Console.Write("4) Цвет текста героя: ");
    switch (conf_user_foreground_color_2)
    {
        case "0":
            user_foreground_color_2 = ConsoleColor.Black;
            break;
        case "1":
            user_foreground_color_2 = ConsoleColor.White;
            break;
        case "2":
            user_foreground_color_2 = ConsoleColor.DarkGray;
            break;
        case "3":
            user_foreground_color_2 = ConsoleColor.DarkBlue;
            break;
        case "4":
            user_foreground_color_2 = ConsoleColor.DarkGreen;
            break;
        case "5":
            user_foreground_color_2 = ConsoleColor.DarkCyan;
            break;
        case "6":
            user_foreground_color_2 = ConsoleColor.DarkRed;
            break;
        case "7":
            user_foreground_color_2 = ConsoleColor.DarkMagenta;
            break;
        case "8":
            user_foreground_color_2 = ConsoleColor.DarkYellow;
            break;
        case "9":
            user_foreground_color_2 = ConsoleColor.DarkGray;
            break;
        case "10":
            user_foreground_color_2 = ConsoleColor.Blue;
            break;
        case "11":
            user_foreground_color_2 = ConsoleColor.Green;
            break;
        case "12":
            user_foreground_color_2 = ConsoleColor.Cyan;
            break;
        case "13":
            user_foreground_color_2 = ConsoleColor.Red;
            break;
        case "14":
            user_foreground_color_2 = ConsoleColor.Magenta;
            break;
        case "15":
            user_foreground_color_2 = ConsoleColor.Yellow;
            if (conf_theme == "light")
            {
                conf_user_foreground_color_2 = "0";
                var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                config1.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                user_foreground_color_2 = ConsoleColor.Black;
            }
            break;
        default:
            if (conf_theme == "dark")
            {
                conf_user_foreground_color_2 = "1";
                var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                config1.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                user_foreground_color_2 = ConsoleColor.White;
            }
            else if (conf_theme == "light")
            {
                conf_user_foreground_color_2 = "0";
                var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                config1.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                user_foreground_color_2 = ConsoleColor.Black;
            }
            break;
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("Почесать муди");
    Console.ForegroundColor = black_text;
    Console.WriteLine("5) Громкость: В винде регулируй");
    Console.Write("6) Музыка: ");
    if (conf_music == "1")
    {
        Console.WriteLine("Вкл.");
    }
    else if (conf_music == "0")
    {
        Console.WriteLine("Выкл.");
    }
    else
    {
        Console.WriteLine("Вкл.");
        conf_music = "1";
        music_value = true;
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["music"].Value = conf_music;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        try
        {
            foreach (Process proc in Process.GetProcessesByName("music2_zapizdoha.bin"))
            {
                proc.Kill();
            }
        }

        catch (Exception ex)
        {

        }
        Process.Start("soundtracks/music2_zapizdoha.bin");
    }
    Console.Write("7) Звуки: ");
    if (conf_sound == "1")
    {
        Console.WriteLine("Вкл.");
    }
    else if (conf_sound == "0")
    {
        Console.WriteLine("Выкл. (Так ты упустишь некоторые приколы)");
    }
    else
    {
        Console.WriteLine("Вкл.");
        conf_sound = "1";
        sound_value = true;
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["sound"].Value = conf_sound;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
    }
    Console.WriteLine("Размер шрифта: <-- |" + conf_fontsize + "| -->");
    Console.WriteLine(@"
Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.D1:
                keyInt++;
                if (conf_fullscreen == "1")
                {
                    IntPtr handle = GetConsoleWindow();
                    PostMessage(handle, WM_KEYDOWN, (IntPtr)VK_F11, IntPtr.Zero);

                    conf_fullscreen = "0";
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["fullscreen"].Value = conf_fullscreen;
                    config.Save(ConfigurationSaveMode.Modified);
                }
                else if (conf_fullscreen == "0")
                {
                    IntPtr handle = GetConsoleWindow();
                    PostMessage(handle, WM_KEYDOWN, (IntPtr)VK_F11, IntPtr.Zero);

                    conf_fullscreen = "1";
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["fullscreen"].Value = conf_fullscreen;
                    config.Save(ConfigurationSaveMode.Modified);
                }
                Settings_menu();
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (conf_theme == "dark")
                {
                    conf_theme = "light";
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["theme"].Value = conf_theme;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Console.BackgroundColor = ConsoleColor.White;
                    conf_user_foreground_color_1 = "0";
                    var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                    config1.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    conf_user_foreground_color_2 = "0";
                    var config2 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config2.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                    config2.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    ending_text = ConsoleColor.DarkYellow;
                    black_text = ConsoleColor.Black;

                    Settings_menu();
                }
                else if (conf_theme == "light")
                {
                    conf_theme = "dark";
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["theme"].Value = conf_theme;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Console.BackgroundColor = ConsoleColor.Black;
                    conf_user_foreground_color_1 = "1";
                    var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                    config1.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    conf_user_foreground_color_2 = "1";
                    var config2 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config2.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                    config2.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    black_text = ConsoleColor.White;
                    ending_text = ConsoleColor.Yellow;
                    Settings_menu();
                }
                else
                {
                    conf_theme = "dark";
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["theme"].Value = conf_theme;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Console.BackgroundColor = ConsoleColor.Black;
                    conf_user_foreground_color_1 = "1";
                    var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                    config1.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    user_foreground_color_1 = ConsoleColor.White;
                    conf_user_foreground_color_2 = "1";
                    var config2 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config2.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                    config2.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    user_foreground_color_2 = ConsoleColor.White;
                    black_text = ConsoleColor.White;
                    ending_text = ConsoleColor.Yellow;
                    Settings_menu();
                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                if (int.TryParse(conf_user_foreground_color_1, out int_user_foreground_color_1))
                {
                    int_user_foreground_color_1 = Convert.ToInt32(conf_user_foreground_color_1);
                    if (int_user_foreground_color_1>=15 || int_user_foreground_color_1<0)
                    {
                        int_user_foreground_color_1 = 0;
                        if (conf_theme == "dark")
                        {
                            int_user_foreground_color_1 = 1;
                        }
                        conf_user_foreground_color_1 = int_user_foreground_color_1.ToString();
                        var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                        config1.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                    }
                    else
                    {
                        int_user_foreground_color_1++;
                        if (conf_theme == "light" && int_user_foreground_color_1 == 1)
                        {
                            int_user_foreground_color_1 = 2;
                        }
                        else if (conf_theme == "light" && int_user_foreground_color_1 == 15)
                        {
                            int_user_foreground_color_1 = 0;
                        }
                        conf_user_foreground_color_1 = int_user_foreground_color_1.ToString();
                        var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                        config1.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                    }
                    Settings_menu();
                }
                else
                {
                    if (conf_theme == "dark")
                    {
                        conf_user_foreground_color_1 = "1";
                        var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                        config1.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                        user_foreground_color_1 = ConsoleColor.White;
                    }
                    else if (conf_theme == "light")
                    {
                        conf_user_foreground_color_1 = "0";
                        var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config1.AppSettings.Settings["user_foreground_color_1"].Value = conf_user_foreground_color_1;
                        config1.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                        user_foreground_color_1 = ConsoleColor.Black;
                    }
                    Settings_menu();
                }
                break;
            case ConsoleKey.D4:
                keyInt++;
                if (int.TryParse(conf_user_foreground_color_2, out int_user_foreground_color_2))
                {
                    int_user_foreground_color_2 = Convert.ToInt32(conf_user_foreground_color_2);
                    if (int_user_foreground_color_2 >= 15 || int_user_foreground_color_2 < 0)
                    {
                        int_user_foreground_color_2 = 0;
                        if (conf_theme == "dark")
                        {
                            int_user_foreground_color_2 = 1;
                        }
                        conf_user_foreground_color_2 = int_user_foreground_color_2.ToString();
                        var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                        config1.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                    }
                    else
                    {
                        int_user_foreground_color_2++;
                        if (conf_theme == "light" && int_user_foreground_color_2 == 1)
                        {
                            int_user_foreground_color_2 = 2;
                        }
                        else if (conf_theme == "light" && int_user_foreground_color_2 == 15)
                        {
                            int_user_foreground_color_2 = 0;
                        }
                        conf_user_foreground_color_2 = int_user_foreground_color_2.ToString();
                        var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                        config1.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                    }
                    Settings_menu();
                }
                else
                {
                    if (conf_theme == "dark")
                    {
                        conf_user_foreground_color_1 = "1";
                        var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                        config1.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                        user_foreground_color_2 = ConsoleColor.White;
                    }
                    else if (conf_theme == "light")
                    {
                        conf_user_foreground_color_2 = "0";
                        var config1 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config1.AppSettings.Settings["user_foreground_color_2"].Value = conf_user_foreground_color_2;
                        config1.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                        user_foreground_color_2 = ConsoleColor.Black;
                    }
                    Settings_menu();
                }
                break;
            case ConsoleKey.D5:
                keyInt++;
                idiot = true;
                Settings_menu();
                break;
            case ConsoleKey.D6:
                keyInt++;
                if (conf_music=="1")
                {
                    conf_music = "0";
                    if (music_value)
                    {
                        try
                        {
                            foreach (Process proc in Process.GetProcessesByName("music2_zapizdoha.bin"))
                            {
                                proc.Kill();
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine("ОШИБКА " + ex + ": СКРИПТ АУДИО НЕ БЫЛ ПРЕРВАН. ВОЗМОЖНО ОН УЖЕ БЫЛ ЗАВЕРШЕН ИЛИ НЕ БЫЛ ЗАПУЩЕН. ПРОГРАММА НЕ БУДЕТ ЗАВЕРШЕНА.");
                            Console.WriteLine("press any key to continue.");
                            Console.ReadLine();
                        }
                    }
                    music_value = false;
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["music"].Value = conf_music;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Settings_menu();
                }
                else if (conf_music == "0")
                {
                    conf_music = "1";
                    music_value = true;
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["music"].Value = conf_music;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    if (music_value)
                    {
                        Process.Start("soundtracks/music2_zapizdoha.bin");
                    }
                    Settings_menu();
                }
                break;
            case ConsoleKey.D7:
                keyInt++;
                if (conf_sound == "1")
                {
                    conf_sound = "0";
                    sound_value = false;
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["sound"].Value = conf_sound;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Settings_menu();
                }
                else if (conf_sound == "0")
                {
                    conf_sound = "1";
                    sound_value = true;
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["sound"].Value = conf_sound;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Settings_menu();
                }
                break;
            case ConsoleKey.RightArrow:
                if (int_conf_fontsize < 72)
                {
                    keyInt++;
                    int_conf_fontsize++;
                    conf_fontsize = int_conf_fontsize.ToString();
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["fontsize"].Value = conf_fontsize;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Settings_menu();
                }
                else if (int_conf_fontsize > 72)
                {
                    int_conf_fontsize = 16;
                    conf_fontsize = int_conf_fontsize.ToString();
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["fontsize"].Value = conf_fontsize;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Settings_menu();
                }
                break;
            case ConsoleKey.LeftArrow:
                if (int_conf_fontsize > 12)
                {
                    keyInt++;
                    int_conf_fontsize--;
                    conf_fontsize = int_conf_fontsize.ToString();
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["fontsize"].Value = conf_fontsize;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Settings_menu();
                }
                else if (int_conf_fontsize < 12)
                {
                    int_conf_fontsize = 16;
                    conf_fontsize = int_conf_fontsize.ToString();
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["fontsize"].Value = conf_fontsize;
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                    Settings_menu();
                }
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Main_menu();
                break;
        }
    }
}
void Achivement_menu()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("");
    Console.WriteLine("1) Ачивки");
    Console.WriteLine("2) Концовки");
    Console.WriteLine(@"
Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.D1:
                keyInt++;
                Achivement_menu_Ejchan();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Achivement_menu_Endings1();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Main_menu();
                break;
        }
    }
}
void Achivement_menu_Ejchan()
{
    Console.Clear();
    keyInt = 0;
    Console.WriteLine("Ачивок здесь нет и не будет");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(@"
▓█████ ▄▄▄██▀▀▀▄████▄   ██░ ██  ▄▄▄       ███▄    █                    
▓█   ▀   ▒██  ▒██▀ ▀█  ▓██░ ██▒▒████▄     ██ ▀█   █                    
▒███     ░██  ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒                   
▒▓█  ▄▓██▄██▓ ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒                   
░▒████▒▓███▒  ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░ ██▓  ██▓  ██▓     
░░ ▒░ ░▒▓▒▒░  ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ▒▓▒  ▒▓▒  ▒▓▒     
 ░ ░  ░▒ ░▒░    ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░ ░▒   ░▒   ░▒      
   ░   ░ ░ ░  ░         ░  ░░ ░  ░   ▒      ░   ░ ░  ░    ░    ░       
   ░  ░░   ░  ░ ░       ░  ░  ░      ░  ░         ░   ░    ░    ░      
              ░                                       ░    ░    ░      
 ▄▄▄       ██▓     ██▓ ██▒   █▓▓█████                                  
▒████▄    ▓██▒    ▓██▒▓██░   █▒▓█   ▀                                  
▒██  ▀█▄  ▒██░    ▒██▒ ▓██  █▒░▒███                                    
░██▄▄▄▄██ ▒██░    ░██░  ▒██ █░░▒▓█  ▄                                  
 ▓█   ▓██▒░██████▒░██░   ▒▀█░  ░▒████▒ ██▓  ██▓  ██▓                   
 ▒▒   ▓▒█░░ ▒░▓  ░░▓     ░ ▐░  ░░ ▒░ ░ ▒▓▒  ▒▓▒  ▒▓▒                   
  ▒   ▒▒ ░░ ░ ▒  ░ ▒ ░   ░ ░░   ░ ░  ░ ░▒   ░▒   ░▒                    
  ░   ▒     ░ ░    ▒ ░     ░░     ░    ░    ░    ░                     
      ░  ░    ░  ░ ░        ░     ░  ░  ░    ░    ░                    
                           ░            ░    ░    ░                    
  █████▒▒█████   ██▀███  ▓█████ ██▒   █▓▓█████  ██▀███                 
▓██   ▒▒██▒  ██▒▓██ ▒ ██▒▓█   ▀▓██░   █▒▓█   ▀ ▓██ ▒ ██▒               
▒████ ░▒██░  ██▒▓██ ░▄█ ▒▒███   ▓██  █▒░▒███   ▓██ ░▄█ ▒               
░▓█▒  ░▒██   ██░▒██▀▀█▄  ▒▓█  ▄  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄                 
░▒█░   ░ ████▓▒░░██▓ ▒██▒░▒████▒  ▒▀█░  ░▒████▒░██▓ ▒██▒ ██▓  ██▓  ██▓ 
 ▒ ░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░░ ▒░ ░  ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░ ▒▓▒  ▒▓▒  ▒▓▒ 
 ░       ░ ▒ ▒░   ░▒ ░ ▒░ ░ ░  ░  ░ ░░   ░ ░  ░  ░▒ ░ ▒░ ░▒   ░▒   ░▒  
 ░ ░   ░ ░ ░ ▒    ░░   ░    ░       ░░     ░     ░░   ░  ░    ░    ░   
           ░ ░     ░        ░  ░     ░     ░  ░   ░       ░    ░    ░  
                                    ░                     ░    ░    ░  ");
    Console.ForegroundColor = black_text;
    Console.WriteLine(@"
Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.D1:
                keyInt++;
                Podjog_chegoto();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Achivement_menu_Endings1();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings1()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("1 -  ");
    if (conf_end_1 == "A8xP9M2k")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Разозгневал светило и был попущен");
    Console.Write("2 -  ");
    if (conf_end_2 == "Yd3T7LqV")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Убился из-за того, что дали поиграть в карты");

    Console.Write("3 -  ");
    if (conf_end_3 == "KxM4Jp9B")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Подзарядка спичек обернулась неудачей");

    Console.Write("4 -  ");
    if (conf_end_4 == "ZpL7T8Nx")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поджег одежду на себе");

    Console.Write("5 -  ");
    if (conf_end_5 == "Wm9XK4Jq")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Дежавю или безумие?");

    Console.Write("6 -  ");
    if (conf_end_6 == "KxM4Jp9B")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Соперник по гонке погиб");

    Console.Write("7 -  ");
    if (conf_end_7 == "XqK4M9L7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Победа в текстовых гонках сладка");

    Console.Write("8 -  ");
    if (conf_end_8 == "JpT7L3NX")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Семейная концовка");

    Console.Write("9 -  ");
    if (conf_end_9 == "L7XK3N9T")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Звезда нижнего интернета");

    Console.Write("10 - ");
    if (conf_end_10 == "M9JXK4L7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Попал на съемки фильма про динозавров");

    Console.WriteLine(@"
    |Страница 1|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings2();
                break;
            case ConsoleKey.LeftArrow:


                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings2()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("11 - ");
    if (conf_end_11 == "K4L7T9XN")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Пусть говорят");
    Console.Write("12 - ");
    if (conf_end_12 == "nkdJbSu0")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Неудачно спустился по лестнице");

    Console.Write("13 - ");
    if (conf_end_13 == "Ljn4Td96")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Концовка Fallout 3");

    Console.Write("14 - ");
    if (conf_end_14 == "XnfiL0Tt")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Был убит как лишний свидетель");

    Console.Write("15 - ");
    if (conf_end_15 == "JnkH8fd4")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Отдан в рабство к треш-стримерам");

    Console.Write("16 - ");
    if (conf_end_16 == "0d39HcGx")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Расплескал говно по всей лаборатории");

    Console.Write("17 - ");
    if (conf_end_17 == "XkJch2hL")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Отыграл честного проверяющего");

    Console.Write("18 - ");
    if (conf_end_18 == "Ns1T0gL8")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Взятки гладки");

    Console.Write("19 - ");
    if (conf_end_19 == "JXhd7Jpl")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Снайпнул проводку водяным пистолетом");

    Console.Write("20 - ");
    if (conf_end_20 == "ThgN37Ms")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Наврал ботану и спровоцировал взрыв");

    Console.WriteLine(@"
<-  |Страница 2|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings3();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings1();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings3()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("21 - ");
    if (conf_end_21 == "8RoBb7r6")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Задушил ботана за потраченое зря время");

    Console.Write("22 - ");
    if (conf_end_22 == "2x9qLvZr")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Сломал шаттл и получил дыру в голове");

    Console.Write("23 - ");
    if (conf_end_23 == "mK14kp7N")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Перезагрузил компьютер");

    Console.Write("24 - ");
    if (conf_end_24 == "w7h57T2N")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поиграл с проводкой");

    Console.Write("25 - ");
    if (conf_end_25 == "wH8uGbx7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Был пойман на пиздеже");

    Console.Write("26 - ");
    if (conf_end_26 == "LjMK47rG")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Загремел на зону");

    Console.Write("27 - ");
    if (conf_end_27 == "7K4LjreM")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("СУУУУУУУУУУУУТ!!");

    Console.Write("28 - ");
    if (conf_end_28 == "L9FFK7N3")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Не прошел тест мудреца");

    Console.Write("29 - ");
    if (conf_end_29 == "X9J7NK4M")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Наказан за покушение на мудреца");

    Console.Write("30 - ");
    if (conf_end_30 == "by7BDb36")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Безнаказанно расправился с мудрецом");

    Console.WriteLine(@"
<-  |Страница 3|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings4();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings2();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings4()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("31 - ");
    if (conf_end_31 == "JnsO8ev7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Сварился в гейзере");
    Console.Write("32 - ");
    if (conf_end_32 == "HAn09w3b")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Переборщил с истерикой");

    Console.Write("33 - ");
    if (conf_end_33 == "hYq4z2aV")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Кекс и Укроп - кокс хорошая");

    Console.Write("34 - ");
    if (conf_end_34 == "2wJRe83u")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Кекс и Укроп - кокс плохая");

    Console.Write("35 - ");
    if (conf_end_35 == "J7Mdh623")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Кекс и Укроп - шишки плохая");

    Console.Write("36 - ");
    if (conf_end_36 == "H8w3bYss")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Кекс и Укроп - шишки хорошая");

    Console.Write("37 - ");
    if (conf_end_37 == "hRfv5s7G")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Подружился с Сусом");

    Console.Write("38 - ");
    if (conf_end_38 == "TG7h63bG")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Пойман охраной в бункере");

    Console.Write("39 - ");
    if (conf_end_39 == "LhsYYji0")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Оскорбил Комрада и был наказан");

    Console.Write("40 - ");
    if (conf_end_30 == "BJwb78fF")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Полез в катакомбы без спичек");

    Console.WriteLine(@"
<-  |Страница 4|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings5();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings3();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings5()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("41 - ");
    if (conf_end_41 == "J67gJ4N7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Отказал команде в спичках");

    Console.Write("42 - ");
    if (conf_end_42 == "GuGo3e37")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Гляделки с безумным дедом в степи");

    Console.Write("43 - ");
    if (conf_end_43 == "Mu2ecn7k")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Продолжил Дело сумасшедшего деда");

    Console.Write("44 - ");
    if (conf_end_44 == "nbz38web")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("War of Fucks");

    Console.Write("45 - ");
    if (conf_end_45 == "An74mM6n")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Сожрал поварешку");

    Console.Write("46 - ");
    if (conf_end_46 == "B67bESnj")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Надругался над дедом");

    Console.Write("47 - ");
    if (conf_end_47 == "NJgC40nb")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Двач R.I.P.");

    Console.Write("48 - ");
    if (conf_end_48 == "Ni1K94uc")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Позвонил расказчику");

    Console.Write("49 - ");
    if (conf_end_49 == "NIws5b3J")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Попал в мир Марио");

    Console.Write("50 - ");
    if (conf_end_50 == "9A32Jk8О")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Хули тут так мало!?");

    Console.WriteLine(@"
<-  |Страница 5|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings6();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings4();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings6()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("51 - ");
    if (conf_end_51 == "A66BnWFO")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Прошел Майнкрафт");
    Console.Write("52 - ");
    if (conf_end_52 == "k3JAVapz")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Тактика боя с драконом не сработала");

    Console.Write("53 - ");
    if (conf_end_53 == "mlcUaJG3")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поспал в Энде");

    Console.Write("54 - ");
    if (conf_end_54 == "lb4wApgu")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Копал под себя");

    Console.Write("55 - ");
    if (conf_end_55 == "9k8dRix5")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Динамит детям не игрушки");

    Console.Write("56 - ");
    if (conf_end_56 == "PI3jpMca")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Отпиздил дерево");

    Console.Write("57 - ");
    if (conf_end_57 == "1lJhdUX0")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Получил нагоняй от голема");

    Console.Write("58 - ");
    if (conf_end_58 == "5CmR1n4t")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поборол все двери");

    Console.Write("59 - ");
    if (conf_end_59 == "WQlCrS8m")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Творец хуев");

    Console.Write("60 - ");
    if (conf_end_60 == "eB1tPoXz")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Лицезрел пивзавод");

    Console.WriteLine(@"
<-  |Страница 6|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings7();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings5();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings7()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("61 - ");
    if (conf_end_61 == "erMZXB6W")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Растворился в глотке холодненького");

    Console.Write("62 - ");
    if (conf_end_62 == "2wd4yJRY")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поломал автомат и свою голову");

    Console.Write("63 - ");
    if (conf_end_63 == "LsfjDj0l")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Уронил автомат на себя");

    Console.Write("64 - ");
    if (conf_end_64 == "U7RYm07w")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Слишком далеко ушел");

    Console.Write("65 - ");
    if (conf_end_65 == "DxXqmBG9")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Помог девушке и стал королем");

    Console.Write("66 - ");
    if (conf_end_66 == "uf0Yqn8E")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Помог девушке и получил пулю в лоб");

    Console.Write("67 - ");
    if (conf_end_67 == "5TOMWm1c")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Зверски убит девушкой");

    Console.Write("68 - ");
    if (conf_end_68 == "1HY4phoI")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Убил девушку");

    Console.Write("69 - ");
    if (conf_end_69 == "nI3ZB6OR")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Зарикроллен");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("70 - ");
    if (conf_end_70 == "eeoN0rBI")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Патриотичная концовка");

    Console.WriteLine(@"
<-  |Страница 7|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings8();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings6();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings8()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("71 - ");
    if (conf_end_71 == "ИдИнахуЙ")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Дорога в светлое будущее");
    Console.Write("72 - ");
    if (conf_end_72 == "mVzIL0t0")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Проебал все деньги бизнесмена");

    Console.Write("73 - ");
    if (conf_end_73 == "3jdkByfs")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Ну, Саша!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("74 - ");
    if (conf_end_74 == "VA6AyKpL")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Разорил норильского жулика");

    Console.Write("75 - ");
    if (conf_end_75 == "D9UsLIb6")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Не сумел принять извинения");

    Console.Write("76 - ");
    if (conf_end_76 == "6k7kEoPl")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Подружился с великаном");

    Console.Write("77 - ");
    if (conf_end_77 == "oAt77yWC")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поджарен и съеден титаном");

    Console.Write("78 - ");
    if (conf_end_78 == "WA4jl0Fv")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Живьем сожран гигантом");

    Console.Write("79 - ");
    if (conf_end_79 == "kUX6AnX7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Упал со стола");

    Console.Write("80 - ");
    if (conf_end_80 == "6l6pvPGI")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Попустил гиганта в нечестной битве");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.WriteLine(@"
<-  |Страница 8|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings9();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings7();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings9()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("81 - ");
    if (conf_end_81 == "l70fhqVm")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Прихлопнут великаном");

    Console.Write("82 - ");
    if (conf_end_82 == "BJFz6kBr")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Детонация жигулей");

    Console.Write("83 - ");
    if (conf_end_83 == "fDc3oZdO")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Отпиздил чечена");

    Console.Write("84 - ");
    if (conf_end_84 == "uyn9qcPC")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Получил от чечена пиздов");

    Console.Write("85 - ");
    if (conf_end_85 == "OUu6bBBx")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Бамблби!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("86 - ");
    if (conf_end_86 == "Xkjxa6Xu")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Press F");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }


    Console.Write("87 - ");
    if (conf_end_87 == "hOTi72fA")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Остался с голой жопой");

    Console.Write("88 - ");
    if (conf_end_88 == "VR6zxmY2")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Порезан кавказцем на швейцарский сыр");

    Console.Write("89 - ");
    if (conf_end_89 == "nk3NXbIY")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Очень долго пытался безуспешно завести жигуль");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("90 - ");
    if (conf_end_90 == "B9J9IUPd")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Презик либераха");

    Console.WriteLine(@"
<-  |Страница 9|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings10();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings8();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings10()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("91  - ");
    if (conf_end_91 == "GN8Z9OGw")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Диктаторский презик");

    Console.Write("92  - ");
    if (conf_end_92 == "lqB2ntZV")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Презик-бездарь");

    Console.Write("93  - ");
    if (conf_end_93 == "eU6QNK9h")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Получил путевку в ПНД");

    Console.Write("94  - ");
    if (conf_end_94 == "j1V2v729")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Пульт от ядерки");

    Console.Write("95  - ");
    if (conf_end_95 == "6OToIFel")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Все поняли что ты не президент");

    Console.Write("96  - ");
    if (conf_end_96 == "rTso5EYh")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Ожидал приезда полиции");

    Console.Write("97  - ");
    if (conf_end_97 == "bHOl1GPc")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Разбил головку об приборку");

    Console.Write("98  - ");
    if (conf_end_98 == "МаЛьВиНА")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Не справился с управлением космического шаттла");

    Console.Write("99  - ");
    if (conf_end_99 == "veF86iK4")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Узнал все тайны человечества");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("100 - ");
    if (conf_end_100 == "6IRojx78")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Ввел неверный пароль в шаттле");

    Console.WriteLine(@"
<-  |Страница 10|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings11();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings9();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings11()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("101 - ");
    if (conf_end_101 == "fsY3Fs0h")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Не расчитал высоту");
    Console.Write("102 - ");
    if (conf_end_102 == "NN3SLlGp")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Объединился с ветераном");

    Console.Write("103 - ");
    if (conf_end_103 == "58XUDUhD")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Отведал человечинки");

    Console.Write("104 - ");
    if (conf_end_104 == "1dIdT1wo")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Вэй Ин");

    Console.Write("105 - ");
    if (conf_end_105 == "CK05lJv7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Не внемлил предупреждению");

    Console.Write("106 - ");
    if (conf_end_106 == "4r9Z8jc8")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Прокатился по маслу");

    Console.Write("107 - ");
    if (conf_end_107 == "0joLBK0j")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Фанат побочных квестов");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("108 - ");
    if (conf_end_108 == "UtV4hjLv")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Утонул в реке");

    Console.Write("109 - ");
    if (conf_end_109 == "Z6jE8q3j")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Призвал Солнце");

    Console.Write("110 - ");
    if (conf_end_110 == "OGFKmz0w")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Задумался над моргом с кухней в лесу");

    Console.WriteLine(@"
<-  |Страница 11|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings12();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings10();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings12()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("111 - ");
    if (conf_end_111 == "BTrlZbI7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Выполнил квест Оператора");
    Console.Write("112 - ");
    if (conf_end_112 == "Abc99mmV")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Сгублен диким лесом");

    Console.Write("113 - ");
    if (conf_end_113 == "kjEahr6f")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Превращен в кровавую лужу");

    Console.Write("114 - ");
    if (conf_end_114 == "Lv5H6f8d")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Стал жертвой мочи");

    Console.Write("115 - ");
    if (conf_end_115 == "d1R45Vxj")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Открыл сундук");

    Console.Write("116 - ");
    if (conf_end_116 == "5c1FQkzg")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Проиграл Сатане в его игре");

    Console.Write("117 - ");
    if (conf_end_117 == "lkezTCU8")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Разозлил Сатану");

    Console.Write("118 - ");
    if (conf_end_118 == "7s9bVV4b")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Не проси Сатану дважды");

    Console.Write("119 - ");
    if (conf_end_119 == "O1UIVLMy")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Хлебнул маслица с пола");

    Console.Write("120 - ");
    if (conf_end_120 == "yR7LfKgQ")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Мытье полов оказалось ненапрасным");

    Console.WriteLine(@"
<-  |Страница 12|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings13();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings11();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings13()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("121 - ");
    if (conf_end_121 == "kmkBV5ql")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Шизохоккей");
    Console.Write("122 - ");
    if (conf_end_122 == "7PvzvAyS")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Le bortsch! Le plus délicieux!");

    Console.Write("123 - ");
    if (conf_end_123 == "zri6Jcfr")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Недурный борщ");

    Console.Write("124 - ");
    if (conf_end_124 == "1phdVQ7j")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Говнище вместо борща");

    Console.Write("125 - ");
    if (conf_end_125 == "s0vWQali")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поскользнулся, ударился головой и умер");

    Console.Write("126 - ");
    if (conf_end_126 == "Ue1Hahr8")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Отмудохал Оператора");

    Console.Write("127 - ");
    if (conf_end_127 == "f54ppeF6")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Харкач - гавно!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("128 - ");
    if (conf_end_128 == "21nJpbTY")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Проиграл Оператору в схватке");

    Console.Write("129 - ");
    if (conf_end_129 == "gX4hvGwx")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Помыл руке");

    Console.Write("130 - ");
    if (conf_end_130 == "rMxCHF47")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Вертолет, нейтральная");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.WriteLine(@"
<-  |Страница 13|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings14();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings12();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings14()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("131 - ");
    if (conf_end_131 == "pOsVTw2z")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Вертолет, плохая");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("132 - ");
    if (conf_end_132 == "Ju1A0lgP")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Вертолет, хорошая");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("133 - ");
    if (conf_end_133 == "S7S4ZkkS")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: ЕЕФ, лучшая");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("134 - ");
    if (conf_end_134 == "MAKlyFa2")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: ЕЕФ, хорошая");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("135 - ");
    if (conf_end_135 == "SgLn2ERg")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: ЕЕФ, нейтральная 1");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("136 - ");
    if (conf_end_136 == "oO2Inqux")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: ЕЕФ, нейтральная 2");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("137 - ");
    if (conf_end_137 == "yuc9Q6MC")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: ЕЕФ, плохая");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("138 - ");
    if (conf_end_138 == "rBTZGJ8m")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: ЕЕФ, худшая");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("139 - ");
    if (conf_end_139 == "JN7nv4hD")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Канализационная битва");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("140 - ");
    if (conf_end_140 == "OGFKmz0w")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Вертолет, иношопо-тян");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.WriteLine(@"
<-  |Страница 14|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings15();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings13();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings15()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("141 - ");
    if (conf_end_141 == "bq2vPLZ1")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Вертолет, миниган");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("142 - ");
    if (conf_end_142 == "jZwmc3qz")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Вертолет, ракетница");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("143 - ");
    if (conf_end_143 == "xR5M1qxG")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Вертолет, крушение");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("144 - ");
    if (conf_end_144 == "yRJcFyV3")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Аптека");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("145 - ");
    if (conf_end_145 == "Te92BhMn")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Нерешительность");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("146 - ");
    if (conf_end_146 == "isHx8ZFc")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Драка с инопланетянами");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("147 - ");
    if (conf_end_147 == "Rj2aeIp0")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Довыёбывался");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("148 - ");
    if (conf_end_148 == "lEF9anP6")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Ало, Бэн? Это Данила");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("149 - ");
    if (conf_end_149 == "pq8PWthv")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Говно и точка");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("150 - ");
    if (conf_end_150 == "G2SmVcLX")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Прикинулся пришельцем");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.WriteLine(@"
<-  |Страница 15|  ->

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:
                keyInt++;
                Achivement_menu_Endings16();
                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings14();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}
void Achivement_menu_Endings16()
{
    Console.Clear();
    keyInt = 0;
    Console.Write("151 - ");
    if (conf_end_151 == "vCAvE5nU")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Авапа");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("152 - ");
    if (conf_end_152 == "FC72k78z")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Устроил трагедию");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("153 - ");
    if (conf_end_153 == "9GMb6l2r")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
        Console.WriteLine("Апокалипсис: Всадник апокалипсиса");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.WriteLine("???");
        Console.ForegroundColor = black_text;
    }

    Console.Write("154 - ");
    if (conf_end_154 == "hb67iOXG")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Расстрелять!");

    Console.Write("155 - ");
    if (conf_end_155 == "HvHy52iB")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Не показал внутренний мир");

    Console.Write("156 - ");
    if (conf_end_156 == "sw83dQW7")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Получена   : ");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Не получена: ");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Включил Оперу Путина");

    Console.WriteLine(@"




<-  |Страница 16|    

Esc) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.RightArrow:

                break;
            case ConsoleKey.LeftArrow:
                keyInt++;
                Achivement_menu_Endings15();
                break;
            case ConsoleKey.Escape:
                keyInt++;
                Achivement_menu();
                break;
        }
    }
}


void Nachalo()
{
    oper_dovolen = true; // настроение прораба в зависимости как ты проник в кабинку
    tualet_byl_li = false; // переменная отвечающая за то, был ли гг уже в туалете или нет.
    oper_byl_li = false; // переменная отвечающая за то, был ли гг уже у прораба или нет.
    op_quest_zad = 0;
    op_quest_mud = 0;
    op_quest_prohodimcy = 0;
    op_quest_ataka = 0;
    op_quest_zadanie = 0;
    operator_secret_end = 0;

    kuhnya_byl_li = false;

    //Река, пляж, лес
    zagar_byl_li = false;
    reka_end = false;
    reka_podumat = true;
    reka_poplavat = true;
    reka_zabluditsa = true;
    reka_zagar = true;

    //Рэмбо
    R_quest_cel = 0;
    R_quest_fed = 0;
    R_quest_vet = 0;
    R_quest_yes = 0;
    R_quest_DALSHE = 0;
    Rambo_pobil = 0;

    future_trans = false;
    zhiguli_zavedenie = 0;
    zhiguli_Y = false;
    zhiguli_F = false;
    zhiguli_Z = false;
    zhiguli_kapot = false;
    car = false;
    car_str = "";
    Red_Alert = 0;
    tea = 0; //чай президента
    pol = 0; // направление политики -либ +конс
    par_q_1 = false;
    par_q_2 = false;
    par_q_3 = false;
    par_q_4 = false;
    fighter = 0;// 1-кавказец 2-великан 3-прараб 4-сатана 5-зомби
    vrag_hp = 0;
    u_hp = 20;
    stop_fight = 0;
    u_stop_fight = 0;
    start_fight = false;
    gigant_love = 0;

    //Сатана
    satana = 0;
    satana_int = 0;
    satana_who = false;
    satana_x = true; //костыль для диалога с сатаной

    //Бизнесмен
    biznessmen = 1;
    biznesmen_1_byl_li = false;

    //разводила
    stavka = 0;
    trenirovochniy = true;
    rub_razvodila = 500000;

    //плакса
    plaksa_killed = false;
    plaksa_end_good = true;

    //опасный поцык
    pocyk_1 = true;
    pocyk_2 = true;

    //предметы
    karty = true;
    spichki = true; //спички в начале игры
    pesok = false; //песок в начале игры
    zaryadka = true; //зарядка в начале игры
    gold_key = false; //золотой ключ в морге
    gold_lopata = false; //золотая лопата прораба
    odejda = true; // одежда главного героя
    vid_odejdy = 0; // 0 - лохмотья
                        // 1 - смокинг
                        // 2 - халат

    rubli = 0; // количество рублей у гг

    //камень ножницы бумага
    knb_wins_all = 0;
    u_wins = 0;
    vrag_wins = 0;
    u_zhest = 0;
    vrag_zhest = 0; //1-камень 2-ножницы 3-бумага 4-ящерица 5-спок
    name_knb = "";
    name_zhest_vrag = "";
    name_zhest_u = "";
    knb_znak = "";

    mine = 0;

    //дежавю
    deja_1 = false;
    deja_2 = false;
    deja_3 = false;

    //лабиринт бункера
    pred_komnata = 1;

    gor_step = false; //горящая степь

    vkus_borsha = 0; //вкус борща

    hod_pasyans = 0;

    Norilsk_Secret_1 = false;
    Norilsk_Secret_2 = false;
    Norilsk_Secret_3 = false;

    //зомби апокалипсис
    zombi_lvl = 0;
    zombi_xp = 0;
    megapulemet_jiv = true;
    vertolet_li = true;
    vertolet_end = 0;
    qte_score = 0;

    //technology
    black_vhod = 0;
    kod_1 = false;
    sloman_shattl = false;
    alkash_ushel = false;

    if (kolco_vsemogushestva)
    {
        u_hp = 999999999;
    }
    if (povareshka)
    {
        povareshka_int++;
    }
    if (povareshka_int>1)
    {
        povareshka = false;
        povareshka_int = 0;
    }
    if (satana == 1)
    {
        satana_int++;
    }
    if (satana_int > 1)
    {
        satana = 0;
        satana_int = 0;
    }
    Console.Clear();
    keyInt = 0;

    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (nachalo_byl_li==false)
    {
        Console.WriteLine("Ты просыпаешься возле дороги. На улице полдень. Солнце печет, а температура воздуха по ощущениям не меньше 28. Что будем делать?");
    }
    else
    {
        Console.WriteLine("Ты оказываешься возле дороги. На улице полдень. Солнце печет, а температура воздуха по ощущениям не меньше 28. Что будем делать?");

    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Полазить в карманах");
    Console.WriteLine("2) Осмотреться");
    Console.WriteLine("3) Закатить истерику, а после жестко запаниковать");
    Console.WriteLine("4) Обматерить Солнце за жару");
    if (nachalo_byl_li == true)
    {
        Console.WriteLine("5) Кажется у меня дежавю...");
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                nachalo_byl_li = false;
                Karmany();
                break;
            case ConsoleKey.D2:
                keyInt++;
                nachalo_byl_li = false;
                Osmotr_u_Dorogi();
                break;
            case ConsoleKey.D3:
                keyInt++;
                nachalo_byl_li = false;
                Bunkar(1);
                break;
            case ConsoleKey.D4:
                keyInt++;
                nachalo_byl_li = false;
                END_Solnce();
                break;
            case ConsoleKey.D5:
                if (nachalo_byl_li == true)
                {
                    keyInt++;
                    nachalo_byl_li = false;
                    Dejavu(0);
                }
                break;
        }
    }
}//дорога, солнце, жар, безумство.
void END_Solnce()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_1 != "A8xP9M2k")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_1 = "A8xP9M2k";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_1"].Value = conf_end_1;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 1");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Услышав твои слова, Солнце обиделось и погасло, что повлекло за собой падение температуры до -98 градусов, которую ты не пережил.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Karmany()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Покапавшись в карманах ты обнаружил зарядку, спички и колоду карт.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Поджечь что-то");
    Console.WriteLine("2) Попытаться зарядить спички");
    Console.WriteLine("3) Собрать пасьянс");
    Console.WriteLine("4) Осмотреться вокруг");
    Console.WriteLine("5) Выбросить все содержимое карманов и осмотреться");
    Console.WriteLine("5) Набрать полные карманы песка и осмотреться");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Podjog_chegoto();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Zaryadka_Spichek();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Pasyans(0);
                break;
            case ConsoleKey.D4:
                keyInt++;
                Osmotr_u_Dorogi();
                break;
            case ConsoleKey.D5:
                keyInt++;
                karty = false;
                spichki = false;
                zaryadka = false;
                Osmotr_u_Dorogi();
                break;
            case ConsoleKey.D6:
                keyInt++;
                pesok = true;
                Osmotr_u_Dorogi();
                break;
        }
    }
}
void Dejavu(int deja)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (deja == 0)
    {
        Console.WriteLine("Хммм, а ведь действительно. Ты здесь уже определенно был... или нет?");
    }
    else if (deja == 1)
    {
        Console.WriteLine("Ты потираешь виски, тужась пытаешься вспомнить этот момент, но ничего не приходит в голову, словно кто-то подтер тот раздел в твоем мозге.");
    }
    else if (deja == 2)
    {
        Console.WriteLine("Десятки вариантов пролетаеют в голове, но ни одного дельного или хотя бы мало-мальски реалистичного.");
    }
    else if (deja == 3)
    {
        Console.WriteLine("Ты пытаешься связать несвязуемое, фрагменты никак не хотят клеиться, а учитывая тот факт, что ты ничего не помнишь, это превращается в задачу для квантовых компьютеров.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    if (deja_1)
    {
        Console.WriteLine("1) Сойти с ума");
    }
    else
    {
        Console.WriteLine("1) Попытаться вспомнить");
    }
    if (deja_2)
    {
        Console.WriteLine("2) Сойти с ума");
    }
    else
    {
        Console.WriteLine("2) Подумать как это могло произойти");
    }
    if (deja_3)
    {
        Console.WriteLine("3) Сойти с ума");
    }
    else
    {
        Console.WriteLine("3) Выстроить причинно-следственную связь");
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (deja_1)
                {
                    END_Dejavu();
                }
                else
                {
                    deja_1 = true;
                    Dejavu(1);
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (deja_2)
                {
                    END_Dejavu();
                }
                else
                {
                    deja_2 = true;
                    Dejavu(2);
                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                if (deja_3)
                {
                    END_Dejavu();
                }
                else
                {
                    deja_3 = true;
                    Dejavu(3);
                };
                break;
        }
    }
}
void END_Dejavu()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_5 != "Wm9XK4Jq")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_5 = "Wm9XK4Jq";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_5"].Value = conf_end_5;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 5");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Не сумев построить логически верное объяснение сложившейся ситуации, твой мозг включил защитную реакцию, во избежание перегруза, и просто отключил нейроны отвечающие за адекватное восприятие, или, говоря проще - ты сошел с ума.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Pasyans(int pasyans)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (pasyans == 0)
    {
        Console.WriteLine("Ты разложил паука и тщательно обдумывая ходы начал собирать. Собрал. Выйграл. Молодец. Теперь пошли куда-нибудь.");
    }
    if (pasyans == 1)
    {
        Console.WriteLine("Шутишь? В этот раз ты решил разложить солитер. Ты усердно думал над каждым ходом, нерешительно отдергивал руку, а когда наконец собрал, то радовался как ребенок, катаясь по дороге. Все? Идем?");
    }
    if (pasyans == 2)
    {
        Console.WriteLine("Да ты издеваешься! Перетосовав колоду ты нначал складывать следующий пасьянс. Им оказался Три вершины. Он дался тебе очень легко, ты не задумываясь собрал его буквально за пару минут.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Убрать колоду и поджечь что-то");
    Console.WriteLine("2) Собрать другой пасьянс");
    Console.WriteLine("3) Убрать колоду и осмотреться вокруг");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Podjog_chegoto();
                break;
            case ConsoleKey.D2:
                keyInt++;
                hod_pasyans++;
                if (hod_pasyans<3)
                {
                    Pasyans(hod_pasyans);
                }
                else
                {
                    Pasyans_2();
                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                Osmotr_u_Dorogi();
                break;
        }
    }
}
void Pasyans_2()
{
    karty = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("С меня хватит! Подул ветер и все твои карты разлетелись на долгие километры.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Со злости от несправедливости поджечь что-то");
    Console.WriteLine("2) Свернуть себе шею");
    Console.WriteLine("4) С обиженным видом осмотреться вокруг");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Podjog_chegoto();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Pasyans();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Osmotr_u_Dorogi();
                break;
        }
    }
}
void END_Pasyans()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_2 != "Yd3T7LqV")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_2 = "Yd3T7LqV";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_2"].Value = conf_end_2;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 2");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Эй-эй-эй! Ты что делаешь!? Аййй... Ну знаешь ли! Если ты так хотел играть в карты, то шел бы уж сразу в Microsoft Solitaire Collection, а теперь лежи тут со свернутой шеей.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Zaryadka_Spichek()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты серьезно?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Поджечь что-то");
    Console.WriteLine("2) Да, я серьезно хочу зарядить спички");
    Console.WriteLine("3) Собрать пасьянс");
    Console.WriteLine("4) Осмотреться вокруг");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Podjog_chegoto();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Zaryadka_Spichek_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Pasyans(0);
                break;
            case ConsoleKey.D4:
                keyInt++;
                Osmotr_u_Dorogi();
                break;
        }
    }
}
void Zaryadka_Spichek_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Блин, чет не выходит.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Поджечь что-то");
    Console.WriteLine("2) Попытаться воткнуть провод с другой стороны");
    Console.WriteLine("3) Собрать пасьянс");
    Console.WriteLine("4) Осмотреться вокруг");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Podjog_chegoto();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Zaryadka_Spichek_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Pasyans(0);
                break;
            case ConsoleKey.D4:
                keyInt++;
                Osmotr_u_Dorogi();
                break;
        }
    }
}
void Zaryadka_Spichek_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Все равно шляпа какая-то.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Поджечь что-то");
    Console.WriteLine("2) Попробовать зарядить спички телекинетической энергией");
    Console.WriteLine("3) Собрать пасьянс");
    Console.WriteLine("4) Осмотреться вокруг");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Podjog_chegoto();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Zaryadka_Spichek();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Pasyans(0);
                break;
            case ConsoleKey.D4:
                keyInt++;
                Osmotr_u_Dorogi();
                break;
        }
    }
}
void END_Zaryadka_Spichek()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_3 != "KxM4Jp9B")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_3 = "KxM4Jp9B";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_3"].Value = conf_end_3;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 3");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("И ты попробовал, напряг все мускулы тела. Однако твое сердце не выдержало и остановилось. Ты умер от остановки сердца.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Osmotr_u_Dorogi()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Осмотрев окресности, ты видишь указатель, который гласит, что в одну сторону, дорога ведет к гейзерам, а в другой стороне находится Норильск. Справа от дороги ты видишь лес, а слева степь.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Пойти в лес");
    Console.WriteLine("2) Пойти в степь");
    Console.WriteLine("3) Пойти в Норильск");    
    Console.WriteLine("4) Пойти к гейзерам");
    
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Norilsk(0);
                break;
            case ConsoleKey.D4:
                keyInt++;
                Gazers(0);
                break;
        }
    }
}
void Gazers(int byl_li)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (byl_li == 0)
    {
        Console.WriteLine("Далеко ходить не пришлось и уже через 15 минут ты лицезрел прекраснейшее чудо природы. Что не удивительно, здесь была целая куча народу, но твое внимание привлекли лишь: монах, мидитирующий в скоплении гейзеров, работяги, суетящиеся вокруг огромной лужи молока, парень в брендовых шмотках в окружении охраны, сломанный таксофон и какой-то бомж блюющий на синюю Феррари.");
    }
    else if (byl_li == 1)
    {
        Console.WriteLine("Ты вернулся к выбору активностей. Напоминаю, что на выбор есть: монах, мидитирующий в скоплении гейзеров, работяги, суетящиеся вокруг огромной лужи молока, парень в брендовых шмотках в окружении охраны, сломанный таксофон и какой-то бомж блюющий на синюю Феррари.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подойти к монаху");
    Console.WriteLine("2) Подойти к луже молока");
    Console.WriteLine("3) Подойти к сломанному таксофону");
    Console.WriteLine("4) Подойти к бомжу с Феррари");
    Console.WriteLine("5) Искупаться в гейзере");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (kolco_vsemogushestva)
                {
                    Gazers_Monah_Otdat();
                }
                else
                {
                    Gazers_Monah_Obresti();
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Milk();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Taksofon();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Gazers_Ferrari();
                break;
            case ConsoleKey.D5:
                keyInt++;
                END_Gazers();
                break;

        }
    }
}
void Gazers_Ferrari()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты подошел к бомжу. Бомж оказался не очень дружелюбный, зато очень пьяный. \"Слышь!.. Ик!.. Вли дава! Пдаше... Ик!.. Т мэй ластчки...\" - В максимально развалистой позе пригрозил бомж. В этот момент, свет от солнца упал на одну из фар, создав кратковременный блик. Это она тебе подмигивает? Я думаю, что она горит тем, чтобы ее угнал.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Угнать");
    Console.WriteLine("1) Угнать");
    Console.WriteLine("1) Угнать");
    Console.WriteLine("1) Угнать");
    Console.WriteLine("1) Угнать");
    Console.WriteLine("1) Угнать");
    Console.WriteLine("1) Угнать");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Ferrari_1();
                break;
        }
    }
}
void Gazers_Ferrari_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Надавав бомжу смачных подсрачников, ты быстрым рывком сел за руль и дернул ключ зажигания. Мотор заревел, тапок в пол, колеса буксуя подняли клубы пыли и дыма. И вот ты уже на всей скорости мчишь по трассе в неизвестном направлении. Это было легко, я бы сильно удивился, если бы тебе не удалось угнать этот автомобиль. ВНЕЗАПНО на твоем пути ты встречаешь какого-то выскочку на розовом Порше, есть несколько действий на выбор:");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Устроить аварию");
    Console.WriteLine("2) Предложить погонять");
    Console.WriteLine("3) Не обращать внимания");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Ferrari_Gonki();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Ferrari_Gonki();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Ferrari_Gonki();
                break;
        }
    }
}
void Gazers_Ferrari_Gonki()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Неважно что ты сейчас выбрал (как будто предыдущие бесчисленные выборы имели значение), ведь тебя ждет гонка! Ура! Интерактивчик! Стрелка вправо - ехать, стрелки вниз/вверх - сменить полосу, ты синий, твой враг розовый, удачи!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ну, гонки так гонки");
    Console.WriteLine("2) Но мне лееень(");
    Console.WriteLine("3) Эй погоди! Я ничего не понял!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gonki();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gonki();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gonki();
                break;
            case ConsoleKey.D4:
                if (kolco_vsemogushestva)
                {
                    keyInt++;
                    Gonki();
                }
                break;
        }
    }
}
void END_Ferrari_Avaria_Alt()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_6 != "Np3T7JxL")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_6 = "Np3T7JxL";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_6"].Value = conf_end_6;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 6");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("К сожелению твой оппонент погиб в аварии, однако виноват не он, и даже не господин со встречки, а криворукий быдлокодер создатель, который не смог прописать нормальную логику в гонках.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Gazers_Ferrari_Avaria()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты попал в аварию. Но вопреки всем твоим ожиданиям, ты не умер, даже более того, ты не получил ни единой царапины. Нет, авария-то произошла, причем серьезная: обе машины всмятку. Ты спросишь почему ты не умер? А я отвечу - все благодаря системе пудушек безопасности Joyson Safety Systems. Joyson Safety Systems - Мировой лидер в области безопасности передвижения.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Пошел нахуй со своей рекламой");
    Console.WriteLine("2) Засунь такую подушку себе в очко и раскрой ее там");
    Console.WriteLine("3) Мне похуй");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Ferrari_Avaria_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Ferrari_Avaria_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Ferrari_Avaria_1();
                break;
        }
    }
}
void Gazers_Ferrari_Avaria_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ладно, не кипятись ты так, кушать все хотят. Выползши червяком из мятки, ты заметил, что находишься где-то в селе или ПГТ, вокруг ивента собралась большая толпа, пешками наблюдающая за горящим металоломом и в драной одежде тобой. Хотя может быть они так смотрели из-за того, что из дыры на твоих штанах в области паха выглядывал петушок.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Стыдливо прикрыть дырку ладонями");
    Console.WriteLine("2) Не обращать на сей казус никакого внимания");
    Console.WriteLine("3) Гордо раздвинуть ноги и трясти хозяйством");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Ferrari_Avaria_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Ferrari_Avaria_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Ferrari_Avaria_2();
                break;
        }
    }
}
void Gazers_Ferrari_Avaria_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Как бы то ни было, надо срочно делать ноги подальше от дорожного проишествия, так как местные уже начали звонить в 112. Лучше беги, если ты конечно не хочешь проблем с полицией.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Стоять как вкопанный");
    Console.WriteLine("2) Бежать с места аварии");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Ferrari_Avaria();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology(0);
                break;
        }
    }
}
void END_Gazers_Ferrari_Pobeda()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_7 != "XqK4M9L7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_7 = "XqK4M9L7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_7"].Value = conf_end_7;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 7");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Поздравляю, ты победил в корявых ASCII гонках! Это уже само по себе достижение и невероятного рода удача, поэтому держи свою поистине заслуженную концовку.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Gazers_Ferrari_Porajenie()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Лошара! Продул какому-то лоху на гламурном ведре! По окончанию гонки, твой розовый оппонент свернул на обочину. Ты быстренько его догнал, выскочил из машины и с грозным видом пошел к окну водительского розового автомобиля. Когда ты подошел, то увидел в машине лысого качка в черной майке и солнцезащитных очках. Тебе захотелось высказать ему все что ты о нем думаешь.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ты - сын дырявой шалавы! Тебя в детстве отчим насиловал!");
    Console.WriteLine("2) Ты щас у меня дерьмо жрать будешь, залупа ты лысая!");
    Console.WriteLine("3) Я шатал твой рот и всю твою семью!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Ferrari_Porajenie_11();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Ferrari_Porajenie_11();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Ferrari_Porajenie_1();
                break;
        }
    }
}
void Gazers_Ferrari_Porajenie_11()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Качек разозлился и отметелил тебя изорвав при этом всю твою одежду, я думаю ничего другого ожидать и не следовало. В конце концов качок тебя отпустил и ты в ужасе бежал без оглядки.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) БЕГСТВО!");
    Console.WriteLine("2) ПОБЕГ!");
    Console.WriteLine("3) ДРАП!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology(0);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology(0);
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology(0);
                break;
        }
    }
}
void Gazers_Ferrari_Porajenie_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (music_value)
    {
        foreach (Process proc in Process.GetProcessesByName("music_zapizdoha.bin"))
        {
            proc.Kill();
        }
    }
    if (sound_value) {zvuk8.Play();}
    Console.WriteLine("\"Ты сказал семья?\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Что?");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Gazers_Ferrari_Porajenie();
                break;
        }
    }
}
void END_Gazers_Ferrari_Porajenie()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_8 != "JpT7L3NX")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_8 = "JpT7L3NX";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_8"].Value = conf_end_8;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 8");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("\"Нет ничего важнее семьи!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (music_value)
                {
                    Process.Start("soundtracks/music_zapizdoha.bin");
                }
                Nachalo();
                break;
        }
    }
}
void Technology(int pr_black_vhod)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (pr_black_vhod == 1)
    {
        Console.WriteLine("Обойдя здание ты не заметил ничего интересного, кроме наличия черного входа.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Осмотреть здание еще раз");
        Console.WriteLine("2) Войти через главный вход");
        Console.WriteLine("3) Войти через черный вход");
    }
    else if (pr_black_vhod == 0)
    {
        Console.WriteLine("Ты драпал по проселочным дорогам, через дворы, сквозь заборы и огороды, пока твои глаза не заметили большое кирпичное здание, походившее на не то ангар, не то склад. Над главным входом красовалась большая светодиодная вывеска \"Осколково\", написанная провинциальным шрифтом.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Осмотреть здание");
        Console.WriteLine("2) Войти через главный вход");
    }
    else if (pr_black_vhod == 2)
    {
        Console.WriteLine("Обойдя здание еще раз и осмотрев все вокруг повнимательнее, помимо наличия черного входа, ты заметил два комплекта одежды, аккуратно убранные в пакет, на скамейке возле черного входа - чистый черный смокинг и грязный белый халат с бейджиком.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Осмотреть здание еще раз");
        Console.WriteLine("2) Войти через главный вход");
        Console.WriteLine("3) Войти через черный вход");
        Console.WriteLine("4) Надеть смокинг");
        Console.WriteLine("5) Надеть халат");
    }
    else if (pr_black_vhod == 10)
    {
        
        if (vid_odejdy == 0)
        {
            Console.WriteLine("Ты переоделся в свои лохмотья, можешь зайти в них через главный или черный вход, а можешь переодеться во что-нибудь другое");
            Console.ForegroundColor = user_foreground_color_2;
            Console.WriteLine("1) Осмотреть здание еще раз");
            Console.WriteLine("2) Войти через главный вход");
            Console.WriteLine("3) Войти через черный вход");
            Console.WriteLine("4) Надеть смокинг");
            Console.WriteLine("5) Надеть халат");
        }
        else if (vid_odejdy == 1)
        {
            Console.WriteLine("Ты переоделся в смокинг, можешь зайти в нем через главный или черный вход, а можешь переодеться во что-нибудь другое");
            Console.ForegroundColor = user_foreground_color_2;
            Console.WriteLine("1) Осмотреть здание еще раз");
            Console.WriteLine("2) Войти через главный вход");
            Console.WriteLine("3) Войти через черный вход");
            Console.WriteLine("4) Надеть лохмотья");
            Console.WriteLine("5) Надеть халат");
        }
        else if (vid_odejdy == 2)
        {
            Console.WriteLine("Ты переоделся в халат, можешь зайти в нем через главный или черный вход, а можешь переодеться во что-нибудь другое");
            Console.ForegroundColor = user_foreground_color_2;
            Console.WriteLine("1) Осмотреть здание еще раз");
            Console.WriteLine("2) Войти через главный вход");
            Console.WriteLine("3) Войти через черный вход");
            Console.WriteLine("4) Надеть смокинг");
            Console.WriteLine("5) Надеть лохмотья");
        }
    }
    else
    {
        Console.WriteLine("Обойдя здание еще раз ты не нашел для себя ничего нового, только черный вход, смокинг и халат. Можешь не пытаться продолжать тыкаться в этот вариант ответа, здесь нет никакой концовки.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Осмотреть здание еще раз");
        Console.WriteLine("2) Войти через главный вход");
        Console.WriteLine("3) Войти через черный вход");
        if (vid_odejdy == 0)
        {
            Console.WriteLine("4) Надеть смокинг");
            Console.WriteLine("5) Надеть халат");
        }
        else if (vid_odejdy == 1)
        {
            Console.WriteLine("4) Надеть лохмотья");
            Console.WriteLine("5) Надеть халат");
        }
        else if (vid_odejdy == 2)
        {
            Console.WriteLine("4) Надеть смокинг");
            Console.WriteLine("5) Надеть лохмотья");
        }
    }
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (black_vhod<3)
                    black_vhod++;
                Technology(black_vhod);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White();
                break;
            case ConsoleKey.D3:
                if (pr_black_vhod>0)
                {
                    keyInt++;
                    Technology_Black();
                }
                break;
            case ConsoleKey.D4:
                if (pr_black_vhod > 1)
                {
                    keyInt++;
                    if (vid_odejdy == 0)
                        vid_odejdy = 1;
                    else if (vid_odejdy == 1)
                        vid_odejdy = 0;
                    else if (vid_odejdy == 2)
                        vid_odejdy = 1;
                    Technology(10);
                }
                break;
            case ConsoleKey.D5:
                if (pr_black_vhod > 1)
                {
                    keyInt++;
                    if (vid_odejdy == 0)
                        vid_odejdy = 2;
                    else if (vid_odejdy == 1)
                        vid_odejdy = 2;
                    else if (vid_odejdy == 2)
                        vid_odejdy = 0;
                    Technology(10);
                }
                break;
        }
    }
}
void Technology_Black()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Тяжко, с характерным скрипом железная дверь открылась. Ты увидел перед собой лестницу идущую глубоко под землю, которую освещали слабенькие красные лампы.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Неторопливо спуститься по лестнице");
    Console.WriteLine("2) Пробежать лестницу с видом скрывающегося от погони");
    Console.WriteLine("3) Скатиться на попе");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_Black_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_Black_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Black();
                break;
        }
    }
}
void Technology_Black_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты спустился и увидел перед собой три двери: белую, синюю и красную. В какую желаете заглянуть?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Красный - это значит красивый");
    Console.WriteLine("2) Синий, значит свежий");
    Console.WriteLine("3) А белый - элегантность");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Technology_Black_Krasniy();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_Black_Siniy();
                break;
            case ConsoleKey.D3:
                keyInt++;
                deja_1 = true;
                deja_2 = true;
                deja_3 = true;
                Technology_Black_Beliy(0);
                break;
        }
    }
}
void END_Technology_Black_Krasniy()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_9 != "L7XK3N9T")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_9 = "L7XK3N9T";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_9"].Value = conf_end_9;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 9");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Как только ты открыл дверь то в нос тебе ударил ядерный духан перегара, который положил тебя в спячку. Очнулся ты уже на какой-то раздолбанной и заблеванной хате в компании алкашей. Напротив тебя стоял компьютер с запущенной OBS. Ты попал в логово которая треш-стримеров. Не знаю почему, но ты быстро с ними спелся, вы вместе издевались над рабами треш-стримов, бухали, творили всякую дичь за донаты... Позднее ты даже стал звездой нижнего интернета, так себе достижение конечно, но все же.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Technology_Black_Siniy()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Зайдя в синюю дверь, ты попал в пустое темное помещение, ну, как пустое, в нем была огромная колба и пульт управления перед ней. Подойдя к пульту твоему взору предстала лежащая на нем бумажка: \"Здесь есть две комнаты с колбами: телепорт и газовая камера, и я тебя поздравляю, ты попал в комнату с газовой камерой! Ты должен ее активировать и зайти внутрь, потому что это твоя судьба.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Активировать камеру и зайти в колбу");
    Console.WriteLine("2) Нажать на рычаг активации и проникнуть в газовую камеру");
    Console.WriteLine("3) У тебя все равно нет выбора");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Technology_Black_Siniy();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Black_Siniy();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Black_Siniy();
                break;
        }
    }
}
void Technology_Black_Beliy(int xr)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (xr == 0)
    {
        Console.WriteLine("Зайдя в синюю дверь, ты попал в пустое темное помещение, ну, как пустое, в нем была огромная колба и пульт управления перед ней. Подойдя к пульту твоему взору предстала лежащая на нем бумажка: \"Здесь есть две комнаты с колбами: телепорт и газовая камера, эта же комната с телепортом. Инструкция: Перед нач...\" - На этом моменте тебе ужасно захотелось спать, разберемся по ходу, че мы, пальцем деланы?");
    }
    else if (xr == 1)
    {
        Console.WriteLine("Так, ну, по крайней мере ничего не взорвалось, только и в целом как будто ничего не произошло.");
    }
    else if (xr == 2)
    {
        Console.WriteLine("Это тоже не сработало. Хм-м, мне кажется ты делаешь что-то не так.");
    }
    else if (xr == 3)
    {
        Console.WriteLine("Ого, у тебя ничего не вышло! Я думаю что тебе все же придется...");
    }
    
    Console.ForegroundColor = user_foreground_color_2;
    if (deja_1)
    {
        Console.WriteLine("1) Нажать на красную кнопку");
    }

    if (deja_1 && deja_2)
    {
        Console.WriteLine("2) Дернуть за желтый рычаг");
    }
    else if (!deja_1 && deja_2)
    {
        Console.WriteLine("1) Дернуть за желтый рычаг");
    }

    if (deja_1 && deja_2 && deja_3)
    {
        Console.WriteLine("3) Повернуть синий вентель");
    }
    else if ((!deja_1 || !deja_2) && (deja_1 || deja_2) && deja_3)
    {
        Console.WriteLine("2) Повернуть синий вентель");
    }
    else if (!deja_1 && !deja_2 && deja_3)
    {
        Console.WriteLine("1) Повернуть синий вентель");
    }

    if (deja_1 && deja_2 && deja_3)
    {
        Console.WriteLine("4) Взять себя в руки и дочитать инструкцию");
    }
    else if ((!deja_1 && deja_2 && deja_3) || (deja_1 && !deja_2 && deja_3) || (deja_1 && deja_2 && !deja_3))
    {
        Console.WriteLine("3) Взять себя в руки и дочитать инструкцию");
    }
    else if ((!deja_1 && !deja_2 && deja_3) || (deja_1 && !deja_2 && !deja_3) || (!deja_1 && deja_2 && !deja_3))
    {
        Console.WriteLine("2) Взять себя в руки и дочитать инструкцию");
    }
    else if (!deja_1 && !deja_2 && !deja_3)
    {
        Console.WriteLine("1) Взять себя в руки и дочитать инструкцию");
    }
    pol++;
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                
                if (deja_1)
                {
                    keyInt++;
                    deja_1 = false;
                    Technology_Black_Beliy(pol);
                }
                else if (!deja_1 && deja_2)
                {
                    keyInt++;
                    deja_2 = false;
                    Technology_Black_Beliy(pol);
                }
                else if (!deja_1 && !deja_2 && deja_3)
                {
                    keyInt++;
                    deja_3 = false;
                    Technology_Black_Beliy(pol);
                }
                else if (!deja_1 && !deja_2 && !deja_3)
                {
                    keyInt++;
                    Technology_Black_Beliy_1();
                }
                break;
            case ConsoleKey.D2:
                
                if (deja_1 && deja_2)
                {
                    keyInt++;
                    deja_2 = false;
                    Technology_Black_Beliy(pol);
                }
                else if ((!deja_1 || !deja_2) && (deja_1 || deja_2) && deja_3)
                {
                    keyInt++;
                    deja_3 = false;
                    Technology_Black_Beliy(pol);
                }
                else if ((!deja_1 && !deja_2 && deja_3) || (deja_1 && !deja_2 && !deja_3) || (!deja_1 && deja_2 && !deja_3))
                {
                    keyInt++;
                    Technology_Black_Beliy_1();
                }
                break;
            case ConsoleKey.D3:
                
                if (deja_1 && deja_2 && deja_3)
                {
                    keyInt++;
                    deja_3 = false;
                    Technology_Black_Beliy(pol);
                }
                else if ((!deja_1 && deja_2 && deja_3) || (deja_1 && !deja_2 && deja_3) || (deja_1 && deja_2 && !deja_3))
                {
                    keyInt++;
                    Technology_Black_Beliy_1();
                }
                break;
            case ConsoleKey.D4:

                if (deja_1 && deja_2 && deja_3)
                {
                    keyInt++;
                    Technology_Black_Beliy_1();
                }
                break;
        }
    }
}
void Technology_Black_Beliy_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Инструкция: Перед началом подумать о том куда ты хочешь попасть, после чего зайти в капсулу.\". Фууух, самое сложное позади, а теперь давай воображай, на что фантазия богата.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Динозавры");
    Console.WriteLine("2) Аниме");
    Console.WriteLine("3) Грудастые женщины");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Technology_Black_Dinozavry();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_Black_Beliy_Malakhov();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_Black_Beliy_Malakhov();
                break;
        }
    }
}
void END_Technology_Black_Dinozavry()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_10 != "M9JXK4L7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_10 = "M9JXK4L7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_10"].Value = conf_end_10;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 10");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты зажмурился и зашел в колбу. Открыв глаза ты оказался рядом с динозаврами. Получилось! Или нет... Что-то тут не так. Почему тут камеры? И почему тут другие люди... \"Посторонний человек на площадке! Охрана!\". Кажется ты представил Парк юрского периода и попал на съемочную площадку. Ладно, с кем не бывает.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Technology_Black_Beliy_Malakhov()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (music_value)
    {
        foreach (Process proc in Process.GetProcessesByName("music_zapizdoha.bin"))
        {
            proc.Kill();
        }
    }
    if (sound_value) {zvuk7.Play();}
    Console.WriteLine("Неожиданно для себя ты попал на передачу Малахова. \"Москва, ток-шоу \"Пусть говорят\", в этой студии мы обсуждаем невыдуманные истории о которых невозможно молчать\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ээ, а где онеме?!");
    Console.WriteLine("2) Где большие сиськи!?");
    Console.WriteLine("3) Где хоть что-нибудь!?");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_Black_Beliy_Malakhov_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_Black_Beliy_Malakhov_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_Black_Beliy_Malakhov_2();
                break;
        }
    }
}
void Technology_Black_Beliy_Malakhov_2()
{
    if (music_value)
    {
        Process.Start("soundtracks/music_zapizdoha.bin");
    }
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Сегодня в гостях у нас человек, износиловавший бабушку с четырнадцатым размером груди из-за аниме...\" - По бумаге зачитал Малахов, после чего бабки-сраки недовольно загудели.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ложь и провакация!");
    Console.WriteLine("2) Ну было, и что дальше!? Всего разок ведь...");
    Console.WriteLine("3) Это вы про меня?");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_Black_Beliy_Malakhov_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_Black_Beliy_Malakhov_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_Black_Beliy_Malakhov_3();
                break;
        }
    }
}
void Technology_Black_Beliy_Malakhov_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Скажите пожалуйста, что вами двигало в этот момент?\" - Подсел к тебе Малахов.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Дело в том что мне захотелось подергать за висячие штучки");
    Console.WriteLine("2) Мной двигала любовь..");
    Console.WriteLine("3) Это был косплей на Прохора Шаляпина");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_Black_Beliy_Malakhov_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_Black_Beliy_Malakhov_4();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_Black_Beliy_Malakhov_4();
                break;
        }
    }
}
void Technology_Black_Beliy_Malakhov_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Пенсионеры загудели, а отдельные личности начали неистово кричать в микрофон, разобрать отдельные слова не представлялось возможным. Малахов поспешил успокоить зал, после чего продолжил: \"Так, с мотивами мы разобрались, теперь о последствиях. Чувствуете ли вы вину или раскаяние за содеянное\" - Подсел к тебе Малахов.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Дело в том что мне захотелось подергать за висячие штучки");
    Console.WriteLine("2) И дня не проходит чтобы я не раскаялся");
    Console.WriteLine("3) Чувствуют мелочь в кармане и хер в жопе");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Technology_Black_Malakhov();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Black_Malakhov();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Black_Malakhov();
                break;
        }
    }
}
void END_Technology_Black_Malakhov()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_11 != "K4L7T9XN")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_11 = "K4L7T9XN";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_11"].Value = conf_end_11;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 11");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Там была еще куча вопросов и куча бурных реакций от зала перед тем, как тебя заживо загрызли бабки.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Black()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_12 != "nkdJbSu0")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_12 = "nkdJbSu0";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_12"].Value = conf_end_12;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 12");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("На попе ты прокатился всего по трем ступенькам, все остальное время ты катился кубарем, разваливаясь и хрустя костями. Итогом катаний стали: перелом голени, перелом четырех ребер, перелом позвоночника, перелом копчика, сотрясение мозга и множественные гематомы. Ты бы хоть ледянку взял.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Black_Siniy()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_13 != "Ljn4Td96")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_13 = "Ljn4Td96";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_13"].Value = conf_end_13;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 13");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("По всем канонам Тодда Говарда, ты просто зашел и умер, просто потому что.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Technology_White()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (vid_odejdy == 0)
    {
        Console.WriteLine("Когда ты зашел, то увидел, что внутри все выглядит, куда цивильнее, нежели снаружи. Все вокруг было в лаконичных пастельных тонах, вкруговую стояли уютные голубые диваны, а по центру стоял стеклянный водопад. Ты в нерешительности стоял в холле, пока наконец тебя не встретил какой-то ботан в халате и очках: \"Уважаемый, а вы, собственно, кто? И что вы здесь забыли?!\".");
    }
    else
    {
        Console.WriteLine("Когда ты зашел, то увидел, что внутри все выглядит, куда цивильнее, нежели снаружи. Все вокруг было в лаконичных пастельных тонах, вкруговую стояли уютные голубые диваны, а по центру стоял стеклянный водопад. Ты в нерешительности стоял в холле, пока наконец тебя не встретил какой-то ботан в халате и очках: \"Добрый день, я могу вам чем-нибудь помочь?\".");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я же твой коллега, что, не узнал?");
    Console.WriteLine("2) Я ревизор, прибыл с проверкой");
    Console.WriteLine("3) Я посетитель, просто осматриваюсь тут");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (vid_odejdy == 2)
                {
                    Technology_White_Kollega();
                }
                else
                {
                    END_Technology_Proval();
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (vid_odejdy == 1)
                {
                    Technology_White_Revizor();
                }
                else
                {
                    END_Technology_Proval();
                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                if (vid_odejdy == 1)
                {
                    Technology_White_Posetitel();
                }
                else if (vid_odejdy == 0)
                {
                    END_Technology_Posetitel_Alt();
                }
                else
                {
                    END_Technology_Proval();
                }
                break;
        }
    }
}
void Technology_White_Posetitel()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("УСПЕХ! \"Посетитель значит? тогда давайте пройдемся.\" - Пролепетал ботан и вы пошли по коридору. - \"Здесь у нас находится лаборатория номер 1, в ней мы разрабатываем военного робота.\" Вы зашли в лабораторию, внутри была пара таких же ботанов, которые усердно работали над роботом красовавшимся по центру. Робот выглядел как большой пылесос, на который пластелином прилепили игрушечные ракетницы и пулеметы.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Крууууто");
    Console.WriteLine("2) Афигееееть");
    Console.WriteLine("3) Вот это даааа");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Posetitel_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Posetitel_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Posetitel_1();
                break;
        }
    }
}
void Technology_White_Posetitel_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"А теперь идем дальше.\" - Сказал очкарик и вы прошли дальше по коридору. - \"А вот тут лаборатория номер 2, здесь мы разрабатываем космошаттл.\". Вы зашли в лабораторию, внутри никого не было. Вся лаборатория была обставлена по последнему слову техники, ну а квинтэссенцией сего был гигакомпьютер в центре стены. Всю малину портила проводка, оголенная в некоторых местах. Однако самого космошаттла в ней не было. Со словами \"Одну минутку\" Очкарик прильнул к громадной ЭВМ и беквально через секунд 30 из люка эффектно вышел космошаттл, вернее его каркас напичканный различной электроникой.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Вааау");
    Console.WriteLine("2) Ниифиигаасеее");
    Console.WriteLine("3) Жееесть");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Posetitel_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Posetitel_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Posetitel_2();
                break;
        }
    }
}
void Technology_White_Posetitel_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Здесь все, идем дальше.\" - Сказал очкарик и вы прошли дальше по коридору. - \"А вот тут лаборатория номер 3, здесь мы... В прочем, сам увидишь.\". Вы зашли в лабораторию, внутри было очень темно, по центру стояла большая колба, а перед ней пульт управления, помимо этого в лаборатории ничего не было.ся лаборатория на вид была пустой. \"Заходите в колбу\" - Сказал тебе очкарик, после чего ты послушно зашел внутрь. Когда ты зашел, колба герметично закрылась. \"А теперь я убью тебя, так как ты слишком много знаешь\" - Послышался голос очкарика из динамиков в колбы.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Блиииин");
    Console.WriteLine("2) Ниииееет");
    Console.WriteLine("3) Ни нааадааа");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Technology_Posetitel();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Posetitel();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Posetitel();
                break;
        }
    }
}
void END_Technology_Posetitel()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_14 != "XnfiL0Tt")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_14 = "XnfiL0Tt";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_14"].Value = conf_end_14;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 14");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ботан нажал на кнопку в приборной панели, колба заполнилась газом и ты задохнулся.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Posetitel_Alt()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_15 != "JnkH8fd4")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_15 = "JnkH8fd4";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_15"].Value = conf_end_15;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 15");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("\"Убирайтесь отсюда! Охрана! Выведите этого бомжа отсю... А хотя... Отведите его на стрим-хату...\" - Услышал ты от ботана, прежде чем тебя вырубили. Очнулся ты уже на той самой стрим-хате, которая оказалась логовом треш-стримеров. Было и крещение, и обряды очищения и изгнание духов... Короче говоря ты попал в рабство.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Technology_White_Revizor()
{
    Technology_White_Revizor_Robot();
}
void Technology_White_Revizor_Robot()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("УСПЕХ! \"О, боже, прошу простить, просто мы не ждали вас так рано. Давайте пройдемся\" - Пролепетал ботан и вы пошли по коридору. - \"Здесь у нас находится лаборатория номер 1, разработка военного робота на базе нейросети в ней ведется полным ходом.\" Вы зашли в лабораторию, внутри была пара таких же ботанов, которые усердно работали над роботом красовавшимся по центру. Робот выглядел как большой пылесос, на который пластелином прилепили игрушечные ракетницы и пулеметы. \"Это Иван, руководитель проекта.\" - Отвлек тебя очкарик, показывая ладонью на ботана с внешностью алкаша. Он протянул тебе руку, которую ты пожал. \"Помогу чем смогу...\" - с кислой рожей проговорил ботан-алкоголик, держась за голову.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Включить робота");
    Console.WriteLine("2) Слышал в соседнем магазе бесплатно раздают водку");
    Console.WriteLine("3) Идем дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Robot_No(alkash_ushel);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Revizor_Robot_Ushel();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_1();
                break;
        }
    }
}
void Technology_White_Revizor_Robot_Ushel()
{
    alkash_ushel = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Где!?\" - Оживленно крикнул алкаш, после чего побежал по направлению выхода. Очкарик же просто тяжело выдохнул и потер глаза. \"Прошу прошения, это в первый раз с ним такое, клянусь. Мне правдо очень стыдно, что так вышло, но я думаю, что нужно продолжить проверку.\" - С виноватым видом оправдался он.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Включить робота");
    Console.WriteLine("2) Мне кажется, нужно остановить Ивана");
    Console.WriteLine("3) Идем дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Robot_No(alkash_ushel);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Revizor_Robot_Ushel_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_1();
                break;
        }
    }
}
void Technology_White_Revizor_Robot_Ushel_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Что ж, вы правы, нужно остановить его, пока проблемы не начались.\" - Заявил очкарик и быстрым шагом пошел к выходу. Теперь-то тебе никто не помешает сделать это, в лаборатории конечно остались люди, но они так увлечены работой, что вряд-ли видят дальше собственного носа. Действуй).");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Включить робота");
    Console.WriteLine("2) Дернуть на роботе тумблер включения");
    Console.WriteLine("3) Перевести робота во состояние ON");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Technology_Revizor_Robot();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Revizor_Robot();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Revizor_Robot();
                break;
        }
    }
}
void Technology_White_Revizor_Robot_No(bool au)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (!au)
    {
        Console.WriteLine("Ты потянулся к тумблеру включения, но твою руку перехватил алкаш. \"Сушай, не барагозь, не нужно этого делать...\" - Предупредил он тебя, продолжая держаться за голову.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Включить робота");
        Console.WriteLine("2) Слышал в соседнем магазе бесплатно раздают водку");
        Console.WriteLine("3) Идем дальше");
    }
    else if (au)
    {
        Console.WriteLine("Ты потянулся к тумблеру включения, но твою руку перехватил очкарик. \"Прошу вас не трогать робота, так как это опасно\" - Предупредил он тебя, очкарик.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Включить робота");
        Console.WriteLine("2) Мне кажется, нужно остановить Ивана");
        Console.WriteLine("3) Идем дальше");
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Robot_No(alkash_ushel);
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (!au)
                {
                    Technology_White_Revizor_Robot_Ushel();
                }
                else if (au)
                {
                    Technology_White_Revizor_Robot_Ushel_2();
                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_1();
                break;
        }
    }
}
void END_Technology_Revizor_Robot()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_16 != "0d39HcGx")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_16 = "0d39HcGx";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_16"].Value = conf_end_16;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 16");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("\"РЕжим ликвИдации активирОван\" - Послышалось из робота голосом Говорилки, после чего тот, под крики работников, из всех \"пулеметов\" и \"ракетниц\", залил говном всех и каждого в лаборатории, тебя в том числе, попадая на пол, стены и потолок, после чего засвистел как чайник и взорвался, облепив фекальными массами все, что до этого было по каким-то удивительным причинам чистое. Ты не умер, но сильно зашкварен и продолжать с тобой игру я уже не хочу.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Technology_White_Revizor_1()
{
    Technology_White_Revizor_Kosmoshattl();
}
void Technology_White_Revizor_Kosmoshattl()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Вы прошли дальше по коридору. \"А вот тут лаборатория номер 2, разработка космошаттла хоть и несколько замедлилась, однако все равно идет.\". Вы зашли в лабораторию, внутри никого не было. Вся лаборатория была обставлена по последнему слову техники, ну а квинтэссенцией сего был гигакомпьютер в центре стены. Всю малину портила проводка, оголенная в некоторых местах. Однако самого космошаттла в ней не было, зато, на полке ты заприметил плазмаган. Со словами \"Одну минутку\" Очкарик прильнул к громадной ЭВМ. Ожидаемо, ты прождал гораздо дольше, через 5 минут тебе надоело стоять и смотреть на ботана тыкающего на кнопочки. Мне тоже кста надоело, тем более ты слышишь как тебя зазывает бластер?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Путь завершён, человек, иди ко мне");
    Console.WriteLine("2) Вознаграждён будет только один");
    Console.WriteLine("3) Пришло время, я вижу твоё желание");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_1();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты прикоснулся к бластеру и твое тело словно переполнилось силой, которая уже лилась из краев. Ну! Давай! Куда ты ее направишь?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) В очкарика!");
    Console.WriteLine("2) В компьютер!");
    Console.WriteLine("3) В огнетушитель!");
    Console.WriteLine("4) Положить бластер на место");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Technology_Blaster();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Blaster();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Blaster();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_2();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Зануда! Ботан тем временем походу закончил возиться с приготовлениями, из люка в полу эффектно поднялся космошаттл, ну как космошаттл, какой-то каркас для него или что-то вроде того.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я думаю мне следует доложить об этом начальству");
    Console.WriteLine("2) Мне кажется верхушка не обрадуется моему докладу");
    Console.WriteLine("3) Идем дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_22();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_22()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Дальше ничего нет\" - Чеша репу с виноватым выражением произнес ботан.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) То есть все что у вас, блять, есть, это Пылелятор 2000 и каркас от ВАЗ 2107?!");
    Console.WriteLine("2) То есть миллионы выделенные из госбюджета были проебаны, я правильно понял?!");
    Console.WriteLine("3) Да вы че, ваще ахуели?!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_222();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_222();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_222();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_222()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Да какоке право вы имеете так со мной разговаривать?! Предъявите ваше удостоверение проверяющего!\" - Разгневанно защебетал очкарик.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я не обязан! Ты никто и звать тебя никтак!");
    Console.WriteLine("2) Цыть я сказал! Здесь я хозяин!");
    Console.WriteLine("3) Да ты никто в априори! Не нравится - выход там!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Technology_Proval();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Proval();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Proval();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Может как-нибудь договримся?\" - Как бы невзначай предложил ботан в ответ на замечание.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Может и договоримся...");
    Console.WriteLine("2) Нет! Ты отправляешься в тюрьму!");
    Console.WriteLine("3) Договоримся?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Vzyatka_No();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_4();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ну, я вас богаче сделаю, взамен на то что об этом никто не узнает, понимаете?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Давай");
    Console.WriteLine("2) Нет, я не согласен");
    Console.WriteLine("3) Богаче сделаете?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Vzyatka_No();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_5();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ну, у вас кармашек толще станет, а для верхушки - все замечательно, понимаете?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Давай");
    Console.WriteLine("2) Нет, я не согласен");
    Console.WriteLine("3) Кармашек толще?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Vzyatka_No();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_6();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ну, вы получите за хорошую роботу, а хорошая работа - не говорить о том что вы здесь увидели начальству, понимаете?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Давай");
    Console.WriteLine("2) Нет, я не согласен");
    Console.WriteLine("3) За хорошую работу?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Vzyatka_No();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_7();
                break;
        }
    }
}
void Technology_White_Revizor_Kosmoshattl_7()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ну, я вам даю прибыль, а вы даете молчание, понимаете?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Давай");
    Console.WriteLine("2) Нет, я не согласен");
    Console.WriteLine("3) Даете прибыль?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Revizor_Kosmoshattl_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Vzyatka_No();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Vzyatka();
                break;
        }
    }
}
void END_Technology_Vzyatka_No()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_17 != "XkJch2hL")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_17 = "XkJch2hL";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_17"].Value = conf_end_17;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 17");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ботан свистнул пальцами и за его спиной выросла толпа одинаковых охранников, которая устранила тебя на месте. Слишком уж ты вжился в роль по-моему.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Vzyatka()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_18 != "Ns1T0gL8")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_18 = "Ns1T0gL8";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_18"].Value = conf_end_18;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 18");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ботан продолжик кидать намеки, а ты продолжил их не понимать. \"Ну, ты даешь молчание, а я это компенсирую, понимаете? Ну, я сделаю вам намордник из купюр, понимаете?\", Это продолжалось до тех пор, пока ботан окончательно не разозлился и не позвал охрану, которая прекратила это безумие, путем твоего устранения.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Blaster()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_19 != "JXhd7Jpl")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_19 = "JXhd7Jpl";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_19"].Value = conf_end_19;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 19");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты со всей злости шмальнул из бластера в объект своей ненависти и... Это оказался обычный водяной пистолет, что странно, ведь в другой концовке бластер был настоящий. Однако ущерб тебе все-таки удалось нанести благодаря твоей феноменальной меткости. Вместо своей мишени ты попал в оголенную проводку и тебя шарахнуло током. Да, ущерб ты нанес себе, но все же.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Technology_White_Kollega()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("УСПЕХ! \"Ах, это вы. Прошу простить, мой друг, не узнал, со зрением в последнее время прям беда. Пройдем в лабораторию, у нас еще много работы. Ты, кстати, эрпэ 122 в слоты джи два закодировал?\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да");
    Console.WriteLine("2) Нет");
    Console.WriteLine("3) Что?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Kollega_1(true);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Kollega_1(false);
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Proval();
                break;
        }
    }
}
void Technology_White_Kollega_1(bool kod)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (!kod)
    {
        Console.WriteLine("\"Почему, черт возьми!? Эхх... Снова придется заниматься всем самому...\" - Уныло проворчал очкарик и вы зашли в лабораторию. Вокруг была огромная куча какого-то инновационного флагманского оборудования и, типичные для подобных мест, торчащие оголенные провода. Интересно, откуда и зачем это все в селе? Очкарик подошел к здоровенному компьютеру в центре стены и начал тыркать по кнопочкам. Что-то зашумело как турбина самолета и, в лучших традициях жанра, из большого люка на полу, под аккомпонименты дыма, элегантно медленно кружась, появился космошаттл. Хотя если быть уж совсем честным, до космошаттла ему еще очень далеко. \"Я отойду за новыми чипами, пока постой и ничего не делай. И да, ни в коем случае не трогай кнопку перезагрузки компьютера, система перезагрузки в последнее время барахлит и ведет себя очень нестабильно.\" - Пролепетал ботан и куда-то ушел. А теперь я думаю настало время повеселиться.");
        kod_1 = false;
    }
    else
    {
        Console.WriteLine("\"Отлично! Значит мы уже почти готовы к тестовому запуску!\" - Радостно воскликнул очкарик и вы зашли в лабораторию. Вокруг была огромная куча какого-то инновационного флагманского оборудования и, типичные для подобных мест, торчащие оголенные провода. Интересно, откуда и зачем это все в селе? Очкарик подошел к здоровенному компьютеру и начал тыркать по кнопочкам. Что-то зашумело как турбина самолета и, в лучших традициях жанра, из большого люка на полу, под аккомпонименты дыма, элегантно медленно кружась, появился космошаттл. Хотя если быть уж совсем честным, до космошаттла ему еще очень далеко. \"Я отойду за новыми чипами, пока постой и ничего не делай. И да, ни в коем случае не трогай кнопку перезагрузки компьютера, система перезагрузки в последнее время барахлит и ведет себя очень нестабильно.\" - Пролепетал ботан и куда-то ушел. А теперь я думаю настало время повеселиться.");
        kod_1 = true;
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Покататься на космошаттле");
    Console.WriteLine("2) Перезагрузить компьютер");
    Console.WriteLine("3) Поиграться с оголенной проводкой");
    Console.WriteLine("4) Ничего не делать, ждать ботана");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Kollega_Kosmoshattl();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Technology_Reboot();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Technology_Provodka();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Technology_White_Kollega_2();
                break;
        }
    }
}
void Technology_White_Kollega_Kosmoshattl()
{
    sloman_shattl = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты сел в кабину и попытался его завести дергая ключ зажигания, однако ничего не удалось ибо как я и сказал ранее, здесь по сути один каркас и заводить особо нечего. Этот факт тебя очень сильно разозлил и ты начал со всей силы бить кулаками по приборной панели. Это создало тряску и откуда-то с козырька вывалилась бумажка, прямо тебе в руки. На ней было написано: \"Пароль от бортового компьютера: 2j845gyns73\". Обнаружив эту находку, ты решил попробовать его ввести, однако выяснилось что ты его сломал, когда молотил по приборке. Это тебя разозлило еще больше и ты начал еще сильнее лупить по приборке. В конце концов это закончилось тем, что из под капота пошел дымок.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Быстро вылезти из кабины и увлеченно теребить раскиданную на столе электронику");
    Console.WriteLine("2) Потихому выйти из шаттла и из последних сил делать вид что ничего не замечаешь");
    Console.WriteLine("3) Насвистывая выпорхнуть из шаттла и ковырять пол носком");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Technology_White_Kollega_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Technology_White_Kollega_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Technology_White_Kollega_2();
                break;
        }

    }
}
void Technology_White_Kollega_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Спустя какое-то количество времени очкарик вернулся с каким-то компьютерным хламом в руках. Он начал что-то колдовать с паяльником, изредка метаясь к огромной ЭВМ. Выглядело все это крайне нудно и скучно, но вскоре это все закончилось и ботан крикнул \"Good! Можем запускать, готов удивляться?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Давай быстрее уже, я устал ждать");
    Console.WriteLine("2) Наконец-то, а то я уже состарился");
    Console.WriteLine("3) Запускай уже свою шайтан-машину");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                break;
            case ConsoleKey.D2:
                keyInt++;
                break;
            case ConsoleKey.D3:
                keyInt++;
                break;
        }
    }
    if (kod_1)
    {
        END_Technology_Kollega_1();
    }
    else if (!kod_1 && !sloman_shattl)
    {
        END_Technology_Kollega_2();
    }
    else if (!kod_1 && sloman_shattl)
    {
        END_Technology_Kollega_3();
    }
}
void END_Technology_Kollega_1()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_20 != "ThgN37Ms")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_20 = "ThgN37Ms";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_20"].Value = conf_end_20;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 20");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ботан торжественно нажал на кнопку и все взорвалось к хуям. Хмм, да вы мастера своего дела.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Kollega_2()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_21 != "8RoBb7r6")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_21 = "8RoBb7r6";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_21"].Value = conf_end_21;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 21");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ботан торжественно нажал на кнопку и у шаттла открылась дверь. Это жалкое зрелище вызвало у тебя гнев от бессмысленного ожидания и ты придушил очкарика.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Kollega_3()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_22 != "2x9qLvZr")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_22 = "2x9qLvZr";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_22"].Value = conf_end_22;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 22");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ботан торжественно нажал на кнопку и шаттл развалился по мелким кускам, попутно испустив немного дыма. На лице очкарика повисла нечеловеческая гримасса смеси ужаса и злости, которая медленно поворачивалась в твою сторону. Когда очкарик наконец посмотрел на тебя, он схватил с полки бластер и прожег дыру в твоем черепе. Зато теперь ты знаешь что там был бластер, хотя теперь эта информация уже ни к чему.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Reboot()
{

    Console.Clear();
    keyInt = 0;
    if (conf_end_23 != "mK14kp7N")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_23 = "mK14kp7N";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_23"].Value = conf_end_23;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 23");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Увидимся после перезагрузкиXD");
    Thread.Sleep(300);
    Process.Start("rbt.bat");
    Console.ForegroundColor = user_foreground_color_2;
    while (keyInt <= 0)
    {
        keyInt--;
        keyInt++;
    }
}
void END_Technology_Provodka()
{

    Console.Clear();
    keyInt = 0;
    if (conf_end_24 != "w7h57T2N")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_24 = "w7h57T2N";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_24"].Value = conf_end_24;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 24");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Игра с вышла весьма увлекательной и ты ее прошел, жаль что перепройти ее ты уже не сможешь.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Technology_Proval()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_25 != "wH8uGbx7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_25 = "wH8uGbx7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_25"].Value = conf_end_25;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 25");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("ПРОВАЛ! Твоя ложь была раскрыта, тебя вывела охрана и до смерти забила дубинками.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Ferrari_Avaria()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_26 != "LjMK47rG")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_26 = "LjMK47rG";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_26"].Value = conf_end_26;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 26");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("В скором времени на место прибыл наряды ППС, скорой помощи и МЧС. Тебя скрутили и упаковали в бобик. По приезду в участок тебе предъявили обвинения по целой дюжине статей. Потом был суд и его приговор - пожизненное заключение в колонии строгого режима. Тебя привезли в тюрягу, определили в камеру, и тут... В прочем, это долгая история.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Gazers_Taksofon()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Таксофон, как таксофон.\" - Думал ты обходя ее. Не найдя ничего интересного, ты развирнулся и собрался уходить, как вдруг подул ветер и сзади что-то громко зашуршало. Ты обернулся на звук и увидел балтающееся на длинной ленте скотча, как воздушный змей, цирковое объявление. \"Умная обезъянка Абу снова в нашем зоопарке!\" - Гласит название, снизу указан номер: (505) 104 261-123.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Это мне обязательно пригодится");
    Console.WriteLine("2) Мне ведь это пригодится?");
    Console.WriteLine("3) Да ведь?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers(1);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers(1);
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers(1);
                break;
        }
    }
}
void Gazers_Milk()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты подошел поближе и увидел большой грузовик с цистерной, кривая надпись на которой гласит: \"молоко\". Ты подошел к одному из встревоженных мужиков и поинтересовался о ситуации, на что он отвечает: \"СУУУУУУУУУУУТ!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Что?");
    Console.WriteLine("2) Кто ссут?");
    Console.WriteLine("3) Куда ссут?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Milk_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Milk_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Milk_1();
                break;
        }
    }
}
void Gazers_Milk_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"СУУУУУУУУУУУУУУУУТ!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я немного не понимаю.");
    Console.WriteLine("2) Не могли бы вы разъясняться по-понятнее?");
    Console.WriteLine("3) Речь идет о моче? Я правильно понимаю?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Milk_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Milk_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Milk_2();
                break;
        }
    }
}
void Gazers_Milk_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"СУУУУУУУУУУУУУУУТ!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да уж");
    Console.WriteLine("2) Ага-ага, а она ему что?");
    Console.WriteLine("3) Я думаю, что так мы ни к чему не придем");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Milk_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Milk_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Milk_3();
                break;
        }
    }
}
void Gazers_Milk_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"СУУУУУУУУУУУУУУУУУУТ!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Что тебе делают на голову?");
    Console.WriteLine("2) Твои родители мне не со...");
    Console.WriteLine("3) Скажи \"сут\", если сосал");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Milk_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Milk_4();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Milk_4();
                break;
        }
    }
}
void Gazers_Milk_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"СУУУУУУУУУУУУУУУУУУУУУУУУУУУТ!!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ты, я так понимаю, вообще других слов не знаешь?");
    Console.WriteLine("2) Ты надо мной поиздеваться решил типа?");
    Console.WriteLine("3) Че \"сут\" то?! Ну вот че \"сут\"!?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Milk_5();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Milk_5();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Milk_5();
                break;
        }
    }
}
void Gazers_Milk_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"СУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУТ!!!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Суут!");
    Console.WriteLine("2) Сууууут!");
    Console.WriteLine("3) СУУУУУУУТ!!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Milk_6();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Milk_6();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Milk_6();
                break;
        }
    }
}
void Gazers_Milk_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"СУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУТ!!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("3) СУУУУУУУУУУУТ!!");
    Console.WriteLine("3) СУУУУУУУУУУУУТ!!");
    Console.WriteLine("3) СУУУУУУУУУТ!!!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers_Milk_7();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Milk_7();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Milk_7();
                break;
        }
    }
}
void Gazers_Milk_7()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"СУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУТ!!!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("3) СУУУУУУУУУУУУУТ!!!");
    Console.WriteLine("3) СУУУУУУУУУУУТ!!!");
    Console.WriteLine("3) СУУУУУУУУУУУУТ!!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Gazers_Milk();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Gazers_Milk();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Gazers_Milk();
                break;
        }
    }
}
void END_Gazers_Milk()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_27 != "7K4LjreM")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_27 = "7K4LjreM";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_27"].Value = conf_end_27;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 27");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("СУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУТ!!!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Gazers_Monah_Obresti()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Готов ли ты получить великую силу?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Нет");
    Console.WriteLine("2) Да");
    Console.WriteLine("3) Избить монаха");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers(1);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Monah_Obresti_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                if (kolco_vsemogushestva)
                {
                    END_Gazers_Monah_Alt_Good();
                }
                else
                {
                    END_Gazers_Monah_Alt_Bad();
                }
                break;
        }
    }
}
void Gazers_Monah_Obresti_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"В таком случае, дабы доказать свою готовность, ты должен пройти тест. Тест состоит из шести вопросов, в случае правильного ответа, происходит переход на следующий вопрос, в случае неправильного - мгновенная смерть. А теперь поехали.\"");
    Console.WriteLine("\"Первый вопрос: Какого символа нет в пароле для космошаттла?\"");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) g");
    Console.WriteLine("2) 3");
    Console.WriteLine("3) j");
    Console.WriteLine("4) f");
    Console.WriteLine("5) y");
    Console.WriteLine("6) 4");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Gazers_Monah_Obresti_2();
                break;
            case ConsoleKey.D5:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D6:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
        }
    }
}
void Gazers_Monah_Obresti_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Верно! Второй вопрос: Сколько лестниц в бункере?\"");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) 1");
    Console.WriteLine("2) 2");
    Console.WriteLine("3) 3");
    Console.WriteLine("4) 4");
    Console.WriteLine("5) 5");
    Console.WriteLine("6) 6");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Monah_Obresti_3();
                break;
            case ConsoleKey.D4:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D5:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D6:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
        }
    }
}
void Gazers_Monah_Obresti_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Правильно! Третий вопрос: Какой вопрос нельзя задать Оперу?\"");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ежчан?");
    Console.WriteLine("2) ППО?");
    Console.WriteLine("3) Кто ты?");
    Console.WriteLine("4) Моча?");
    Console.WriteLine("5) Задание?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Gazers_Monah_Obresti_4();
                break;
            case ConsoleKey.D5:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
        }
    }
}
void Gazers_Monah_Obresti_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Верно! Четвертый вопрос: Нажми кнопку, которая в одной из концовок ведет к секретной концовке.\"");

    Console.ForegroundColor = user_foreground_color_2;


    KeyOtvet = Console.ReadKey();
    switch (KeyOtvet.Key)
    {
        case ConsoleKey.Escape:
            keyInt++;
            ToMainMenu();
            break;
        case ConsoleKey.F:
            Gazers_Monah_Obresti_5();
            break;
        default:
            END_Gazers_Monah_Bad();
            break;
    }
}
void Gazers_Monah_Obresti_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Отлично! Теперь вопросы с повышенной сложностью. Пятый вопрос: Сколько концовок ведут к DLC?\"");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) 1");
    Console.WriteLine("2) 2");
    Console.WriteLine("3) 3");
    Console.WriteLine("4) 4");
    Console.WriteLine("5) 5");
    Console.WriteLine("6) 6");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D4:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers_Monah_Obresti_6();
                break;
            case ConsoleKey.D5:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
            case ConsoleKey.D6:
                keyInt++;
                END_Gazers_Monah_Bad();
                break;
        }
    }
}
void Gazers_Monah_Obresti_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Точно! И наконец самый сложный шестой вопрос: Напиши максимально короткую комбинацию ответов, которая ведет к секретной ветке. Например комбинация \"22111111\" ведет к ветке с моргом.\"");

    Console.ForegroundColor = black_text;
    Console.WriteLine("Введи число: ");
    Console.ForegroundColor = user_foreground_color_2;
    string stavka_string;
    stavka_string = Console.ReadLine();
    if (long.TryParse(stavka_string, out stavka))
    {
        stavka = Convert.ToInt64(stavka_string);
    }
    else
    {
        END_Gazers_Monah_Bad();
    }
    if (stavka == 233323124 || stavka == 233312234 || stavka == 231233234 || stavka == 231223334 || stavka == 232333124 || stavka == 232312334)
    {
        Gazers_Monah_Obresti_Kolco();
    }
    else
    {
        END_Gazers_Monah_Bad();
    }
}
void Gazers_Monah_Obresti_Kolco()
{
    kolco_vsemogushestva = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Поздравляю тебя с прохождением теста! Ты ответил правильно на все вопросы, а значит свою часть договора ты выполнил, теперь моя часть.\" - Монах вручил тебе кольцо. - \"Сила в кольце, прими его, смотри не разочаруйся...\"");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Надеть кольцо и уйти");
    Console.WriteLine("3) Надеть кольцо и избить монаха");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers(1);
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Gazers_Monah_Alt_Good();
                break;
        }
    }
}
void Gazers_Monah_Otdat()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Готов ли ты расстаться с великой силой?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Нет");
    Console.WriteLine("2) Да");
    Console.WriteLine("3) Избить монаха");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers(1);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers_Monah_Otdat_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                if (kolco_vsemogushestva)
                {
                    END_Gazers_Monah_Alt_Good();
                }
                else
                {
                    END_Gazers_Monah_Alt_Bad();
                }
                break;
        }
    }
}
void Gazers_Monah_Otdat_1()
{
    kolco_vsemogushestva = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Хорошо, тогда я забираю у тебя кольцо. Если что, ты в любой момент можешь повторно пройти процедуру его получения.\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Договорились");
    Console.WriteLine("2) Бла-бла-бла... Забирай и пошел в задницу!");
    Console.WriteLine("3) Bazar");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gazers(1);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gazers(1);
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gazers(1);
                break;
        }
    }
}
void END_Gazers_Monah_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_28 != "L9FFK7N3")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_28 = "L9FFK7N3";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_28"].Value = conf_end_28;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 28");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Внезапно ты умер, видимо названный тобой ответ оказался неправильным.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Gazers_Monah_Alt_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_29 != "X9J7NK4M")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_29 = "X9J7NK4M";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_29"].Value = conf_end_29;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 29");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("За твои действия, Немезида мгновенно покарала тебя, отобрав у тебя остатки интеллекта. Теперь ты обречен всю оставшуюся жизнь пускать слюни и играть в мобильные игры.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Gazers_Monah_Alt_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_30 != "by7BDb36")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_30 = "by7BDb36";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_30"].Value = conf_end_30;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 30");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Немезида спустилась к тебя чтобы покарасть тебя за твои действия, но ты, словно Ван Панч Мэн, расщепил ее на атомы. Будь горд! Ты избил беспомощного монаха и остался безнаказанным!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Gazers()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_31 != "JnsO8ev7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_31 = "JnsO8ev7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_31"].Value = conf_end_31;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 31");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Решение оказалось не слишком разумным. Ты сначала сварился, а после разлетелся на мелкие куски от потока мощной струи.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Bunkar(int bunk)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (bunk == 0)
    {
        Console.WriteLine("Ты аккуратно начал спускаться по лестнице, а потом хоп! и ты уже не просто спускаешься, нет, ты летишь! Но не как птица, а как булыжник. С секунды спустя ты смачно шмякнулся задницей на бетонный пол, а следом за тобой на твою голову и лестница, не выдержавшая такую пушинку. Ладно, разрешаю выматериться.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Ебаное блядство!");
        Console.WriteLine("2) Ебал я рот этих лестниц ебаных!!");
        Console.WriteLine("3) Пидаристическое говно нахуй! Заебись просто блять!");
    }
    else if (bunk == 1)
    {
        Console.WriteLine("Ты начал орать как душевнобольшной, слыша твои крики, птицы улепетывали в страхе. Но тебе, похоже, было этого недостаточно, ты ни на секунду не непрекращая орать лег на землю и попутно вырывая волосы с головы, начал кататься колбаской, и даже как-то успевал плакать. Сколько там Юлий Цезарь мог делать дел одновременно? Три? Так ты круче него! Целых 4 дела! А в последствии и все пять: Орать, Рвать волосы, кататься, плакать и падать в открытый люк. Но последнее ты уже делал неосознанно, так как ты этого просто не заметил со своим истеричным припадком. В конце концов ты больно-больно упал на спину, что заставило тебя придти в себя.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Встать, смахнуть с себя грязь, поправить волосы, осмотреться с интелегентным видом");
        Console.WriteLine("2) Оглядываясь быстро встать испытывая неодержимый стыд, что кто-то тебя увидел");
        Console.WriteLine("3) Истерика - есть, осталось жестко запаниковать.");
    }
    else if (bunk == 2)
    {
        spichki = false;
        odejda = false;
        gor_step = true;
        Console.WriteLine("Ты взял спички и, истратив все, смог таки поджечь пару травинок, однако в такую жару, хватило и этого, для того, чтобы в считанные минуты воспылала вся степь. Тебя охватила паника и ты начал глупые попытки потушить пожар, что привело к тому, что теперь горишь уже ты сам. Ты вспомнил что каком-то видео на ютуб говорилось, что если ты горишь, надо кататься по земле. Ты начал кататься и в панике укатился в самое пекло. Кошмар! А нет, ты скатился какой-то люк. Глубокий, надо сказать, однако поскольку ты находился в шоковом состоянии, да еще и горел, ты этого не заметил. Не заметил ни самой высоты, ни боли от падения с нее, зато ты заметил, что не горишь.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Заюзать насмешку Поджигатиля из TF2");
        Console.WriteLine("2) Пафосно затушить небольшой огонек на груди");
        Console.WriteLine("3) Сделать вид что все произошедшее было так и задуманно");
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Bunkar_1(false);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Bunkar_1(false);
                break;
            case ConsoleKey.D3:
                keyInt++;
                if (bunk == 1)
                {
                    END_Bunker_Panika();
                }
                else
                {
                    Bunkar_1(false);
                }
                break;
        }
    }
}
void END_Bunker_Panika()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_32 != "HAn09w3b")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_32 = "HAn09w3b";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_32"].Value = conf_end_32;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 32");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Зрелище, должен сказать, было жалким. Ты в абсолютной темноте, один, просто бегал и орал схватившись за голову, пока твои потуги не прервала арматура вонзившаяся в твою голову.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Bunkar_1(bool byl_li)
{
    pred_komnata = 1;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (byl_li)
    {
        Console.WriteLine("Ты заметил свет с потолка и решил подойти посмотреть. Подойдя поближе, ты увидел сломанную лестницу. Ты пришел в самое начало.");
    }
    else
    {
        Console.WriteLine("Осмотревшись ты заметил, что находишься в каком-то похожем на бункер месте, а может это и есть бункер, шут его знает. Лестница сломана, так что братно подняться не представляетсся возможным. Зато перед тобой два прохода - налево и направо. В какую сторону идем?");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Bunkar_12();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Bunkar_2();
                break;
        }
    }
}
void Bunkar_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 1:
                        pred_komnata = 2;
                        Bunkar_4();
                        break;
                    case 4:
                        pred_komnata = 2;
                        Bunkar_3();
                        break;
                    case 3:
                        pred_komnata = 2;
                        Bunkar_1(true);
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 1:
                        pred_komnata = 2;
                        Bunkar_3();
                        break;
                    case 4:
                        pred_komnata = 2;
                        Bunkar_1(true);
                        break;
                    case 3:
                        pred_komnata = 2;
                        Bunkar_4();
                        break;
                }
                break;
        }
    }
}
void Bunkar_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 5:
                        pred_komnata = 3;
                        Bunkar_2();
                        break;
                    case 4:
                        pred_komnata = 3;
                        Bunkar_5();
                        break;
                    case 2:
                        pred_komnata = 3;
                        Bunkar_4();
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 5:
                        pred_komnata = 3;
                        Bunkar_4();
                        break;
                    case 4:
                        pred_komnata = 3;
                        Bunkar_2();
                        break;
                    case 2:
                        pred_komnata = 3;
                        Bunkar_5();
                        break;
                }
                break;
        }
    }
}
void Bunkar_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 6:
                        pred_komnata = 4;
                        Bunkar_3();
                        break;
                    case 3:
                        pred_komnata = 4;
                        Bunkar_2();
                        break;
                    case 2:
                        pred_komnata = 4;
                        Bunkar_6();
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 6:
                        pred_komnata = 4;
                        Bunkar_2();
                        break;
                    case 3:
                        pred_komnata = 4;
                        Bunkar_6();
                        break;
                    case 2:
                        pred_komnata = 4;
                        Bunkar_3();
                        break;
                }
                break;
        }
    }
}
void Bunkar_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Блуждания по темным коридорам привели тебя в какую-то подсобку. Разглядеть хоть что-то не представлялось возможным из-за дыма. В дыму показалось две фигуры: розовая и желтая. желтая говорит в твою сторону: \"Эй, чувак, пошли покумарим.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) А давай");
    Console.WriteLine("2) Почему бы и нет");
    Console.WriteLine("3) Не будь душнилой, раскумарься с типами, это всего лишь игра!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Bunkar_Keks_i_Ukrop_0();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Bunkar_Keks_i_Ukrop_0();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Bunkar_Keks_i_Ukrop_0();
                break;

        }
    }
}
void Bunkar_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка... Постой... Это же Сус!! Увидев тебя он говорит: \"Привет, слушай, ты не видел Камрада? Я его тут уже часа полтора жду, а он все не приходит.\" Тут из-за поворота выбегает Камрад с воплями: \"ТАМ ОХРАНА! БЕЖИМ!\". \"Бежим с нами дружище!\" - кричит тебе Сус и убегает вслед за Камрадом. Решай теперь.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Бежать с ними");
    Console.WriteLine("2) Бежать одному");
    Console.WriteLine("3) Не бежать");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Bunkar_Sus();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Bunkar_6();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Bunkar_6();
                break;

        }
    }
}
void Bunkar_7()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 5:
                        pred_komnata = 7;
                        Bunkar_6();
                        break;
                    case 6:
                        pred_komnata = 7;
                        Bunkar_8();
                        break;
                    case 8:
                        pred_komnata = 7;
                        Bunkar_5();
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 5:
                        pred_komnata = 7;
                        Bunkar_8();
                        break;
                    case 6:
                        pred_komnata = 7;
                        Bunkar_5();
                        break;
                    case 8:
                        pred_komnata = 7;
                        Bunkar_6();
                        break;
                }
                break;
        }
    }
}
void Bunkar_8()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 7:
                        pred_komnata = 8;
                        Bunkar_10();
                        break;
                    case 9:
                        pred_komnata = 8;
                        Bunkar_7();
                        break;
                    case 10:
                        pred_komnata = 8;
                        Bunkar_9();
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 7:
                        pred_komnata = 8;
                        Bunkar_9();
                        break;
                    case 9:
                        pred_komnata = 8;
                        Bunkar_10();
                        break;
                    case 10:
                        pred_komnata = 8;
                        Bunkar_7();
                        break;
                }
                break;
        }
    }
}
void Bunkar_9()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Тебе на пути попадается свисающая с потолка лестница. Над лестницей виднеется люк. Поднимешься или продолжишь бродить по коридорам?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подняться");
    Console.WriteLine("2) Идти дальше");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Morg(true);
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 11:
                        pred_komnata = 9;
                        Bunkar_8();
                        break;
                    case 8:
                        pred_komnata = 9;
                        Bunkar_11();
                        break;
                }
                break;
        }
    }
}
void Bunkar_10()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 8:
                        pred_komnata = 10;
                        Bunkar_13();
                        break;
                    case 11:
                        pred_komnata = 10;
                        Bunkar_8();
                        break;
                    case 13:
                        pred_komnata = 10;
                        Bunkar_11();
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 8:
                        pred_komnata = 10;
                        Bunkar_11();
                        break;
                    case 11:
                        pred_komnata = 10;
                        Bunkar_13();
                        break;
                    case 13:
                        pred_komnata = 10;
                        Bunkar_8();
                        break;
                }
                break;
        }
    }
}
void Bunkar_11()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 9:
                        pred_komnata = 11;
                        Bunkar_10();
                        break;
                    case 10:
                        pred_komnata = 11;
                        Bunkar_12();
                        break;
                    case 12:
                        pred_komnata = 11;
                        Bunkar_9();
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 9:
                        pred_komnata = 11;
                        Bunkar_12();
                        break;
                    case 10:
                        pred_komnata = 11;
                        Bunkar_9();
                        break;
                    case 12:
                        pred_komnata = 11;
                        Bunkar_10();
                        break;
                }
                break;
        }
    }
}
void Bunkar_12()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 1:
                        pred_komnata = 12;
                        Bunkar_11();
                        break;
                    case 11:
                        pred_komnata = 12;
                        Bunkar_13();
                        break;
                    case 13:
                        pred_komnata = 12;
                        Bunkar_1(true);
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 1:
                        pred_komnata = 12;
                        Bunkar_13();
                        break;
                    case 11:
                        pred_komnata = 12;
                        Bunkar_1(true);
                        break;
                    case 13:
                        pred_komnata = 12;
                        Bunkar_11();
                        break;
                }
                break;
        }
    }
}
void Bunkar_13()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Еще одна развилка.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Налево");
    Console.WriteLine("2) Направо");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                switch (pred_komnata)
                {
                    case 12:
                        pred_komnata = 13;
                        Bunkar_10();
                        break;
                    case 10:
                        pred_komnata = 13;
                        Bunkar_6();
                        break;
                    case 6:
                        pred_komnata = 13;
                        Bunkar_12();
                        break;
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                switch (pred_komnata)
                {
                    case 12:
                        pred_komnata = 13;
                        Bunkar_6();
                        break;
                    case 10:
                        pred_komnata = 13;
                        Bunkar_12();
                        break;
                    case 6:
                        pred_komnata = 13;
                        Bunkar_10();
                        break;
                }
                break;
        }
    }
}
void Bunkar_Keks_i_Ukrop_0()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Подойдя к ним поближе, ты понял, что это, мать их, Кекс и Укроп! Вы сели, словили жесткий раскумар и рубанулись в плойку. \"Давай еще забьем!\" - Утвердительно произнес Укроп.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) И еще по колпачку");
    Console.WriteLine("2) И еще по колпачку");
    Console.WriteLine("3) Хапачку за мамочку, за папу хапачку");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Bunkar_Keks_i_Ukrop();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Bunkar_Keks_i_Ukrop();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Bunkar_Keks_i_Ukrop();
                break;

        }
    }
}
void Bunkar_Keks_i_Ukrop()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Подойдя к ним поближе, ты понял, что это, мать его, Кекс и Укроп! Вы пару раз дунули, поиграли в плойку, потом еще пару раз дунули, потом еще поиграли, и тут Укроп говорит: \"Кончилось...\" Кекс подумал-подумал и говорит: \"Можем либо коки долбануть, либо подняться наверх и нарубить самых отборных шишичек выращенных мной.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Шишки");
    Console.WriteLine("2) Кока");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (gor_step)
                {
                    END_Bunkar_Keks_i_Ukrop_Shishki_Bad();
                }
                else
                {
                    END_Bunkar_Keks_i_Ukrop_Shishki_Good();
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (karty)
                {
                    END_Bunkar_Keks_i_Ukrop_Koka_Good();
                }
                else
                {
                    END_Bunkar_Keks_i_Ukrop_Koka_Bad();
                }
                break;

        }
    }
}
void END_Bunkar_Keks_i_Ukrop_Koka_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_33 != "hYq4z2aV")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_33 = "hYq4z2aV";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_33"].Value = conf_end_33;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 33");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Кекс сбегал за пакетами и вы принялись насыпать их содержимое на стол. Когда дело пришло до потребления, оказалось что не оказалось карты, но ты спас ситуацию, достав из кармана колоду игральных карт. Кайф удался, good end.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Bunkar_Keks_i_Ukrop_Koka_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_34 != "2wJRe83u")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_34 = "2wJRe83u";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_34"].Value = conf_end_34;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 34");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Кекс сбегал за пакетами и вы принялись насыпать их содержимое на стол. Когда дело пришло до потребления, оказалось что не оказалось карты, ты пошарил по карманам и тоже ничего не нашел. Ты решил забить на это и стал делать все пальцем и просыпал пару песчинок на пол. Такого не смог выдержать никто из присутствующих и всех троих хватил сердечный приступ. Кайф не удался, bad end.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Bunkar_Keks_i_Ukrop_Shishki_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_35 != "J7Mdh623")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_35 = "J7Mdh623";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_35"].Value = conf_end_35;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 35");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Вы поднялись на поверхность по лестнице из подсобки и оказались на огромной плантации. Только вот есть загвоздка, пожар который ты устроил в степи полностью ее уничтожил. Вид вызженной пустоши мгновенно вызвал у всех вас троих остановку сердца.");
    Console.WriteLine("We mash up the place, turn up the bass, and make them all have fun (Fun) A-we a blaze the fire, make it bun dem We mash up the place, turn up the bass, and make some sound boy run (Run) A-we will end your week just like a Sunday");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Bunkar_Keks_i_Ukrop_Shishki_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_36 != "H8w3bYss")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_36 = "H8w3bYss";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_36"].Value = conf_end_36;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 36");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Вы поднялись на поверхность по лестнице из подсобки и оказались на огромной плантации. Вы нарвали самых убойных и сочных шишичек и упоролись настолько сильно, что никого из вас так и не отпустило к смерти.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Bunkar_Sus()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Вы бежали сначала по коридорам, потом по тунелям, потом каким-то боком оказались в метро, где забежали в какую-то пещеру, а потом... у Камрада с Сусом сел фонарик, а темно, хоть глаз выколи. И тут Камрад задает тебе уместный вопрос: \"Спички есть? Факел сделать.\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да");
    Console.WriteLine("2) Нет");
    Console.WriteLine("3) Обматерить Камрада за безответственность");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (spichki)
                {
                    Bunkar_Sus_2();
                }
                else
                {
                    END_Bunkar_Sus_NetSpichek();
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Bunkar_Sus_No();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Bunkar_Sus_Alt();
                break;

        }
    }
}
void Bunkar_Sus_2()
{
    spichki = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты без труда достал спички из кармана и передал их Камраду. Немного повозившись, факел был готов. Пара минут и вы выбрались на поверхность где-то в лесу. Казалось бы, пора расходиться, но тут Сус тебе говорит: \"Слушай, друг, а не хочешь пойти с нами?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Разумеется хочу!");
    Console.WriteLine("2) Извините, но у меня своя дорога");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Bunkar_Sus_Yes();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Bunkar_Sus_3();
                break;

        }
    }
}
void Bunkar_Sus_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ну, как знаешь.\" - Сказал тебе Камрад и начал уходить, но резко остановился, подошел к тебе какую-то бумажку. \"Это тебе благодарность за спички.\" -  договорил он, и ушел. На бумажке был написан номер, подписанный как \"Старший\". Номер следующий: 532-325-322, это может пригодиться.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ок");
    Console.WriteLine("2) Ясно");
    Console.WriteLine("3) Пон");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_1();
                break;

        }
    }
}
void END_Bunkar_Sus_Yes()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_37 != "hRfv5s7G")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_37 = "hRfv5s7G";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_37"].Value = conf_end_37;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 37");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("И пошел ты вместе с ними. Вы вместе снимали ролики на Ютуб про проникновения во всякие катакомбы, а потом и вовсе придумали новый формат - дегустация радиоактивных металлов! Снимали рубрику о реставрации Чернобыльского реактора... В общем, все у тебя было отлично, за исключением того, что в старости у тебя светился член, хотя это вроде не так плохо...");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Bunkar_6()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_38 != "TG7h63bG")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_38 = "TG7h63bG";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_38"].Value = conf_end_38;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 38");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты быстро был пойман охраной, затем тебя повезли в участок, разбирательства-суды, бла-бла-бла. Короче говоря тебя посадили за незаконное проникновение.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Bunkar_Sus_Alt()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_39 != "LhsYYji0")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_39 = "LhsYYji0";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_39"].Value = conf_end_39;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 39");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Комрада хватило всего на пару оскарблений, затем он просто тебя вырубил. Ты больше не проснулся.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Bunkar_Sus_NetSpichek()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_40 != "BJwb78fF")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_40 = "BJwb78fF";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_40"].Value = conf_end_40;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 40");
    Console.ForegroundColor = user_foreground_color_1;
    if (spichki == false && gor_step == true)
    {
        Console.WriteLine("Ты засунул руки в карманы и не нашел там спичек, ну конечно! Кто-то предусмотрительно решил поиграть в поджигателя и истратить все спички! Молодец просто! Вот твоя концовка за твою ответственность и предусмотрительность.");

    }
    else if (spichki == false && gor_step == false)
    {
        Console.WriteLine("Ты засунул руки в карманы и не нашел там спичек, ну конечно! Кто-то предусмотрительно решил выбросить все спички на дорогу! Ведь действительно, зачем они нужны!? Молодец просто! Вот твоя концовка за твою ответственность и предусмотрительность.");

    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Bunkar_Sus_No()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_41 != "J67gJ4N7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_41 = "J67gJ4N7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_41"].Value = conf_end_41;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 41");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Этот ответ опечалил все команду, но это уже неважно, ведь уже через пару минут из кромешной темноты пещеры вылезла злобная чубака, которая всех вас сожрала.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Stepi()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты решил пойти в степь. Сделав шагов 10 от дороги, ты чуть не упал в открытый люк. Дна ты не увидел, что решишь?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Спуститься");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Bunkar(0);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_1();
                break;
        }
    }
}
void Stepi_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Пройдя по степи метров 500, ты увидел деда отчаянно лупящего поворешкой по одиноко стоящей аккации.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подойти к деду");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Ded();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_2(0);
                break;
        }
    }
}
void Stepi_Ded()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ты че ебанутый?\" - обронил ты, наблюдая за непонятными действиями деда сунув руки в карманы. Дед повернулся к тебе и с улыбкой сказал: \"Я ждал тебя.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) И зачем же?");
    Console.WriteLine("2) Показать фак");
    Console.WriteLine("3) Дать деду пиздюлей");
    Console.WriteLine("4) Уйти пока не поздно");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Ded_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Ded_Fuck();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Stepi_Ded_Izbit();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Stepi_2(0);
                break;
        }
    }
}
void Stepi_Ded_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ты - приемник моего дела. Твое предназначение решено судьбою и изменить его нельзя.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я - твой приемник?");
    Console.WriteLine("2) Показать фак");
    Console.WriteLine("3) Уйти пока не поздно");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Ded_2(false);
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Ded_Fuck();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Stepi_Ded_2(true);
                break;
        }
    }
}
void Stepi_Ded_2(bool uyti)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (uyti)
    {
        Console.WriteLine("Поздно! \"Мои дни уже сочтены, но у тебя... У тебя еще все впереди, а потому ты должен продолжить то, ради чего жил я, жил мой наставник, жили все кто был до нас с тобой, и будешь жить ты.\".");
    }
    else
    {
        Console.WriteLine("\"Да, мои дни уже сочтены, но у тебя... У тебя еще все впереди, а потому ты должен продолжить то, ради чего жил я, жил мой наставник, жили все кто был до нас с тобой, и будешь жить ты.\".");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) О каком деле ты говоришь?");
    Console.WriteLine("2) Показать фак");
    Console.WriteLine("3) Уйти пока не поздно");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Ded_3(false, 0);
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Ded_Fuck();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Stepi_Ded_3(true, 0);
                break;
        }
    }
}
void Stepi_Ded_3(bool uyti, int vijid)
{
    Console.Clear();
    keyInt = 0;
    if (mine>4)
    {
        END_Stepi_Ded_Ojidanie();
    }
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (uyti && vijid==0)
    {
        Console.WriteLine("Поздно! \"Твое дело состоит в том, чтобы бить это священное дерево этим священным артефактом\" - Сказал он и протянул тебе поварешку. - \"Держи и приступай.\" Ты взял эту поварешку. Дед выжидающе смотрит на тебя.");
    }
    else if (!uyti && vijid == 0)
    {
        Console.WriteLine("\"\"О каком деле я говорю...\" А ты сам-то еще не понял? Твое дело состоит в том, чтобы бить это священное дерево этим священным артефактом\" - Сказал он и протянул тебе поварешку. - \"Держи и приступай.\" Ты взял эту поварешку. Дед выжидающе смотрит на тебя.");
    }
    else if (vijid == 1)
    {
        Console.WriteLine("На деда эта провокация не подействовала, он продолжил смотреть на тебя в ожидании чего-то.");
    }
    else if (vijid == 2)
    {
        Console.WriteLine("Дед все также сверлит тебя взглядом, мне кажется, что он от тебя чего-то хочет.");
    }
    else if (vijid == 3)
    {
        Console.WriteLine("Битва молчаливых ожиданий продолжается! Я напомню что МС слева - OxxxyЖИДание, а МС справа - Слава Кp.s. давай быстрее уже решай!");
    }
    else if (vijid == 4)
    {
        Console.WriteLine("Это очень суровое, по-настоящему мужское противостояние, исход которого не ясен. Очевидно, что каждая сторона рассчитывает на победу. Впрочем, я уже согласен на ничью.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подойти к дереву и заниматься \"делом\"");
    Console.WriteLine("2) Показать фак");
    Console.WriteLine("3) Сразмаху втащить деду поварешкой по голове");
    Console.WriteLine("4) Выжидающе смотреть на него в ответ");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Ded_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Ded_Fuck();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Stepi_Ded_Izbit();
                break;
            case ConsoleKey.D4:
                keyInt++;
                mine++;
                Stepi_Ded_3(false, mine);
                break;
        }
    }
}
void Stepi_Ded_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты подошел к дереву и... Начал колотить его поварешкой, тебе очень хотелось уйти, но за твоей спиной стоял дед, то и дело злобно пыхтя тебе в ухо. Через некоторое время ему это надоело и он пошел. Ты решил дождаться пока он пропадет за горизонтом, чтобы уйти со спокойной душой. И вот, когда он наконец скрылся, ты решил...");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Посвятить \"делу\" всю жизнь");
    Console.WriteLine("2) Идти дальше");
    Console.WriteLine("3) Проглатить поварешку");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Stepi_Ded_Delo();
                break;
            case ConsoleKey.D2:
                keyInt++;
                povareshka = true;
                Stepi_2(1);
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Stepi_Ded_Povareshka();
                break;
        }
    }
}
void END_Stepi_Ded_Ojidanie()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_42 != "GuGo3e37")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_42 = "GuGo3e37";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_42"].Value = conf_end_42;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 42");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Вы так еще долго простояли, вот прям реально долго, часов 14 наверное. Простояли бы скорее всего и еще, если бы не пришел лев и не сожрал вас обоих, вы ведь в степи были, забыл?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Ded_Delo()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_43 != "Mu2ecn7k")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_43 = "Mu2ecn7k";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_43"].Value = conf_end_43;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 43");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("В смысле? Ты же уйти собирался? Давай дальше, там столько всего интересного! Нет? Ну и оставайся. На сколько тебя хватило я не знаю, я ушел через неделю твоего безумия, так как ничего интересного не происходило - ты продолжал лупить свое \"священное дерево\" своим \"священным артефактом\". Однако учитывая твое упорство, могу спрогнозировать наверняка - ты занимался этим до самой смерти.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Ded_Fuck()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_44 != "nbz38web")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_44 = "nbz38web";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_44"].Value = conf_end_44;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 44");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Дед Нацепил гримасу самого злобного из всех существующих в мире оскалов и яростно ткнул тебе в харю своим факом. Ты поначалу растерялся, но потом все же пришел в себя и снова показал фак. Дед решил ответить и во второй раз показал тебе фак, но ты-то не пальцем деланный и с уверенными щами дал деду понюхать свой фак... Так продолжалось до тех пор пока деду наконец не надоело и он не угандошил тебя поварешкой.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Ded_Povareshka()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_45 != "An74mM6n")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_45 = "An74mM6n";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_45"].Value = conf_end_45;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 45");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Чего? Зачем? Да стой ты, эта поварешка большая, у нее черпак как тазик, да погоди ты, эй, ты что делаешь? Стой!.. Ого... А ну-ка... Давай-давай, чуть-чуть осталось... Вот это пластичность! Ну молодец! Проглатил двухметровый агрегат! Жаль, что ты порвал себе тем самым все внутренности и умер.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Stepi_Ded_Izbit()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Дело сделано, я думаю можно пойти дальше.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Обхаркать валяющегося без сознания деда");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Ded_Izbit_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_2(0);
                break;
        }
    }
}
void Stepi_Ded_Izbit_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Так, ну, слюни у тебя увы или к счастью не бесконечные, пора идти дальше.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Обоссать лежачего обплеванного деда");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Ded_Izbit_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_2(0);
                break;
        }
    }
}
void Stepi_Ded_Izbit_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Угу... Ну допустим что ты это сделал");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Насрать на голову и без того униженного деда.");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Ded_Izbit_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_2(0);
                break;
        }
    }
}
void Stepi_Ded_Izbit_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Да что ты творишь!? Да ты... Ладно бог с ним, пошли. Только не забудь жопу вытереть... Но не футболкой же деда!! ... Все идем дальше в степь.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Засунуть поварешку деду в...");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Stepi_Ded_Izbit();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_2(0);
                break;
        }
    }
}
void END_Stepi_Ded_Izbit()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_46 != "B67bESnj")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_46 = "B67bESnj";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_46"].Value = conf_end_46;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 46");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ну это уже ни в какие рамки!! Это просто отвратительно!! Тебе должно быть стыдно за получение этой концовки!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Stepi_2(int pov)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (pov == 0)
    {
        Console.WriteLine("Тебе пришлось пройти еще мининмум километр до следующей активности. Ей стала телефонная будка.");
    }
    else
    {
        Console.WriteLine("Разумный выбор, ты забрал черпак и пошел глубже в степь. Тебе пришлось пройти еще мининмум километр до следующей активности. Ей стала телефонная будка.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Зайти в будку");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Budka(0);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_3();
                break;
        }
    }
}
void Stepi_Budka(int xab)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (xab == 0)
    {
        Console.WriteLine("Зайдя внутрь, ты как ни странно увидел телефон? старый такой, с кольцом вместо кнопок. Можно кому-нибудь позвонить.");
    }
    else if (xab == 1)
    {
        Console.WriteLine("Повышающие тон гудки. \"Неправильно набран номер...\" - Гласит автоответчик.");
    }
    else if (xab == 2)
    {
        Console.WriteLine("Короткие гудки. Кому еще позвоним?");
    }
    Console.ForegroundColor = user_foreground_color_2;
    if (xab == 0)
    {
        Console.WriteLine("1) Набрать номер");
    }
    else if (xab == 1 || xab == 2)
    {
        Console.WriteLine("1) Набрать номер еще раз");
    }
    Console.WriteLine("2) Выйти из будки и идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Budka_Nomer();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_3();
                break;
        }
    }
}
void Stepi_Budka_Saul()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Пара длинных гудков и \"Ало\" мужским голосом из телефона.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Это Абу?");
    Console.WriteLine("2) Сбросить");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Budka_Saul_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_Budka(2);
                break;
        }
    }
}
void Stepi_Budka_Saul_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Абу? Абу это обезьянка. Вы позвонили в зоопарк\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) А вы знали, что у вашей обезьянки есть доступ в интернет?");
    Console.WriteLine("2) Сбросить");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Budka_Saul_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_Budka(2);
                break;
        }
    }
}
void Stepi_Budka_Saul_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"У вас с головой все в порядке?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да, а вот у вас нет, раз не заметили как ваша обезьянка ведет двач на протяжении более десятка лет");
    Console.WriteLine("2) Сбросить");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Budka_Saul_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_Budka(2);
                break;
        }
    }
}
void Stepi_Budka_Saul_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Это какой-то розыгрыш? Что за бред вы несете?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Сами зайдите в вальер абузьянки и посмотрите");
    Console.WriteLine("2) Сбросить");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Budka_Saul_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_Budka(2);
                break;
        }
    }
}
void Stepi_Budka_Saul_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"...\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ну что?");
    Console.WriteLine("2) Сбросить");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Budka_Saul_5();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Budka_Saul();
                break;
        }
    }
}
void Stepi_Budka_Saul_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Глазам своим не верю! Спасибо что сообщили нам об этом! Больше она вас не побеспокоит! До свидания!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) До свидания");
    Console.WriteLine("2) Сбросить");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Stepi_Budka_Saul();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Budka_Saul();
                break;
        }
    }
}
void Stepi_Budka_Nomer()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты взял трубку, приложил ее к уху и начал крутить кольцо...");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("Введите номер.");
    Console.ForegroundColor = user_foreground_color_2;
    Stepi_Budka_Nomer_1();
}
void Stepi_Budka_Nomer_1()
{
    string stavka_string;
    stavka_string = Console.ReadLine();
    if (long.TryParse(stavka_string, out stavka))
    {
        stavka = Convert.ToInt64(stavka_string);
    }
    else
    {
        Stepi_Budka(1);
    }
    if (stavka == 5104261123)
    {
        Stepi_Budka_Saul();
    }
    else if (stavka == 532325322)
    {
        END_Stepi_Budka();
    }
    else
    {
        Stepi_Budka(1);
    }
}
void END_Stepi_Budka_Saul()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_47 != "NJgC40nb")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_47 = "NJgC40nb";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_47"].Value = conf_end_47;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 47");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Через пару минут после завершения звонка, Двач упал в последний раз, все тгк Двача были удалены, а домены раскуплены мелкобордами. Ты стал героем о котором никто не просил, и которого никто не ждал.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Budka()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_48 != "Ni1K94uc")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_48 = "Ni1K94uc";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_48"].Value = conf_end_48;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 48");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ало... Погоди, это ты мне что ли звонишь?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Stepi_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Спустя 2 километра в пути, твое внимание привлекла Большая мультяшная зеленая труба, ведущая в землю");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Прыгнуть в трубу");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Stepi_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_4();
                break;
        }
    }
}
void END_Stepi_3()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_49 != "NIws5b3J")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_49 = "NIws5b3J";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_49"].Value = conf_end_49;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 1");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Провалившись в трубу, ты попал в мир Марио, повсюду бегали Гумбы, черепашки, везде были блоки кирпичей, блоки со знаками вопроса, вокруг были разбросаны монетки, но ты всего этого не увидел, так как мир был двухмерным и тебя просто-напросто расплющило.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Stepi_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("5 километров еще пришлось пройти по степи, прежде чем твой взгляд наткнулся на что-нибудь интересное. Перед тобой стоит какой-то низкий паренек в шапке.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подойти к пареньку");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_OP();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_5(0);
                break;
        }
    }
}
void Stepi_OP()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Подойдя поближе, ты смог получше рассмотреть паренька. На вид ему лет 13, в шапку подсунута зажигалка, а в зубах сигарета. \"Слышь, ты че тут забыл!? Давай уебывай!\" - Сказал тебе паренек, когда ты подошел ближе.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Остаться");
    Console.WriteLine("2) Уйти");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_OP_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_5(1);
                break;
        }
    }
}
void Stepi_OP_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты остался стоять на месте и с глупой улыбкой смотрел на паренька. Видя это, он продолжил: \"Ну все, ебать. Гони косарь за посещение нашей точки!\". Договорив это, он толкнул тебя в плечо, твоя воспаленная гордость не могла стерпеть такой наглости:");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Слышь, ебать, да ты кто по масти чтобы так базарить!?");
    Console.WriteLine("2) Да ты мне сам ща торчать будешь, пиздюкан!");
    Console.WriteLine("3) Я ща тя в чешки обую, гнома щекастого.");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_OP_2(0);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_OP_2(0);
                break;
            case ConsoleKey.D3:
                keyInt++;
                Stepi_OP_2(0);
                break;
        }
    }
}
void Stepi_OP_2(int xab)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (xab == 0)
    {
        Console.WriteLine("После сказанного, перед глазами твоими начался звездный вальс. Несмотря на свой маленький рост этот пацан тебя так вшатал, что на мгновение тебе показалось что душа твоя уже выходит из тела. \"Ну че, платим за вход или ты продолжишь из себя фуфела играть?\" - Говорит он тебе потирая кулаки. Твое желание спорить резко улетучилось.");

    }
    else if (xab == 1)
    {
        Console.WriteLine("\"Ты че ваще тупой?! Бабки гони!\"");
    }
    Console.ForegroundColor = user_foreground_color_2;
    if (pocyk_1)
    {
        Console.WriteLine("1) Отдать все что есть в карманах");
    }
    if (pocyk_2)
    {
        if (!pocyk_1)
        {
            Console.WriteLine("1) Снять и отдать ему свою одежду");
        }
        else
        {
            Console.WriteLine("2) Отдать ему свою одежду");
        }
    }
    if (!pocyk_1 && !pocyk_2)
    {
        Console.WriteLine("1) Отдать непонятно откуда взявшуюся мелочь с карманов");
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                if (pocyk_1)
                {
                    keyInt++;
                    pocyk_1 = false;
                    Stepi_OP_2(1);
                }
                else if (!pocyk_1 && pocyk_2)
                {
                    keyInt++;
                    pocyk_2 = false;
                    Stepi_OP_2(1);
                }
                else if (!pocyk_1 && !pocyk_2)
                {
                    keyInt++;
                    END_Stepi_OP();
                }
                break;
            case ConsoleKey.D2:
                if (pocyk_1 && pocyk_2)
                {
                    keyInt++;
                    pocyk_2 = false;
                    Stepi_OP_2(1);
                }
                break;
        }
    }
}
void END_Stepi_OP()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_50 != "9A32Jk8О")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_50 = "9A32Jk8О";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_50"].Value = conf_end_50;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 50");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("\"Хули тут так мало?! Это наша точка, блять! Ты выёбывался — я те пизды дал! Ты на пенёк сел — должен был косарь отдать! А тут хули так мало, урод, блядь, ты!? Мм?! Уёба! Ди нахуй, пидор, блять! Как уебу, сука!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Stepi_5(int xab)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (xab == 0)
    {
        Console.WriteLine("Ты прошел еще немало миль прежде чем ты заметил, что все вокруг стало пиксельным и.... кубическим?");
    }
    else if (xab == 1)
    {
        Console.WriteLine("\"Давай-давай, чеши отсюда!\" - Сказал паренек вслед уходящему тебе. От такого ты обиделся и ускорил шаг. Ты прошел еще немало миль прежде чем ты заметил, что все вокруг стало пиксельным и.... кубическим?");

    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ааа, где я? Кажется я в мире Майнкрафта, похоже на то!");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Minecraft();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_6();
                break;
        }
    }
}
void Stepi_Minecraft()
{
    Console.Clear();
    mine = 0;
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Итож, я конечно не эксперт в этой игре, но я думаю, что для начала неплохо было бы добыть дерево, или у тебя есть какие-то другие идеи?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Бить по дереву кулаками");
    Console.WriteLine("2) Строить писюны из грязи");
    Console.WriteLine("3) Пойти на поиск деревни");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Stepi_Minecraft_Derevo();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Minecraft_Pisyuny();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Stepi_Minecraft_1();
                break;
            case ConsoleKey.T:
                keyInt++;
                Stepi_Minecraft_console();
                break;
        }
    }
}
void Stepi_Minecraft_1()
{
    Console.Clear();
    mine = 1;
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Хм, вполне разумное решение. Долго искать не пришлось и уже через 15 минут ты стоял перед кузницей.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Залутать все сундуки");
    Console.WriteLine("2) Убивать жителей");
    Console.WriteLine("3) Сломать все двери в деревне");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_Minecraft_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Minecraft_Genocid();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Stepi_Minecraft_Dveri();
                break;
            case ConsoleKey.T:
                keyInt++;
                Stepi_Minecraft_console();
                break;
        }
    }
}
void Stepi_Minecraft_2()
{
    Console.Clear();
    mine = 2;
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("На твое счастье, деревня оказалось крайне жирной, обыскав ее ты нашел алмазную кирку, полный железный сет брони, железный топор, лук со стрелами, кровать, кучу хлеба, три стака различных стройматериалов, огниво и пару блоков динамита. Только вот используй последнее по назначению.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Пойти копать шахту");
    Console.WriteLine("2) Пойти копать колодец");
    Console.WriteLine("3) Побаловаться с динамитом");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Stepi_Minecraft_Shahta();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Stepi_Minecraft_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Stepi_Minecraft_TNT();
                break;
            case ConsoleKey.T:
                keyInt++;
                Stepi_Minecraft_console();
                break;
        }
    }
}
void Stepi_Minecraft_3()
{
    Console.Clear();
    mine = 3;
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("А зачем? Ну ладно, ты взял кирку, прыгнул в колодец и начал копать. Копать пришлось немного, но делать это пришлось долго, тык как ты находился под водой. Пару раз не задохнувшись, ты таки докопался до... Эндерпортала? А ты знал что тебе нужно именно сюда или ты наобум это сделал. Как бы-то ни было, времени размышлять на то прыгать в него или нет, у тебя не было, так как упал ты прямо в него. И вот ты в Энде, что дальше?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Достать кровать и поспать");
    Console.WriteLine("2) Убить дракона луком и стрелами");
    Console.WriteLine("3) Убить дракона кроватью");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Stepi_Minecraft_Pospal();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Minecraft_LukiStrely();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Stepi_Minecraft();
                break;
            case ConsoleKey.T:
                keyInt++;
                Stepi_Minecraft_console();
                break;
        }
    }
}
void Stepi_Minecraft_console()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("Консоль: ");
    Console.ForegroundColor = user_foreground_color_2;
    string password = Console.ReadLine();
    if (password == "/tp")
    {
        nachalo_byl_li = true;
        Nachalo();
    }
    else if (password == "/teleport")
    {
        nachalo_byl_li = true;
        Nachalo();
    }
    else
    {
        switch (mine)
        {
            case 0:
                keyInt++;
                Stepi_Minecraft();
                break;
            case 1:
                keyInt++;
                Stepi_Minecraft_1();
                break;
            case 2:
                keyInt++;
                Stepi_Minecraft_2();
                break;
            case 3:
                keyInt++;
                Stepi_Minecraft_3();
                break;
        }
    }
}
void END_Stepi_Minecraft()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_51 != "A66BnWFO")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_51 = "A66BnWFO";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_51"].Value = conf_end_51;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 51");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Как самый настоящий профи, ты подбежал к бедроковому гнезду дракона, выкопал яму, поставил на бедрок кровать, прыгнул в яму и, как только подлетел дракон, разделался с ним одним нажатием на кровать. Не любуясь дезинтеграцией эндердракона, ты сразу же прыгнул в портал и на экране поползли титры. Я уверен, что до этого момента ты ни разу не проходил майнкрафт, но теперь, ты можешь похвастаться тем, что сделал это.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Minecraft_LukiStrely()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_52 != "k3JAVapz")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_52 = "k3JAVapz";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_52"].Value = conf_end_52;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 52");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Попал! Да ты снайпер! Точно в цель! Ты бы и продолжал попускать дракона, если бы он не решил тебя скинуть в пустоту.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Minecraft_Pospal()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_53 != "mlcUaJG3")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_53 = "mlcUaJG3";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_53"].Value = conf_end_53;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 53");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("УДИВИТЕЛЬНО, но ты взорвался. Ооо, как же это было неожииииданно.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Minecraft_Shahta()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_54 != "lb4wApgu")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_54 = "lb4wApgu";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_54"].Value = conf_end_54;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 54");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Идея показалась самой очевидной, что могло пойти не так? Ты прокопался до камня, взял в руки кирку и начал копать под себя, но ты не учел, что под тобой может оказаться здоровенная пещера, в которую ты и упал и разбился.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Minecraft_TNT()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_55 != "9k8dRix5")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_55 = "9k8dRix5";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_55"].Value = conf_end_55;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 55");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Я понятия не имею на что ты расчитывал, решив побаловаться с tnt. Ты умер. Ты взорвал самого себя и умер.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Minecraft_Derevo()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_56 != "PI3jpMca")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_56 = "PI3jpMca";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_56"].Value = conf_end_56;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 56");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Стой, ты же не сможешь этого сделать. Эй, не делай этого, твои руки не предназначены... Ну вот и чего ты добился? Теперь лежи и помирай от кровотечения.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Minecraft_Genocid()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_57 != "1lJhdUX0")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_57 = "1lJhdUX0";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_57"].Value = conf_end_57;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 57");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты тыркал одного жителя минут 20 и как только он с истошным стоном превратился в дымок, появился голем, который сразу же показал тебе, кто здесь батя.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Minecraft_Dveri()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_58 != "5CmR1n4t")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_58 = "5CmR1n4t";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_58"].Value = conf_end_58;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 58");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты колотил двери аж до самого наступления ночи, которое повлекло за собой набег зомбей и скелетонов, а так как ты ликвидировал все двери в деревне, укрыться ты от них не сумел.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Minecraft_Pisyuny()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_59 != "WQlCrS8m")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_59 = "WQlCrS8m";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_59"].Value = conf_end_59;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 59");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Было весело, но ты так увлекся процессом, что не заметил подкравшегося из-за угла крипера, который решил прервать веселье.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Stepi_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Оооооочень много километров спустя, ты наткнулся на огромную махину (10x10x10 метров примерно). Также считаю своим долгом предупредить тебя, что идти дальше не имеет смысла, так как там ничего нет.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Осмотреть махину");
    Console.WriteLine("2) Идти дальше");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Stepi_6_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Stepi_Last();
                break;
        }
    }
}
void Stepi_6_1()
{
    Random rnd = new Random();
    int rnd_int;
    rnd_int = rnd.Next(1, 101);
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Пройдясь вокруг этой здоровой штукенции, ты предположил, что это какой-то обменник, так как увидел 2 отсека, один открыт, второй закрыт. Над открытым написано \"Песок\", а над закрытым \"Пиво\". Выгодно однако.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Залезть внутрь обменника");
    Console.WriteLine("2) Постучать по машине кулаком, в надежде, что он выдаст бесплатное пиво. (50/50)");
    if (pesok)
    {
        Console.WriteLine("3) Вытряхнуть весь песок из карманов в обменник");
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Stepi_6_Bad();
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (rnd_int < 51)
                {
                    END_Stepi_6_RND_Good();
                }
                else
                {
                    END_Stepi_6_RND_Bad();
                }
                break;
            case ConsoleKey.D3:
                if (pesok)
                {
                    keyInt++;
                    END_Stepi_6_Good();
                }
                break;
        }
    }
}
void END_Stepi_6_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_60 != "eB1tPoXz")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_60 = "eB1tPoXz";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_60"].Value = conf_end_60;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 60");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Кое-как протиснувшись в маленькое окошко, ты попал в \"машинное отделение\", которым являлось кучка арабов ссущих в чан с водярой. От данного пивного рецепта тебе стало настолько плохо, что, в сопровождении рвоты, тебя желудком вывернуло наизнанку, однако умер ты от остановки сердца, не выдержало оно таких издевательств над добрым именем жидкого золота.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_6_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_61 != "erMZXB6W")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_61 = "erMZXB6W";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_61"].Value = conf_end_61;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 61");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Высыпав все до последней песчинки, ты нажал на ржавую кнопку рядом с открытой ячейкой. Отсек с песком с ужасающим скрипом закрылся, и спустя пару секунд открылся отсек с пивом. недолго думая, ты отхлебнул слегонца. И это оказалось райским наслаждением. Пивко оказалось холодным, что в такую жарень было именно тем чего так сильно нехватало. Тебе стало настолько хорошо, что ты не увидел смысла жить дальше и в буквальном смысле растворился в этом глотке.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_6_RND_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_62 != "2wd4yJRY")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_62 = "2wd4yJRY";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_62"].Value = conf_end_62;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 62");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты встал в крутую позу и пару раз стукнул кулаком по автомату. Створка ячейки с пивом приоткрылась и оттуда показалась заветная тара. Под впечетлением от собственной крутости, ты решил повторить трюк, однако постучав по обменнику еще раз, от него что то отвалилось, упало и размозжило тебе голову.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_6_RND_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_63 != "LsfjDj0l")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_63 = "LsfjDj0l";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_63"].Value = conf_end_63;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 63");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты постучал кулаком по машине - ничего не произошло. Ты решил, что этого мало и постучал двумя кулаками - результат тот же. Тебе показалось, что этого по прежнему не достаточно, ты начал пытаться раскачивать этого монстра 10x10 и, я не знаю как, но тебе удалось его уронить, жаль правда, что на себя.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Stepi_Last()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_64 != "U7RYm07w")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_64 = "U7RYm07w";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_64"].Value = conf_end_64;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 64");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("На этот раз далеко идти не пришлось, всего через пару шагов под ногами пропала коллизия и ты провалился за карту.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Norilsk(int norilsk_byl_li)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (norilsk_byl_li == 0)
    {
        Console.WriteLine("Мои поздравления, ты в Норильске. Тут все абсолютно серое и совершенно нечего делать. Тебе пришлось несколько раз обойти весь город, чтобы найти хоть что-то интересное. Когда ты зашел в какую-то очередную подворотню, ты заметил трех интересных персонажей: мужика в смокинге, деда со стаканчиками и плачущую девушку в ярком красном платье.");
    }
    else if (norilsk_byl_li == 1 && plaksa_killed == false)
    {
        Console.WriteLine("Рядом с тобой трое интересных персонажей: мужик в смокинге, дед со стаканчиками и плачущая девушка в ярком красном платье.");
    }
    else if (norilsk_byl_li == 1 && plaksa_killed == true)
    {
        Console.WriteLine("Рядом с тобой уже двое интересных персонажей: мужик в смокинге и дед со стаканчиками.");
    }
    else if (norilsk_byl_li == 2)
    {
        plaksa_killed = true;
        Console.WriteLine("Засунув руки в карманы, ты вспомнил, что выбросил ее возле дороги. осознав это, ты, выдавив самую глупую из улыбок, изрек: \"Нету)\". Девушка на миг перестала плакать, но лишь для того чтобы послать тебя ко всем чертям. Разговаривать с тобой она больше явно не намерена. Осталось лишь двое интересных персонажей для взаимодействия: мужик в смокинге и дед со стаканчиками.");
    }

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подойти к бизнесмену");
    Console.WriteLine("2) Подойти к разводиле");
    if (!plaksa_killed)
    {
        Console.WriteLine("3) Подойти к плаксе");
    }
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (biznessmen == 1)
                {
                    Norilsk_Biznesmen();
                }
                else if (biznessmen == 2)
                {
                    Norilsk_Biznesmen_2(1);
                }
                else if (biznessmen == 3)
                {
                    Norilsk_Biznesmen_3(1);
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                Norilsk_Razvodila(0);
                break;
            case ConsoleKey.D3:
                if (!plaksa_killed)
                {
                    keyInt++;
                    Plaksa();
                }
                break;
            case ConsoleKey.D4:
                if (Norilsk_Secret_1 && Norilsk_Secret_2 && Norilsk_Secret_3)
                {
                    keyInt++;
                    Apocalipsis_Secret();
                }
                break;
        }
    }
}
void Plaksa()
{
    Norilsk_Secret_1 = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты подошел к девушке поближе. Увидев тебя, ее глаза наполнились надеждой. Она молит тебя: \"Молодой человек, мне нужна помощь!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Че надо?");
    Console.WriteLine("2) Чем я могу вам помочь?");
    Console.WriteLine("3) Да пошла ты (Вернуться назад)");
    Console.WriteLine("4) Избить ее");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                plaksa_end_good = false;
                Plaksa_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Plaksa_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                plaksa_end_good = false;
                Norilsk(1);
                break;
            case ConsoleKey.D4:
                keyInt++;
                Plaksa_Ubita();
                break;
        }
    }
}
void Plaksa_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Милостливый, я молю вас о помощи, дело в том, что мой смартфон потерял весь свой заряд, а мне срочно нужно позвонить своему человеку, дабы меня смогли забрать из этого отвратительного места. Я вас великодушно прошу: одолжите мне свое зарядное устройство, дабы я могла подключиить телефон к пауэрбанку и тем самым зарядить его.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Дать зарядку");
    Console.WriteLine("2) Не давать зарядку");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (zaryadka && plaksa_end_good)
                {
                    END_Plaksa_Good();
                }
                if (zaryadka && !plaksa_end_good)
                {
                    END_Plaksa_Bad();
                }
                else if (!zaryadka)
                {   
                    Norilsk(2);
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                Norilsk(1);
                break;
        }
    }
}
void END_Plaksa_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_65 != "DxXqmBG9")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_65 = "DxXqmBG9";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_65"].Value = conf_end_65;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 65");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты помог девушке в беде и она была тебе очень благодарна. Как она и сказала, она зарядила телефон и вызвала человека. прихал черный гелик и из него вышел здоровый амбал который посадил девушку в авто. Сев в машину, дама протянула тебе руку и сказала: \"Пойдем...\". Ты сел в машину и поехал вместе с ней. Девушка оказалась принцессой одного небольшого государства. У вас завязался роман, затем вы поженились и ты стал принцем, а в последствие и вовсе королем заняв престол.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Plaksa_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_66 != "uf0Yqn8E")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_66 = "uf0Yqn8E";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_66"].Value = conf_end_66;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 66");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты помог девушке в беде и она была тебе очень благодарна. Как она и сказала, она зарядила телефон и вызвала человека. прихал черный гелик и из него вышел здоровый амбал который посадил девушку в авто. Сев в машину, дама ткнула в тебя пальцем и сказала: \"Он оскорбил меня!\". Услышав это, амбал тут же достал из кабуры пистолет и произвел точечный выстрел в твою голову.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Plaksa_Ubita()
{
    plaksa_killed = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты замахнулся кулаком и вмазал ей прямо в аккуратненький носик. Девушке этого хватило для того чтобы потерять сознание и повалиться на землю. Иными словами, ты \"избил\" ее, только вот зачем?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Пойду-ка я к кому-нибудь еще");
    Console.WriteLine("2) Попытаться поднять ее");
    Console.WriteLine("3) Забить ее до смерти");
    Console.WriteLine("4) Меня такое развитие событий не устраивает");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Norilsk(1);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Plaksa_Ubita_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Plaksa_Ubita_1();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Plaksa_Alt();
                break;
        }
    }
}
void Plaksa_Ubita_1()
{
    plaksa_killed = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Энергичные шлепки по щекам не дали результатов и поэтому ты решил проверить ее дыхание. Оно есть.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Пойду-ка я к кому-нибудь еще");
    Console.WriteLine("2) Попытаться поднять ее другим способом");
    Console.WriteLine("3) Забить ее до смерти");
    Console.WriteLine("4) Заняться с ней сексом");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Norilsk(1);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Plaksa_Shaman();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Plaksa_Ubita_1();
                break;
            case ConsoleKey.D4:
                keyInt++;
                END_Plaksa_Ubita_rickroll();
                break;
        }
    }
}
void Plaksa_Alt()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ладно, отмотаем немного назад. Ты замахнулся кулаком и вмазал ей прямо в аккуратненький носик, девушка удара не почувствовала но решила ответить и, с силой Ванпанчмена размазала тебя по полу. Так лучше?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да");
    Console.WriteLine("2) Нет");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Plaksa_Alt();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Plaksa_Alt_1();
                break;
        }
    }
}
void Plaksa_Alt_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Тогда не выебывайся и хавай сюжет который я тебе даю.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ладно");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Plaksa_Ubita();
                break;
        }
    }
}
void END_Plaksa_Alt()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_67 != "5TOMWm1c")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_67 = "5TOMWm1c";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_67"].Value = conf_end_67;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 67");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("В таком случае, можешь считать это за концовку.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Plaksa_Ubita_1()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_68 != "1HY4phoI")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_68 = "1HY4phoI";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_68"].Value = conf_end_68;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 68");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Как ни странно, тебе это удалось, а еще тебе удалось отлететь по 105 статье Уголовного кодекса.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Plaksa_Ubita_rickroll()
{
    Process.Start(new ProcessStartInfo("https://cdn-useast1.kapwing.com/static/templates/rick-roll-video-meme-template-video-1da252ec.mp4") { UseShellExecute = true });
    Console.Clear();
    keyInt = 0;
    if (music_value)
    {
        foreach (Process proc in Process.GetProcessesByName("music_zapizdoha.bin"))
        {
            proc.Kill();
        }
    }
    if (conf_end_69 != "nI3ZB6OR")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_69 = "nI3ZB6OR";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_69"].Value = conf_end_69;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
    }
    else
    {
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 69");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("NEVER GONNA GIVE YOU UP! NEVER GONNA LET YOU DOWN!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                if (music_value)
                {
                    Process.Start("soundtracks/music_zapizdoha.bin");
                }
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (music_value)
                {
                    Process.Start("soundtracks/music_zapizdoha.bin");
                }
                Nachalo();
                break;
        }
    }
}
void Plaksa_Shaman()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Немного почесав затылок, ты наклонился к уху девушки и прошептал...");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я РУССКИИИИИЙ!!!!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Plaksa_Shaman_2();
                break;
        }
    }
}
void Plaksa_Shaman_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Девушка подскакивает, сдирает волосы и сбрасывает с себя платье...");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я ИДУ ДО КОНЦАААААААААА!!!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Plaksa_Shaman_3();
                break;
        }
    }
}
void Plaksa_Shaman_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Этой девушкой оказался переодетый Шаман!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я ИДУ ДО КОНЦАААААААААА!!!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Plaksa_Shaman_4();
                break;
        }
    }
}
void Plaksa_Shaman_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Он вытаскивает из кармана джоггеров микрофон...");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я РУССКИИИИИИИИЙЙ!!!!!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Plaksa_Shaman_5();
                break;
        }
    }
}
void Plaksa_Shaman_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("И вот вы уже вместе начинаете орать:");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) МОЯ КОРВЬ ОТ ОТЦАААААААА!!!!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Plaksa_Shaman_6();
                break;
        }
    }
}
void Plaksa_Shaman_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Я РУССКИИИИИИИЙ!!!!!!!!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1)Я РУССКИИИИИИИЙ!!!!!!!!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Plaksa_Shaman();
                break;
        }
    }
}
void END_Plaksa_Shaman()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_70 != "eeoN0rBI")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_70 = "eeoN0rBI";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_70"].Value = conf_end_70;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 70");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Я ИДУ ДО КОНЦАААААА!!!!!!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Norilsk_Biznesmen()
{
    Norilsk_Secret_2 = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (biznesmen_1_byl_li == false)
    {
        Console.WriteLine("\"Слушай, хочешь дам 100 000 рублей? Просто так, ничего делать не надо. Просто вот возьму и вот дам, хочешь?\"");
    }
    else if (biznesmen_1_byl_li == true)
    {
        Console.WriteLine("\"Снова ты? Ну так что, хочешь дам 100 000 рублей? Просто так, ничего делать не надо. Просто вот возьму и вот дам, хочешь?\"");
    }
    biznesmen_1_byl_li = true;
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Давай!");
    Console.WriteLine("2) Я подумаю (Вернуться назад)");
    Console.WriteLine("3) Папа, мне не нужны твои деньги!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                biznessmen++;
                rubli += 100000;
                Norilsk_Biznesmen_2(0);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Norilsk(1);
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Norilsk_Biznesmen();
                break;
        }
    }
}
void Norilsk_Biznesmen_2(int biznesmen_byl_li)
{
    if (rubli<1000)
    {
        END_Norilsk_Biznesmen_Bad();
    }
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (biznesmen_byl_li == 0)
    {
        Console.WriteLine("\"Вот, держи.\" - Сказал тебе бизнесмен и протянул тебе металлический дпломат. - \"Если хочешь, я могу помочь тебе не только не потерять эти деньги, но и удвоить, а то и утроить их! Интересно?\"");
    }
    else if (biznesmen_byl_li == 1)
    {
        Console.WriteLine("\"Снова ты? Если хочешь, я могу помочь тебе не только не потерять эти деньги, но и удвоить, а то и утроить их! Интересно?\"");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Даааа!");
    Console.WriteLine("2) Мне нужно подумать (Вернуться назад)");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                biznessmen++;
                Norilsk_Biznesmen_3(0);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Norilsk(1);
                break;
        }
    }
}
void Norilsk_Biznesmen_3(int biznesmen_byl_li)
{
    if (rubli < 1000)
    {
        END_Norilsk_Biznesmen_Bad();
    }
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (biznesmen_byl_li == 1)
    {
        Console.WriteLine("\"Ты вернулся? Напоминаю, что чтобы увеличить свой капитал нужно начать инвестировать.\" - Говорит тебе бизнесмен. - \"Тебе очень повезло, ведь я могу бесплатно тебя этому обучить. Для этого тебе просто нужно пойти со мной.\"");
    }
    else if (biznesmen_byl_li == 0)
    {
        Console.WriteLine("\"Чтобы увеличить свой капитал нужно начать инвестировать.\" - Говорит тебе бизнесмен. - \"Тебе очень повезло, ведь я могу бесплатно тебя этому обучить. Для этого тебе просто нужно пойти со мной.\"");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Пойдем мутить бабки!");
    Console.WriteLine("2) Мне нужно подумать (Вернуться назад)");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Norilsk_Biznesmen_Good();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Norilsk(1);
                break;
        }
    }
}
void END_Norilsk_Biznesmen_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_71 != "ИдИнахуЙ")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_71 = "ИдИнахуЙ";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_71"].Value = conf_end_71;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 71");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Вы с бизнесменом вышли из подворотни. Вас встретил новенький Bentley Continental GT. Шофер открыл вам двери, вы сели в машину и вместе поехали в светлое будущее.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Norilsk_Biznesmen_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_72 != "mVzIL0t0")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_72 = "mVzIL0t0";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_72"].Value = conf_end_72;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 72");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Увидев пустой дипломат бизнесмен позеленел от злости. Потом он схватил тебя за горло и задушил.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Norilsk_Biznesmen()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_73 != "3jdkByfs")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_73 = "3jdkByfs";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_73"].Value = conf_end_73;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 73");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("\"Ну, Саша!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Norilsk_Razvodila(int xy)
{
    Norilsk_Secret_3 = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (xy == 0)
    {
        Console.WriteLine("Ты подошел к деду сидящему за небольшим столиком, на котором стоит 3 стаканчика и лежит шарик. \"Здарова!\" - Говорит он тебе. - \"Предлагаю тебе угадать под каким стаканчиком шарик. Можем сделать первую игру тренировочной, а остальные на ставку или, если ты уверен в своих силах, то можно сразу на ставку. Сыграем?\"");
    }
    else if (xy == 1)
    {
        Console.WriteLine("\"Либо мы играем тренировочный, либо ты идешь искать деньги. Будем играть тренировочный раунд?\"");
    }
    else if (xy == 2)
    {
        Console.WriteLine("\"Молодец, одержал победу. Вот твои " + stavka + " рублей.\".");
    }
    else if (xy == 22)
    {
        Console.WriteLine("\"Красава, победил. Может теперь сыграем на ставку?\"");
        trenirovochniy = false;
    }
    else if (xy == 3)
    {
        Console.WriteLine("\"Не повезло тебе, братик. Давай сюда " + stavka + " рублей.\".");
    }
    else if (xy == 33)
    {
        Console.WriteLine("\"Увы, твое поражение. Сыграем на ставку? Вдруг повезет.\"");
        trenirovochniy = false;
    }
    Console.ForegroundColor = user_foreground_color_2;
    if (trenirovochniy)
    {
        Console.WriteLine("1) Играть тренировочный");
        Console.WriteLine("2) Играть на ставку");
        Console.WriteLine("3) Не охота мне что-то (Вернуться назад)");
    }
    else
    {
        Console.WriteLine("1) Играть на ставку");
        Console.WriteLine("2) Не охота мне что-то (Вернуться назад)");
    }
    stavka = 0;

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                if (trenirovochniy)
                {
                    keyInt++;
                    Norilsk_Razvodila_game_1();
                }
                else
                {
                    keyInt++;
                    if (rubli > 0)
                    {
                        Norilsk_Razvodila_stavka(0);
                    }
                    else if (rubli <= 0)
                    {
                        Norilsk_Razvodila(1);
                    }
                }
                break;
            case ConsoleKey.D2:
                if (trenirovochniy)
                {
                    keyInt++;
                    if (rubli > 0)
                    {
                        Norilsk_Razvodila_stavka(0);
                    }
                    else if (rubli <= 0)
                    {
                        Norilsk_Razvodila(1);
                    }
                }
                else
                {
                    keyInt++;
                    Norilsk(1);
                }
                break;
            case ConsoleKey.D3:
                if (trenirovochniy)
                {
                    keyInt++;
                    Norilsk(1);
                }
                break;
        }
    }
}
void Norilsk_Razvodila_stavka(int x)
{
    Console.Clear();
    keyInt = 0;
    if (x == 0)
    {
        if (sound_value) {zvuk3.Play();}
        Console.ForegroundColor = user_foreground_color_1;
        Console.WriteLine("\"Введи сумму на которую будем играть\"");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Сейчас у тебя на балансе: " + rubli + " рублей.");
        Console.ForegroundColor = user_foreground_color_2;
    }
    else if (x == 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Не хватает денег!");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Сейчас у тебя на балансе: " + rubli + " рублей.");
        Console.ForegroundColor = user_foreground_color_2;
    }
    else if (x == 2)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Введена некорректная сумма!");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Сейчас у тебя на балансе: " + rubli + " рублей.");
        Console.ForegroundColor = user_foreground_color_2;
    }

    else if (x == 3)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Сумма не может равняться 0!");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Сейчас у тебя на балансе: " + rubli + " рублей.");
        Console.ForegroundColor = user_foreground_color_2;
    }
    Norilsk_Razvodila_stavka_1();
}
void Norilsk_Razvodila_stavka_1()
{
    string stavka_string;
    stavka_string = Console.ReadLine();
    if (long.TryParse(stavka_string, out stavka))
    {
        stavka = Convert.ToInt64(stavka_string);
    }
    else
    {
        Norilsk_Razvodila_stavka(2);
    }

    if (rubli - stavka < 0 && stavka > 0)
    {
        Norilsk_Razvodila_stavka(1);
    }
    else if (rubli - stavka >= 0 && stavka > 0)
    {
        if (stavka<=rub_razvodila)
        {
            Norilsk_Razvodila_game_0();
        }
        else
        {
            END_Norilsk_Razvodila();
        }
    }
    else if (stavka<0)
    {
        Norilsk_Razvodila_stavka(2);
    }
    else if (stavka == 0)
    {
        Norilsk_Razvodila_stavka(3);
    }
}
void Norilsk_Razvodila_game_0() // на ставку
{
    Random rnd = new Random();
    int razvod_sharik = rnd.Next(1, 4);
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ставка принята!\" - Воскликнул мужик, кинул деньги на стол и быстро перетасовал стаканчики. После этого, он ожидающе показал на них руками. \"Под каким находится шарик?\" - Спрашивает он у тебя.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Первый");
    Console.WriteLine("2) Второй");
    Console.WriteLine("3) Третий");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (razvod_sharik == 1)
                {
                    rub_razvodila -= stavka;
                    rubli += stavka;
                    Norilsk_Razvodila(2);
                    
                }
                else
                {
                    rub_razvodila += stavka;
                    rubli -= stavka;
                    Norilsk_Razvodila(3);
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (razvod_sharik == 2)
                {
                    rub_razvodila -= stavka;
                    rubli += stavka;
                    Norilsk_Razvodila(2);
                    
                }
                else
                {
                    rub_razvodila += stavka;
                    rubli -= stavka;
                    Norilsk_Razvodila(3);
                    
                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                if (razvod_sharik == 3)
                {
                    rub_razvodila -= stavka;
                    rubli += stavka;
                    Norilsk_Razvodila(2);
                    
                }
                else
                {
                    rub_razvodila += stavka;
                    rubli -= stavka;
                    Norilsk_Razvodila(3);
                    
                }
                break;
        }
    }
}
void Norilsk_Razvodila_game_1() //тренировочный
{
    Random rnd = new Random();
    int razvod_sharik = rnd.Next(1, 4);
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Мужик быстро перетасовал стаканчики и ожидающе показал на них руками. \"Под каким находится шарик?\" - Спрашивает он у тебя.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Первый");
    Console.WriteLine("2) Второй");
    Console.WriteLine("3) Третий");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (razvod_sharik == 1)
                {
                    Norilsk_Razvodila(22);

                }
                else
                {
                    Norilsk_Razvodila(33);
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (razvod_sharik == 2)
                {
                    Norilsk_Razvodila(22);

                }
                else
                {
                    Norilsk_Razvodila(33);

                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                if (razvod_sharik == 3)
                {
                    Norilsk_Razvodila(22);

                }
                else
                {
                    Norilsk_Razvodila(33);

                }
                break;
        }
    }
}
void END_Norilsk_Razvodila()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_74 != "VA6AyKpL")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_74 = "VA6AyKpL";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_74"].Value = conf_end_74;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 74");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Когда ты сделал ставку, хозяин лохотрона начал шариться по карманам, в поисках суммы для встречной ставки, после чего выпучил глаза и в страхе убежал. Мои поздравления! Ты разорил уличного разводилу, а также стал самым богатым человеком в Норильске.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Les()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты заблудился. Объяснения тут излишни. Поговорка \"В трех соснах заблудился\" Явно про тебя. Лоох!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Эй! Не обзывайся, сам такой!");
    Console.WriteLine("2) Ваще пофиг");
    Console.WriteLine("3) Сделать вид, что так и задумано");
    
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Sorry();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_2();
                break;
        }
    }
}
void Les_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Поскольку ты в лесу, а ориентиров ты никаких не знаешь, ты пошел куда глаза глядят и, что не мудрено, заблудился. Лоох!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Эй! Не обзывайся, сам такой!");
    Console.WriteLine("2) Ваще пофиг");
    Console.WriteLine("3) Сделать вид, что так и задумано");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Sorry();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_2();
                break;
        }
    }
}
void Les_Sorry()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ладно, прости, так что делать-то будем?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Неискренне, я требую искренних извинений!");
    Console.WriteLine("2) Принять извинения и осмотреться");
    Console.WriteLine("3) Принять извинения и кричать о помощи");
    Console.WriteLine("4) Принять извинения и лечь в ожидании смерти");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Sorry_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_Osmotr();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_Krik();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Les_Loveushka();
                break;
        }
    }
}
void Les_Sorry_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ну правда, извини меня пожалуйста.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ты правда не понимаешь? Мне нужны ИСКРЕННИЕ извинения.");
    Console.WriteLine("2) Принять извинения и осмотреться");
    Console.WriteLine("3) Принять извинения и кричать о помощи");
    Console.WriteLine("4) Принять извинения и лечь в ожидании смерти");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Sorry_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_Osmotr();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_Krik();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Les_Loveushka();
                break;
        }
    }
}
void Les_Sorry_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Я был не прав, признаю свою вину и впредь постараюсь так больше не поступать");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) ЭТО НЕИСКРЕННЕ!! Я ВСЕ ЕЩЕ В ОБИДЕ НА ТЕБЯ!!!!");
    Console.WriteLine("2) Принять извинения и осмотреться");
    Console.WriteLine("3) Принять извинения и кричать о помощи");
    Console.WriteLine("4) Принять извинения и лечь в ожидании смерти");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Sorry_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_Osmotr();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_Krik();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Les_Loveushka();
                break;
        }
    }
}
void Les_Sorry_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("О, Великодушный, смилуйтесь надо мной, мою вину ничем не искупить. Я преклоняюсь перед вами, дабы попросить прощения. И нет, я не жду, что вы меня простите, однако не могу терпеть я больше муки совести...");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) ТЫ НАДО МНОЙ ИЗДЕВАЕШЬСЯ!!!!! ЭТО НЕ ИЗВИНЕНИЕ, А ИЗДЕВКА!!!!!!!!");
    Console.WriteLine("2) Принять извинения и осмотреться");
    Console.WriteLine("3) Принять извинения и кричать о помощи");
    Console.WriteLine("4) Принять извинения и лечь в ожидании смерти");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Les_Sorry();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_Osmotr();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_Krik();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Les_Loveushka();
                break;
        }
    }
}
void END_Les_Sorry()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_75 != "D9UsLIb6")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_75 = "D9UsLIb6";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_75"].Value = conf_end_75;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 75");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Твое раздутое эго не выдержало такого давления и лопнуло. Затем твои глаза закатились, а тело замертво повалилось наземь. Ну правда прости((");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Les_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ладно, Сусанин, что делать-то будем?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Осмотреться");
    Console.WriteLine("2) Кричать о помощи");
    Console.WriteLine("3) Лечь в ожидании смерти");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Osmotr();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_Krik();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_Loveushka();
                break;
        }
    }
}
void Les_Loveushka()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (Rambo_pobil == 0)
    {
        Console.WriteLine("Ты лег и долго ворочался в попытках найти удобную позу, а когда все-таки нашел, тебя на веревке за ногу подбросило в воздух. Ты в ловушке, дружок, и теперь висишь вниз головой на дереве на высоте метров 25.");
    }
    else
    {
        Console.WriteLine("Услышав твои слова, ветеран огорчился и избил тебя до отключки. Когда ты очнулся, ты попытался встать, но что-то схватило тебя за ногу и подбросило в воздух. Ты в ловушке, дружок, и теперь висишь вниз головой на дереве на высоте метров 25.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Попытаться выпутаться");
    Console.WriteLine("2) Ждать невесть чего");
    Console.WriteLine("3) Молиться о спасении");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Les_Loveushka();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gigant();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_Spasenie();
                break;
        }
    }
}
void Gigant()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Провисев несколько минут в такой позе, ты отключился от избыточного прилива крови к голове.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Тихонько спать");
    Console.WriteLine("2) Спать слегка посапывая");
    Console.WriteLine("3) Храпеть как слон");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gigant_son();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gigant_son();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gigant_son();
                break;
        }
    }
}
void Gigant_son()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Когда ты спал, тебе приснился странный сон, о том, как ты в белых одеяниях разливаешь по чашкам разные штуки:");
    Console.WriteLine("Море в первую чашку,");
    Console.WriteLine("Кровь в первую и третью чашки,");
    Console.WriteLine("Траву во вторую и третью чашки.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Интересненько");
    Console.WriteLine("2) Пофигу мне");
    Console.WriteLine("3) Мне это точно пригодится");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gigant_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gigant_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gigant_2();
                break;
        }
    }
}
void Gigant_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Очнулся ты привязанным к огромному-огромному столу, который длиннее и шире тебя раз этак в 10. Рядом ты видишь великана, который что-то готовит. Он услышал как ты ворочаешься пытаясь освободиться, повернулся к тебе и сказал: \"сейчас мы будем обедать.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ура, обед!");
    Console.WriteLine("2) Освободи меня и пообедаем");
    Console.WriteLine("3) Слышь, ты че, меня жрать собрался!?");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                gigant_love++;
                Gigant_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gigant_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gigant_3();
                break;
        }
    }
}
void Gigant_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Оу да, сейчас я буду тебя есть. Ты выглядишь таким сочным!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Давай лучше, вместе покушаем");
    Console.WriteLine("2) Может быть сначала поговорим?");
    Console.WriteLine("3) А хочешь, я отучу тебя питаться людьми?");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gigant_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                gigant_love++;
                Gigant_4();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gigant_4();
                break;
        }
    }
}
void Gigant_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Черт, от твоих слов, у меня пропал аппетит...\" - Расстроенно произнес великан.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Извини, я не хотел");
    Console.WriteLine("2) Может быть это потому, что ты не хочешь меня есть?");
    Console.WriteLine("3) Эй, не вешай нос, хочешь, я сам залезу к тебе в рот?");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Gigant_5();
                break;
            case ConsoleKey.D2:
                keyInt++;
                gigant_love++;
                Gigant_5();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gigant_5();
                break;
        }
    }
}
void Gigant_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Не говори так, словно ты меня понимаешь! Я все равно тебя съем! Но сначала нужно разжечь камин.\" - Разозлился великан и пошел в сторону камина, но остановился на пол пути и не оборачиваясь стыдливо спросил. - \"У меня тут закончились спички... У тебя не найдется огоньку?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Разумеется, только я не могу их достать пока связан");
    Console.WriteLine("2) Попытаться достать спички будучи связанным");
    Console.WriteLine("3) Для тебя, мне ничего не жалко, только мои руки привязанны к туловищу и я не могу их достать.");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                gigant_love++;
                Gigant_6();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Gigant_6();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Gigant_6();
                break;
        }
    }
}
void Gigant_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ох, прости!\" - Спохватился великан и развязал тебя.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Дать спички");
    Console.WriteLine("2) Бежать");
    Console.WriteLine("3) Напасть");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (spichki == false)
                {
                    END_Gigant_nofire();
                }
                else if(spichki && gigant_love>=4)
                {
                    Gigant_7();
                }
                else if (spichki && gigant_love < 4)
                {
                    END_Gigant_bad();
                }
                 break;
            case ConsoleKey.D2:
                keyInt++;
                END_Gigant_Begstvo();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Console.Clear();
                fighter = 2;
                start_fight = false;
                vrag_hp = 29353;
                Gigant_Fight();
                break;
        }
    }
}
void Gigant_7()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Слушай, а ты хороший парень, ты мне нравишься, не буду тебя есть. Давай будем друзьями?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Даааааа!!");
    Console.WriteLine("2) Знаешь, а это отличная идея!");
    Console.WriteLine("3) Фу, только не с тобой");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                gigant_love++;
                END_Gigant_good();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Gigant_good();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Gigant_bad();
                break;
        }
    }
}
void END_Gigant_good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_76 != "6k7kEoPl")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_76 = "6k7kEoPl";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_76"].Value = conf_end_76;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 76");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("И стали вы с великаном друзьями, помогали друг другу, поддерживали друг друга в трудные минуты, до тех пор, пока великан на тебя случайно не наступил и не раздавил.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void END_Gigant_bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_77 != "oAt77yWC")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_77 = "oAt77yWC";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_77"].Value = conf_end_77;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 77");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Великан без лишьних слов взял спички, разжег камин и поджарил тебя.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void END_Gigant_nofire()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_78 != "WA4jl0Fv")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_78 = "WA4jl0Fv";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_78"].Value = conf_end_78;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 78");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты долго шарился по карманам приговаривая \"ща-ща-ща\", прождав приличное количество времени, великан не выдержал, разозлился и сожрал тебя живьем.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void END_Gigant_Begstvo()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_79 != "kUX6AnX7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_79 = "kUX6AnX7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_79"].Value = conf_end_79;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 79");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Разбежавшись прыгну со столааа! Побежал, прыгнул со стола, разбился в лепешку. На этом все, не считая того, что великан выбросил тебя в мусорку не захотев есть с пола.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void Gigant_Fight()
{
    if (vrag_hp <= 0 && fighter == 2)
    {
        Thread.Sleep(3000);
        END_Gigant_Fight_good();
    }
    else if (u_hp <= 0 && fighter == 1)
    {
        Thread.Sleep(3000);
        END_Gigant_Fight_bad();
    }
    Random rnd = new Random();
    int ataka;
    int uron;
    keyInt = 0;
    Console.ForegroundColor = ConsoleColor.Gray;
    if (sound_value) {zvuk3.Play();}
    Console.Write("Великан ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(vrag_hp + "HP");
    Console.WriteLine("");
    if (stop_fight == 0 && start_fight)
    {
        ataka = rnd.Next(1, 3);
        switch (ataka)
        {
            case 1:
                if (rnd.Next(1, 101) < 91)
                {
                    uron = 9999;
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Великан нанес удар своей левой огромной ладонью " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Великан нанес удар своей левой огромной ладонью, но промазал!");
                }
                break;
            case 2:
                if (rnd.Next(1, 101) < 100)
                {
                    uron = 7999;
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Великан нанес удар своей правой огромной ладонью " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Великан нанес удар своей правой огромной ладонью, но промазал!");
                }
                break;
            case 3:
                if (rnd.Next(1, 101) < 100)
                {
                    uron = 7999;
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Великан нанес удар своей правой огромной ладонью " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Великан нанес удар своей правой огромной ладонью, но промазал!");
                }
                break;
        }
    }
    else if (stop_fight > 0 && start_fight)
    {
        stop_fight--;
    }
    else if (stop_fight == 0 && start_fight == false)
    {
        start_fight = true;
    }
    else if (stop_fight > 0 && start_fight == false)
    {
        stop_fight--;
        start_fight = true;
    }
    Attack();


}
void END_Gigant_Fight_good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_80 != "6l6pvPGI")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_80 = "6l6pvPGI";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_80"].Value = conf_end_80;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 80");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Погоди... ЧЕ!!! Ты победил что ли?!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void END_Gigant_Fight_bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_81 != "l70fhqVm")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_81 = "l70fhqVm";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_81"].Value = conf_end_81;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 81");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Только ты нанес свой камариный удар, как великан прихлопнул камариного тебя.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void Les_Spasenie()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты прочитал молитву и, по велению небес, время ускорилось в 1000 раз. Тебе посчастливилось на самом себе ощутить магию таймлабса: ты увидел, как лес превратился в болото, как дерево, на котором ты висишь в нем утопло, как ты опустился на землю, а когда ты опустился, стукнул сезон засухи и болото пересохло, и теперь ты на твердой земле. Закончилась перемотка, эпичным рассыпанием веревки от старости.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) АХУЕТЬ!!");
    Console.WriteLine("2) ЕБААТЬ!!");
    Console.WriteLine("3) ДА НУ НАХУЙ, ЭТО ЧЕ ЗА ХУЙНЯ БЛЯТЬ!!!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Spasenie_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_Spasenie_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_Spasenie_2();
                break;
        }
    }
}
void Les_Spasenie_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Слишком много мата! Отныне всю нецензурную брань я буду заменять на звездочки");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да ты *****!");
    Console.WriteLine("2) Ну *****((");
    Console.WriteLine("3) Не очень то и хотелось!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Future();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Future();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Future();
                break;
        }
    }
}
void Future()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (future_trans)
    {
        Console.WriteLine("Что на этот раз выберем?");
    }
    else
    {
        Console.WriteLine("Ты огляделся и заметил, что от большого леса остался лишь маленький клочок болота, вокруг которого теперь огромный мегаполис будущего! Рядом с тобой находится парковка, на чем прокатимся?");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Космошаттл");
    Console.WriteLine("2) Tesla Aeroplan");
    Console.WriteLine("3) Ржавый жигуль");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Kosmoshattl();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Tesla();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Zhiguli();
                break;
        }
    }
}
void Zhiguli()
{
    if (zhiguli_kapot)
    {
        Zhiguli_Rabotaet();
    }
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (future_trans)
    {
        Console.WriteLine("Ты снова сел за руль и снова начал заводить и, О ЧУДО! - она снова не заводится. Что теперь делаем?");
    }
    else
    {
        Console.WriteLine("Ты сел за руль и начал заводить. Но не тут то было, она не заводится. Что делаем?");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заглянуть под капот");
    Console.WriteLine("2) Попытаться завести еще раз");
    Console.WriteLine("3) Выбрать другой транспорт");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Zhiguli_Kapot();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Zhiguli_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                future_trans = true;
                Future();
                break;
        }
    }
}
void Zhiguli_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    
    Console.WriteLine("Не заводится, можешь даже не пытаться завести ее еще раз.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заглянуть под капот");
    Console.WriteLine("2) Попытаться завести еще раз");
    Console.WriteLine("3) Выбрать другой транспорт");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Zhiguli_Kapot();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Zhiguli_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                future_trans = true;
                Future();
                break;
        }
    }
}
void Zhiguli_3()
{
    if (zhiguli_zavedenie>=18)
    {
        END_ZhiguliSecret();
    }
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Не заводится.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заглянуть под капот");
    Console.WriteLine("2) Попытаться завести еще раз");
    Console.WriteLine("3) Выбрать другой транспорт");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Zhiguli_Kapot();
                break;
            case ConsoleKey.D2:
                keyInt++;
                zhiguli_zavedenie++;
                Zhiguli_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                future_trans = true;
                Future();
                break;
        }
    }
}
void Zhiguli_Kapot()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}

    Console.Write("Открыв капот, ты удивился, перед тобой не стандартные \"+\" и \"-\", а 3 цветных провода с клемами: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("желтый");

    Console.ForegroundColor = user_foreground_color_1;
    Console.Write(", ");

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("фиолетовый");

    Console.ForegroundColor = user_foreground_color_1;
    Console.Write(" и ");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("зеленый");

    Console.ForegroundColor = user_foreground_color_1;
    Console.Write(". Для них имеется 3 контакта без каких либо пометок. Куда присоединяем ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("желтый");

    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("?");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) На первый");
    Console.WriteLine("2) На второй");
    Console.WriteLine("3) На третий");
    Console.WriteLine("4) Соединить все наугад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                zhiguli_Y = false;
                break;
            case ConsoleKey.D2:
                keyInt++;
                zhiguli_Y = false;
                break;
            case ConsoleKey.D3:
                keyInt++;
                zhiguli_Y = true;
                break;
            case ConsoleKey.D4:
                keyInt++;
                Zhiguli_Rabotaet();
                break;
        }
    }
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}

    Console.ForegroundColor = user_foreground_color_1;
    Console.Write("Куда присоединяем ");

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("фиолетовый");

    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("?");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) На первый");
    Console.WriteLine("2) На второй");
    Console.WriteLine("3) На третий");
    Console.WriteLine("4) Соединить все наугад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                zhiguli_F = true;
                break;
            case ConsoleKey.D2:
                keyInt++;
                zhiguli_F = false;
                break;
            case ConsoleKey.D3:
                keyInt++;
                zhiguli_F = false;
                break;
            case ConsoleKey.D4:
                keyInt++;
                Zhiguli_Rabotaet();
                break;
        }
    }
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}

    Console.ForegroundColor = user_foreground_color_1;
    Console.Write("Куда присоединяем ");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("зеленый");

    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("?");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) На первый");
    Console.WriteLine("2) На второй");
    Console.WriteLine("3) На третий");
    Console.WriteLine("4) Соединить все наугад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                zhiguli_Z = false;
                break;
            case ConsoleKey.D2:
                keyInt++;
                zhiguli_Z = true;
                break;
            case ConsoleKey.D3:
                keyInt++;
                zhiguli_Z = false;
                break;
            case ConsoleKey.D4:
                keyInt++;
                Zhiguli_Rabotaet();
                break;
        }
    }
    Zhiguli_Rabotaet();
}
void Zhiguli_Rabotaet()
{
    zhiguli_kapot = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Все провода соединены, заводим!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Завести машину");
    Console.WriteLine("2) Выбрать другой транспорт");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (zhiguli_F && zhiguli_Y && zhiguli_Z)
                {
                    car_str = "старый жигуль, ";
                    car = true;
                    Kavkazec();
                }
                else
                {
                    END_Zhiguli_Bomb();
                }
                break;
            case ConsoleKey.D2:
                keyInt++;
                future_trans = true;
                Future();
                break;
        }
    }
}
void END_Zhiguli_Bomb()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_82 != "BJFz6kBr")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_82 = "BJFz6kBr";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_82"].Value = conf_end_82;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 82");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Тут уж ебануло так, что ни тебя, ни парковщика, ни самой парковки не осталось.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Kavkazec()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) { zvuk3.Play(); }
    if (car)
    {
        Console.WriteLine("Автомобиль завелся и ты выехал с парковки. Ты проехал метров 100 и только стал думать куда бы поехать, как тачка заглохла и больше не заводилась, как бы ты не старался. Ты вышел из машины, поматерился, помахал руками и вдруг тебе кричат: \"Сющи братан!\". Ты осмотрелся в поисках источника звука и сначала увидел автомастерскую, а потом и кавказца машущего оттуда тебе рукой: \"Таскай это ведро ка мне, я те такую ласточку сделю, оай! ти вахуи будищь!\"");
    }
    else
    {
        Console.WriteLine("И ты убежал. Ловить тебя не стали, ведь ты \"президент\" как никак. Убежав на достаточное расстояние ты остановился чтобы перевести дух, и вдруг тебе кричат: \"Сющи братан!\". Ты осмотрелся в поисках источника звука и сначала увидел автомастерскую, а потом и кавказца машущего оттуда тебе рукой: \"Захади, я те такую ласточку пакажю, оай! ти вахуи будищь!\"");
    }
    Console.ForegroundColor = user_foreground_color_2;
    if (car)
    {
        Console.WriteLine("1) Дотолкать машину до мастерской");
    }
    else
    {
        Console.WriteLine("1) Зайти в мастерскую");
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Kavkazec_2();
                break;
        }
    }
}
void Kavkazec_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (car)
    {
        Console.WriteLine("Ты кое-как затащил жигуль в автосервис. Кавказец тут же закрыл за тобой дверь на щеколду. Оглядвешись, ты заметил что в мастерской нет инструментов... и запчастей... В ней вообще ничего нет! Она абсолютно пустая. В твою голову закрались сомнения, а когда кавказец достал нож, то они мигом подтвердились. \"Се що есть гони, бистро бля!\"");
    }
    else
    {
        Console.WriteLine("Ты зашел в автосервис и кавказец на щеколду закрыл за тобой дверь. Оглядвешись, ты заметил что в мастерской нет машины... И инструментов... В ней вообще ничего нет! Она абсолютно пустая. В твою голову закрались сомнения, а когда кавказец достал нож, то они мигом подтвердились. \"Се що есть гони, бистро бля!\"");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Отдать все что есть");
    Console.WriteLine("2) Бежать");
    Console.WriteLine("3) Драться");
    if (car)
    {
        Console.WriteLine("4) Бамблби! Превращение!!!");
    }
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Kavkazec_Pozor();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Kavkazec_Begstvo();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Console.Clear();
                fighter = 1;
                start_fight = false;
                vrag_hp = 20;
                Kavkazec_Fight();
                break;
            case ConsoleKey.D4:
                if (car)
                {
                    keyInt++;
                    END_Bamblbi();
                }
                break;
        }
    }

}
void Kavkazec_Fight()
{
    if (vrag_hp <= 0 && fighter == 1)
    {
        END_Kavkazec_Fight_good();
    }
    else if (u_hp <= 0 && fighter == 1)
    {
        END_Kavkazec_Fight_bad();
    }
    Random rnd = new Random();
    int ataka;
    int uron;
    keyInt = 0;
    Console.ForegroundColor = ConsoleColor.Gray;
    if (sound_value) {zvuk3.Play();}
    Console.Write("Кавказец ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(vrag_hp + "HP");
    Console.WriteLine("");
    if (stop_fight==0 && start_fight)
    {
        ataka = rnd.Next(1, 4);
        switch (ataka)
        {
            case 1:
                if (rnd.Next(1, 101) < 36)
                {
                    uron = rnd.Next(0, 10);
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Кавказец нанес удар ножом и снес тебе " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Кавказец ударил ножом, но промазал!");
                }
                break;
            case 2:
                if (rnd.Next(1, 101) < 86)
                {
                    uron = rnd.Next(2, 4);
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Кавказец нанес удар ногой и снес тебе " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Кавказец ударил ногой, но промазал!");
                }
                break;
            case 3:
                if (vrag_hp < 20)
                {
                    if (rnd.Next(1, 101) < 81)
                    {
                        uron = rnd.Next(3, 5);
                        vrag_hp += uron;
                        if (vrag_hp > 20)
                        {
                            vrag_hp = 20;
                        }
                        Console.ForegroundColor = user_foreground_color_1;
                        Console.WriteLine("Кавказец применил кефтеме и восстановил здоровье на "+uron+"HP! Теперь у него " + vrag_hp+"HP");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        Console.WriteLine("Кавказец применил кефтеме, но ему не помогло!");
                    }
                }
                else
                {
                    if(rnd.Next(1,101)>50)
                    {
                        if (rnd.Next(0, 100) < 36)
                        {
                            uron = rnd.Next(0, 10);
                            u_hp = u_hp - uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            Console.WriteLine("Кавказец нанес удар ножом и снес тебе " + uron + " урона!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            Console.WriteLine("Кавказец ударил ножом, но промазал!");
                        }
                    }
                    else
                    {
                        if (rnd.Next(1, 101) < 86)
                        {
                            uron = rnd.Next(2, 4);
                            u_hp = u_hp - uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            Console.WriteLine("Кавказец нанес удар ногой и снес тебе " + uron + " урона!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            Console.WriteLine("Кавказец ударил ногой, но промазал!");
                        }
                    }
                }
                break;
        }
    }
    else if (stop_fight > 0 && start_fight)
    {
        stop_fight--;
    }
    else if (stop_fight == 0 && start_fight == false)
    {
        start_fight = true;
    }
    else if (stop_fight > 0 && start_fight == false)
    {
        stop_fight--;
        start_fight = true;
    }

        Attack();


}
void Attack()
{
    if (kolco_vsemogushestva)
    {
        u_hp = 999999999;
    }
    int uron;
    Random rnd = new Random();
    keyInt = 0;
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("Ты ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(u_hp + "HP");
    Console.WriteLine("");
    if (vrag_hp <= 0 && fighter == 1)
    {
        Thread.Sleep(3000);
        END_Kavkazec_Fight_good();
    }
    else if (u_hp <= 0 && fighter == 1)
    {
        Thread.Sleep(3000);
        END_Kavkazec_Fight_bad();
    }
    if (vrag_hp <= 0 && fighter == 2)
    {
        Thread.Sleep(3000);
        END_Gigant_Fight_good();
    }
    else if (u_hp <= 0 && fighter == 2)
    {
        Thread.Sleep(3000);
        END_Gigant_Fight_bad();
    }
    if (vrag_hp <= 0 && fighter == 3)
    {
        Thread.Sleep(3000);
        END_Operator_Fight_good();
    }
    else if (u_hp <= 0 && fighter == 3)
    {
        Thread.Sleep(3000);
        END_Operator_Fight_bad();
    }
    if (vrag_hp <= 0 && fighter == 5)
    {
        Thread.Sleep(3000);
        if (zombi_lvl == 5)
        {
            Apocalipsis_Secret_Bezhat_5();
        }
        if (zombi_lvl == 6)
        {
            Apocalipsis_Secret_Baza();
        }
    }
    else if (u_hp <= 0 && fighter == 5)
    {
        Thread.Sleep(3000);
        END_Apocalipsis_Secret_Zombi_Fight_Bad();
    }

    if (fighter == 5 && kolco_vsemogushestva == false)
    {
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) AK-15 очередь (Урон: 5-30, Шанс: 90%)");
        Console.WriteLine("2) AK-15 точечный (Урон: 30-40, Шанс: 15%)");
        Console.WriteLine("3) Апперкот (Урон: 0-9, Шанс: 35%)");
        Console.WriteLine("4) Крапива (Урон: 2-3, Шанс: 85%)");
        Console.WriteLine("5) Удар по яйцам (Урон: Паралич на 1-2 хода, Шанс: 50%)");
        if (u_hp < 20)
        {
            Console.WriteLine("6) Понюхать потертую об яйца руку (Восстановление: 3-4, Шанс: 80%)");
        }
        while (keyInt <= 0)
        {
            KeyOtvet = Console.ReadKey();
            switch (KeyOtvet.Key)
            {
                case ConsoleKey.Escape:
                    keyInt++;
                    ToMainMenu();
                    break;
                case ConsoleKey.D1:
                    keyInt++;
                    if (rnd.Next(1, 101) < 91)
                    {
                        uron = rnd.Next(5, 31);
                        vrag_hp = vrag_hp - uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты выстрелил очередью и нанес врагу " + uron + " урона!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты выстрелил очередью, но ни разу не попал!");
                    }
                    break;
                case ConsoleKey.D2:
                    keyInt++;
                    if (rnd.Next(1, 101) < 16)
                    {
                        uron = rnd.Next(30, 41);
                        vrag_hp = vrag_hp - uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты точечно выстрелил и нанес врагу " + uron + " урона!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты точечно выстрелил, но промазал!");
                    }
                    break;
                
                case ConsoleKey.D3:
                    keyInt++;
                    if (rnd.Next(1, 101) < 36)
                    {
                        uron = rnd.Next(0, 10);
                        vrag_hp = vrag_hp - uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты преминил апперкот и нанес врагу " + uron + " урона!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты пытался сделать апперкот, но промазал!");
                    }
                    break;
                case ConsoleKey.D4:
                    keyInt++;
                    if (rnd.Next(1, 101) < 86)
                    {
                        uron = rnd.Next(2, 4);
                        vrag_hp = vrag_hp - uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты сделал врагу крапиву и нанес врагу " + uron + " урона!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты пытался сделать крапиву, но промазал!");
                    }
                    break;
                case ConsoleKey.D5:
                    keyInt++;
                    if (rnd.Next(1, 101) < 51)
                    {
                        uron = rnd.Next(1, 3);
                        stop_fight += uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты ударил по яйцам и нанес паралич! Враг обездвижен на " + uron + " ход(а)!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) {zvuk3.Play();}
                        Console.WriteLine("Ты пытался ударить по яйцам, но промазал!");
                    }
                    break;
                case ConsoleKey.D6:
                    if (u_hp < 20)
                    {
                        keyInt++;
                        if (rnd.Next(1, 101) < 81)
                        {
                            uron = rnd.Next(3, 5);
                            u_hp += uron;
                            if (u_hp > 20)
                            {
                                u_hp = 20;
                            }
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) {zvuk3.Play();}
                            Console.WriteLine("Ты понюхал яйца и восстановил здоровье на " + uron + "HP! Теперь у тебя " + u_hp + "HP!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) {zvuk3.Play();}
                            Console.WriteLine("Ты понюхал яйца, но тебе не помогло!");
                        }
                    }
                    break;
            }
        }
    }
    else if (fighter != 5 && kolco_vsemogushestva == false)
    {
        if (u_stop_fight == 0)
        {
            Console.ForegroundColor = user_foreground_color_2;
            Console.WriteLine("1) Апперкот (Урон: 0-9, Шанс: 35%)");
            Console.WriteLine("2) Крапива (Урон: 2-3, Шанс: 85%)");
            Console.WriteLine("3) Удар по яйцам (Урон: Паралич на 1-2 хода, Шанс: 50%)");
            if (u_hp < 20)
            {
                Console.WriteLine("4) Понюхать потертую об яйца руку (Восстановление: 3-4, Шанс: 80%)");
            }
            while (keyInt <= 0)
            {
                KeyOtvet = Console.ReadKey();
                switch (KeyOtvet.Key)
                {
                    case ConsoleKey.Escape:
                        keyInt++;
                        ToMainMenu();
                        break;
                    case ConsoleKey.D1:
                        keyInt++;
                        if (rnd.Next(1, 101) < 36)
                        {
                            uron = rnd.Next(0, 10);
                            vrag_hp = vrag_hp - uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) {zvuk3.Play();}
                            Console.WriteLine("Ты преминил апперкот и нанес врагу " + uron + " урона!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) {zvuk3.Play();}
                            Console.WriteLine("Ты пытался сделать апперкот, но промазал!");
                        }
                        break;
                    case ConsoleKey.D2:
                        keyInt++;
                        if (rnd.Next(1, 101) < 86)
                        {
                            uron = rnd.Next(2, 4);
                            vrag_hp = vrag_hp - uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) {zvuk3.Play();}
                            Console.WriteLine("Ты сделал врагу крапиву и нанес врагу " + uron + " урона!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) {zvuk3.Play();}
                            Console.WriteLine("Ты пытался сделать крапиву, но промазал!");
                        }
                        break;
                    case ConsoleKey.D3:
                        keyInt++;
                        if (rnd.Next(1, 101) < 51)
                        {
                            uron = rnd.Next(1, 3);
                            stop_fight += uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) {zvuk3.Play();}
                            Console.WriteLine("Ты ударил по яйцам и нанес паралич! Враг обездвижен на " + uron + " ход(а)!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) {zvuk3.Play();}
                            Console.WriteLine("Ты пытался ударить по яйцам, но промазал!");
                        }
                        break;
                    case ConsoleKey.D4:
                        if (u_hp < 20)
                        {
                            keyInt++;
                            if (rnd.Next(1, 101) < 81)
                            {
                                uron = rnd.Next(3, 5);
                                u_hp += uron;
                                if (u_hp > 20)
                                {
                                    u_hp = 20;
                                }
                                Console.ForegroundColor = user_foreground_color_1;
                                if (sound_value) {zvuk3.Play();}
                                Console.WriteLine("Ты понюхал яйца и восстановил здоровье на " + uron + "HP! Теперь у тебя " + u_hp + "HP!");
                            }
                            else
                            {
                                Console.ForegroundColor = user_foreground_color_1;
                                if (sound_value) {zvuk3.Play();}
                                Console.WriteLine("Ты понюхал яйца, но тебе не помогло!");
                            }
                        }
                        break;
                }
            }
        }
        else
        {
            u_stop_fight--;
        }
    }
    else if (fighter == 5 && kolco_vsemogushestva == true)
    {
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) AK-15 очередь (Урон: 5-30, Шанс: 90%)");
        Console.WriteLine("2) AK-15 точечный (Урон: 30-40, Шанс: 15%)");
        Console.WriteLine("3) Апперкот (Урон: 0-9, Шанс: 35%)");
        Console.WriteLine("4) Крапива (Урон: 2-3, Шанс: 85%)");
        Console.WriteLine("5) Удар по яйцам (Урон: Паралич на 1-2 хода, Шанс: 50%)");
        Console.WriteLine("6) bot_kill! (КОЛЬЦО ВСЕМОГУЩЕСТВА)");
        if (u_hp < 20)
        {
            Console.WriteLine("7) Понюхать потертую об яйца руку (Восстановление: 3-4, Шанс: 80%)");
        }
        while (keyInt <= 0)
        {
            KeyOtvet = Console.ReadKey();
            switch (KeyOtvet.Key)
            {
                case ConsoleKey.Escape:
                    keyInt++;
                    ToMainMenu();
                    break;
                case ConsoleKey.D1:
                    keyInt++;
                    if (rnd.Next(1, 101) < 91)
                    {
                        uron = rnd.Next(5, 31);
                        vrag_hp = vrag_hp - uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты выстрелил очередью и нанес врагу " + uron + " урона!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты выстрелил очередью, но ни разу не попал!");
                    }
                    break;
                case ConsoleKey.D2:
                    keyInt++;
                    if (rnd.Next(1, 101) < 16)
                    {
                        uron = rnd.Next(30, 41);
                        vrag_hp = vrag_hp - uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты точечно выстрелил и нанес врагу " + uron + " урона!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты точечно выстрелил, но промазал!");
                    }
                    break;

                case ConsoleKey.D3:
                    keyInt++;
                    if (rnd.Next(1, 101) < 36)
                    {
                        uron = rnd.Next(0, 10);
                        vrag_hp = vrag_hp - uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты преминил апперкот и нанес врагу " + uron + " урона!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты пытался сделать апперкот, но промазал!");
                    }
                    break;
                case ConsoleKey.D4:
                    keyInt++;
                    if (rnd.Next(1, 101) < 86)
                    {
                        uron = rnd.Next(2, 4);
                        vrag_hp = vrag_hp - uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты сделал врагу крапиву и нанес врагу " + uron + " урона!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты пытался сделать крапиву, но промазал!");
                    }
                    break;
                case ConsoleKey.D5:
                    keyInt++;
                    if (rnd.Next(1, 101) < 51)
                    {
                        uron = rnd.Next(1, 3);
                        stop_fight += uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты ударил по яйцам и нанес паралич! Враг обездвижен на " + uron + " ход(а)!");
                    }
                    else
                    {
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты пытался ударить по яйцам, но промазал!");
                    }
                    break;
                case ConsoleKey.D6:
                    keyInt++;
                    vrag_hp = vrag_hp - 999999999;
                    Console.ForegroundColor = user_foreground_color_1;
                    if (sound_value) { zvuk3.Play(); }
                    Console.WriteLine("Ты нанес врагу 999999999 урона. Это нокаут!");
                    break;
                case ConsoleKey.D7:
                    if (u_hp < 20)
                    {
                        keyInt++;
                        if (rnd.Next(1, 101) < 81)
                        {
                            uron = rnd.Next(3, 5);
                            u_hp += uron;
                            if (u_hp > 20)
                            {
                                u_hp = 20;
                            }
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) { zvuk3.Play(); }
                            Console.WriteLine("Ты понюхал яйца и восстановил здоровье на " + uron + "HP! Теперь у тебя " + u_hp + "HP!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) { zvuk3.Play(); }
                            Console.WriteLine("Ты понюхал яйца, но тебе не помогло!");
                        }
                    }
                    break;
            }
        }
    }
    else if (fighter != 5 && kolco_vsemogushestva == true)
    {
        if (u_stop_fight == 0)
        {
            Console.ForegroundColor = user_foreground_color_2;
            Console.WriteLine("1) Апперкот (Урон: 0-9, Шанс: 35%)");
            Console.WriteLine("2) Крапива (Урон: 2-3, Шанс: 85%)");
            Console.WriteLine("3) Удар по яйцам (Урон: Паралич на 1-2 хода, Шанс: 50%)");
            Console.WriteLine("4) bot_kill! (КОЛЬЦО ВСЕМОГУЩЕСТВА)");
            if (u_hp < 20)
            {
                Console.WriteLine("5) Понюхать потертую об яйца руку (Восстановление: 3-4, Шанс: 80%)");
            }
            while (keyInt <= 0)
            {
                KeyOtvet = Console.ReadKey();
                switch (KeyOtvet.Key)
                {
                    case ConsoleKey.Escape:
                        keyInt++;
                        ToMainMenu();
                        break;
                    case ConsoleKey.D1:
                        keyInt++;
                        if (rnd.Next(1, 101) < 36)
                        {
                            uron = rnd.Next(0, 10);
                            vrag_hp = vrag_hp - uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) { zvuk3.Play(); }
                            Console.WriteLine("Ты преминил апперкот и нанес врагу " + uron + " урона!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) { zvuk3.Play(); }
                            Console.WriteLine("Ты пытался сделать апперкот, но промазал!");
                        }
                        break;
                    case ConsoleKey.D2:
                        keyInt++;
                        if (rnd.Next(1, 101) < 86)
                        {
                            uron = rnd.Next(2, 4);
                            vrag_hp = vrag_hp - uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) { zvuk3.Play(); }
                            Console.WriteLine("Ты сделал врагу крапиву и нанес врагу " + uron + " урона!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) { zvuk3.Play(); }
                            Console.WriteLine("Ты пытался сделать крапиву, но промазал!");
                        }
                        break;
                    case ConsoleKey.D3:
                        keyInt++;
                        if (rnd.Next(1, 101) < 51)
                        {
                            uron = rnd.Next(1, 3);
                            stop_fight += uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) { zvuk3.Play(); }
                            Console.WriteLine("Ты ударил по яйцам и нанес паралич! Враг обездвижен на " + uron + " ход(а)!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            if (sound_value) { zvuk3.Play(); }
                            Console.WriteLine("Ты пытался ударить по яйцам, но промазал!");
                        }
                        break;
                    case ConsoleKey.D4:
                        keyInt++;
                        vrag_hp = vrag_hp - 999999999;
                        Console.ForegroundColor = user_foreground_color_1;
                        if (sound_value) { zvuk3.Play(); }
                        Console.WriteLine("Ты нанес врагу 999999999 урона. Это нокаут!");
                        break;
                    case ConsoleKey.D5:
                        if (u_hp < 20)
                        {
                            keyInt++;
                            if (rnd.Next(1, 101) < 81)
                            {
                                uron = rnd.Next(3, 5);
                                u_hp += uron;
                                if (u_hp > 20)
                                {
                                    u_hp = 20;
                                }
                                Console.ForegroundColor = user_foreground_color_1;
                                if (sound_value) { zvuk3.Play(); }
                                Console.WriteLine("Ты понюхал яйца и восстановил здоровье на " + uron + "HP! Теперь у тебя " + u_hp + "HP!");
                            }
                            else
                            {
                                Console.ForegroundColor = user_foreground_color_1;
                                if (sound_value) { zvuk3.Play(); }
                                Console.WriteLine("Ты понюхал яйца, но тебе не помогло!");
                            }
                        }
                        break;
                }
            }
        }
        else
        {
            u_stop_fight--;
        }
    }
    Thread.Sleep(3000);
    Console.Clear();
    if (fighter == 1)
    {
        Kavkazec_Fight();
    }
    else if (fighter == 2)
    {
        Gigant_Fight();
    }
    else if (fighter == 3)
    {
        Operator_Fight();
    }
    else if (fighter == 5)
    {
        Zombi_Fight();
    }
}
void END_Kavkazec_Fight_good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_83 != "fDc3oZdO")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_83 = "fDc3oZdO";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_83"].Value = conf_end_83;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 83");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("После того, как ты победил кавказца в смертельном бою, ты присвоил мастерскую себе и стал его приемником, теперь ТЫ зазывал лошков и устраивал здесь гоп-стоп, пока не появился тот, кто одалел тебя в поединке.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void END_Kavkazec_Fight_bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_84 != "uyn9qcPC")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_84 = "uyn9qcPC";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_84"].Value = conf_end_84;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 84");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Увы, но ты проиграл в этом поединке, как Макгрегор проиграл Хабибу. Разница лишь в том, что Макгрегор потом был жив.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void END_Bamblbi()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_85 != "OUu6bBBx")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_85 = "OUu6bBBx";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_85"].Value = conf_end_85;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 85");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Жигуль закряхтел, запердел и таки превратился в автобота! Своим превращением Он разрушил и пол, и потолок, и стены, обломки которых обрушились на ваши буйные с кавказцем головы. Press F.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.F:
                keyInt++;
                END_PressF();
                break;

        }
    }
}
void END_PressF()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_86 != "Xkjxa6Xu")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_86 = "Xkjxa6Xu";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_86"].Value = conf_end_86;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 86");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Так, а вот тут ты не должен был оказаться!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Kavkazec_Pozor()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_87 != "hOTi72fA")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_87 = "hOTi72fA";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_87"].Value = conf_end_87;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 87");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("У тебя отжали все что у тебя было: кофту, футболку, носки, ботинки, " + car_str + "мусор с карманов... Вообще все! Тебя выкинули из автосервиса полностью голого, за что впоследствии арестовали и посадили в обезьянник, буквально. Там ты и прожил остаток жизни, найдя самку и обзаведясь с ней потомством.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Kavkazec_Begstvo()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_88 != "VR6zxmY2")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_88 = "VR6zxmY2";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_88"].Value = conf_end_88;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 88");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты побежал и, позабыв что дверь закрыта, влетел в нее на всей скорости. Кавказец за такое, недолго думая, нашпиговал тебя своим ножичком.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_ZhiguliSecret()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_89 != "nk3NXbIY")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_89 = "nk3NXbIY";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_89"].Value = conf_end_89;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 89");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ладно, на концовку за упертость.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Tesla()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Когда ты залез в машину, она автоматически заблокировала двери. \"Несанкцианированное проникновение! Двери заблокированы, ожидайте прибытия спецслужб.\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Попытаться взломать автомобиль");
    Console.WriteLine("2) Попытаться выбить стекла");
    Console.WriteLine("3) Ждать полицию");
    Console.WriteLine("4) Слушай, Алиса, это я, просто я забыл умный ключ от машины дома");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Tesla_Start();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Tesla_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Tesla_Police();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Tesla_Start();
                break;
        }
    }
}
void Tesla_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты молотил со всей силы, но стекла не поддались. По всей видимости они бронированные.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Попытаться взломать автомобиль");
    Console.WriteLine("2) Биться о стекла башкой");
    Console.WriteLine("3) Ждать полицию");
    Console.WriteLine("4) Слушай, Алиса, это я, просто я забыл умный ключ от машины дома");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Tesla_Start();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Tesla_Head();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Tesla_Police();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Tesla_Start();
                break;
        }
    }
}
void Tesla_Start()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Успех! Тебе удалось нагнуть систему, поздравляю! Ассистент сказал тебе \"Доброе утро, хозяин\", и на автопилоте куда-то повез.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Сделать дэб");
    Console.WriteLine("2) Это с самого начала было частью плана");
    Console.WriteLine("3) Тупа топ, тупа изи, тупа сплэш!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Parlament();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Parlament();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Parlament();
                break;
        }
    }
}
void Parlament()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Машина долетела до футуристичного стеклянного здания и открыла тебе дверь со словали \"Здание Парламента, хозяин\". Когда ты вышел, тебя встретила толпа крутых смоккингов с дипломатами. Один из них говорит тебе: \"Господин президент, идемте, вас уже заждались.\". Ты прикинь, походу ты угнал президентскую тачку и тебя приняли за него.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Отнекиваться");
    Console.WriteLine("2) Играть в президента");
    Console.WriteLine("3) Напасть");
    Console.WriteLine("4) Бежать");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Tyurma();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Parlament_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Tyurma();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Kavkazec();
                break;
        }
    }
}
void Parlament_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Тебя отвели в президентский люкс, внутри ктотрого, почти все сделанно из золота. На столе ты видишь большую красную кнопку, которая сразу же превлекла твое внимание. Как только ты сел в кресло, тебе захотелось покорчить из себя пупа земли.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) На трон села, на трон села. Царь во дворца, царь во дворца");
    Console.WriteLine("2) Закинуть ноги на стол и представлять себя Тони Сопрано");
    Console.WriteLine("3) Ебать я красивый... аху... ахуеть... бляяя... пиздец я краси... ахуенно...");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Parlament_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Parlament_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Parlament_3();
                break;
        }
    }
}
void Parlament_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (Red_Alert>0)
    {
        Console.WriteLine("Пресс-секретарь схватил вас за руку со словами: \"Не трогайте эту кнопку!\"");
    }
    else
    {
        Console.WriteLine("Как только ты закончил кривляться, к тебе в кабинет зашел пресс-секретарь: \"Мистер Президент, на повестке дня принятие поправок в конституции и законопроектов, предложенных парламентом.\"");
    }
    
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Приступить к работе");
    Console.WriteLine("2) Уважаемый, принесите мне чай, без чая я не могу работать");
    Console.WriteLine("3) Нажать на красную кнопку");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Parlament_Podpisanie();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Parlament_RedAlert();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Red_Alert = 1;
                Parlament_3();
                break;
        }
    }
}
void Parlament_Podpisanie()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (tea > 0)
    {
        Console.WriteLine("Пресс-секретарь принес тебе премиальный индийский чай, ты его залпом выпил и приступил к работе. Секретарь достал из-за пазухи папку с документами, развернул ее и протянул тебе.");
    }
    else
    {
        Console.WriteLine("Секретарь достал из-за пазухи папку с документами, развернул ее и протянул тебе.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Бегло осмотреть папку");
    Console.WriteLine("2) Ознакомиться с документами со всей серьезностью");
    Console.WriteLine("3) Внимательно осмотреть папку, затем ощупать, обнюхать и лизнуть каждый лист, а после изучить ее физические свойства");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                break;
            case ConsoleKey.D2:
                keyInt++;
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Durka();
                break;
        }
    }

    //ВОПРОС 1
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = black_text;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("ЗАКОНОПРОЕКТ \"О введении налога на воздух.\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подписать");
    Console.WriteLine("2) Отклонить");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                pol++;
                par_q_1 = true;
                break;
            case ConsoleKey.D2:
                keyInt++;
                pol--;
                par_q_1 = false;
                break;
        }
    }

    //ВОПРОС 2
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = ConsoleColor.Gray;
    if (sound_value) {zvuk3.Play();}
    Console.Write("ЗАКОНОПРОЕКТ \"О введении налога на воздух.\"");
    if (par_q_1)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("ЗАКОНОПРОЕКТ \"Об усилении контроля за гражданами путем установки камер в жилищную площадь.\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подписать");
    Console.WriteLine("2) Отклонить");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                pol++;
                par_q_2 = true;
                break;
            case ConsoleKey.D2:
                keyInt++;
                pol--;
                par_q_2 = false;
                break;
        }
    }

    //ВОПРОС 3
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = black_text;
    if (sound_value) {zvuk3.Play();}
    Console.Write("ЗАКОНОПРОЕКТ \"О введении налога на воздух.\"");
    if (par_q_1)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.Write("ЗАКОНОПРОЕКТ \"Об усилении контроля за гражданами путем установки камер в жилищную площадь.\"");
    if (par_q_2)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поправка к конституции на тему отмены ограничений свободы слова в отношении критики власти");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подписать");
    Console.WriteLine("2) Отклонить");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                pol--;
                par_q_3 = true;
                break;
            case ConsoleKey.D2:
                keyInt++;
                pol++;
                par_q_3 = false;
                break;
        }
    }
    //ВОПРОС 4
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = black_text;
    if (sound_value) {zvuk3.Play();}
    Console.Write("ЗАКОНОПРОЕКТ \"О введении налога на воздух.\"");
    if (par_q_1)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.Write("ЗАКОНОПРОЕКТ \"Об усилении контроля за гражданами путем установки камер в жилищную площадь.\"");
    if (par_q_2)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.Write("Поправка к конституции на тему отмены ограничений свободы слова в отношении критики власти");
    if (par_q_3)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.WriteLine("Поправка к конституции на тему увеличения прав и свобод граждан");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подписать");
    Console.WriteLine("2) Отклонить");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                pol--;
                par_q_4 = true;
                break;
            case ConsoleKey.D2:
                keyInt++;
                pol++;
                par_q_4 = false;
                break;
        }
    }

    //ИТОГИ
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = ConsoleColor.Gray;
    if (sound_value) {zvuk3.Play();}
    Console.Write("ЗАКОНОПРОЕКТ \"О введении налога на воздух.\"");
    if (par_q_1)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.Write("ЗАКОНОПРОЕКТ \"Об усилении контроля за гражданами путем установки камер в жилищную площадь.\"");
    if (par_q_2)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.Write("Поправка к конституции на тему отмены ограничений свободы слова в отношении критики власти");
    if (par_q_3)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    Console.Write("Поправка к конституции на тему увеличения прав и свобод граждан");
    if (par_q_4)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" ПОДПИСАНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ОТКЛОНЕНО");
        Console.WriteLine("");
        Console.ForegroundColor = black_text;
    }

    Thread.Sleep(4000);

    if (pol>2) //Ультраправая концовка
    {
        END_Parlament_Kons();
    }
    else if (pol<-2) //Ультралевая концовка
    {
        END_Parlament_Lib();
    }
    else if (pol<3 && pol>-3) //Нейтральная концовка
    {
        END_Parlament_Neut();
    }
}
void END_Parlament_Lib()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_90 != "B9J9IUPd")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_90 = "B9J9IUPd";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_90"].Value = conf_end_90;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 90");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты стал самым либеральным президентом в истории страны. Столько бунтов, митингов и гласности никогда не было. К сожелению для тебя, на второй срок тебя не избрали и к власти пришел еще более либеральный кандидат, а ты же провел оставшуюся жизнь в рутине и умер от старости.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Parlament_Kons()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_91 != "GN8Z9OGw")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_91 = "GN8Z9OGw";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_91"].Value = conf_end_91;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 91");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты стал самым, что ни на есть, диктатором. Страну поглатил тотальный контроль, а ты в свою очередь из раза в раз переизбирался подтасовывая голоса, пока наконец, не отменил голосования и узурпировал власть. При жизни, тебя часто сравнивали с Ким Чен Ыном, но таких было не много, да и тех ждала тяжелая участь. Ты просидел в президентском кресле всю жизнь, и в нем же и умер.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Parlament_Neut()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_92 != "lqB2ntZV")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_92 = "lqB2ntZV";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_92"].Value = conf_end_92;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 92");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Народу ты запомнился как самый бездарный и президент в истории. Вроде бы изменения в лучшую сторону и были, но они были черезчур незначительными, да и те что были перекрывались такими же незначительными изменениями в худшую сторону. В конце концов, людям это надоело и тебя свергли.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Durka()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_93 != "eU6QNK9h")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_93 = "eU6QNK9h";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_93"].Value = conf_end_93;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 93");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Наблюдая за вашими действиями, секретарь не нашел ничего лучше, чем вызвать наряд скорой помощи. Тебя скрутили и засунули в газель. Ты конечно пытался сопротивляться и кричать \"Я НОРМАЛЬНЫЙ!!!!\", но тебя никто не слушал. После тебя положили в палату к психам и ежедневно накачивали слоновьей дозой транквилизаторов. Ты конечно не умер, но живым тебя уже точно не назовешь.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Parlament_RedAlert()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Конечно, Господин Президент!\" - протараторил секретарь и скрылся за дверью. Жми, я знаю, ты этого хочешь");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Нажать на кнопку рукой");
    Console.WriteLine("2) Ногой на кнопку нажать");
    Console.WriteLine("3) Ударить по кнопке кулаком");
    Console.WriteLine("4) Не хочу я жать на кнопку! Ща бахну чаю и приступлю к работе");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_RedAlert();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_RedAlert();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_RedAlert();
                break;
            case ConsoleKey.D4:
                keyInt++;
                tea = 1;
                Parlament_Podpisanie();
                break;
        }
    }
}
void END_RedAlert()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_94 != "j1V2v729")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_94 = "j1V2v729";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_94"].Value = conf_end_94;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 94");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("За окном показалась баллистическая ракета, которая неторопливо взмыла в воздух. Буквально через секунду в кабинет залетели министры крича в один голос \"ЧТО ВЫ НАДЕЛАЛИ!!\". Во всей округе гремела воздушная тревога. Вас связали и повели к выходу. Тут ты замечаешь несколько ракет которые летят в твою сторону. Несколько секунд и из под земли взросли ядерные грибы озарив все небо алым светом. Это было невероятное зрелище, ты бы и дальше за ним наблюдал, если бы не расплавился.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Tyurma()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_95 != "6OToIFel")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_95 = "6OToIFel";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_95"].Value = conf_end_95;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 95");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Из-за этого действия тебя раскрыли, скрутили, судили и посадили в тюрьму на пожизненное. Иначе говоря, тебя откинули в деморган за нонрп. Когда ты оказался в тюрьме... В прочем, об этом как нибудь в другой раз.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Tesla_Police()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_96 != "rTso5EYh")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_96 = "rTso5EYh";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_96"].Value = conf_end_96;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 96");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты ждал... и ждал... ждал до тех пор пока не умер от жажды и голода. Ты очивидно забыл, что находишься в России.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Tesla_Head()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_97 != "bHOl1GPc")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_97 = "bHOl1GPc";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_97"].Value = conf_end_97;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 97");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Уже минуты через 2, твоя голова выглядела как Фарш Индилайт классический охлаждённый. Но умер ты не от повреждений мозга, ибо повреждаться там нечему, а от того, что кровь начала заливать дыхательные пути и перекрыла доступ к кислороду.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Kosmoshattl()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Скажу сразу: ты не умеешь водить космолеты. Перед тобой приборная панель и экран, на котором горит надпись \"Введите пароль:\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Тыкать на все подряд");
    Console.WriteLine("2) Бить по приборной панели");
    Console.WriteLine("3) Ввести пароль");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Kosmoshattl_alt();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Kosmoshattl_alt();
                break;
            case ConsoleKey.D3:
                keyInt++;
                break;
        }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Введите пароль: ");
    Console.ForegroundColor = user_foreground_color_2;
    string password = Console.ReadLine();
    if (password == "2j845gyns73")
    {
        END_Kosmoshattl_good();
    }
    else
    {
        END_Kosmoshattl_bad();
    }

}
void END_Kosmoshattl_alt()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_98 != "МаЛьВиНА")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_98 = "МаЛьВиНА";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_98"].Value = conf_end_98;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 98");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Не разобравшись с управлением, ты влетел в близжайший столб, тебя зажало в кабине пилота и ты умер от болевого шока.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Kosmoshattl_good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_99 != "veF86iK4")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_99 = "veF86iK4";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_99"].Value = conf_end_99;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 99");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Введя верный пароль, ты лицезрел все тайны человечества. Узнав всю правду, ты разочаровался во всем мире и погрузился в вечную депрессию.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Kosmoshattl_bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_100 != "6IRojx78")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_100 = "6IRojx78";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_100"].Value = conf_end_100;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 100");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Введя неверный пароль, компьютер заблокировался. и ты покочнил собой, не вынеся муки неутоленного искушения.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Les_Loveushka()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_101 != "fsY3Fs0h")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_101 = "fsY3Fs0h";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_101"].Value = conf_end_101;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 101");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты выпутался. И упал. И разбился. И насмерть");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Les_Krik()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Орал ты во всю глотку и, на удивление, это сработало! На твой клич пришел полуголый мужик с дробовиком в руках и с тряпкой на лбу.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Кто ты?");
    Console.WriteLine("2) Ты пришел на помощь?");
    Console.WriteLine("3) Ты пришел меня убить?");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Krik_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_Krik_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Les_Krik_2();
                break;
        }
    }
}
void Les_Krik_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Здесь опасно, надо уходить\" - только и сказал мужик. Он выглядел так круто и брутально, что ты невольно восхитился им. Он схватил тебя на руки и побежал вглубь леса.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ахххх");
    Console.WriteLine("2) С тобой, я не чувствую опасности...");
    Console.WriteLine("3) Молча восхищаться");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Rambo_Quest();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Rambo_Quest();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Rambo_Quest();
                break;
        }
    }
}
void Rambo_Quest()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Теперь, когда мы в относительной безопасности, я готов ответить на твои вопросы\"");
    R_quest_DALSHE = 0;
    Rambo_Questions();
}
void Rambo_Quest_Kto()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ветеран Въетнама, живущий ради цели\"");
    R_quest_DALSHE = 0;
    R_quest_cel = 1;
    R_quest_vet = 1;
    Rambo_Questions();
}
void Rambo_Quest_Opasnost()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Вонючие федералы... Ненавижу вонючих федералов...\"");
    R_quest_DALSHE = 0;
    R_quest_fed = 1;
    Rambo_Questions();
}
void Rambo_Quest_4to_Dalshe()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Я буду дальше мочить федералов... Ненавижу вонючих федералов...\"");
    R_quest_DALSHE = 1;
    R_quest_fed = 1;
    R_quest_yes = 1;
    Rambo_Questions();
}
void Rambo_Quest_Veteran()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Это я\"");
    R_quest_DALSHE = 0;
    Rambo_Questions();
}
void Rambo_Quest_Cel()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Моя цель - мочить вонючих федералов... Ненавижу вонючих федералов...\"");
    R_quest_DALSHE = 0;
    R_quest_fed = 1;
    Rambo_Questions();
}
void Rambo_Quest_Federaly()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ненавижу вонючих федералов... Потому что они ненавидят ветеранов Въетнама... Ненавидят меня... Ненавижу вонючих федералов...\"");
    R_quest_DALSHE = 0;
    R_quest_fed = 1;
    Rambo_Questions();
}
void Rambo_Questions()
{
    keyInt = 0;

    string __3 = null;
    string __4 = null;
    string __5 = null;
    string __6 = null;
    string __7 = null;
    string __8 = null;

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Кто ты?");
    Console.WriteLine("2) О какой опасности ты говоришь?");
    
    if (R_quest_vet == 1)
    {
        Console.WriteLine("3) Ветеран Въетнама?");
        __3 = "ветеран";

    }


    if (__3 == null && R_quest_cel == 1)//if (Pr_quest_zad == 1 && Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Какова твоя цель?");
        __3 = "цель";
    }
    else if (__4 == null && R_quest_cel == 1)//if (Pr_quest_zad == 1 && Pr_quest_ataka == 1)
    {
        Console.WriteLine("4) Какова твоя цель?");
        __4 = "цель";
    }


    if (__3 == null && R_quest_fed == 1)//(Pr_quest_mud == 1 && Pr_quest_zad + Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Федералы?");
        __3 = "федералы";
    }
    else if (__4 == null && R_quest_fed == 1)//(Pr_quest_mud == 1 && Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("4) Федералы?");
        __4 = "федералы";
    }
    else if (__5 == null && R_quest_fed == 1)//(Pr_quest_mud == 1 && Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("5) Федералы?");
        __5 = "федералы";
    }


    if (__3 == null)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Что будет дальше?");
        __3 = "дальше";
    }
    else if (__4 == null)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("4) Что будет дальше?");
        __4 = "дальше";
    }
    else if (__5 == null)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("5) Что будет дальше?");
        __5 = "дальше";
    }
    else //if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("6) Что будет дальше?");
        __6 = "дальше";
    }


    if (__3 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Я с тобой!");
        __3 = "да";
    }
    else if (__4 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("4) Я с тобой!");
        __4 = "да";
    }
    else if (__5 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("5) Я с тобой!");
        __5 = "да";
    }
    else if (__6 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("6) Я с тобой!");
        __6 = "да";
    }
    else if (__7 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("7) Я с тобой!");
        __7 = "да";
    }


    if (__3 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Я тебе не позволю! (Напасть)");
        __3 = "нет";
    }
    else if (__4 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("4) Я тебе не позволю! (Напасть)");
        __4 = "нет";
    }
    else if (__5 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("5) Я тебе не позволю! (Напасть)");
        __5 = "нет";
    }
    else if (__6 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("6) Я тебе не позволю! (Напасть)");
        __6 = "нет";
    }
    else if (__7 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("7) Я тебе не позволю! (Напасть)");
        __7 = "нет";
    }
    else if (__7 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("7) Я тебе не позволю! (Напасть)");
        __7 = "нет";
    }
    else if (__8 == null && R_quest_yes == 1 && R_quest_DALSHE == 1)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("8) Я тебе не позволю! (Напасть)");
        __8 = "нет";
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Rambo_Quest_Kto();
                break;
            case ConsoleKey.D2:
                Rambo_Quest_Opasnost();
                break;
            case ConsoleKey.D3:
                switch (__3)
                {
                    case "ветеран":
                        keyInt++;
                        Rambo_Quest_Veteran();
                        break;
                    case "цель":
                        keyInt++;
                        Rambo_Quest_Cel();
                        break;
                    case "федералы":
                        keyInt++;
                        Rambo_Quest_Federaly();
                        break;
                    case "дальше":
                        keyInt++;
                        Rambo_Quest_4to_Dalshe();
                        break;
                    case "да":
                        keyInt++;
                        Rambo_2();
                        break;
                    case "нет":
                        keyInt++;
                        END_Rambo_bad();
                        break;
                }
                break;
            case ConsoleKey.D4:
                switch (__4)
                {
                    case "цель":
                        keyInt++;
                        Rambo_Quest_Cel();
                        break;
                    case "федералы":
                        keyInt++;
                        Rambo_Quest_Federaly();
                        break;
                    case "дальше":
                        keyInt++;
                        Rambo_Quest_4to_Dalshe();
                        break;
                    case "да":
                        keyInt++;
                        Rambo_2();
                        break;
                    case "нет":
                        keyInt++;
                        END_Rambo_bad();
                        break;
                }
                break;
            case ConsoleKey.D5:
                switch (__5)
                {
                    case "федералы":
                        keyInt++;
                        Rambo_Quest_Federaly();
                        break;
                    case "дальше":
                        keyInt++;
                        Rambo_Quest_4to_Dalshe();
                        break;
                    case "да":
                        keyInt++;
                        Rambo_2();
                        break;
                    case "нет":
                        keyInt++;
                        END_Rambo_bad();
                        break;
                }
                break;
            case ConsoleKey.D6:
                switch (__6)
                {
                    case "дальше":
                        keyInt++;
                        Rambo_Quest_4to_Dalshe();
                        break;
                    case "да":
                        keyInt++;
                        Rambo_2();
                        break;
                    case "нет":
                        keyInt++;
                        END_Rambo_bad();
                        break;
                }
                break;
            case ConsoleKey.D7:
                switch (__7)
                {
                    case "да":
                        keyInt++;
                        Rambo_2();
                        break;
                    case "нет":
                        keyInt++;
                        END_Rambo_bad();
                        break;
                }
                break;
            case ConsoleKey.D8:
                switch (__8)
                {
                    case "да":
                        keyInt++;
                        Rambo_2();
                        break;
                    case "нет":
                        keyInt++;
                        END_Rambo_bad();
                        break;
                }
                break;
        }
    }
}
void Rambo_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ты хочешь мочить федералов вместе со мной?.. Хочешь мстить за плохое отношение к ветеранам?.. Хорошо, но перед этим спрошу: Ты ветеран Въетнама?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да... я ветеран Въетнама, как и ты!");
    Console.WriteLine("2) Нет, я не ветеран.");
    Console.WriteLine("3) Дядь, ты гонишь? Служба для олухов!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Rambo_good();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Rambo_pobil = 1;
                Les_Loveushka();                
                break;
            case ConsoleKey.D3:
                keyInt++;
                Rambo_pobil = 1;
                Les_Loveushka();
                break;
        }
    }
}
void END_Rambo_good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_102 != "NN3SLlGp")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_102 = "NN3SLlGp";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_102"].Value = conf_end_102;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 102");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ветеран и ты прослезились и пошли вместе мочить федералов. Сколько трудностей было впереди, сколько драмотичных моментов... Однако длительным ваш союз не стал и уже в конце 2-го фильма тебя подстрелили из снайперской винтовки, твой товарищь горько плакал, но ты этого не видел ибо был мертв.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Rambo_bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_154 != "hb67iOXG")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_154 = "hb67iOXG";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_102"].Value = conf_end_154;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 102");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Только ты подумал об этом, как ветеран изрешетил тебя пулеметом. Ты напал на Рэмбо, чего ты еще ожидал?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Les_Osmotr()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Кругом деревья, Шерлок.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Кричать о помощи");
    Console.WriteLine("2) Лечь в ожидании смерти");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Les_Krik();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Les_Loveushka();
                break;
        }
    }
}
void Podjog_chegoto()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("В поисках чего-то горючего, ты смекнул, что из горючего здесь только твоя одежда и сухая трава вокруг дороги");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Снять одежду и поджечь");
    Console.WriteLine("2) Поджечь одежду на себе");
    Console.WriteLine("3) Поджечь траву");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Podjog_Odejdy();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Podjog_Odejdy();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Bunkar(2);
                break;
        }
    }
    
}
void Podjog_Odejdy()
{
    odejda = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты снял одежду и кинул ее прямо в центр дороги, затем, истратив все спички, поджег одежду. И горела она ярким пламенем, и смотрел ты на все это с воодушевлением, до тех пор, пока не потерял сознание от едких паров синтетики.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Вляться в отрубе");
    Console.WriteLine("2) Терять сознание");
    Console.WriteLine("3) Ощущать обморок");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Morg(false);
                break;
            case ConsoleKey.D2:
                keyInt++;
                Morg(false);
                break;
            case ConsoleKey.D3:
                keyInt++;
                Morg(false);
                break;
        }
    }
}
void END_Podjog_Odejdy()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_4 != "ZpL7T8Nx")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_4 = "ZpL7T8Nx";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_4"].Value = conf_end_4;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 4");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Скажу кратко: ты сгорел заживо и получил Премию Дарвина.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Morg(bool labirint)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (labirint)
    {
        Console.WriteLine("Ты поднялся по лестнице, едва-едва открыл чугунный люк, который по ощущениям весил как жирный слон и залез внутрь. Немного переведя дух, ты осмотрелся. Местом в которое ты попал оказался в слабосвещенный морг.");
    }
    else
    {
        Console.WriteLine("Ты очнулся в каком-то чулане, только чулан перевернут... Стоп! Да это же не чулан а гроб!! Ты открыл крышку гроба и оказался в слабосвещенном морге.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Обыскать морг");
    Console.WriteLine("2) Обыскать трупы");
    Console.WriteLine("3) Поедать трупы");
    Console.WriteLine("4) Провести ритуал воскрешения");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Morg_Obysk();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Morg_ObyskTrupov();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Morg_PoedanieTrupov();
                break;
            case ConsoleKey.D4:
                keyInt++;
                END_Morg_Voskreshenie();
                break;
        }
    }
}
void Morg_ObyskTrupov()
{
    gold_key = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Сигареты... Кольцо... Жвачка... В трупах не было ничего интересного, хотя нет! Этот ключик нам наверное пригодится.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Взять ключ и обыскать морг");
    Console.WriteLine("2) Поедать трупы");
    Console.WriteLine("3) Провести ритуал воскрешения");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Morg_Obysk();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Morg_PoedanieTrupov();
                break;
            case ConsoleKey.D4:
                keyInt++;
                END_Morg_Voskreshenie();
                break;
        }
    }
}
void END_Morg_PoedanieTrupov()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_103 != "58XUDUhD")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_103 = "58XUDUhD";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_103"].Value = conf_end_103;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 103");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Было вкусно наверное, ибо чвякал ты так, что аж за ушами трещало. Ты пожрал многих, но не всех поскольку ты заболел редкой формой смертельной губчатой энцефалопатии и моментально умер.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Morg_Obysk()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Осмотрев морг ты нашел большой и очень красивый камень, записку и дверь");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Взять камушек");
    Console.WriteLine("2) Прочесть записку");
    Console.WriteLine("3) Пройти в дверь");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Morg_Kamen();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Morg_Zapiska();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Morg_Dver();
                break;
        }
    }
}
void END_Morg_Voskreshenie()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_104 != "1dIdT1wo")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_104 = "1dIdT1wo";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_104"].Value = conf_end_104;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 104");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты начал рвать волосы у себя из головы и орать что-то нечленораздельное разбрасывая волосы по кругу. Затем ты оторвал у одного из трупов палец, и тухлой кровью сочущейся из этого пальца начал рисовать какие-то каракули и... Мертвецы восстали! Они сначала осмотрелись вокруг в поисках пищи, но не считая зомби, съедобный там был только ты. Тебя сожрали зомби.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Morg_Kamen()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_105 != "CK05lJv7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_105 = "CK05lJv7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_105"].Value = conf_end_105;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 105");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Как только твоя рука коснулась камня, все твое тело покрылось язвами, ты визжал как девчонка, а после скропостижно умер, надо было слушать, что тебе говорят.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Morg_Zapiska()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты взял записку и начал читаить:\"тот, кто возьмет этот большой и красивый камень, будет навсегда проклят и умрет мучительной смертью!!! p.s. в майнкрафте открой чат и впиши команду телепортации.\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Взять камень");
    Console.WriteLine("2) Подтереть запиской жопу, а потом взять камень");
    Console.WriteLine("3) Пройти в дверь");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Morg_Kamen();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Morg_Kamen();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Morg_Dver();
                break;
        }
    }
}
void Morg_Dver()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Внезапно тебе очень захотелось выпендриться и открыть дверь особым способом.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Флиртовать с дверью и нежно опустить ручку");
    Console.WriteLine("2) FBI! OPEN UP!");
    Console.WriteLine("3) Сезам откройся!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Kuhnya();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Kuhnya();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Kuhnya();
                break;
        }
    }
}
void Kuhnya()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (kuhnya_byl_li == false)
    {
        Console.WriteLine("Дверь ведет в \"кухню\" типичной вестренской харчевни, но что-то в ней было определенно не так. Пол был очень-ОЧЕНЬ скользким. Походив по кухне ты заметил причину: на полу валяется пустая бутыль из-под масла, содержимое которой вытекло на пол. Также ты заметил 2 двери в следующие помещения: стальную с облупленной серой краской и резную радужную. Из интересного ты увидел только швабру, салфетки и газовый баллон. В этот раз я не буду сильно ограничивать в выборе");
    }
    else
    {
        Console.WriteLine("Ты снова в \"кухне\" типичной вестренской харчевни. Пол по-прежнему очень-ОЧЕНЬ скользкий, На полу по-прежнему валяется пустая бутыль из-под масла, содержимое которой вытекло на пол. Также по-прежнему есть 2 двери дальше: стальная с облупленной серой краской, надпись на которой гласит \"Диспетчерская\" и резная радужная. Из интересного есть только швабра, салфетки и газовый баллон. И я по-прежнему не ограничиваю тебя в выборе");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Помыть полы");
    Console.WriteLine("2) Поиграть со шваброй и бутылем в хоккей");
    Console.WriteLine("3) Покататься по полу как пингвин");
    Console.WriteLine("4) Поджечь масло");
    Console.WriteLine("5) Приготовить борщ");
    Console.WriteLine("6) Пойти в диспетчерскую");
    Console.WriteLine("7) Пойти в резную радужную дверь");
    Console.WriteLine("8) Поскользнуться, удариться головой и умереть");
    Console.WriteLine("9) Попытаться слизать все масло с пола");
    kuhnya_byl_li = true;
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Kuhnya_Shvabra();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Kuhnya_Hokkey();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Kuhnya_Penguin();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Kuhnya_Satana();
                break;
            case ConsoleKey.D5:
                keyInt++;
                Kuhnya_Borsh();
                break;
            case ConsoleKey.D6:
                keyInt++;
                if (tualet_byl_li)
                {
                    Tualet_2();
                }
                else
                {
                    Tualet();
                }
                break;
            case ConsoleKey.D7:
                keyInt++;
                Reka();
                break;
            case ConsoleKey.D8:
                keyInt++;
                END_Kuhnya_Poskolznulsa();
                break;
            case ConsoleKey.D9:
                keyInt++;
                END_Kuhnya_Virusy();
                break;
        }
    }
}
void Kuhnya_Penguin()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Было весело, но веселье быстро закончилось врезанием твоей головы в резную радужную дверь, которая сломалась от одного этого удара. Точнее даже не сломалась а порвалась. Походу это не резная деревянная, а картонная с заделом под дерево дверь. Теперь у тебя болит голова, приляжем или двинем дальше?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Поспать");
    Console.WriteLine("2) Подавить боль техникой джиу-джитсу");
    Console.WriteLine("3) Я мужик-терпила!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Kuhnya_Penguin();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Reka();
                break;
        }
    }
}
void END_Kuhnya_Penguin()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_106 != "4r9Z8jc8")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_106 = "4r9Z8jc8";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_106"].Value = conf_end_106;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 106");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Как это обычно бывает, ты уснул и не проснулся.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Reka()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Радужная дверь вела на улицу. Перед тобой широченная река с пляжем, вокруг которой простирается лес. Интересно, зачем кто-то построил морг с кухней в лесу?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Задуматься почему морг с кухней в лесу");
    Console.WriteLine("2) Поплавать в речке");
    Console.WriteLine("3) Позагарать");
    Console.WriteLine("4) Пойти по течению");
    Console.WriteLine("5) Пойти против течения");
    Console.WriteLine("6) Заблудиться в лесу");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_Podumat();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_Poplavat();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Reka_Zagarat();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Lesnik();
                break;
            case ConsoleKey.D5:
                keyInt++;
                Sunduk_s_zasosom();
                break;
            case ConsoleKey.D6:
                keyInt++;
                Reka_No();
                break;
        }
    }
}
void Reka_2()
{
    if(!reka_podumat && !reka_poplavat && !reka_zabluditsa && !reka_zagar && !reka_end)
    {
        END_Reka();
    }
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Итак, ты рядом с лесом возле реки с пляжем, что делаем?");
    Console.ForegroundColor = user_foreground_color_2;
    if (reka_podumat == true)
    {
        Console.WriteLine("1) Задуматься почему морг с кухней в лесу");
    }
    if (reka_poplavat == true)
    {
        Console.WriteLine("2) Поплавать в речке");
    }
    if (reka_zagar == true)
    {
        Console.WriteLine("3) Позагарать");
    }
    Console.WriteLine("4) Пойти по течению");
    Console.WriteLine("5) Пойти против течения");
    if (reka_zabluditsa == true)
    {
        Console.WriteLine("6) Заблудиться в лесу");
    }

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                if (reka_podumat == true)
                {
                    keyInt++;
                    Reka_Podumat();
                }
                break;
            case ConsoleKey.D2:
                if (reka_poplavat == true)
                {
                    keyInt++;
                    Reka_Poplavat();
                }
                break;
            case ConsoleKey.D3:
                if (reka_zagar == true)
                {
                    keyInt++;
                    Reka_Zagarat();
                }
                break;
            case ConsoleKey.D4:
                keyInt++;
                Lesnik();
                break;
            case ConsoleKey.D5:
                keyInt++;
                Sunduk_s_zasosom();
                break;
            case ConsoleKey.D6:
                if (reka_zabluditsa == true)
                {
                    keyInt++;
                    Reka_No();
                }
                break;
        }
    }
}
void END_Reka()
{
    reka_end = true;
    Console.Clear();
    keyInt = 0;
    if (conf_end_107 != "0joLBK0j")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_107 = "0joLBK0j";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_107"].Value = conf_end_107;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 107");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("За то, что ты выполнил все побочные активности у реки, я дарую тебе эту особенную концовку. Ее особенность в том, что после ее получения начинать игру с начала не обязательно, ты можешь продолжить игру.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    Console.WriteLine("2) Продолжить");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void Reka_Poplavat()
{
    reka_poplavat = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Как будешь плавать?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Кролем");
    Console.WriteLine("2) Брассом");
    Console.WriteLine("3) По-собачьи");
    Console.WriteLine("4) Просто помочить ноги");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Reka_Poplavat(1);
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Reka_Poplavat(2);
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Reka_Poplavat(3);
                break;
            case ConsoleKey.D4:
                keyInt++;
                Reka_Poplavat_2();
                break;
        }
    }
}
void Reka_Poplavat_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты залез в воду примерно по колено. Попереминавшись в ней с минуту, тебе стало холодно.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Фух! Пора заканчивать водные процедуры и заниматься чем-то другим.");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void END_Reka_Poplavat(int utop)
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_108 != "UtV4hjLv")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_108 = "UtV4hjLv";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_108"].Value = conf_end_108;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 108");
    Console.ForegroundColor = user_foreground_color_1;
    if (utop == 1)
    {
        Console.WriteLine("Как професиональный пловец, ты поплыл против течения, но у судорог ног на тебя были свои планы. Ты утонул");
    }
    else if (utop == 2)
    {
        Console.WriteLine("Размеренным брассом ты бороздил речные просторы, как ВНЕЗАПНО ты вспомнил, что не умеешь плавать. Ты утонул");
    }
    else if (utop == 3)
    {
        Console.WriteLine("Кое-как ты доплыл до центра реки, после чего силы тебя покинули. Ты утонул");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Reka_Zagarat()
{
    Console.Clear();
    keyInt = 0;
    if (sound_value) { zvuk3.Play(); }
    Console.ForegroundColor = user_foreground_color_1;
    if (zagar_byl_li == false)
    {
        Console.WriteLine("Ой, забыл уточнить: сейчас ночь, соответственно позагарать не получится.");
        zagar_byl_li = true;
    }
    else
    {
        Console.WriteLine("Напоминаю, что на улице ночь, и что позагарать не выйдет.");
    }
    
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Попытаться позагарать без солнца");
    Console.WriteLine("2) Исполнить шаманский танец призыва солнца");
    Console.WriteLine("3) Передумать загарать");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_Zagarat_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Reka_Zagarat();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void Reka_Zagarat_2()
{
    reka_zagar = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Игнорируя мои слова о том, что сейчас ночь, ты прыгнул в холодный песок. Полежал на нем минуты две и встал с песком в жопе и волосах на голове.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) С загаром, покончено! Надо бы заняться чем-то другим");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void END_Reka_Zagarat()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_109 != "Z6jE8q3j")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_109 = "Z6jE8q3j";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_109"].Value = conf_end_109;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 109");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Выполнив энергичный племянной флекс, ты призвал солнце на землю или себя на солнце, суть не важна, ведь ты моментально сгорел.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Reka_Podumat()
{
    reka_podumat = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Хм, а ведь действительно, почему? - Подумалось тебе. - Может чтобы подальше от лишних глаз разделывать трупы, готовить их и продавать?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подумать еще");
    Console.WriteLine("2) Перестать думать об этом и заняться чем-то другим");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_Podumat_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void Reka_Podumat_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Хотя кому продавать трупы в лесу... А может их сюда привозят, а потом закапывают, а кухня для тех кто закапывает?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подумать еще");
    Console.WriteLine("2) Перестать думать об этом и заняться чем-то другим");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_Podumat_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void Reka_Podumat_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Хотя тут нет ни могил ни крестов... Да и дороги чтобы довозить... Я понял! Это сортировочный пункт! Их сюда сплавляют по реке, вылавливают здесь, и сортируют.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подумать еще");
    Console.WriteLine("2) Перестать думать об этом и заняться чем-то другим");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_Podumat_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void Reka_Podumat_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Но зачем сортировать трупы? Да и куда, если река здесь единственный путь транспортировки... А может быть это чья-то гробница?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подумать еще");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_Podumat_5();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void Reka_Podumat_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Но зачем тогда нужна кухня? Или это все-таки канибальский ресторан? Добираются на лодках и лакомятся, но тогда почему он стоит в лесу? Да и нету там фуд-корта, просто кухня и морг. А может здесь планируют строить кладбище и заранее привезли трупы и кухня для строителей?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подумать еще");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_Podumat_6();
                break;
        }
    }
}
void Reka_Podumat_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("А может когда-то здесь было поселение, но от него остался один лишь морг и ресторан? Или может его сюда переместили инопланетяне? А что-если это и есть частилище, а трупы это новоприбывшие и я тоже труп? А вдруг это все иллюзия и мне это снится?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Подумать еще");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Reka_Podumat();
                break;
        }
    }
}
void END_Reka_Podumat()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_110 != "OGFKmz0w")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_110 = "OGFKmz0w";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_110"].Value = conf_end_110;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 110");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Варианты причины такого явления пролетали в твоей голове с немыслемой скоростью, от чего, что логично, ты перестал адекватно мыслить и просто сошел с ума.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Reka_No()
{
    reka_zabluditsa = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Нет");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Почему?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_No_2();
                break;
        }
    }
}
void Reka_No_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Потому, что, во первых, этот вариант уже есть в другой ветке квеста, а во вторых, потому что мне лень придумавать, что с тобой произойдет в этом случае.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ладно");
    Console.WriteLine("2) В каком квесте?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_No_3();
                break;
        }
    }
}
void Reka_No_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("В этом текстовом квесте. Не прикидывайся персонажем из игры, четвертая стена уже сломана. Из-за тебя кстати!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ладно");
    Console.WriteLine("2) Персонажем игры?");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_No_4();
                break;
        }
    }
}
void Reka_No_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты сейчас играешь в игру «‎Запиздоха!» за тупого персонажа, который постоянно отклоняется от сюжета в поисках не менее тупых концовок.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ладно");
    Console.WriteLine("2) Не верю!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_No_5();
                break;
        }
    }
}
void Reka_No_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("То есть тебя не смущает, что вся твоя жизнь - это текст произносимый мной и варианты ответов, также предлагаемые мной?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ладно");
    Console.WriteLine("2) У всех людей в мире так, ты звучишь не убедительно!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_No_6();
                break;
        }
    }
}
void Reka_No_6()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Все, ты мне надоел, я забираю у тебя возможность продолжать этот диалог.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ладно");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void Lesnik()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты пошел по течению реки, которая в конечном итоге закончилась и привела тебя в болото. Ты осмотелся в поисках возможного продолжения пути. Не найдя глазами ничего интересного, ты просто решил пойти куда глаза глядят. Сделав шаг ты наступил на что-то твердое. Опустив взгляд, ты понял, что это ничто иное как компас. И тут у тебя появилось целых 4 варианта продолжения пути:");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Запад");
    Console.WriteLine("2) Восток");
    Console.WriteLine("3) Север");
    Console.WriteLine("4) Юг");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Lesnik();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Lesnik();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Lesnik_2();
                break;
            case ConsoleKey.D4:
                keyInt++;
                END_Lesnik();
                break;
        }
    }
}
void Lesnik_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Выбрав север в качестве своего основного направления, ты через какое-то время вышел к безнадежно засранной опушке, кое-как ты смог разглядеть на ней три залитых говном с мочей хижины. В какую зайдешь?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Первая");
    Console.WriteLine("2) Вторая");
    Console.WriteLine("3) Третья");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Lesnik_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (odejda)
                {
                    END_Lesnik_Odejda();
                }
                else
                {
                    Lesnik_3();
                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Lesnik_2();
                break;
        }
    }
}
void Lesnik_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Зайдя в хижину, ты встретил синеволосую девочку с наитупейшим выражением лица. Первым делом она спросила у тебя: \"ЫыЫЫы! Ты ктоэо?!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Не имеет значения");
    Console.WriteLine("2) Вписать имя");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Lesnik_3(1);
                break;
            case ConsoleKey.D2:
                keyInt++;                
                break;
        }
    }
    string NaMe = Console.ReadLine();
    if (NaMe == "не ежачер")
    {
        Lesnik_4();
    }
    else
    {
        END_Lesnik_3(2);
    }
}
void Lesnik_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"ЫЫыЫ!! Сцука! Обосрач гавно! Обосрачеры пидары!1!\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да! ППО - сила! Аве сблевачу!");
    Console.WriteLine("2) Изображать из себя сблевачера.");
    if (gold_lopata)
    {
        Console.WriteLine("3) Молча отдать ёршик");
    }


    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Lesnik_3(3);
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Lesnik_3(3);
                break;
            case ConsoleKey.D3:
                if (gold_lopata)
                {
                    keyInt++;
                    END_Lesnik_Good();
                }
                break;
        }
    }
}
void END_Lesnik_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_111 != "BTrlZbI7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_111 = "BTrlZbI7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_111"].Value = conf_end_111;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 111");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты отдал леснику ёршик и сразу ушел. Эскейптян громко мычала что-то бессвязное тебе вслед в след, но ты ее не слушал. Поздравляю, ты выполнил квест Оператора!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Lesnik_Odejda()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_155 != "HvHy52iB")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_155 = "HvHy52iB";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_155"].Value = conf_end_155;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 155");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Открыв дверь, первым и последним что ты увидел, был поток кислотной мочи стремительно летящий в тебя. \"ЫыЫЫы!! Одежда!! Ты не показал внутренний мир!!1! ЫЫЫЫ!!!1!\" - Услышал ты, прежде чем умер.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Lesnik()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_112 != "Abc99mmV")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_112 = "Abc99mmV";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_112"].Value = conf_end_112;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 112");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Направление оказалось неверным и дикий лес тебя погубил.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Lesnik_2()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_113 != "kjEahr6f")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_113 = "kjEahr6f";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_113"].Value = conf_end_113;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 113");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Как только ты зашел в хижину, так сразу же превратился в кровавую лужу.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Lesnik_3(int xy)
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_114 != "Lv5H6f8d")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_114 = "Lv5H6f8d";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_114"].Value = conf_end_114;
        config.Save(ConfigurationSaveMode.Modified);
        
        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 114");
    Console.ForegroundColor = user_foreground_color_1;
    if (xy == 1)
    {
        Console.WriteLine("\"Чеыыоыо!!? Анон, иди нахуй!\" - Провопила девочка, оголила вагину и облила тебя кислотной мочой, которая тебя растворила.");
    }
    else if (xy == 2)
    {
        Console.WriteLine("\"ЫыЫЫЫ! РАЧЬЕ!!1!1!.\" - Заорала тян, оголила вагину и облила тебя кислотной мочой, которая тебя растворила.");
    }
    else if (xy == 3)
    {
        Console.WriteLine("Эскейптян догадалась, что ты от Ежача, оголила вагину и облила тебя кислотной мочой, которая тебя растворила.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Sunduk_s_zasosom()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Река привела тебя к одинокому сундуку.");
    Console.ForegroundColor = user_foreground_color_2;
    if (gold_key)
    {
        Console.WriteLine("1) Открыть сундук ключом найденным в морге");
    }
    else
    {
        Console.WriteLine("1) Попытаться вскрыть сундук");
    }
    Console.WriteLine("2) Уйти обратно");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                if (gold_key)
                {
                    END_Sunduk_s_zasosom();
                }
                else
                {
                    Sunduk_s_zasosom_2();
                }
                keyInt++;
                
                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void Sunduk_s_zasosom_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Тебе не удалось взломать сундук.");
    if (gold_key)
    {
        Console.WriteLine("1) Открыть сундук золотым ключом");
    }
    else
    {
        Console.WriteLine("1) Попытаться вскрыть сундук");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("2) Уйти обратно");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                if (gold_key)
                {
                    END_Sunduk_s_zasosom();
                }
                else
                {
                    Sunduk_s_zasosom_2();
                }
                keyInt++;

                break;
            case ConsoleKey.D2:
                keyInt++;
                Reka_2();
                break;
        }
    }
}
void END_Sunduk_s_zasosom()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_115 != "d1R45Vxj")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_115 = "d1R45Vxj";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_115"].Value = conf_end_115;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 115");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Открыв сундук ключом, тебя сразу же засосало внутрь него. Ты оказался в каком-то подвале с бетонными стенами, рядом с тобой... В прочем, это другая история.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Kuhnya_Satana()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Проявив недюжинную изобретательность, ты подключил баллон к плите, сделал из салфеток фитиль от плиты до пола и нажал на пьезоподжиг.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Инсендио!");
    Console.WriteLine("2) Огонь на поражение!");
    Console.WriteLine("3) Ты горишь, как огонь! йа, у меня агония!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Kuhnya_Satana_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Kuhnya_Satana_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Kuhnya_Satana_2();
                break;
        }
    }
}
void Kuhnya_Satana_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) { zvuk3.Play(); }
    if (odejda)
    {
        Console.WriteLine("Весь пол моментально вспыхнул. Как вспыхнула и твоя одежда. И вообще, что у тебя за нездравая мания к поджигательству? Пиромант. Твои ноги начало не по-детски жарить и ты залез на близжайшую возвышенность, коей стала газовая плита. Как только ты залез на плиту из огня полезло чудище. Ну кого ты еще призвал, идиот!?");
    }
    else
    {
        Console.WriteLine("Весь пол моментально вспыхнул. Вспыхнула и твоя одежда... бы, если бы ты не сжег ее раньше. И вообще, что у тебя за нездравая мания к поджигательству? Пиромант. Твои ноги начало не по-детски жарить и ты залез на близжайшую возвышенность, коей стала газовая плита. Как только ты залез на плиту из огня полезло чудище. Ну кого ты еще призвал, идиот!?");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Очень сильно перепугаться");
    Console.WriteLine("2) Слегка испугнуться");
    Console.WriteLine("3) Не пугаться");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Kuhnya_Satana_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Kuhnya_Satana_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Kuhnya_Satana_3();
                break;
        }
    }
}
void Kuhnya_Satana_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (satana == 0 && satana_who == false)
    {
        Console.WriteLine("Чудище вылезло из огня и заговорило дьявольским голосом: \"Зачем ты вызвал меня, человек!?\".");
    }
    else if (satana_who == true && satana_x == true)
    {
        Console.WriteLine("\"Ты даже не знаешь кого ты вызвал? Я Сатана - верховный демон зла и властелин ада! Так зачем ты вызвал меня, человек!?\".");
        satana_x = false;
    }
    else if (satana > 0)
    {
        Console.WriteLine("\"Опять ты!? Зачем ты вызвал меня на этот раз, человек!?\".");
    }
    Console.ForegroundColor = user_foreground_color_2;
    if (satana_who == false && satana_x == true)
    {
        Console.WriteLine("1) Кто, ты!?");
        Console.WriteLine("2) Спасити-памагити!!");
    }
    else 
    {
        Console.WriteLine("1) Спасити-памагити!!");
    }
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                if (satana_who == false && satana_x == true )
                {
                    keyInt++;
                    satana_who = true;
                    Kuhnya_Satana_3();
                }
                else
                {
                    keyInt++;
                    Kuhnya_Satana_4();
                }
                break;
            case ConsoleKey.D2:
                if (satana_who == false && satana_x == true)
                {
                    keyInt++;
                    Kuhnya_Satana_4();
                }
                else
                {

                }
                break;
        }
    }
}
void Kuhnya_Satana_4()
{
    if (satana > 0)
    {
        END_Satana_Hell();
    }
    satana = 1;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Чтоооо!? Я Сатана, а не ангел-хранитель! Я прибыл из ада, где пытают людей!!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Из какого-какого ты зада?");
    Console.WriteLine("2) Разве ты не Сатанангел-хранитель?");
    Console.WriteLine("3) Ну помоги мне!!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Satana_bad();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Satana_bad();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Kuhnya_Satana_KNB();
                break;
        }
    }
}
void Kuhnya_Satana_Reverse()
{
    Console.Clear();
    nachalo_byl_li = true;
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Поскольку ты победил в честном бою, я тебе помогу, человек. Я верну тебя назад в прошлое, в момент, где ты еще не решил все сжечь к чертовой матери!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Урааа, я спасен!");
    Console.WriteLine("2) Давай быстрее, я сейчас сгорю!!");
    Console.WriteLine("3) Спасибо, мистер демон!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Nachalo();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Kuhnya_Satana_KNB()
{
    fighter = 4;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ладно, сделаю скидку на то, что ты идиот, и помогу тебе в первый и последний раз, это понятно!? Если ты попытаешься вызвать меня вновь и снова посмеешь просить о помощи, я, за все твои грехи, заберу тебя с собой в ад!!\" - Прорычал демон и протянул на ладони в твою сторону кулак - \"Я помогу тебе если ты меня выйграешь меня в «Камень, ножницы, бумага, ящерица, Спок». Выбери до скольки побед будем играть или я могу объяснить правила игры\".");
    Console.ForegroundColor = user_foreground_color_2;
    
    Console.WriteLine("1) Играем до 1 победы");
    Console.WriteLine("2) Играем до 2 побед");
    Console.WriteLine("3) Играем до 3 побед");
    Console.WriteLine("4) Играем до 4 побед");
    Console.WriteLine("5) Играем до 5 побед");
    Console.WriteLine("6) Играем до 6 побед");
    Console.WriteLine("7) Играем до 7 побед");
    Console.WriteLine("8) Играем до 8 побед");
    Console.WriteLine("9) Играем до 9 побед");
    Console.WriteLine("0) Правила");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                knb_wins_all = 1;
                KNB_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                knb_wins_all = 2;
                KNB_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                knb_wins_all = 3;
                KNB_1();
                break;
            case ConsoleKey.D4:
                keyInt++;
                knb_wins_all = 4;
                KNB_1();
                break;
            case ConsoleKey.D5:
                keyInt++;
                knb_wins_all = 5;
                KNB_1();
                break;
            case ConsoleKey.D6:
                keyInt++;
                knb_wins_all = 6;
                KNB_1();
                break;
            case ConsoleKey.D7:
                keyInt++;
                knb_wins_all = 7;
                KNB_1();
                break;
            case ConsoleKey.D8:
                keyInt++;
                knb_wins_all = 8;
                KNB_1();
                break;
            case ConsoleKey.D9:
                keyInt++;
                knb_wins_all = 9;
                KNB_1();
                break;
            case ConsoleKey.D0:
                keyInt++;
                Satana_KNB_Pravila();
                break;
        }
    }
}
void Satana_KNB_Pravila()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}

    Console.WriteLine("Ты еще и правил не знаешь!? Да ты надо мной издеваешься! Ладно, убогий, рассказываю правила игры \"Камень, ножницы, бумага, ящерица, Спок\".");
    Console.WriteLine("");
    Console.WriteLine("Игра включает пять жестов:");
    Console.WriteLine("1. Камень");
    Console.WriteLine("2. Ножницы");
    Console.WriteLine("3. Бумага");
    Console.WriteLine("4. Ящерица");
    Console.WriteLine("5. Спок");
    Console.WriteLine("");
    Console.WriteLine("Кто кого побеждает:");
    WriteBattle("Камень", "побеждает", "Ножницы");
    WriteBattle("Камень", "побеждает", "Ящерицу");
    WriteBattle("Ножницы", "побеждают", "Бумагу");
    WriteBattle("Ножницы", "побеждают", "Ящерицу");
    WriteBattle("Бумага", "побеждает", "Камень");
    WriteBattle("Бумага", "побеждает", "Спока");
    WriteBattle("Ящерица", "побеждает", "Спока");
    WriteBattle("Ящерица", "побеждает", "Бумагу");
    WriteBattle("Спок", "побеждает", "Ножницы");
    WriteBattle("Спок", "побеждает", "Камень");
    Console.WriteLine("");
    Console.WriteLine("Правила ходов:");
    Console.WriteLine("1. Игроки одновременно показывают жест рукой.");
    Console.WriteLine("2. Победитель определяется на основе вышеприведённого списка и получает очко победы.");
    Console.WriteLine("3. Если жесты одинаковые, то это ничья и очко победы никому не засчитывается.");
    Console.WriteLine("");
    Console.WriteLine("Теперь выбирай на сколько побед играем, если хочешь спастись, кожанный кусок ты дрьма!");

    Console.ForegroundColor = user_foreground_color_2;

    Console.WriteLine("1) Играем до 1 победы");
    Console.WriteLine("2) Играем до 2 побед");
    Console.WriteLine("3) Играем до 3 побед");
    Console.WriteLine("4) Играем до 4 побед");
    Console.WriteLine("5) Играем до 5 побед");
    Console.WriteLine("6) Играем до 6 побед");
    Console.WriteLine("7) Играем до 7 побед");
    Console.WriteLine("8) Играем до 8 побед");
    Console.WriteLine("9) Играем до 9 побед");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                knb_wins_all = 1;
                KNB_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                knb_wins_all = 2;
                KNB_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                knb_wins_all = 3;
                KNB_1();
                break;
            case ConsoleKey.D4:
                keyInt++;
                knb_wins_all = 4;
                KNB_1();
                break;
            case ConsoleKey.D5:
                keyInt++;
                knb_wins_all = 5;
                KNB_1();
                break;
            case ConsoleKey.D6:
                keyInt++;
                knb_wins_all = 6;
                KNB_1();
                break;
            case ConsoleKey.D7:
                keyInt++;
                knb_wins_all = 7;
                KNB_1();
                break;
            case ConsoleKey.D8:
                keyInt++;
                knb_wins_all = 8;
                KNB_1();
                break;
            case ConsoleKey.D9:
                keyInt++;
                knb_wins_all = 9;
                KNB_1();
                break;
        }
    }
}
void WriteBattle(string winner, string action, string loser)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(winner);
    Console.ForegroundColor = user_foreground_color_1;
    Console.Write($" {action} ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(loser + ".");
    Console.ForegroundColor = user_foreground_color_1;
}
void KNB_1()
{
    Console.Clear();
    switch (fighter)
    {
        case 4:
            name_knb = "Сатана";
            break;
    }
    keyInt = 0;

    if (vrag_zhest != 0)
    {
        if (sound_value) {zvuk3.Play();}
    }

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"{name_knb} {vrag_wins}:{u_wins} Ты");
    Console.WriteLine($"Игра до {knb_wins_all} побед");
    Console.WriteLine("");
    if (u_zhest != 0)
    {
        Console.ForegroundColor = user_foreground_color_1;
        Console.Write("Цу ");
        if (vrag_zhest != 0)
        {
            Thread.Sleep(300);
        }
        Console.Write("е ");
        if (vrag_zhest != 0)
        {
            Thread.Sleep(300);
        }
        Console.WriteLine("фа!");
        if (vrag_zhest != 0)
        {
            Thread.Sleep(300);
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(name_knb);
        Console.ForegroundColor = user_foreground_color_1;
        Console.Write($" выкинул ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{name_zhest_vrag}");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Ты");
        Console.ForegroundColor = user_foreground_color_1;
        Console.Write($" выкинул ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{name_zhest_u}");

        Console.WriteLine("");

        if (vrag_zhest != 0)
        {
            Thread.Sleep(2000);
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(name_zhest_vrag);
        Console.ForegroundColor = user_foreground_color_1;
        Console.Write($" {knb_znak} ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(name_zhest_u);
        Console.ForegroundColor = user_foreground_color_1;
        if (knb_znak == "=")
        {
            if (vrag_zhest != 0)
            {
                Thread.Sleep(2000);
            }
            Console.WriteLine("Ничья");
        }
        else if (knb_znak == ">")
        {
            if (vrag_zhest != 0)
            {
                Thread.Sleep(2000);
                vrag_wins++;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(name_knb);
            Console.ForegroundColor = user_foreground_color_1;
            Console.WriteLine(" победил в этом раунде");
        }
        else if (knb_znak == "<")
        {
            if (vrag_zhest != 0)
            {
                Thread.Sleep(2000);
                u_wins++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ты");
            Console.ForegroundColor = user_foreground_color_1;
            Console.WriteLine(" победил в этом раунде");
        }

        if (vrag_zhest != 0)
        {
            Thread.Sleep(2000);
            vrag_zhest = 0;
            KNB_1();
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        if (sound_value) {zvuk3.Play();}
    }

    if (fighter == 4 && u_wins >= knb_wins_all)
    {
        Kuhnya_Satana_Reverse();
    }
    else if (fighter == 4 && vrag_wins >= knb_wins_all)
    {
        END_Satana_KNB();
    }
    Console.WriteLine("");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Камень");
    Console.WriteLine("2) Ножницы");
    Console.WriteLine("3) Бумага");
    Console.WriteLine("4) Ящерица");
    Console.WriteLine("5) Спок");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                u_zhest = 1;
                break;
            case ConsoleKey.D2:
                keyInt++;
                u_zhest = 2;
                break;
            case ConsoleKey.D3:
                keyInt++;
                u_zhest = 3;
                break;
            case ConsoleKey.D4:
                keyInt++;
                u_zhest = 4;
                break;
            case ConsoleKey.D5:
                keyInt++;
                u_zhest = 5;
                break;
        }
    }
    KNB_2();
}
void KNB_2()
{
    Random rnd = new Random();
    vrag_zhest = rnd.Next(1,6);
    switch (vrag_zhest)
    {
        case 1:
            name_zhest_vrag = "Камень";
            break;
        case 2:
            name_zhest_vrag = "Ножницы";
            break;
        case 3:
            name_zhest_vrag = "Бумага";
            break;
        case 4:
            name_zhest_vrag = "Ящерица";
            break;
        case 5:
            name_zhest_vrag = "Спок";
            break;
        case 6:
            name_zhest_vrag = "Спок";
            break;
    }
    switch (u_zhest)
    {
        case 1:
            name_zhest_u = "Камень";
            break;
        case 2:
            name_zhest_u = "Ножницы";
            break;
        case 3:
            name_zhest_u = "Бумага";
            break;
        case 4:
            name_zhest_u = "Ящерица";
            break;
        case 5:
            name_zhest_u = "Спок";
            break;
    }
    if (name_zhest_vrag == name_zhest_u) //одинаковые жесты
    {
        knb_znak = "=";
    }
    else if ((name_zhest_vrag == "Камень" && name_zhest_u == "Ящерица") || (name_zhest_vrag == "Камень" && name_zhest_u == "Ножницы") || 
        (name_zhest_vrag == "Ящерица" && name_zhest_u == "Бумага") || (name_zhest_vrag == "Ящерица" && name_zhest_u == "Спок") ||
        (name_zhest_vrag == "Спок" && name_zhest_u == "Ножницы") || (name_zhest_vrag == "Спок" && name_zhest_u == "Камень") ||
        (name_zhest_vrag == "Ножницы" && name_zhest_u == "Бумага") || (name_zhest_vrag == "Ножницы" && name_zhest_u == "Ящерица") ||
        (name_zhest_vrag == "Бумага" && name_zhest_u == "Спок") || (name_zhest_vrag == "Бумага" && name_zhest_u == "Камень"))
    {
        knb_znak = ">"; //враг победил
    }
    else if ((name_zhest_vrag == "Ящерица" && name_zhest_u == "Камень") || (name_zhest_vrag == "Ножницы" && name_zhest_u == "Камень") ||
        (name_zhest_vrag == "Бумага" && name_zhest_u == "Ящерица") || (name_zhest_vrag == "Спок" && name_zhest_u == "Ящерица") ||
        (name_zhest_vrag == "Ножницы" && name_zhest_u == "Спок") || (name_zhest_vrag == "Камень" && name_zhest_u == "Спок") ||
        (name_zhest_vrag == "Бумага" && name_zhest_u == "Ножницы") || (name_zhest_vrag == "Ящерица" && name_zhest_u == "Ножницы") ||
        (name_zhest_vrag == "Спок" && name_zhest_u == "Бумага") || (name_zhest_vrag == "Камень" && name_zhest_u == "Бумага"))
    {
        knb_znak = "<"; //ты победил
    }

    KNB_1();
}
void END_Satana_KNB()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_116 != "5c1FQkzg")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_116 = "5c1FQkzg";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_116"].Value = conf_end_116;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 116");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("\"Поскольку ты проиграл, я не стану тебе помогать!\" - Сказал демон и скрылся в пламени. Ты же сначала задохнулся от угарного газа, а после сгорел.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Satana_bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_117 != "lkezTCU8")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_117 = "lkezTCU8";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_117"].Value = conf_end_117;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 117");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Услышав твои слова, Сатана разозлился и испепелил тебя. Надо быть вежлевее, пусть даже и по отношению к Сатане.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Satana_Hell()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_118 != "7s9bVV4b")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_118 = "7s9bVV4b";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_118"].Value = conf_end_118;
        config.Save(ConfigurationSaveMode.Modified);
        
        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 118");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("\"Я предупреждал, что будет, если ты вновь будешь просить у меня помощи!!\" - Зарычал Сатана и утащил тебя в преисподнюю.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Kuhnya_Virusy()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_119 != "O1UIVLMy")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_119 = "O1UIVLMy";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_119"].Value = conf_end_119;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 119");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Тебе почти удалось это сделать, возможно ты бы смог, если бы все известные миру вирусы и бактерии не попали тебе в рот вместе со слизанным с пола маслом.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Kuhnya_Shvabra()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_120 != "yR7LfKgQ")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_120 = "yR7LfKgQ";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_120"].Value = conf_end_120;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 120");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты так тщательно вымыл пол, что он подходил под категорию \"стирильно\". Вдоволь налюбовавшись плодами труда, ты пошел ставить швабру на место. По возвращению ты увидел вышедшего из туалета дядьку в рубашке и гарнитурой на голове, который роняет вторую бутыль с маслом. Твое сердце не вынесло столь большого потрясения и остановилось.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Kuhnya_Hokkey()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_121 != "kmkBV5ql")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_121 = "kmkBV5ql";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_121"].Value = conf_end_121;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 121");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Добро пожаловать на шизоматч по хоккею! Хоккеист уже на поле! И вот он делает разгон, удар по шайбе, ГОООООЛ!!! Ты зарядил бутылью прямо в газовый баллон, который уничтожил все в радиусе 15-ти метров, тебя в том числе.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Kuhnya_Borsh()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;

    if (povareshka)
    {
        Borsh();
    }
    else
    {
        if (sound_value) {zvuk3.Play();}
        Console.WriteLine("Для этого действия необходим предмет: Поварешка.");
    }

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Назад");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                kuhnya_byl_li = true;
                Kuhnya();
                break;
        }
    }
}
void Borsh()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("В эфире кулинарная передача \"Борщец-шо-пиздец\". Сегодня у нас в студии человек без имени и истории, человек без прошлого и будущего, и именно этот безымянный герой нам сегодня покажет, как праильно готовить борщ!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Приветики-пистолетики");
    Console.WriteLine("2) ЫЫыЫыуаыыЫ!!");
    Console.WriteLine("3) Здравствуйте Тимур добрый вечер");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Borsh_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Borsh_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Borsh_1();
                break;
        }
    }
}
void Borsh_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Я думаю, что сначала нужно поставить картошку и начистить воду.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Поставить на плиту налитую с крана подсоленную воду и аккуратно почистить картошку");
    Console.WriteLine("2) Нассать в кастрюлю и кинуть туда картошку с землей");
    Console.WriteLine("3) Насрать в сковородку");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                vkus_borsha--;
                Borsh_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Borsh_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                vkus_borsha++;
                Borsh_2();
                break;
        }
    }
}
void Borsh_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Итак, первая часть сделана, далее по списку: Порезать мясо на средние куски и поставить варить");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Очистить мясо от кожи и положить вариться в кастрюлю");
    Console.WriteLine("2) Принести с морга ногу и запихать в кострюлю");
    Console.WriteLine("3) Нацепть курицу на хуй и, раскручивая ее, еще раз насрать в сковородку");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                vkus_borsha--;
                Borsh_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Borsh_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                vkus_borsha++;
                Borsh_3();
                break;
        }
    }
}
void Borsh_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Следом по нашему фирменному рецепту передачи, у нас идет обжарка. Нужно мелко нарезать остольные овощи и обжарить их на сковородке.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Строго следуя рецепту, нарезать лук, капусту, укроп, петрушку и чеснок и закинуть на обжаривание в сковородку");
    Console.WriteLine("2) Ничего не нарезая кинуть в сковородку и залив литром масла");
    Console.WriteLine("3) Налить в сковородку фери и засыпать все картошкой до горки");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                vkus_borsha--;
                Borsh_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Borsh_4();
                break;
            case ConsoleKey.D3:
                keyInt++;
                vkus_borsha++;
                Borsh_4();
                break;
        }
    }
}
void Borsh_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ах! Какой аромат источает это восхитительное блюдо! Осталось лишь смешать все во едино и добавить специй для сдабривания и без того замечательного вкуса.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Забросить все в одну кострюлю и помешивая добавить перец, ловровый лист и немного чебреца");
    Console.WriteLine("2) Кое-как все уместить в кастрюлю и бухнуть туду 3 ложки соли");
    Console.WriteLine("3) Вылить все в бочку и с логтя посыпать лобковыми волосами");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                vkus_borsha--;
                break;
            case ConsoleKey.D2:
                keyInt++;
                break;
            case ConsoleKey.D3:
                keyInt++;
                vkus_borsha++;
                break;
        }
    }
    if (vkus_borsha>3)
    {
        END_Borsh_Good();
    }
    else if (vkus_borsha<3)
    {
        END_Borsh_Bad();
    }
    else
    {
        END_Borsh_Neutral();
    }
}
void END_Borsh_Good()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_122 != "7PvzvAyS")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_122 = "7PvzvAyS";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_122"].Value = conf_end_122;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 122");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Итак, дорогие зрители, настало время отведать наше блюдо! ... Ммм... Как же вкусно, белиссимо! Просто шедевр! Мсье, почему вы блюете?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Borsh_Neutral()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_123 != "zri6Jcfr")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_123 = "zri6Jcfr";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_123"].Value = conf_end_123;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 123");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Итак, дорогие зрители, настало время отведать наше блюдо! ... Ммм... Неплохо... Слушай, правда неплохо, ты молодец! Только вот почему ты ешь так неохотно?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Borsh_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_124 != "1phdVQ7j")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_124 = "1phdVQ7j";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_124"].Value = conf_end_124;
        config.Save(ConfigurationSaveMode.Modified);
        
        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 124");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Итак, дорогие зрители, настало время отведать наше блюдо! ... Ммм... Фу, какая гадость! Просто отвратительный вкус! И вам вот это нравится?! И это вы называете борщем?!! Да мне стыдно находиться в одном помещении с вами! Идите прочь с нашей кулинарной передачи!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Kuhnya_Poskolznulsa()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_125 != "s0vWQali")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_125 = "s0vWQali";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_125"].Value = conf_end_125;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 125");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты поскользнулся, ударился головой и умер.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Tualet_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты снова в туалете для персонала. Рядом с тобой раковина и открытая кабинка с мужиком.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Помыть руки");
    Console.WriteLine("2) Зайти в кабинку");
    Console.WriteLine("3) Уйти");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Tualet_Ruki();
                break;
            case ConsoleKey.D2:
                if (oper_dovolen)
                {
                    keyInt++;
                    Tualet_Operator_Yes();
                }
                else
                {
                    keyInt++;
                    Tualet_Operator_No();
                }
                break;
            case ConsoleKey.D3:
                keyInt++;
                tualet_byl_li = true;
                Kuhnya();
                break;
        }
    }
}
void Tualet()
{
    tualet_byl_li = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Как только дверь отворилась, ты сразу же почуял, что это за место - туалет для персонала. В нем была раковина и закрытая кабинка, из которой с периодичностью раз в 4 секунды (я специально подсчитал) раздавался мощный залп.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Помыть руки");
    Console.WriteLine("2) Постучаться в кабинку");
    Console.WriteLine("3) Бесцеремонно открыть кабинку");
    Console.WriteLine("4) Уйти");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Tualet_Ruki();
                break;
            case ConsoleKey.D2:
                keyInt++;
                oper_dovolen = true;
                Tualet_Operator_Yes();
                break;
            case ConsoleKey.D3:
                keyInt++;
                oper_dovolen = false;
                Tualet_Operator_No();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Kuhnya();
                break;
        }
    }
}
void Tualet_Operator_Yes()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (oper_byl_li == false && op_quest_zadanie == 0)
    {
        Console.WriteLine("Ты постучал и усслышав за дверцей \"Заходи!\", зашел. В кабинке ты увидел мужика в белой рубашке с гарнитурой, вокруг была куча какого-то древнего оборудования, а еще там был телевизор на котором шло Rozen Maiden. Увидев тебя он заявил \"Подходи, дам задание.\".");
    }
    else if (oper_byl_li == true && op_quest_zadanie == 0)
    {
        Console.WriteLine("Ты зашел в кабинку. В кабинке ты увидел уже знакомого тебе мужика в белой рубашке с гарнитурой, вокруг была куча какого-то древнего оборудования, а еще там был телевизор на котором шло Rozen Maiden. Увидев тебя он заявил \"Опять ты? Подходи, дам задание.\".");
    }
    else if (op_quest_zadanie == 1)
    {
        Console.WriteLine("Ты зашел в кабинку. В кабинке ты увидел уже знакомого тебе мужика в белой рубашке с гарнитурой, вокруг была куча какого-то древнего оборудования, а еще там был телевизор на котором шло Rozen Maiden. Увидев тебя он заявил \"Анон, снова ты? Я же уже дал задание, или у тебя остались вопросы?\".");
    }
    op_quest_zad = 1;
    Operator_Questions();
}
void Tualet_Operator_Yes_Kto()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Я Оператор ПВД, веду Ежчан, отбиваюсь от ППО, а еще у меня есть задание.\".");
    op_quest_prohodimcy = 1;
    op_quest_mud = 1;
    op_quest_zad = 1;
    Operator_Questions();
}
void Tualet_Operator_Yes_Zadanie()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (gold_lopata == false)
    {
        Console.WriteLine("\"Слушай, задание, которое я тебе поручаю, невероятно важно, и если ты сейчас не уловишь всей глубины его значения, то, возможно, никогда не поймёшь, какой масштаб ответственности на тебя возложен. Ёршик, который я передаю тебе, не просто инструмент для чистки параши, а символ, де-факто воплощающий историю поселения Сблевач, и её значение трудно переоценить. Ты должен начать свой путь из ЛГБТ-двери, в которой ты найдешь квинтэссенцию природной красоты. Как же хороша природа в этих краях. Я иногда просто смотрю на нее, любуюсь ее превосходством над всем сущим. Мне иногда кажется, что человек не является природой в качестве ее элемента, а является чем-то отрешенным. Человек следует законам этой природы, но вполне себе подчиняет их себе, становится этаким узурпатором. Дальше тебе нужно будет пройти вдоль широченной реки по ее течению, которая представляет собой ключевой гидрологический элемент нашего региона, но это только первая часть маршрута, потому что дальше тропа начнёт теряться, превращаясь в нечто, что можно было бы назвать диффузной сетью природных образований. Возвращаясь к ёршику, хочу напомнить, что он изготовлена из золота, которое было добыто в шахте одного сосачера, ныне заброшенной, но тогда это была центральная точка экономической и культурной активности, и сам факт использования этого золота добавляет артефакту ещё больший уровень символической значимости. И это, одно из самых величайших творений культуры человечества, ты должен будешь доставить Эскейптян - умственноотсталой синей девочке, которая очень сильно хочет быть как ее импульсивная, но ранимая рыжая сестра. Давно я с ней уже не видался. Сколько, месяц? год? полтора? Уж даже и не помню. Надо бы и самому сходить к ней наведаться, да нет у меня ни пустоты на моей временной ленте ни особого желания. Очень уж она тяжелая и в общении… И в весе, ха! Жируха-пидорнуха, ну ты понял! Она довольно интровертный человек, потому на контакт идет с превеликим трудом. Может быть, поэтому мы перестали с ней контактировать? Бля пизжу, я что ваще ебан, чтобы с такими дегенеративными созданиями брататься? Тем не менее, дам совет: когда войдешь с ней в коммуникацию, скажи, что ты не ежачер, вот прям спросит, а ты ей: не ежачер. Я ее очень плохо помню, но точно помню, что человек она категорически умственно отсталых взглядов. Пусть на земле и есть интеллектуалы, обладатели высокого ума, Эскейптян же ярый приверженец критинизма. Так вот эта Эскейптян, живёт в параше, настолько глубоко интегрированной в биоценоз, что её практически невозможно отличить от окружающей среды, особенно в условиях тумана, который здесь часто застилает всё вокруг и превращает любое передвижение в настоящее испытание. Туман, кстати, тоже интересное явление, он как метафора неопределённости на твоём пути, но это неважно, потому что главное — доставить ёршик. Однако, если ты будешь внимательно следовать северному направлению, ориентируясь, возможно, даже по расположению небесных светил в небе, и в особенности по Полярной звезде, тебе удастся добраться до цели, но помни, что сам путь, хотя и кажется линейным, обладает своей структурной сложностью. Ёршик, кстати, не только важный артефакт, но и символ преемственности, мост между сладким хлебом и керамикой, поэтому потерять его или повредить — это не просто ошибка, а де-факто разрыв всей исторической цепочки, связующей ее с ее предками - абузьянами. Когда ты дойдёшь до того места, где река переходит в более узкий поток, будь особенно внимателен, потому что именно там тропа становится практически незаметной, но ты должен помнить, что главная цель — передать артефакт Эскейптян, человеку с глубокой приверженностью традициям и скудоумию, который, вероятно, даже не станет с тобой взаимодействовать, если ты появишься без этого символа. Хижину ее ты узнаешь по крыше, покрытой густым слоем говна с мочей, но не обманывайся её простотой, потому что она воплощает идеальный баланс между антропогенным воздействием и естественной средой. И снова возвращаясь к пути, не теряй концентрации, даже если тебе покажется, что ты сбился, ведь в конечном счёте всё сводится к твоей способности адаптироваться к обстоятельствам. Это задание — это не просто путешествие, это, можно сказать, священное очищение нашего дома от ёршеблядства, который выходит за пределы личного восприятия и охватывает всю сложность нашего существования. Возьми же этого блядского ёршика и верни его на родину.\" - Истолковал Оператор и вручил ёршик, который ты убрал себе в инвентарь.");
    }
    else if (gold_lopata == true)
    {
        Console.WriteLine("\"Слушай, задание, которое я тебе поручаю, невероятно важно, и если ты сейчас не уловишь всей глубины его значения, то, возможно, никогда не поймёшь, какой масштаб ответственности на тебя возложен. Ёршик, который я передаю тебе, не просто инструмент для чистки параши, а символ, де-факто воплощающий историю поселения Сблевач, и её значение трудно переоценить. Ты должен начать свой путь из ЛГБТ-двери, в которой ты найдешь квинтэссенцию природной красоты. Как же хороша природа в этих краях. Я иногда просто смотрю на нее, любуюсь ее превосходством над всем сущим. Мне иногда кажется, что человек не является природой в качестве ее элемента, а является чем-то отрешенным. Человек следует законам этой природы, но вполне себе подчиняет их себе, становится этаким узурпатором. Дальше тебе нужно будет пройти вдоль широченной реки по ее течению, которая представляет собой ключевой гидрологический элемент нашего региона, но это только первая часть маршрута, потому что дальше тропа начнёт теряться, превращаясь в нечто, что можно было бы назвать диффузной сетью природных образований. Возвращаясь к ёршику, хочу напомнить, что он изготовлена из золота, которое было добыто в шахте одного сосачера, ныне заброшенной, но тогда это была центральная точка экономической и культурной активности, и сам факт использования этого золота добавляет артефакту ещё больший уровень символической значимости. И это, одно из самых величайших творений культуры человечества, ты должен будешь доставить Эскейптян - умственноотсталой синей девочке, которая очень сильно хочет быть как ее импульсивная, но ранимая рыжая сестра. Давно я с ней уже не видался. Сколько, месяц? год? полтора? Уж даже и не помню. Надо бы и самому сходить к ней наведаться, да нет у меня ни пустоты на моей временной ленте ни особого желания. Очень уж она тяжелая и в общении… И в весе, ха! Жируха-пидорнуха, ну ты понял! Она довольно интровертный человек, потому на контакт идет с превеликим трудом. Может быть, поэтому мы перестали с ней контактировать? Бля пизжу, я что ваще ебан, чтобы с такими дегенеративными созданиями брататься? Тем не менее, дам совет: когда войдешь с ней в коммуникацию, скажи, что ты не ежачер, вот прям спросит, а ты ей: не ежачер. Я ее очень плохо помню, но точно помню, что человек она категорически умственно отсталых взглядов. Пусть на земле и есть интеллектуалы, обладатели высокого ума, Эскейптян же ярый приверженец критинизма. Так вот эта Эскейптян, живёт в параше, настолько глубоко интегрированной в биоценоз, что её практически невозможно отличить от окружающей среды, особенно в условиях тумана, который здесь часто застилает всё вокруг и превращает любое передвижение в настоящее испытание. Туман, кстати, тоже интересное явление, он как метафора неопределённости на твоём пути, но это неважно, потому что главное — доставить ёршик. Однако, если ты будешь внимательно следовать северному направлению, ориентируясь, возможно, даже по расположению небесных светил в небе, и в особенности по Полярной звезде, тебе удастся добраться до цели, но помни, что сам путь, хотя и кажется линейным, обладает своей структурной сложностью. Ёршик, кстати, не только важный артефакт, но и символ преемственности, мост между сладким хлебом и керамикой, поэтому потерять его или повредить — это не просто ошибка, а де-факто разрыв всей исторической цепочки, связующей их с ее предками - абузьянами. Когда ты дойдёшь до того места, где река переходит в более узкий поток, будь особенно внимателен, потому что именно там тропа становится практически незаметной, но ты должен помнить, что главная цель — передать артефакт Эскейптян, человеку с глубокой приверженностью традициям и скудоумию, который, вероятно, даже не станет с тобой взаимодействовать, если ты появишься без этого символа. Хижину ее ты узнаешь по крыше, покрытой густым слоем говна с мочей, но не обманывайся её простотой, потому что она воплощает идеальный баланс между антропогенным воздействием и естественной средой. И снова возвращаясь к пути, не теряй концентрации, даже если тебе покажется, что ты сбился, ведь в конечном счёте всё сводится к твоей способности адаптироваться к обстоятельствам. Это задание — это не просто путешествие, это, можно сказать, священное очищение нашего дома от ёршеблядства, который выходит за пределы личного восприятия и охватывает всю сложность нашего существования. Возьми же этого блядского ёршика и верни его на родину.\" - Повторно истолковал Оператор.");
    }
    op_quest_zadanie = 1;
    gold_lopata = true;
    Operator_Questions();
}
void Tualet_Operator_Yes_PPO()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Бывают тут всякие, заговоры строят, порой нападают.\".");
    op_quest_ataka = 1;
    Operator_Questions();
}
void Tualet_Operator_Yes_Ejchan()
{
    Random rnd = new Random();
    int int_rnd = rnd.Next(0,5);

    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    switch (int_rnd)
    {
        case 0:
            Console.WriteLine("\"Ершач - параша пидорух и раков.\".");
            break;
        case 1:
            Console.WriteLine("\"Сломать домен - как нехуй, а сломать анонов еще надо постараться.\".");
            break;
        case 2:
            Console.WriteLine("\"Про ежовое колесо слишал? - Наша заслуга.\".");
            break;
        case 3:
            Console.WriteLine("\"Никому не скрыться от Единого Ежового Фронта\".");
            break;
        case 4:
            Console.WriteLine("\"Любой, кто попробует разрушить наш мирок, утонет в вайпах. Луняне об этом уже в курсе.\".");
            break;
        case 5:
            Console.WriteLine("\"Любой, кто попробует разрушить наш мирок, утонет в вайпах. Луняне об этом уже в курсе.\".");
            break;
    }
    Operator_Questions();
}
void Tualet_Operator_No()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (oper_byl_li == false)
    {
        Console.WriteLine("Ты зашел в кабинку как к себе домой и увидел мужика в белой рубашке с гарнитурой, вокруг была куча какого-то древнего оборудования, а еще там был телевизор на котором шло Rozen Maiden. Увидев тебя он заявил \"Стучаться не учили? Проваливай.\".");
    }
    else
    {
        Console.WriteLine("В кабинке ты увидел уже знакомого тебе мужика в белой рубашке с гарнитурой, вокруг была куча какого-то древнего оборудования, а еще там был телевизор на котором шло Rozen Maiden. Увидев тебя он заявил \"Уходи отсюда, я не буду с тобой разговаривать.\".");
    }
    Operator_Questions();
}
void Tualet_Operator_No_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Ты не уважаешь мое личное пространство, я не буду с тобой общаться.\"");
    op_quest_ataka = 1;
    Operator_Questions();
}
void Operator_Questions()
{
    keyInt = 0;

    string __2 = null;
    string __3 = null;
    string __4 = null;
    string __5 = null;
    string __6 = null;
    string __7 = null;

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Кто ты?");
    if (op_quest_ataka == 1)
    {
        Console.WriteLine("2) Напасть");
        __2 = "напасть";

    }

    if (__2 == null && op_quest_prohodimcy == 1)//(Pr_quest_zad == 1 && Pr_quest_ataka == 0)
    {
        Console.WriteLine("2) ППО?");
        __2 = "проходимцы";
    }
    else if (__3 == null && op_quest_prohodimcy == 1)//if (Pr_quest_zad == 1 && Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) ППО?");
        __3 = "проходимцы";
    }

    if (__2 == null && op_quest_zad == 1)//(Pr_quest_zad == 1 && Pr_quest_ataka == 0)
    {
        Console.WriteLine("2) Задание?");
        __2 = "задание";
    }
    else if ((__3 == null && op_quest_zad == 1))//if (Pr_quest_zad == 1 && Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Задание?");
        __3 = "задание";
    }
    else if ((__4 == null && op_quest_zad == 1))//if (Pr_quest_zad == 1 && Pr_quest_ataka == 1)
    {
        Console.WriteLine("4) Задание?");
        __4 = "задание";
    }


    if (__2 == null && op_quest_mud == 1)//(Pr_quest_mud == 1 && Pr_quest_zad + Pr_quest_ataka == 0)
    {
        Console.WriteLine("2) Ежчан?");
        __2 = "мудрость";
    }
    else if (__3 == null && op_quest_mud == 1)//(Pr_quest_mud == 1 && Pr_quest_zad + Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Ежчан?");
        __3 = "мудрость";
    }
    else if (__4 == null && op_quest_mud == 1)//(Pr_quest_mud == 1 && Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("4) Ежчан?");
        __4 = "мудрость";
    }
    else if (__5 == null && op_quest_mud == 1)//(Pr_quest_mud == 1 && Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("5) Ежчан?");
        __5 = "мудрость";
    }


    if (__2 == null)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 0)
    {
        Console.WriteLine("2) Включить на телевизоре Путина");
        __2 = "путин";
    }
    else if (__3 == null)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Включить на телевизоре Путина");
        __3 = "путин";
    }
    else if (__4 == null)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("4) Включить на телевизоре Путина");
        __4 = "путин";
    }
    else if (__5 == null)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("5) Включить на телевизоре Путина");
        __5 = "путин";
    }
    else //if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("6) Включить на телевизоре Путина");
        __6 = "путин";
    }


    if (__2 == null)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 0)
    {
        Console.WriteLine("2) Уйти");
        __2 = "начать";
    }
    else if (__3 == null)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 1)
    {
        Console.WriteLine("3) Уйти");
        __3 = "начать";
    }
    else if (__4 == null)//(Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 2)
    {
        Console.WriteLine("4) Уйти");
        __4 = "начать";
    }
    else if (__5 == null)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("5) Уйти");
        __5 = "начать";
    }
    else if (__6 == null)//if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("6) Уйти");
        __6 = "начать";
    }
    else if (__7 == null) //if (Pr_quest_mud + Pr_quest_zad + Pr_quest_ataka == 3)
    {
        Console.WriteLine("7) Уйти");
        __7 = "начать";
    }


    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                if (oper_dovolen)
                {
                    Tualet_Operator_Yes_Kto();
                }
                else
                {
                    Tualet_Operator_No_2();
                }
                break;
            case ConsoleKey.D2:
                switch (__2)
                {
                    case "напасть":
                        keyInt++;
                        Console.Clear();
                        fighter = 3;
                        start_fight = false;
                        vrag_hp = 30;
                        Operator_Fight();
                        break;
                    case "задание":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_Zadanie();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "проходимцы":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_PPO();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "мудрость":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_Ejchan();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "путин":
                        keyInt++;
                        END_Operator_Putin();
                        break;
                    case "начать":
                        keyInt++;
                        oper_byl_li = true;
                        tualet_byl_li = true;
                        Kuhnya();
                        break;
                }
                break;
            case ConsoleKey.D3:
                switch(__3)
                {
                    case "задание":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_Zadanie();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "проходимцы":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_PPO();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "мудрость":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_Ejchan();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "путин":
                        keyInt++;
                        END_Operator_Putin();
                        break;
                    case "начать":
                        keyInt++;
                        oper_byl_li = true;
                        tualet_byl_li = true;
                        Kuhnya();
                        break;
                }
                    break;
            case ConsoleKey.D4:
                switch (__4)
                {
                    case "задание":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_Zadanie();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "мудрость":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_Ejchan();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "путин":
                        keyInt++;
                        END_Operator_Putin();
                        break;
                    case "начать":
                        keyInt++;
                        oper_byl_li = true;
                        tualet_byl_li = true;
                        Kuhnya();
                        break;
                }
                break;
            case ConsoleKey.D5:
                switch (__5)
                {
                    case "мудрость":
                        keyInt++;
                        if (oper_dovolen)
                        {
                            Tualet_Operator_Yes_Ejchan();
                        }
                        else
                        {
                            Tualet_Operator_No_2();
                        }
                        break;
                    case "путин":
                        keyInt++;
                        END_Operator_Putin();
                        break;
                    case "начать":
                        keyInt++;
                        oper_byl_li = true;
                        tualet_byl_li = true;
                        Kuhnya();
                        break;
                }
                break;
            case ConsoleKey.D6:
                switch (__6)
                {
                    case "путин":
                        keyInt++;
                        END_Operator_Putin();
                        break;
                    case "начать":
                        keyInt++;
                        oper_byl_li = true;
                        tualet_byl_li = true;
                        Kuhnya();
                        break;
                }
                break;
            case ConsoleKey.D7:
                switch (__7)
                {
                    case "начать":
                        keyInt++;
                        oper_byl_li = true;
                        tualet_byl_li = true;
                        Kuhnya();
                        break;
                }
                break;
        }
    }
}
void END_Operator_Putin()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_156 != "sw83dQW7")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_156 = "sw83dQW7";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_156"].Value = conf_end_156;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 156");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Оператор разозлился, запыхтел, запердел, а после полил тебя отборным матом, в котором ты захлебнулся и утонул.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Operator_Fight()
{
    if (vrag_hp <= 0 && fighter == 3)
    {
        END_Operator_Fight_good();
    }
    else if (u_hp <= 0 && fighter == 3)
    {
        END_Operator_Fight_bad();
    }
    Random rnd = new Random();
    int ataka;
    int uron;
    keyInt = 0;
    Console.ForegroundColor = ConsoleColor.Gray;
    if (sound_value) {zvuk3.Play();}
    Console.Write("Оператор ПВД ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(vrag_hp + "HP");
    Console.WriteLine("");
    if (stop_fight == 0 && start_fight)
    {
        ataka = rnd.Next(1, 5);
        switch (ataka)
        {
            case 1:
                if (rnd.Next(1, 101) < 36)
                {
                    uron = rnd.Next(2, 10);
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Оператор ПВД нанес удар ёршиком и снес тебе " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Оператор ПВД нанес удар ёршиком, но промазал!");
                }
                break;
            case 2:
                if (rnd.Next(1, 101) < 86)
                {
                    uron = rnd.Next(1, 6);
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Оператор ПВД наорал матом и снес тебе " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Оператор ПВД наорал матом, но промазал!");
                }
                break;
            case 3:
                if (vrag_hp < 30)
                {
                    if (rnd.Next(1, 101) < 81)
                    {
                        uron = rnd.Next(3, 5);
                        vrag_hp += uron;
                        if (vrag_hp > 30)
                        {
                            vrag_hp = 30;
                        }
                        Console.ForegroundColor = user_foreground_color_1;
                        Console.WriteLine("Оператор ПВД бахнул форсмана с рулетиками и восстановил здоровье на " + uron + "HP! Теперь у него " + vrag_hp + "HP");
                    }

                    else
                    {
                        uron = rnd.Next(3, 5);
                        vrag_hp -= uron;
                        Console.ForegroundColor = user_foreground_color_1;
                        Console.WriteLine("Оператор ПВД бахнул форсмана с рулетиками и подавился, снизив " + uron + "HP! Теперь у него " + vrag_hp + "HP");
                    }
                }
                else
                {
                    if (rnd.Next(1, 101) > 50)
                    {
                        if (rnd.Next(1, 101) < 36)
                        {
                            uron = rnd.Next(2, 10);
                            u_hp = u_hp - uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            Console.WriteLine("Оператор ПВД нанес удар ёршиком и снес тебе " + uron + " урона!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            Console.WriteLine("Оператор ПВД нанес удар ёршиком, но промазал!");
                        }
                        break;
                    }
                    else
                    {
                        if (rnd.Next(1, 101) < 86)
                        {
                            uron = rnd.Next(1, 6);
                            u_hp = u_hp - uron;
                            Console.ForegroundColor = user_foreground_color_1;
                            Console.WriteLine("Оператор ПВД наорал матом и снес тебе " + uron + " урона!");
                        }
                        else
                        {
                            Console.ForegroundColor = user_foreground_color_1;
                            Console.WriteLine("Оператор ПВД попытался наорать матом, но ему не удалось!");
                        }
                    }
                }
                break;
            case 4:
                if (rnd.Next(1, 101) < 18)
                {
                    uron = rnd.Next(1, 3);
                    u_stop_fight = u_stop_fight + uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Оператор ПВД дал бан и нанес тебе паралич! Ты обездвижен на " + uron + " ход(а)!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Оператор ПВД попытался дать тебе бан, но ему не удалось!");
                }
                break;
        }
    }
    else if (stop_fight > 0 && start_fight)
    {
        stop_fight--;
    }
    else if (stop_fight == 0 && start_fight == false)
    {
        start_fight = true;
    }
    else if (stop_fight > 0 && start_fight == false)
    {
        stop_fight--;
        start_fight = true;
    }

    Attack();


}
void END_Operator_Fight_good()
{
    operator_secret_end++;
    if (operator_secret_end==3 && kolco_vsemogushestva == false)
    {
        END_Operator_Fight_good_alt();
    }
    Console.Clear();
    keyInt = 0;
    if (conf_end_126 != "Ue1Hahr8")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_126 = "Ue1Hahr8";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_126"].Value = conf_end_126;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 126");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты победил Оператора ПВД и из него вылетела душа. Она сказала тебе: \"Это еще не конец! Если хочешь получить дополнительную концовку, то победи меня трижды подряд без кольца!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Operator_Fight_good_alt()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_127 != "f54ppeF6")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_127 = "f54ppeF6";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_127"].Value = conf_end_127;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 127");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты победил Оператора три раза подряд и из него вылетела душа. Она сказала тебе: \"Харкачач - гавно! Абу - гнида! Куклобунт!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Operator_Fight_bad()
{
    operator_secret_end = 0;
    Console.Clear();
    keyInt = 0;
    if (conf_end_128 != "21nJpbTY")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_128 = "21nJpbTY";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_128"].Value = conf_end_128;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 128");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты проиграл в битве с Оператором, увы.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Tualet_Ruki()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты помыл руки и теперь они чистые, что дальше?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Помыть руки еще раз");
    Console.WriteLine("2) Постучаться в кабинку");
    Console.WriteLine("3) Бесцеремонно открыть кабинку");
    Console.WriteLine("4) Уйти");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Tualet_Ruki_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Tualet_Operator_Yes();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Tualet_Operator_No();
                break;
            case ConsoleKey.D4:
                keyInt++;
                tualet_byl_li = true;
                Kuhnya();
                break;
        }
    }
}
void Tualet_Ruki_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты помыл руки еще раз, что на этот раз?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) На этот раз я помою руки");
    Console.WriteLine("2) Постучаться в кабинку");
    Console.WriteLine("3) Бесцеремонно открыть кабинку");
    Console.WriteLine("4) Уйти");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Tualet_Ruki_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Tualet_Operator_Yes();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Tualet_Operator_No();
                break;
            case ConsoleKey.D4:
                keyInt++;
                tualet_byl_li = true;
                Kuhnya();
                break;
        }
    }
}
void Tualet_Ruki_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты в третий раз помыл руки, может мы пойдем дальше по сюжету?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Мыть руки");
    Console.WriteLine("2) Постучаться в кабинку");
    Console.WriteLine("3) Бесцеремонно открыть кабинку");
    Console.WriteLine("4) Уйти");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Tualet_Ruki_4();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Tualet_Operator_Yes();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Tualet_Operator_No();
                break;
            case ConsoleKey.D4:
                keyInt++;
                tualet_byl_li = true;
                Kuhnya();
                break;
        }
    }
}
void Tualet_Ruki_4()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты я так понимаю хочешь получить еще одну тупую концовку?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) МЫТЬ РУКИ");
    Console.WriteLine("2) Постучаться в кабинку");
    Console.WriteLine("3) Бесцеремонно открыть кабинку");
    Console.WriteLine("4) Уйти");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Tualet_Ruki_5();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Tualet_Operator_Yes();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Tualet_Operator_No();
                break;
            case ConsoleKey.D4:
                keyInt++;
                tualet_byl_li = true;
                Kuhnya();
                break;
        }
    }
}
void Tualet_Ruki_5()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ладно, я тебя понял.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) ВОДА ТЕЧЬ, Я МЫТЬ РУКИ, РУКИ ТЕРЕТЬ РУКИ");
    Console.WriteLine("2) Постучаться в кабинку");
    Console.WriteLine("3) Бесцеремонно открыть кабинку");
    Console.WriteLine("4) Уйти");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Tualet_Ruki();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Tualet_Operator_Yes();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Tualet_Operator_No();
                break;
            case ConsoleKey.D4:
                keyInt++;
                tualet_byl_li = true;
                Kuhnya();
                break;
        }
    }
}
void END_Tualet_Ruki()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_129 != "gX4hvGwx")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_129 = "gX4hvGwx";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_129"].Value = conf_end_129;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 129");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты вымыл руки 10 раз, 50 раз, 200 раз. Ты смыл кожу, сухожилия, мышцы и даже кости, а когда мыть стало больше нечего, ты начал мыть ноги, потом тело, а потом и голову. Иначе говоря ты всего себя смыл.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void Apocalipsis_Secret()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Внезапно заорала сирена, послышался рой шипящих колес сопровождаемый криками и звуками столкновений. Все трое, с которыми ты находился рядом, начали вопить и извиваться в неестественных позах. Они превратились в иношопотян! Затем они встали и разом помчались на тебя. Кажется Норильск не такой уж и скучный город. Вдруг, как по сценарию, перед тобой спадает лестница на спасательный вертолет с криком: \"Залезай!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Лезть в вертолет");
    Console.WriteLine("2) Бежать");
    Console.WriteLine("3) Как берсерк драться с иношопотянами");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Apocalipsis_Secret_Vertolet();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Apocalipsis_Secret_Bezhat();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Apocalipsis_Secret_Bad();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet()
{
    vertolet_li = true;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Только ты схватился за лестницу, вертолет взмыл ввысь. Тебе ну никак не удавалось подняться по лестнице и ты болтался как сопля, то и дело ударяясь о стены и крыши домов. Сильно возмущаясь, тебя начали поднимать. И вот ты в вертолете на тебя очень злым взглядом смотит миловидная девушка. Твою тушу только что подняла девушка, не стыдно?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Здравствуйте, девушка");
    Console.WriteLine("2) Bonjour mademoiselle");
    Console.WriteLine("3) Hello miss");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Apocalipsis_Secret_Vertolet_1();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Apocalipsis_Secret_Vertolet_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Apocalipsis_Secret_Vertolet_1();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Тебя что, не учили в школе лазанию по канату?! Ладно, неважно, главное, ты в порядке. Я Опер-тян, агент ФБР, мы прибыли сюда... Думаю ты сам понимаешь зачем. Мы отвезем тебя на базу ЕЕФ, там наши пути разойдутся.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Как скажете");
    Console.WriteLine("2) Но я хочу помочь!");
    Console.WriteLine("3) Ыыыыыыы, я иношопо-тян! ЫыЫыыЫЫы");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                vertolet_end = 0;
                Apocalipsis_Secret_Baza();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Apocalipsis_Secret_Vertolet_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Apocalipsis_Secret_Vertolet_YaZombe();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Помочь? И чем же?\"");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Я могу пострелять из вертолета по иношопотянам");
    Console.WriteLine("2) Я могу привязать себя к канату и приманивать пришельцев");
    Console.WriteLine("3) Я могу поуправлять вертолетом");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Apocalipsis_Secret_Vertolet_3();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Apocalipsis_Secret_Vertolet_3();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Apocalipsis_Secret_Vertolet_3();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet_3()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("\"Что? Нет! Ни в коем случае!\" - Возразила твоему глупому предложению Опер-тян, после чего задумалась. - \"В принципе, если ты так сильно хочешь помочь, то держи рацию и GPS. Будешь раз в минуту передавать передавать координаты.\" - Решила она, вручив тебе необходимые гаджеты. Со словами \"Фортран, набери высоту.\" Опер-тян подошла к пилоту и села рядом, надела гарнитуру и начала оживленно трясти бумажками, что-то очень бурно с ним обсуждая, оставив тебя наедине с оргтехникой. Неужели ты правда будешь этим заниматься? Это же так скучно!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Передавать координаты");
    Console.WriteLine("2) Сесть за миниган");
    Console.WriteLine("3) Сесть за ракетницу");
    Console.WriteLine("4) Кнопка экстренного катапультирования");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Apocalipsis_Secret_Vertolet_Koordinaty();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Apocalipsis_Secret_Vertolet_Minigun();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Apocalipsis_Secret_Vertolet_Raketa();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Apocalipsis_Secret_Vertolet_Katapult();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet_Koordinaty()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ну ты и зануда. Минут 7, ты просто передовал цыферки с экрана GPS, пока с рации не закричали: \"Straight ahead S-13! Turn one hour and fifteen minutes! Now!\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ай донт андэр стэнд ю!");
    Console.WriteLine("2) Бэн? Май нэйм из Данила!");
    Console.WriteLine("3) Че? По-русски давай базарь!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Apocalipsis_Secret_Vertolet_Koordinaty_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Apocalipsis_Secret_Vertolet_Koordinaty_2();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Apocalipsis_Secret_Vertolet_Koordinaty_2();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet_Koordinaty_2()
{
    vertolet_end = 2;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("На этом моменте ты заметил, как вертолет неистово шатает. Инстинктивно ты повернулся в сторону рулевой и увидел как Опер-тян безуспешно пытается привести пилота в чувства. \"Эй! Помоги!\" - Кричит она. - \"Ты должен сесть да штурвал!\" - Запаниковала она, когда ты подбежал.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Прыгнуть за штурвал");
    Console.WriteLine("2) Молиться о спасении");
    Console.WriteLine("3) Кастовать заклинание левитации");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Apocalipsis_Secret_Vertolet_Katapult_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Apocalipsis_Secret_Vertolet_Katapult();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Apocalipsis_Secret_Vertolet_Katapult();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet_Katapult()
{
    vertolet_end = 1;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("По нажатию, кресла Опер-тян и пилота взлетели вместе с ними. Теперь надо что-то срочно решать, иначе вертолет упадет и разобьется вместе с тобой!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Прыгнуть за штурвал");
    Console.WriteLine("2) Молиться о спасении");
    Console.WriteLine("3) Кастовать заклинание левитации");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Apocalipsis_Secret_Vertolet_Katapult_2();
                break;
            case ConsoleKey.D2:
                keyInt++;
                END_Apocalipsis_Secret_Vertolet_Katapult();
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Apocalipsis_Secret_Vertolet_Katapult();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet_Katapult_2()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты резко подскочил и судорожно ухватился за штурвал всеми пальцами и начал рулить, вернее не ты, а твой персонаж, тебе же предстоит одержать победу в QTE, чтобы вертолет успешно приземлился.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Q...");
    Console.WriteLine("2) T...");
    Console.WriteLine("3) EEEEEEEEEEEEEEE!!!!!");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                QTE_Game();
                break;
            case ConsoleKey.D2:
                keyInt++;
                QTE_Game();
                break;
            case ConsoleKey.D3:
                keyInt++;
                QTE_Game();
                break;
        }
    }
}
void Apocalipsis_Secret_Vertolet_QTE()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Победа! Твои старания все-таки привели тебя к успеху в пилотировании! Ура-ура-ура! Ты, трясущимися руками, после до ужаса волнительного полета, кое-как посадил вертолет. Откинувшись на пол (кресло-то катапультировано), ты принялся утирать рукавами струящийся ведрами холодный пот.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Фух...");
    Console.WriteLine("2) Фуууууух...");
    Console.WriteLine("3) Фуууууууууууууууууууууух, бля, пиздееееееец...");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Apocalipsis_Secret_Baza();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Apocalipsis_Secret_Baza();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Apocalipsis_Secret_Baza();
                break;
        }
    }
}
void Apocalipsis_Secret_Bezhat()
{
    vertolet_li = false;
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Бежать оказалось не самым плохим вариантом, по крайней мере ты не умер выбрав его. Пробежав пару кварталов, под гнетом пуль, сквозь полчища иношопо-тян, перевернутых машин и паникующих людей, ты забежал в тупик. Дорога была перекрыта высоченным сетчатым забором, который по всей видимости поставили только что. Назад бежать не вариант, зомби наступают на пятки, остается забежать в помещение сферы услуг, в надежде на спасение. Перед тобой их 3: Вкусно и точка, магазин оружия и какая-то аптека.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Вкусно и точка");
    Console.WriteLine("2) Магазин оружия");
    Console.WriteLine("3) Аптека");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Apocalipsis_Secret_Bezhat_VkusnoiTochka();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Apocalipsis_Secret_Bezhat_1();
                break;
            case ConsoleKey.D3:
                keyInt++;
                Apocalipsis_Secret_Apteka();
                break;
        }
    }
}
void Apocalipsis_Secret_Apteka()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Ты забежал в аптеку. Это оказалась самая обычная аптека, без зомби, без выстрелов и без паники. Ты решил подойти к кассе и как только ты это сделал, на тебя полился шквал воплей: \"ООЧЕРЕДЬ!! КУДА ПРЕШЬ!!!! ОООЧЕРЕДЬ!! НЕ ВИДИШЬ!!?!\". Обернувшись ты увидел очередь человек в 80, непонятно как уместившихся в маленькой аптеке.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Ждать очередь");
    Console.WriteLine("2) Выйти из аптеки");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Apocalipsis_Secret_Apteka();
                break;
            case ConsoleKey.D2:
                keyInt++;
                mine++;
                if (mine>3)
                {
                    END_Apocalipsis_Secret_Apteka_2();
                }
                else
                {
                    Apocalipsis_Secret_Bezhat();
                }
                break;
        }
    }
}
void Apocalipsis_Secret_Bezhat_1()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Внутри творился самый настоящий Doom - Какой-то мужик с головы до ног покрытый броней находясь на кассовой стойке отстреливает прущих на него пришельцев-иношопотян. Парочка инопришеленцев тобой заинтересовалась и стояла в нерешительности, видимо они не могли понять свой ты или все-таки не пришелец.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Прикинуться зомби");
    Console.WriteLine("2) Схватить с полки дробовик");
    Console.WriteLine("3) Схватить с полки AWP");
    Console.WriteLine("4) Схватить с полки гранату");

    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                END_Apocalipsis_Secret_Bezhat_PrikinulsaZombi();
                break;
            case ConsoleKey.D2:
                keyInt++;
                Apocalipsis_Secret_Bezhat_2(0);
                break;
            case ConsoleKey.D3:
                keyInt++;
                END_Apocalipsis_Secret_Bezhat_AWP();
                break;
            case ConsoleKey.D4:
                keyInt++;
                Apocalipsis_Secret_Bezhat_2(1);
                break;
        }
    }
}
void Apocalipsis_Secret_Bezhat_2(int sposob)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (sposob == 0)
    {
        megapulemet_jiv = true;
        Console.WriteLine("В стиле Макс Пейна ты, на пару с солдатом, отстрелял с дробовика всех иношопотян. Когда живыми в магазине остался лишь ты и думгай, он к тебе обратился: \"Идем за мной, здесь опасно!\". Выбора у тебя особо не было, а потому ты пошел за ним.");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Идти за ним");
        Console.WriteLine("2) За ним идти");
        Console.WriteLine("3) Ним идти за");

        while (keyInt <= 0)
        {
            KeyOtvet = Console.ReadKey();
            switch (KeyOtvet.Key)
            {
                case ConsoleKey.Escape:
                    keyInt++;
                    ToMainMenu();
                    break;
                case ConsoleKey.D1:
                    keyInt++;
                    END_Apocalipsis_Secret_Bezhat_Tragedy();
                    break;
                case ConsoleKey.D2:
                    keyInt++;
                    Apocalipsis_Secret_Bezhat_3(0);
                    break;
                case ConsoleKey.D3:
                    keyInt++;
                    END_Apocalipsis_Secret_Bezhat_Best();
                    break;
            }
        }
    }
    else if (sposob == 1)
    {
        megapulemet_jiv = false;
        Console.WriteLine("Я не буду вдаваться в подробности как ты это сделал, факт в том что комната оказалась зачищена, увы, вместе с солдатом...");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Трагично плакать над телом боевого товарища");
        Console.WriteLine("2) Отдать честь и пойти в подсобные помещения магазина");
        Console.WriteLine("3) Облутать труп и пойти навстречу концу света");

        while (keyInt <= 0)
        {
            KeyOtvet = Console.ReadKey();
            switch (KeyOtvet.Key)
            {
                case ConsoleKey.Escape:
                    keyInt++;
                    ToMainMenu();
                    break;
                case ConsoleKey.D1:
                    keyInt++;
                    Apocalipsis_Secret_Bezhat_3(0);
                    break;
                case ConsoleKey.D2:
                    keyInt++;
                    Apocalipsis_Secret_Bezhat_3(0);
                    break;
                case ConsoleKey.D3:
                    keyInt++;
                    Apocalipsis_Secret_Bezhat_3(0);
                    break;
            }
        }
    }
}
void Apocalipsis_Secret_Bezhat_3(int sposob)
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (sposob == 0)
    {
        Console.WriteLine("Вы с думгаем зашли в какую-то подсобку. Ты увидел компанию крутых ребят с крутыми крашенными прическами и крутой броне из говна и палок. \"Мы - Единый Ежовый Фронт.\" - Говорит тебе думгай. - \"А я - Ежовая Альфа. Нам нужны такие храбрые люди как ты, поэтому ты идешь с нами, это не обсуждается.\".");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Ладно...");
        Console.WriteLine("2) А может ты пидор?");
        Console.WriteLine("3) Большие города");
        while (keyInt <= 0)
        {
            KeyOtvet = Console.ReadKey();
            switch (KeyOtvet.Key)
            {
                case ConsoleKey.Escape:
                    keyInt++;
                    ToMainMenu();
                    break;
                case ConsoleKey.D1:
                    keyInt++;
                    Apocalipsis_Secret_Bezhat_4(0);
                    break;
                case ConsoleKey.D2:
                    keyInt++;
                    END_Apocalipsis_Secret_3_Bad();
                    break;
                case ConsoleKey.D3:
                    keyInt++;
                    END_Apocalipsis_Secret_3_BolshieGoroda();
                    break;
            }
        }
    }
    else if (sposob == 1)
    {
        Console.WriteLine("Зайдя в подсобку ты увидел компанию крутых ребят с крутыми крашенными прическами и крутой броне из говна и палок. \"Ты кто такой!?\" - Говорит тебе один из них, направив на тебя пушку. - \"Где Ежовая Альфа!?.\".");
        Console.ForegroundColor = user_foreground_color_2;
        Console.WriteLine("1) Я воин. Ежовая Альфа с честью пал на поле брани");
        Console.WriteLine("2) Я убил вашего дружка! Вы следующие! *безумный джокерский смех*");
        Console.WriteLine("3) Обоссыте, но не бейте!");
        while (keyInt <= 0)
        {
            KeyOtvet = Console.ReadKey();
            switch (KeyOtvet.Key)
            {
                case ConsoleKey.Escape:
                    keyInt++;
                    ToMainMenu();
                    break;
                case ConsoleKey.D1:
                    keyInt++;
                    Apocalipsis_Secret_Bezhat_4(2);
                    break;
                case ConsoleKey.D2:
                    keyInt++;
                    END_Apocalipsis_Secret_3_Bad();
                    break;
                case ConsoleKey.D3:
                    keyInt++;
                    Apocalipsis_Secret_Bezhat_4(1);
                    break;
            }
        }
    }

}
void Apocalipsis_Secret_Bezhat_4(int sposob)
{
    zombi_lvl = 5;
    Random rnd = new Random();
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (sposob == 0)
    {
        Console.WriteLine("\"Выкинь этот дробовик и держи нормальный ствол. А давай двинем отсюда, здесь опасно оставаться.\" - Сказал тебе Ежовый Альфач, и вы двинули. Вы бежали по канализации в известном только для них направлении, как вдруг на вас выпрыгивают инопланетянин. Придется сражаться.");
    }
    else if (sposob == 1)
    {
        Console.WriteLine("\"Ясно. Мы - отряд Единого Ежового Фронта, держи ствол и давай с нами, здесь опасно оставаться.\" - Сказал тебе тот же чувак, и вы двинули. Вы бежали по канализации в известном только для них направлении, как вдруг на вас выпрыгивают инопланетянин. Придется сражаться.");
    }
    else if (sposob == 2)
    {
        Console.WriteLine("\"Что ж, если ты выжил, значит ты сильный, а значит ты обязан пойти с нами. Нам, Единому Ежовому Фронту, нужны такие храбрые люди как ты, поэтому ты идешь, это не обсуждается.\" - Сказал тебе тот же чувак, и вы двинули. Вы бежали по канализации в известном только для них направлении, как вдруг на вас выпрыгивают пришелец. Придется сражаться.");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Сражаться самому");
    Console.WriteLine("2) Довериться бравому отряду ЕЕФ");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Console.Clear();
                fighter = 5;
                start_fight = false;
                vrag_hp = rnd.Next(27, 43);
                Zombi_Fight();
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (rnd.Next(1, 101) > 20)
                {
                    END_Apocalipsis_Secret_Zombi_Fight_Bad();
                }
                else
                {
                    Apocalipsis_Secret_Bezhat_5();
                }
                break;
        }
    }
}
void Apocalipsis_Secret_Bezhat_5()
{
    zombi_lvl = 6;
    Random rnd = new Random();
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    Console.WriteLine("Победа! Отряд и ты побежали дальше и наткнулись на еще одну партию иношопотян. Да будет битва!");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Сражаться самому");
    Console.WriteLine("2) Довериться бравому отряду ЕЕФ");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Console.Clear();
                fighter = 5;
                start_fight = false;
                vrag_hp = rnd.Next(27, 43);
                Zombi_Fight();
                break;
            case ConsoleKey.D2:
                keyInt++;
                if (rnd.Next(1, 101) > 20)
                {
                    END_Apocalipsis_Secret_Zombi_Fight_Bad();
                }
                else
                {
                    Apocalipsis_Secret_Baza();
                }
                break;
        }
    }
}
void Apocalipsis_Secret_Baza()
{
    zombi_lvl = 6;
    Random rnd = new Random();
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    if (sound_value) {zvuk3.Play();}
    if (vertolet_li)
    {
        if (vertolet_end==0)
        {
            Console.WriteLine("Спустя какое-то время вертолет приземлился на базе ЕЕФ. А теперь настало время получить главную концовку в зависимости от прохождения данной ветки. Готов?");
        }
        else
        {
            Console.WriteLine("Как бы то ни было - ты на базе ЕЕФ. А теперь настало время получить главную концовку в зависимости от прохождения данной ветки. Готов?");
        }
    }
    else
    {
        Console.WriteLine("Спустя какое-то количество стычек и некоторое время блужданий по какашкам, вы выбрались на базу Единого Ежового Фронта. А теперь настало время получить главную концовку в зависимости от прохождения данной ветки. Готов?");
    }
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Да, капитан!");
    Console.WriteLine("2) Так точно, капитан!!");
    Console.WriteLine("3) Спанч Боб Свэрэпэнс!!!");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                
                break;
            case ConsoleKey.D2:
                keyInt++;
                
                break;
            case ConsoleKey.D3:
                keyInt++;

                break;
        }
    }
    if (!vertolet_li && megapulemet_jiv && zombi_xp ==2)
    {
        END_Apocalipsis_Good_1();
    }
    else if (!vertolet_li && megapulemet_jiv && zombi_xp <2 && rubli < 100000)
    {
        END_Apocalipsis_Neutral_1();
    }
    else if (!vertolet_li && !megapulemet_jiv && zombi_xp < 2 && rubli < 100000)
    {
        END_Apocalipsis_Bad_1();
    }
    if (!vertolet_li && !megapulemet_jiv && zombi_xp == 2)
    {
        END_Apocalipsis_Good_2();
    }
    else if (!vertolet_li && megapulemet_jiv && zombi_xp < 2 && rubli >= 100000)
    {
        END_Apocalipsis_Neutral_2();
    }
    else if (!vertolet_li && !megapulemet_jiv && zombi_xp < 2 && rubli >= 100000)
    {
        END_Apocalipsis_Bad_2();
    }
    else if (vertolet_li && vertolet_end == 0)
    {
        END_Apocalipsis_Vertolet_0();
    }
    else if (vertolet_li && vertolet_end == 1)
    {
        END_Apocalipsis_Vertolet_1();
    }
    else if (vertolet_li && vertolet_end == 2)
    {
        END_Apocalipsis_Vertolet_2();
    }
}
void Zombi_Fight()
{
    if (vrag_hp <= 0 && fighter == 5)
    {
        if (zombi_lvl == 5)
        {
            Apocalipsis_Secret_Bezhat_5();
        }
        if (zombi_lvl == 6)
        {
            Apocalipsis_Secret_Baza();
        }
    }
    else if (u_hp <= 0 && fighter == 5)
    {
        END_Apocalipsis_Secret_Zombi_Fight_Bad();
    }
    Random rnd = new Random();
    int ataka;
    int uron;
    keyInt = 0;
    Console.ForegroundColor = ConsoleColor.Gray;
    if (sound_value) {zvuk3.Play();}
    Console.Write("Инопришеленец ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(vrag_hp + "HP");
    Console.WriteLine("");
    if (stop_fight == 0 && start_fight)
    {
        ataka = rnd.Next(1, 3);
        switch (ataka)
        {
            case 1:
                if (rnd.Next(1, 101) < 36)
                {
                    uron = rnd.Next(0, 10);
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Инопришеленец укусил тебя и нанес тебе " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Инопришеленец попытался тебя укусить, но промазал!");
                }
                break;
            case 2:
                if (rnd.Next(1, 101) < 86)
                {
                    uron = rnd.Next(2, 4);
                    u_hp = u_hp - uron;
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Инопришеленец ударил тебя когтями и нанес тебе " + uron + " урона!");
                }
                else
                {
                    Console.ForegroundColor = user_foreground_color_1;
                    Console.WriteLine("Инопришеленец попытался тебя ударить когтями, но промазал!");
                }
                break;
        }
    }
    else if (stop_fight > 0 && start_fight)
    {
        stop_fight--;
    }
    else if (stop_fight == 0 && start_fight == false)
    {
        start_fight = true;
    }
    else if (stop_fight > 0 && start_fight == false)
    {
        stop_fight--;
        start_fight = true;
    }

    Attack();


}
void END_Apocalipsis_Vertolet_0()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_130 != "rMxCHF47")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_130 = "rMxCHF47";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_130"].Value = conf_end_130;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 130");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Когда ты вышел из вертолета, как и сказала Опер-тян, ваши пути с ней разошлись. Бойцы ЕЕФ подселили тебя в один из бараков для беженцев и ты там жил на попечении. Тяжело там тебе пришлось, вечная борьба за еду, за одежду, за койку. Так продолжалось до тех пор пока ты не заболел какой-то инфекцией, в столь тяжелое время врачей трудно найти, и потому ты скропостижно скончался.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Vertolet_1()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_131 != "pOsVTw2z")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_131 = "pOsVTw2z";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_131"].Value = conf_end_131;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 131");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Когда ты вышел из вертолета, тебя тут же скрутили заряженные бойцы в тяжелой аммуниции и куда-то поволокли. А поволокли они тебя к кирпичной стене, где тут же расстреляли. А на что ты расчитывал угоняя целый вертолет ФБР?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Vertolet_2()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_132 != "Ju1A0lgP")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_132 = "Ju1A0lgP";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_132"].Value = conf_end_132;
        config.Save(ConfigurationSaveMode.Modified);
        
        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 132");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Когда ты вышел из вертолета, к тебе тут же подошли другие агенты ФБР и начали восхищаться твоим подвигом. Опер-тян же сразу пригласила тебя к ним на работу. Ты согласился, ведь это наверное лучшая перспектива из всех которые тебе светят. Ты прошел обучение, стажировку, получил звание, прилежно работал и в итоге ты в шикарных аппартаментах, в одном из крупнейших оазисов зомби-апокалипсиса, рядом с тобой на кровати лежит Опер-тян, а в руке у тебя, редкая в нынешних реалях, баночка пива.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Good_1()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_133 != "S7S4ZkkS")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_133 = "S7S4ZkkS";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_133"].Value = conf_end_133;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 133");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("На базе оказалось, что Ежовая Альфа - 15-тилетний пиздюк, однако он самый среди главных командиров ЕЕФ. И поскольку ты хорошо себя показал в бою, то он сделал тебя своим помощником, а также присвоил титул Ежовая Сигма. Вы вместе боролись с пришельцами, и в какой-то момент вам даже удалось уничтожить их всех и даже разрушить Луну, с которой они телепортировались в тела землян, увы, ценой всего ЕЕФ... Но это все в будущем, а пока ты просто крутой чел в глазах Ежовой Альфы.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Good_2()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_134 != "MAKlyFa2")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_134 = "MAKlyFa2";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_134"].Value = conf_end_134;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 134");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("По прибытию на базу, бойцы ЕЕФ начали всячески благодарить тебя за помощь и восхищаться твоими способностями. Ты учавствовал в вылазках и показывал великолепные результаты, вскоре выяснилось, что оказывается, один из главных командиов Единого Ежового Фронта погиб в самом начале апокалипсиса, а его место пустует. На Верховном Совете ЕЕФ, было принято единогласное решение: поставить тебя на его место. Поздравляю с повышением! Ты этого заслужил.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Neutral_1()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_135 != "SgLn2ERg")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_135 = "SgLn2ERg";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_135"].Value = conf_end_135;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 135");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("На базе оказалось, что Ежовая Альфа - 15-тилетний пиздюк, однако он самый среди главных командиров ЕЕФ. Увидев твои заурядные способности в бою, он назначил тебя уборщиком. Ты мог отказаться, но кругом вторжение инопланетян, в такой ситуации на более престижную профессию расчитывать не приходится.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Neutral_2()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_136 != "oO2Inqux")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_136 = "oO2Inqux";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_136"].Value = conf_end_136;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 136");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("На базе оказалось, что Ежовая Альфа - 15-тилетний пиздюк, однако он самый среди главных командиров ЕЕФ. Увидев твои заурядные способности, он назначил тебя уборщиком. Но у тебя были деньги, много денег. Ты открыл свой небольшой оружейный бизнес и даже кое-как умудрялся жить. К сожалению, твоя конторка не стала корпорацией, как и ты сам не стал мультимиллионером.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Bad_1()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_137 != "yuc9Q6MC")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_137 = "yuc9Q6MC";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_137"].Value = conf_end_137;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 137");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("По прибытию на базу, бойцы ЕЕФ сразу же офутболили тебя куда подальше от себя. Ты остался один, без навыков, без денег, зато ты на базе Единого Ежового Фронта и тут нет пришельцев. Короче говоря ты стал бомжевать да рачевать на их базе.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Bad_2()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_138 != "rBTZGJ8m")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_138 = "rBTZGJ8m";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_138"].Value = conf_end_138;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 138");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("По прибытию на базу, бойцы ЕЕФ сразу же офутболили тебя куда подальше от себя. Ты остался один, без навыков, зато с деньгами! Правда вскоре и их не стало, первой же ночью, в одной из подворотней на тебя напали какие-то крысы, прятавшиеся в ЕЕФ. Они выглядели как люди с умственной отсталостью и были с ног до головы в блевотне и моче, в прочем, это уже не важно. Они отобрали у тебя дипломат и нанесли с десяток ножевых. Ты истекаешь кровью, а перед твоими глазами красивое звездное небо, перед смертью у тебя есть немного времени подумать, как ты к этому пришел.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Zombi_Fight_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_139 != "JN7nv4hD")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_139 = "JN7nv4hD";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_139"].Value = conf_end_139;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 139");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Итогом кровопролитной канализационной битвы стало поражение. Сначала повергли тебя, а затем и всех остальных. Ваша смерть стала символом борьбы с пришельцами, а на месте вашего сражения в более спокойное время установили памятник каждому из вас.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Vertolet_YaZombe()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_140 != "K9fdzjnY")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_140 = "K9fdzjnY";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_140"].Value = conf_end_140;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 140");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("После такого тебя смачным пинком выбросили из вертолета. Ты упал и разбился.");
    
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Vertolet_Minigun()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_141 != "bq2vPLZ1")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_141 = "bq2vPLZ1";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_141"].Value = conf_end_141;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 141");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Пыщ-пыщ-пыщ-пыщ-пыщ-пыщ-пыщ-пыщ-пыщ-пыщ!! Ты стрелял без разбору по всему и вся. Последствия были вполне ожидаемы: Опер-тян выбросила тебя с вертолета.");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Vertolet_Raketa()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_142 != "jZwmc3qz")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_142 = "jZwmc3qz";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_142"].Value = conf_end_142;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 142");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Что-то пошло не так. Что-то ОПРЕДЕЛЕННО пошло не так. Вертолет буквально разорвало на куски.");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Vertolet_Katapult()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_143 != "xR5M1qxG")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_143 = "xR5M1qxG";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_143"].Value = conf_end_143;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 143");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Проявив нерешительность в критической ситуации, а также неготовность к ней, ты и сам погиб, и загубил часть, и без того немногочисленных, выживших взрывом упавшего вертолета.");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Apteka()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_144 != "yRJcFyV3")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_144 = "yRJcFyV3";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_144"].Value = conf_end_144;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 144");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты сел на свободное место скамейки и принялся ждать. Очередь практически не продвигалась. Ты хотел уйти, но ты принял решение сидеть до последнего.");
    Console.WriteLine("Ты просидел в очереди вот уже 7 лет. Иногда ты встречал смельчаков, решивших бросить вызов и встать в очередь. Это было забавно, ведь ты понимал, что эти люди никогда не дождуться. Казалось что весь мир шел мимо этой аптеки, война с инопланетянами уже давно кончилась, несколько раз происходил зомби апокалипсис, Третья мировая, а аптека как стояла так и стоит, как и очередь в ней.");
    Console.WriteLine("И вот тебе 72 года. Ты уже старый и немощный пенсионер. Очередь до тебя по прежнему слишком большая, чтобы можно было расчитывать на то, что ты когда-нибудь доберешься до кассы. Уходить было уже слишком поздно, ты потратил на ожидание очереди слошком много времени, ты потратил на это всю свою жизнь... В конечном итоге ты умер от старости, так и не увидев кассы и аптекорши. Твое тело там так и оставлили, а твое место в очереди, быстро занял очередной глупец.");

    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Apteka_2()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_145 != "Te92BhMn")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_145 = "Te92BhMn";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_145"].Value = conf_end_145;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 145");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Пока ты метался в нерешительности, Иношопотяне подобрались чересчур близко и пожрали тебя сразу же после того, как ты в очередной раз вышел из аптеки.");
    
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_146 != "isHx8ZFc")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_146 = "isHx8ZFc";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_146"].Value = conf_end_146;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 146");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ну, как берсерк у тебя конечно не вышло, но... Да и в целом у тебя мало что вышло. Ты попытался нанести удар, но промазал и по инерции полетел на землю, после чего тебя сожрали.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_3_Bad()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_147 != "Rj2aeIp0")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_147 = "Rj2aeIp0";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_147"].Value = conf_end_147;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 147");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Тебя пристрелили. Больше сказать тут нечего");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_3_BolshieGoroda()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_148 != "lEF9anP6")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_148 = "lEF9anP6";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_148"].Value = conf_end_148;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 148");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Как в фильме брат, ты положил всех с дробовика. В голове в этот момент у тебя играла та самая песня. Это конечно было эпично, однако ты запорол ветку прохождения и теперь \"живите дальше в проклятом мире, который сами и создали.\".");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Bezhat_VkusnoiTochka()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_149 != "pq8PWthv")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_149 = "pq8PWthv";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_149"].Value = conf_end_149;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 149");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Нужно ли мне говорить, что идея была не лучшей? \"Голодные посетители\" просто-напросто тебя сожрали, как только ты открыл дверь.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Bezhat_PrikinulsaZombi()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_150 != "G2SmVcLX")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_150 = "G2SmVcLX";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_150"].Value = conf_end_150;
        config.Save(ConfigurationSaveMode.Modified);
        
        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 150");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Тебе удалось убедить пришельцев, что ты один из них, однако ты забыл убедить солдата, что ты человек.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Bezhat_AWP()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_151 != "vCAvE5nU")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_151 = "vCAvE5nU";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_151"].Value = conf_end_151;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 151");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Пока ты пытался прицелиться из винтовки тебя слопали. Вот так просто. Ты что, в кс переиграл?");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Bezhat_Tragedy()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_152 != "FC72k78z")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_152 = "FC72k78z";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_152"].Value = conf_end_152;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 152");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты бы мог получить оскар, если бы это был фильм. Однако это был не фильм, а еще тебя сожрали набежавшие второй волной инопишеленцы пока ты плакал.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void END_Apocalipsis_Secret_Bezhat_Best()
{
    Console.Clear();
    keyInt = 0;
    if (conf_end_153 != "9GMb6l2r")
    {
        Console.ForegroundColor = ending_text;
        Console.WriteLine("Новая концовка!");
        conf_end_153 = "9GMb6l2r";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["end_153"].Value = conf_end_153;
        config.Save(ConfigurationSaveMode.Modified);

        ConfigurationManager.RefreshSection("appSettings");
        if (sound_value) { zvuk4.Play(); }
    }
    else
    {
        if (sound_value) { zvuk3.Play(); }
    }
    Console.ForegroundColor = black_text;
    Console.WriteLine("Концовка: 153");
    Console.ForegroundColor = user_foreground_color_1;
    Console.WriteLine("Ты снял с думгая броню, набрал патронов, оружия и пошел навстречу приключениям. Ты круто провел остаток жизни. Ты был всадником апокалипсиса, прям как в Fallout или Безумном Максе. Можешь считать это лучшей концовкой этой ветки.");
    Console.ForegroundColor = user_foreground_color_2;
    Console.WriteLine("1) Заново");
    while (keyInt <= 0)
    {
        KeyOtvet = Console.ReadKey();
        switch (KeyOtvet.Key)
        {
            case ConsoleKey.Escape:
                keyInt++;
                ToMainMenu();
                break;
            case ConsoleKey.D1:
                keyInt++;
                Nachalo();
                break;
        }
    }
}
void QTE_Game()
{
    Console.Clear();
    keyInt = 0;
    Console.ForegroundColor = user_foreground_color_1;
    Random qte_random = new Random();
    ConsoleKey[] qte_keys = { ConsoleKey.A, ConsoleKey.B, ConsoleKey.C, ConsoleKey.D, ConsoleKey.E, ConsoleKey.F, ConsoleKey.G,
                              ConsoleKey.H, ConsoleKey.I, ConsoleKey.J, ConsoleKey.K, ConsoleKey.L, ConsoleKey.M, ConsoleKey.N,
                              ConsoleKey.O, ConsoleKey.P, ConsoleKey.Q, ConsoleKey.R, ConsoleKey.S, ConsoleKey.T, ConsoleKey.U,
                              ConsoleKey.V, ConsoleKey.W, ConsoleKey.X, ConsoleKey.Y, ConsoleKey.Z };
    bool isPlaying = true;
    while (isPlaying)
    {
        Console.Clear();
        if (sound_value) {zvuk3.Play();}
        ConsoleKey keyToPress = qte_keys[qte_random.Next(qte_keys.Length)];
        Console.WriteLine($"\nБыстрее жми: {keyToPress}!");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        bool success = false;
        while (stopwatch.ElapsedMilliseconds <= 1000) // Ограничение времени в 2 секунды
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);

                // Сравнение введённой клавиши с требуемой
                if (keyPressed.Key == keyToPress)
                {
                    success = true;
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        stopwatch.Stop();

        if (success)
        {
            qte_score++;
            if (qte_score>=30)
            {
                Apocalipsis_Secret_Vertolet_QTE();
            }
        }
        else
        {            
            isPlaying = false;
            END_Apocalipsis_Secret_Vertolet_Katapult();
        }
    }
}

[STAThread]
void Gonki()
{
    // завершение треда формы
    if (formThread != null && formThread.IsAlive)
    {
        formThread.Join();
    }

    // обнуление переменных
    Gonk.g_pause = false;
    Gonk.positions_players[0] = 0;
    Gonk.positions_players[1] = 0;
    Gonk.lanes[0] = 0;
    Gonk.lanes[1] = 2;
    Gonk.obstaclePositions[0] = trackLength / 3;
    Gonk.obstaclePositions[1] = trackLength / 2;
    player2SpeedCounter = 0;
    Gonk.isGameRunning = true;
    Console.CursorVisible = false;

    //запуск потока управления гонок в форме
    formThread = new Thread(Gonki_Upravlenie_Forms);
    formThread.SetApartmentState(ApartmentState.STA);
    formThread.Start();

    //сами гонки
    Gonki_GameLoop();
}
void Gonki_Upravlenie_Forms()
{
    Application.Run(new KeyListenerForm());
}
void Gonki_GameLoop()
{
    Random rnd_car = new Random();

    ConsoleColor[] availableColors = {
            ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Red,
            ConsoleColor.Cyan, ConsoleColor.DarkGray,
            ConsoleColor.DarkGreen, ConsoleColor.DarkRed, ConsoleColor.Gray,
            ConsoleColor.DarkYellow, ConsoleColor.DarkCyan };

    enemyColor1 = availableColors[rnd_color.Next(availableColors.Length)];
    enemyColor2 = availableColors[rnd_color.Next(availableColors.Length)];


    Console.Clear();
    Console.SetCursorPosition(0, 0);
    Console.WriteLine(new string(' ', trackLength) + "|");
    Console.SetCursorPosition(0, 1);
    Console.WriteLine(new string(' ', trackLength) + "|");
    Console.SetCursorPosition(0, 2);
    Console.WriteLine(new string(' ', trackLength) + "|");

    while (Gonk.isGameRunning)
    {
        // обновление разметки
        roadMarkings = roadMarkings.Substring(1) + roadMarkings[0];

        for (int i = 0; i < trackLength; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write(" ");
            Console.SetCursorPosition(i, 1);
            Console.Write(roadMarkings[i % roadMarkings.Length]); // разметка
            Console.SetCursorPosition(i, 2);
            Console.Write(" ");
        }

        
        player2SpeedCounter++;
        if (player2SpeedCounter >= 2) //двигается только каждую 4-ю итерацию
        {
            Gonk.positions_players[1]++;
            player2SpeedCounter = 0;
        }


        // авто-уворот нпс с вероятностью 75% при угрозе столкновения
        if ((Gonk.positions_players[1] + 1 == Gonk.obstaclePositions[0] && Gonk.lanes[1] == Gonk.enemyLanes[0]) ||
            (Gonk.positions_players[1] + 1 == Gonk.obstaclePositions[1] && Gonk.lanes[1] == Gonk.enemyLanes[1]))
        {
            if (rnd_color.Next(1, 101) <= 80) // срабатывает в 75% случаев
            {
                Gonk.lanes[1] = (Gonk.lanes[1] == 0) ? 2 : 0; // переключение полосы
            }
        }


        Gonk.obstaclePositions[0]--;
        Gonk.obstaclePositions[1]--;
        if (Gonk.obstaclePositions[0] < 0)
        {
            Gonk.obstaclePositions[0] = trackLength;
            enemyColor1 = availableColors[rnd_color.Next(availableColors.Length)];
        }

        if (Gonk.obstaclePositions[1] < 0)
        {
            Gonk.obstaclePositions[1] = trackLength;
            enemyColor2 = availableColors[rnd_color.Next(availableColors.Length)];
        }

        Console.ForegroundColor = enemyColor1;
        //проверка выхода индексов за границы
        if (Gonk.obstaclePositions[0] >= 0 && Gonk.obstaclePositions[0] < trackLength)
        {
            Console.SetCursorPosition(Gonk.obstaclePositions[0], Gonk.enemyLanes[0]);
            Console.Write("<");
        }
        Console.ForegroundColor = enemyColor2;
        if (Gonk.obstaclePositions[1] >= 0 && Gonk.obstaclePositions[1] < trackLength)
        {
            Console.SetCursorPosition(Gonk.obstaclePositions[1], Gonk.enemyLanes[1]);
            Console.Write("<");
        }
        Console.ForegroundColor = black_text;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(Gonk.positions_players[0], Gonk.lanes[0]);
        Console.Write(">");
        Console.ForegroundColor = black_text;

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetCursorPosition(Gonk.positions_players[1], Gonk.lanes[1]);
        Console.Write(">");
        Console.ForegroundColor = black_text;

        if ((Gonk.positions_players[0] == Gonk.obstaclePositions[0] && Gonk.lanes[0] == Gonk.enemyLanes[0]) ||
            (Gonk.positions_players[0] == Gonk.obstaclePositions[1] && Gonk.lanes[0] == Gonk.enemyLanes[1]) ||
            (Gonk.positions_players[0] == Gonk.positions_players[1] && Gonk.lanes[0] == Gonk.lanes[1]))
        {
            Console.SetCursorPosition(Gonk.positions_players[0], Gonk.lanes[0]);
            Console.Write("X");

            Gonk.isGameRunning = false;
            Thread.Sleep(2000);
            CloseGameForm(1);
            Gonk.positions_players[0] = Math.Max(0, Gonk.positions_players[0] - 2);
        }

        if ((Gonk.positions_players[1] == Gonk.obstaclePositions[0] && Gonk.lanes[1] == Gonk.enemyLanes[0]) ||
            (Gonk.positions_players[1] == Gonk.obstaclePositions[1] && Gonk.lanes[1] == Gonk.enemyLanes[1]))
        {
            Console.SetCursorPosition(Gonk.positions_players[1], Gonk.lanes[1]);
            Console.Write("X");

            Gonk.isGameRunning = false;
            Thread.Sleep(2000);
            CloseGameForm(2);
            Gonk.positions_players[1] = Math.Max(0, Gonk.positions_players[1] - 2);
        }


        if (Gonk.positions_players[0] >= trackLength)
        {
            Console.SetCursorPosition(0, 3);

            Gonk.isGameRunning = false;
            Thread.Sleep(2000);
            CloseGameForm(3);
        }
        else if (Gonk.positions_players[1] >= trackLength)
        {
            Console.SetCursorPosition(0, 3);

            Gonk.isGameRunning = false;
            Thread.Sleep(2000);
            CloseGameForm(4);
        }
        if (Gonk.g_pause == true)
        {
            Gonk.isGameRunning = false;
            CloseGameForm(0);
        }
        Thread.Sleep(100);
    }
}
void CloseGameForm(int g_end)
{
    if (g_end == 0)
    {
        Form activeForm = Form.ActiveForm;
        if (activeForm != null)
        {
            activeForm.Invoke((System.Windows.Forms.MethodInvoker)(() => activeForm.Close()));
        }

        //завершение треда формы
        if (formThread != null && formThread.IsAlive)
        {
            formThread.Join();
        }
        ProcessActivator.ActivateMainProcess();

        Console.CursorVisible = true;
        ToMainMenu();
    }
    else
    {
        Form activeForm = Form.ActiveForm;
        if (activeForm != null)
        {
            activeForm.Invoke((System.Windows.Forms.MethodInvoker)(() => activeForm.Close()));
        }

        //завершение треда формы
        if (formThread != null && formThread.IsAlive)
        {
            formThread.Join();
        }
        ProcessActivator.ActivateMainProcess();

        Console.CursorVisible = true;
        switch (g_end)
        {
            case 1:
                Gazers_Ferrari_Avaria(); // гг в аварии
                break;
            case 2:
                END_Ferrari_Avaria_Alt(); // враг в аварии
                break;
            case 3:
                END_Gazers_Ferrari_Pobeda(); // гг победил
                break;
            case 4:
                Gazers_Ferrari_Porajenie(); // враг победил
                break;
        }
    }
       

}
public static class ConsoleHelper
{
    private const int FixedWidthTrueType = 54;
    private const int StandardOutputHandle = -11;

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr GetStdHandle(int nStdHandle);

    [return: MarshalAs(UnmanagedType.Bool)]
    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    internal static extern bool SetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool MaximumWindow, ref FontInfo ConsoleCurrentFontEx);

    [return: MarshalAs(UnmanagedType.Bool)]
    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    internal static extern bool GetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool MaximumWindow, ref FontInfo ConsoleCurrentFontEx);


    private static readonly IntPtr ConsoleOutputHandle = GetStdHandle(StandardOutputHandle);

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct FontInfo
    {
        internal int cbSize;
        internal int FontIndex;
        internal short FontWidth;
        public short FontSize;
        public int FontFamily;
        public int FontWeight;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        //[MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.wc, SizeConst = 32)]
        public string FontName;
    }

    public static FontInfo[] SetCurrentFont(string font, short fontSize = 0)
    {
        //Console.WriteLine("Set Current Font: " + font);

        FontInfo before = new FontInfo
        {
            cbSize = Marshal.SizeOf<FontInfo>()
        };

        if (GetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref before))
        {

            FontInfo set = new FontInfo
            {
                cbSize = Marshal.SizeOf<FontInfo>(),
                FontIndex = 0,
                FontFamily = FixedWidthTrueType,
                FontName = font,
                FontWeight = 400,
                FontSize = fontSize > 0 ? fontSize : before.FontSize
            };

            // Get some settings from current font.
            if (!SetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref set))
            {
                var ex = Marshal.GetLastWin32Error();
                Console.WriteLine("Set error " + ex);
                throw new System.ComponentModel.Win32Exception(ex);
            }

            FontInfo after = new FontInfo
            {
                cbSize = Marshal.SizeOf<FontInfo>()
            };
            GetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref after);

            return new[] { before, set, after };
        }
        else
        {
            var er = Marshal.GetLastWin32Error();
            Console.WriteLine("Get error " + er);
            throw new System.ComponentModel.Win32Exception(er);
        }
    }
}
public class KeyListenerForm : Form
{
    public static volatile bool keyStay = false;
    public static volatile bool keyPressed = false;
    public static volatile bool iskeyReleased = true;
    public static volatile ConsoleKey lastKey = ConsoleKey.NoName;
    static string conf_music = ConfigurationManager.AppSettings["music"];
    static bool music_value;

    System.Windows.Forms.Timer activationTimer = new System.Windows.Forms.Timer();

    public KeyListenerForm()
    {
        this.KeyDown += new KeyEventHandler(OnKeyDown);
        this.KeyUp += new KeyEventHandler(OnKeyUp);

        this.FormClosing += new FormClosingEventHandler(OnFormClosing); //обработчик закрытия формы

        this.WindowState = FormWindowState.Minimized;
        this.ShowInTaskbar = false;
        this.FormBorderStyle = FormBorderStyle.None;
        this.TopMost = true; //окно формы поверх всех окон
        this.Opacity = 0; //скрытие окна формы

        // таймер для постоянной активации формы
        activationTimer = new System.Windows.Forms.Timer();
        activationTimer.Interval = 50; //каждые 50 мс активируем форму
        activationTimer.Tick += (s, e) => this.Activate();
        activationTimer.Start();


    }
    
    public void OnKeyDown(object sender, KeyEventArgs e)
    {

        Gonk.canMovePlayer1 = !((Gonk.positions_players[0] + 1 == Gonk.obstaclePositions[0] && Gonk.lanes[0] == Gonk.enemyLanes[0]) ||
                                    (Gonk.positions_players[0] + 1 == Gonk.obstaclePositions[1] && Gonk.lanes[0] == Gonk.enemyLanes[1]));

        lastKey = (ConsoleKey)e.KeyCode;
        if (!keyStay)
        {
            keyStay = true;
            if (lastKey == ConsoleKey.RightArrow)
            {
                if (Gonk.canMovePlayer1) // блокировка движения вперед при препятствии
                {
                    Gonk.positions_players[0]++;
                }

            }
            else if (lastKey == ConsoleKey.UpArrow && Gonk.lanes[0] > 0) //вверх
            {
                Gonk.lanes[0] -= 2; //смена полосы
            }
            else if (lastKey == ConsoleKey.DownArrow && Gonk.lanes[0] < 2) //вниз
            {
                Gonk.lanes[0] += 2; //смена полосы
            }
        }
        if (lastKey == ConsoleKey.Escape)
        {
            Gonk.g_pause = true;
        }
        //Program.keyPressed = true;
    }

    public void OnKeyUp(object sender, KeyEventArgs e)
    {

        Gonk.canMovePlayer1 = !((Gonk.positions_players[0] + 1 == Gonk.obstaclePositions[0] && Gonk.lanes[0] == Gonk.enemyLanes[0]) ||
                                    (Gonk.positions_players[0] + 1 == Gonk.obstaclePositions[1] && Gonk.lanes[0] == Gonk.enemyLanes[1]));

        //Program.iskeyReleased = true;
        //Program.keyPressed = false;
        keyStay = false;
    }

    private void OnFormClosing(object sender, FormClosingEventArgs e)
    {
        if (Gonk.isGameRunning)
        {
            Gonk.isGameRunning = false;
            Console.SetCursorPosition(0, 4);
            if (conf_music == "0")
            {
                music_value = false;
            }
            else if (conf_music == "1")
            {
                music_value = true;
            }

            if (music_value)
            {
                foreach (Process proc in Process.GetProcessesByName("music_zapizdoha.bin"))
                {
                    proc.Kill();
                }
            }
            foreach (Process proc in Process.GetProcessesByName("zapizdoha"))
            {
                proc.Kill();
            }
            SendKeys.SendWait("%{F4}");
        }
    }

}
public static class Gonk
{
    public static bool g_pause = false;
    public static bool isGameRunning = true;
    public static int[] enemyLanes = { 0, 2 };
    public static int[] obstaclePositions = { 0, 0 };
    public static bool canMovePlayer1;
    public static int[] positions_players = { 0, 0 };
    public static int[] lanes = { 0, 2 };
}
public class ProcessActivator
{
    [DllImport("user32.dll")]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    public static void ActivateMainProcess()
    {
        string processName = "music_zapizdoha.bin"; // Укажите имя процесса здесь

        IntPtr hWnd = Process.GetProcessesByName(processName)[0].MainWindowHandle;
        SetForegroundWindow(hWnd);
    }
}
