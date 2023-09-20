namespace TestProject1
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange = Preparação
            double pNum = 1;
            double sNum = 2;
            double rNum = 3;

            //Act = Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert = Comparação
            Assert.AreEqual(rNum, resultado);
        }
    }
}