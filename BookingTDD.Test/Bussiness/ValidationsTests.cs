using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingTDD.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingTDD.Services;
using BookingTDD.Test.Fakes;
using BookingTDD.MetaData;
using Rhino.Mocks;

namespace BookingTDD.Bussiness.Tests
{
    [TestClass()]
    public class ValidationsTests
    {
        [TestMethod()]
        public void ValidateCitiesTest()
        {
            // Arrange
            Validations validations = new Validations();
            bool result1 = true;


            // Act
            var result = validations.ValidateCities(1, 1);

            //Assert


            Assert.AreEqual(result,result1);
        }

        [TestMethod()]
        public void IsBogotaTest()
        {
            // Arrange
            int bogId=1;
            string bog = "Bogota";
            //MetaDataFake meta = new MetaDataFake();
            //Validations validations = new Validations(meta);


            //var result = validations.IsBogota(bogId,bog);

            // Arrange
            List<Aeropuerto> aeropFake = new List<Aeropuerto>() {
                new Aeropuerto { CodigoAeropuerto = 1, CodigoCiudad = 1, NombreAeropuerto = "Bogota" },
            new Aeropuerto { CodigoAeropuerto = 2, CodigoCiudad = 2, NombreAeropuerto = "Terminal" }
            };
            IMetaData dataChannel = MockRepository.GenerateMock<IMetaData>();
            dataChannel.Expect(x => x.ConsultarAeropuertos(new FiltroAeropuertos())).IgnoreArguments().Return(aeropFake);

            Validations validations = new Validations(dataChannel);
            // Act
            var result = validations.IsBogota(bogId, bog);
            
            // Assert
            //Assert.AreEqual<int>(c, aeropFake.Count);


            // Assert

            Assert.IsTrue(result);
        }
    }
}