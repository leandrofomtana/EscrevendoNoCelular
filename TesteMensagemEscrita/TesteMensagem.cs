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
        [TestMethod]
        public void Alfabeto()
        {
            Celular celular = new("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.AreEqual("2_22_2223_33_3334_44_4445_55_555" +
                "6_66_6667_77_777_77778_88_8889_99_999_9999", celular.RecebeMensagem());
        }
        [TestMethod]
        public void ErroDigitos()
        {
            Celular celular = new("SEMPRE 12321321");
            Assert.AreEqual("Não pode conter dígitos", celular.RecebeMensagem());
        }
        [TestMethod]
        public void ErroTamanho()
        {
            Celular celular = new("Lorem ipsum dolor sit amet, consectetur " +
                "adipiscing elit. Nulla ac urna non diam ullamcorper porta. " +
                "Suspendisse a ornare urna, id interdum dui. " +
                "Cras vitae elit in diam suscipit fringilla. Pellentesque nec" +
                " porttitor augue, ut eleifend erat. Vestibulum fusce.");
            Assert.AreEqual("Não pode ser maior que 255", celular.RecebeMensagem());
        }
    }
}
