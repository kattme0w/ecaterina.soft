using System;
using System.Collections.Generic;
using System.Text;
using generator.tool.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace generator.tool
{
    /// <summary>
    /// https://blogs.msdn.microsoft.com/quick_thoughts/2015/06/01/windows-10-splitview-build-your-first-hamburger-menu/
    /// </summary>
    [TestClass]
    public class BuilderTest : BaseClass
    {
        [TestMethod]
        public void Creatore()
        {
            List<IStackPanelBuilder> buttons = new List<IStackPanelBuilder>() {
                new StackPanelBuilder("btn1"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                    Tapped="Button_Tapped3",
                    FontIconFontFamily="Segoe MDL2 Assets",
                    FontIconGlyph="&#xE74D;"
                },
                new StackPanelBuilder("btn2"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                    Tapped="Button_Tapped3",
                    FontIconFontFamily="Segoe MDL2 Assets",
                    FontIconGlyph="&#xE80F;"
                },
                new StackPanelBuilder("btn3"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                    Tapped="Button_Tapped3",
                    FontIconFontFamily="Segoe MDL2 Assets",
                    FontIconGlyph="&#xE830;"
                },
                new StackPanelBuilder("btn4"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                    Tapped="Button_Tapped3",
                    FontIconFontFamily="Segoe MDL2 Assets",
                    FontIconGlyph="&#xE830;"
                },
                new StackPanelBuilder("btn5"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                    Tapped="Button_Tapped3",
                    FontIconFontFamily="Segoe MDL2 Assets",
                    FontIconGlyph="&#xEA6A;"
                },
                new StackPanelBuilder("btn6"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                    Tapped="Button_Tapped3",
                    FontIconFontFamily="Segoe MDL2 Assets",
                    FontIconGlyph="&#xEBE8;"
                }
            };
            var sb = new StringBuilder();
            foreach (var item in buttons)
                sb.AppendLine(item.Build());

            string result = sb.ToString();

        }
    }
}
