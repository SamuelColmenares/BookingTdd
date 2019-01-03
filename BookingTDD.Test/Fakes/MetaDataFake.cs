using BookingTDD.MetaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTDD.Test.Fakes
{
    class MetaDataFake : IMetaData
    {
        public List<Estado> ConsultaEstadoPorIdPais(FiltroEstado datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Estado>> ConsultaEstadoPorIdPaisAsync(FiltroEstado datos)
        {
            throw new NotImplementedException();
        }

        public List<Aeropuerto> ConsultarAeropuertos(FiltroAeropuertos datos)
        {
            List<Aeropuerto> aeropFake = new List<Aeropuerto>() {
                new Aeropuerto { CodigoAeropuerto = 1, CodigoCiudad = 1, NombreAeropuerto = "Bogota" },
            new Aeropuerto { CodigoAeropuerto = 2, CodigoCiudad = 2, NombreAeropuerto = "Terminal" }
            };

            return aeropFake;
        }

        public Task<List<Aeropuerto>> ConsultarAeropuertosAsync(FiltroAeropuertos datos)
        {
            throw new NotImplementedException();
        }

        public List<Ciudad> ConsultarCiudades(FiltroCiudades datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ciudad>> ConsultarCiudadesAsync(FiltroCiudades datos)
        {
            throw new NotImplementedException();
        }

        public List<Ciudad> ConsultarCiudadesdeOficinas(FiltroCiudades datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ciudad>> ConsultarCiudadesdeOficinasAsync(FiltroCiudades datos)
        {
            throw new NotImplementedException();
        }

        public List<CiudadAeropuerto> ConsultarCiudadXIataAeropuerto(FiltroCiudades datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<CiudadAeropuerto>> ConsultarCiudadXIataAeropuertoAsync(FiltroCiudades datos)
        {
            throw new NotImplementedException();
        }

        public List<Departamento> ConsultarDepartamentos(FiltroDepartamentos datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Departamento>> ConsultarDepartamentosAsync(FiltroDepartamentos datos)
        {
            throw new NotImplementedException();
        }

        public List<Franquicia> ConsultarFranquicia(FiltroFranquicia datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Franquicia>> ConsultarFranquiciaAsync(FiltroFranquicia datos)
        {
            throw new NotImplementedException();
        }

        public List<Genero> ConsultarGenero(FiltroGenero datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Genero>> ConsultarGeneroAsync(FiltroGenero datos)
        {
            throw new NotImplementedException();
        }

        public List<Idioma> ConsultarIdioma(FiltroIdioma datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Idioma>> ConsultarIdiomaAsync(FiltroIdioma datos)
        {
            throw new NotImplementedException();
        }

        public List<Imagen> ConsultarImagenesPrebooking(Imagen imagen)
        {
            throw new NotImplementedException();
        }

        public Task<List<Imagen>> ConsultarImagenesPrebookingAsync(Imagen imagen)
        {
            throw new NotImplementedException();
        }

        public Imagen ConsultarImagenPrebooking(Imagen imagen)
        {
            throw new NotImplementedException();
        }

        public Task<Imagen> ConsultarImagenPrebookingAsync(Imagen imagen)
        {
            throw new NotImplementedException();
        }

        public List<Landing> ConsultarLandingFiltro(Landing filtro)
        {
            throw new NotImplementedException();
        }

        public Task<List<Landing>> ConsultarLandingFiltroAsync(Landing filtro)
        {
            throw new NotImplementedException();
        }

        public List<Landing> ConsultarLandingsPrinicipales()
        {
            throw new NotImplementedException();
        }

        public Task<List<Landing>> ConsultarLandingsPrinicipalesAsync()
        {
            throw new NotImplementedException();
        }

        public List<Oficinas> ConsultarOficinas(string idioma)
        {
            throw new NotImplementedException();
        }

        public Task<List<Oficinas>> ConsultarOficinasAsync(string idioma)
        {
            throw new NotImplementedException();
        }

        public List<OficinasNm> ConsultarOficinasDeVenta(string idioma)
        {
            throw new NotImplementedException();
        }

        public Task<List<OficinasNm>> ConsultarOficinasDeVentaAsync(string idioma)
        {
            throw new NotImplementedException();
        }

        public List<Oficinas> ConsultarOficinasDeVentaPaisIdioma(int idPais, string idioma, bool activo)
        {
            throw new NotImplementedException();
        }

        public Task<List<Oficinas>> ConsultarOficinasDeVentaPaisIdiomaAsync(int idPais, string idioma, bool activo)
        {
            throw new NotImplementedException();
        }

        public List<Pais> ConsultarPais(FiltroPais datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pais>> ConsultarPaisAsync(FiltroPais datos)
        {
            throw new NotImplementedException();
        }

        public List<Region> ConsultarRegion(FiltroRegion datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Region>> ConsultarRegionAsync(FiltroRegion datos)
        {
            throw new NotImplementedException();
        }

        public List<TipoSaludo> ConsultarSaludo(FiltroSaludo datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<TipoSaludo>> ConsultarSaludoAsync(FiltroSaludo datos)
        {
            throw new NotImplementedException();
        }

        public string ConsultarTimeZoneIATA(string IATA)
        {
            throw new NotImplementedException();
        }

        public Task<string> ConsultarTimeZoneIATAAsync(string IATA)
        {
            throw new NotImplementedException();
        }

        public List<Documento> ConsultarTipoDocumento(FiltroDocumento datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Documento>> ConsultarTipoDocumentoAsync(FiltroDocumento datos)
        {
            throw new NotImplementedException();
        }

        public List<TipoTarjeta> ConsultarTiposTarjeta(FiltroTipoTarjeta datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<TipoTarjeta>> ConsultarTiposTarjetaAsync(FiltroTipoTarjeta datos)
        {
            throw new NotImplementedException();
        }

        public List<TodoRegiones> ConsultarTodoDeRegiones(string idioma)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoRegiones>> ConsultarTodoDeRegionesAsync(string idioma)
        {
            throw new NotImplementedException();
        }

        public List<UbicacionFila> ConsultarUbicacionFila(FiltroUbicacionFila datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<UbicacionFila>> ConsultarUbicacionFilaAsync(FiltroUbicacionFila datos)
        {
            throw new NotImplementedException();
        }

        public List<UbicacionSilla> ConsultarUbicacionSilla(FiltroUbicacionSilla datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<UbicacionSilla>> ConsultarUbicacionSillaAsync(FiltroUbicacionSilla datos)
        {
            throw new NotImplementedException();
        }

        public Landing ConsultarUltimaVersion(string nombre, int pais, int idioma)
        {
            throw new NotImplementedException();
        }

        public Task<Landing> ConsultarUltimaVersionAsync(string nombre, int pais, int idioma)
        {
            throw new NotImplementedException();
        }

        public List<Landing> ConsultarVersionesLanding(Landing datos)
        {
            throw new NotImplementedException();
        }

        public Task<List<Landing>> ConsultarVersionesLandingAsync(Landing datos)
        {
            throw new NotImplementedException();
        }

        public bool EliminarImagenPrebooking(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarImagenPrebookingAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public bool EliminarLanding(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarLandingAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool InactivarLanding(Landing datos)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InactivarLandingAsync(Landing datos)
        {
            throw new NotImplementedException();
        }

        public bool InsertarImagenPrebooking(Imagen imagen)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertarImagenPrebookingAsync(Imagen imagen)
        {
            throw new NotImplementedException();
        }

        public bool InsertarLanding(Landing datos)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertarLandingAsync(Landing datos)
        {
            throw new NotImplementedException();
        }
    }
}
