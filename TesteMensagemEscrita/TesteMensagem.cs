using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaCelular;
namespace TesteMensagemEscrita
{
    [TestClass]
    public class TesteMensagem
    {
        [TestMethod]
        public void Mensagem1() 
        {
            Celular celular = new("SEMPRE ACESSO O DOJOPUZZLES");
            Assert.AreEqual("77773367_7773302_222337777_77776660666036" +
                "6656667889999_9999555337777", celular.RecebeMensagem());
        }
    }
}
