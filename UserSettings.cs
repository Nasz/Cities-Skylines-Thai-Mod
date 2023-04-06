using ColossalFramework;
using ColossalFramework.UI;
using ICities;
using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

namespace Mod_Lang_TH.GUI
{
    public class ModOptions
    {
        public static string URLDiscord { get; } = "https://discord.gg/QB8SFPN5";
        public static string URLGithub { get; } = "https://github.com/Nasz/Cities-Skylines-Mod_Lang_TH";

        public ModOptions(UIHelperBase helper, string name)
        {
            try
            {
                UIHelperBase group = helper.AddGroup(name);
                UIPanel panel = ((UIHelper)group).self as UIPanel;

                UILabel header = panel.AddUIComponent<UILabel>();
                header.name = "header";
                header.textScale = 2f;
                header.text = "ม็อดแปลภาษาไทยเวอร์ชั่นคอมมูนิตี้";

                group.AddSpace(10);

                UILabel credit = panel.AddUIComponent<UILabel>();
                credit.name = "credit";
                credit.textScale = 1.2f;
                credit.text = "ร่วมมอบประสบการณ์โดย\r\n- Bammcool\r\n- N7C\r\n- NogginTime\r\n- Palm'sTime\r\n- Simscolony\r\n- Sornzilla";
                
                group.AddSpace(20);

                UILabel update_h = panel.AddUIComponent<UILabel>();
                update_h.name = "update_label";
                update_h.textScale = 1.4f;
                update_h.text = "อัปเดทล่าสุด 6 เมษายน 2566 ";

                UILabel updated = panel.AddUIComponent<UILabel>();
                updated.name = "update_text";
                updated.textScale = 1.2f;
                updated.text = "รายละเอียดของม็อด\r\n- แปลไทยครบทุกส่วน\r\n- ปรับแก้ไขคำให้ทันสมัย\r\n- เจี๊ยบเปอร์พูดไทยชัดขึ้น\r\n- อัปเดตภาษาไทยให้กับ Hub & Transport\r\n- อัปเดตภาษาไทยให้กับ Financial district\r\n- อัปเดตภาษาไทยให้กับ Plazas & promenades\r\n- อัปเดตภาษาไทยให้กับ DLC Airport\r\n- อื่น ๆ";
                
                group.AddSpace(20);

                UIButton button = (UIButton)group.AddButton("ชุมชนของเราบน Discord ", () => OpenUrl(URLDiscord));
                button.autoSize = false;
                button.textHorizontalAlignment = UIHorizontalAlignment.Center;
                button.size = new Vector2(250, 40);
                button.tooltip = "Discord";

                button = (UIButton)group.AddButton("Source code on Github ", () => OpenUrl(URLGithub));
                button.autoSize = false;
                button.textHorizontalAlignment = UIHorizontalAlignment.Center;
                button.size = new Vector2(250, 40);
                button.tooltip = "Github";
            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log("OnSettingsUI failed");
                UnityEngine.Debug.LogException(e);
            }
        }

        public static void OpenUrl(string url)
        {
            Process.Start(url);
        }
    }
}