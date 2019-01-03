using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BookingTDD.Models.Tests
{
    using BookingTDD.MetaData;
    using BookingTDD.Test.Fakes;
    using Rhino.Mocks;
    using System.Collections.Generic;

    [TestClass()]
    public class CiudadesProcTests
    {
        [TestMethod()]
        public void CountTest()
        {
            // Arrange
            List<Aeropuerto> aeropFake = new List<Aeropuerto>() { new Aeropuerto { CodigoAeropuerto = 1, CodigoCiudad = 1, NombreAeropuerto = "ElDorado" } };
            //IMetaData dataChannel = MockRepository.GenerateMock<IMetaData>();
            //dataChannel.Expect(x => x.ConsultarAeropuertos(new FiltroAeropuertos())).IgnoreArguments().Return(aeropFake);

            IMetaData dataChannel = new MetaDataFake();
            CiudadesProc ciudades = new CiudadesProc(dataChannel);
            // Act
            int c = ciudades.Count();
            // Assert
            Assert.AreEqual<int>(c, aeropFake.Count);
        }
    }
}