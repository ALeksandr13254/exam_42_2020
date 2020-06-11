using System.Collections.Generic;
using Xunit;

namespace Examen
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyTest()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> words = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            Assert.Equal(new Dictionary<string, string>(), Map.FuncFlat(words));
        }
        [Fact]
        public void CorrectTest()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> words = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            words.Add("a", new Dictionary<string, Dictionary<string, string>>());
            words["a"].Add("b", new Dictionary<string, string>());
            words["a"].Add("", new Dictionary<string, string>());
            words["a"]["b"].Add("c", "12");
            words["a"]["b"].Add("d", "Hello World");
            words["a"][""].Add("e", "1,2,3");
            Dictionary<string, string> correct = new Dictionary<string, string>();
            correct.Add("a/b/c", "12");
            correct.Add("a/b/d", "Hello World");
            correct.Add("a/e", "1,2,3");
            Assert.Equal(correct, Map.FuncFlat(words));
        }      
    }
}
