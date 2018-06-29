using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generator.tool.Infrastructure
{
    public class StackPanelBuilder : IStackPanelBuilder
    {
        private string Name;

        public StackPanelBuilder(string Name)
        {
            this.Name = Name;
        }
        public string FontFamily { get; set; }
        public string Content { get; set; }
        public string Tapped { get; set; }

        public string FontIconFontFamily { get; set; }
        public string FontIconGlyph { get; set; }

        public string Build()
        {
            StringBuilder sb = new StringBuilder();
            //Content =\"{Content}\" 
            sb.AppendLine($"<StackPanel Orientation=\"Horizontal\">");
            sb.AppendLine($"    <Button x:Name=\"{Name}\" FontFamily=\"{FontFamily}\" Tapped=\"{Tapped}\" Width=\"50\" Height=\"50\" Background=\"Transparent\"> ");
            sb.AppendLine($"        <FontIcon FontFamily=\"{FontIconFontFamily}\" Glyph=\"{FontIconGlyph}\"   />");
            sb.AppendLine($"    </Button>");
            sb.AppendLine($"    <TextBlock Text=\"Button 1\" FontSize=\"18\" VerticalAlignment=\"Center\" />");
            sb.AppendLine($"</StackPanel>");
            return sb.ToString();
        }
    }
}
