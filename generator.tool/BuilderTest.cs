using System;
using System.Collections.Generic;
using System.Text;
using generator.tool.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace generator.tool
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void Creatore()
        {
            List<IStackPanelBuilder> buttons = new List<IStackPanelBuilder>() {
                new StackPanelBuilder("HamburgerButton"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                },
                new StackPanelBuilder("HamburgerButton2"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                },
                new StackPanelBuilder("HamburgerButton3"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                },
                new StackPanelBuilder("HamburgerButton4"){
                    FontFamily="Segoe MDL2 Assets",
                    Content="&#xE700;",
                }
            };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<StackPanel Background=\"Gray\">");
            foreach (var item in buttons)
                sb.AppendLine(item.Build());
            sb.AppendLine("</StackPanel>");

            string result = sb.ToString();

        }
    }
}
