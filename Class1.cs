using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MantenimientoTests

{
    [TestMethod]
    public void CalcularCostoMantenimiento_DeberiaRetornarCostoCorrecto()
    {
        // Arrange (preparar el escenario)
        var mantenimiento = new Mantenimiento(); // Instancia de la clase que deseas probar
        double costoEsperado = 100.00; // El resultado esperado

        // Act (actuar, realizar la acción que se va a probar)
        double costoCalculado = mantenimiento.CalcularCostoMantenimiento(vehiculo);

        // Assert (verificar el resultado)
        Assert.AreEqual(costoEsperado, costoCalculado);
    }
}
