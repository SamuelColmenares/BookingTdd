using BookingTDD.MetaData;
using BookingTDD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingTDD.Bussiness
{
    public class Validations
    {
        private MetadataIntegration Client  { get; set; }

        public Validations()
        {
            this.Client = new MetadataIntegration();
        }

        public Validations(IMetaData client)
        {
            this.Client = new MetadataIntegration(client);
        }
        public bool ValidateCities(int idOrigin, int idDesti)
        {
            return idOrigin == idDesti;
        }

        public bool IsBogota(int idAirport, string name)
        {
            
            var a = Client.InvokeCities("EN");
            var result = a.FirstOrDefault(x => x.CodigoAeropuerto == idAirport);



            var result2 = result?.NombreAeropuerto.Equals(name);

            return result2.HasValue && result2.Value;

            //throw new NotImplementedException();
        }
    }
}