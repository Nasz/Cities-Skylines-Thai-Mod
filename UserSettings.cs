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
        public static string URLDiscord { get; } = "https://discord.gg/HSYPKfdJfr";
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
                header.text = "ม็อดภาษาไทย 2 เวอร์ชั่นคอมมูนิตี้";

                group.AddSpace(10);

                UILabel credit = panel.AddUIComponent<UILabel>();
                credit.name = "credit";
                credit.textScale = 1.2f;
                credit.text = "แปลโดย\r\n- Bammcool\r\n- N7C\r\n- NogginTime\r\n- PanlopPalms\r\n- Simscolony\r\n- Sornzilla";
                
                group.AddSpace(20);

                UILabel update_h = panel.AddUIComponent<UILabel>();
                update_h.name = "update_label";
                update_h.textScale = 1.4f;
                update_h.text = "อัปเดตล่าสุด 26 พฤษภาคม 2566 19:22 น.";

                UILabel updated = panel.AddUIComponent<UILabel>();
                updated.name = "update_text";
                updated.textScale = 1.2f;
                updated.text = "รายละเอียด\r\n- แปลไทยครบทุกเนื้อหาดาวน์โหลด สมบูรณ์ถึงเกมเวอร์ชัน 1.17.0-f3\r\n- แก้ปัญหาโหลดเกมค้างที่หน้าโหลดแผนที่\r\n- แก้ปัญหาแจ้งเตือนข้อผิดพลาดการจัดรูปแบบตัวเลข\r\n- ปรับแก้ไขคำจากรุ่นก่อนหน้าให้ทันสมัย";
                
                group.AddSpace(20);

                UIButton button = (UIButton)group.AddButton("การสนับสนุนบน Discord ", () => OpenUrl(URLDiscord));
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