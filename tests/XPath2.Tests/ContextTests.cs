using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Wmhelp.XPath2;
using Xunit;
using System.Xml.XPath;

namespace XPath2.Tests
{
    public class ContextTests
    {
        private XDocument GetTestDocument()
        {
            return XDocument.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?>
                <test id=""root"">
                  <item id=""i1""><item id=""i3""></item></item>
                  <item id=""i2""><item id=""i4""></item></item>
                  <label f=""i1"" id=""l1"">Label i1</label>
                  <label for=""i2"" id=""l2"">Label i2</label>
                  <label f=""i3"" id=""l3"">Label i3</label>
                </test>");
        }

        [Fact]
        public void Select_Multiple_From_Root()
        {
            var doc = GetTestDocument();

            var result = doc.XPath2Select("//label[@f=//item[1]/@id]").Cast<XElement>().Select(e=> e.Attribute("id").Value).ToArray();

            result.Length.Should().Be(2);
            result[0].Should().Be("l1");
            result[0].Should().Be("l3");
        }

        [Fact]
        public void From_Node_To_Absolute_Root()
        {
            var doc = GetTestDocument();

            var result = doc.Root.Element("item").XPath2Select("/test").Cast<XElement>().Select(e => e.Attribute("id").Value).ToArray();

            result.Length.Should().Be(1);
            result[0].Should().Be("root");
        }

        [Fact]
        public void From_Node_To_Relative_Other_Base()
        {
            var doc = GetTestDocument();

            var result = doc.Root.Element("item").XPath2Select("item").Cast<XElement>().Select(e => e.Attribute("id").Value).ToArray();

            result.Length.Should().Be(1);
            result[0].Should().Be("i3");
        }

        [Fact]
        public void From_Node_To_Relative_Other_DotName()
        {
            var doc = GetTestDocument();

            var result = doc.Root.Element("item").XPath2Select("./item").Cast<XElement>().Select(e => e.Attribute("id").Value).ToArray();

            result.Length.Should().Be(1);
            result[0].Should().Be("i3");
        }
    }
}
