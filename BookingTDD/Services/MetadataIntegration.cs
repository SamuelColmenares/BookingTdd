

namespace BookingTDD.Services
{
    using BookingTDD.MetaData;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class MetadataIntegration
    {
        private IMetaData Client { get; set; }

        public MetadataIntegration()
        {
            this.Client= new MetaData.MetaDataClient();
        }

        public MetadataIntegration(IMetaData client)
        {
            this.Client = client;
        }

        public IEnumerable<Aeropuerto> InvokeCities(string lan)
        {
            
            FiltroAeropuertos filter = new FiltroAeropuertos
            {
                Idioma = lan
            };

            var cities = Client.ConsultarAeropuertos(filter);
            return cities;
        }
    }
}