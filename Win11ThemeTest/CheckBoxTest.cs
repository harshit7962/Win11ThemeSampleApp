using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.UIA3;

namespace Win11ThemeTest
{
    public class cbTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckBoxCheckedTest()
        {
            var app = FlaUI.Core.Application.Launch(@"..\\..\\..\\..\\Win11ThemeSampleApp\\bin\\x64\\Debug\\net9.0-windows\\win-x64\\Win11ThemeSampleApp.exe");
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);
                var checkBox1 = window.FindFirstDescendant(cf => cf.ByAutomationId("firstCheckBox")).AsCheckBox();
                var checkBox2 = window.FindFirstDescendant(cf => cf.ByAutomationId("lastCheckBox")).AsCheckBox();
                Assert.That(checkBox1.ToggleState, Is.EqualTo(ToggleState.Off));
                checkBox1.Toggle();
                Assert.That(checkBox1.ToggleState, Is.EqualTo(ToggleState.On));

                Assert.That(checkBox2.ToggleState, Is.EqualTo(ToggleState.Off));

                window.Close();
            }
        }
    }
}