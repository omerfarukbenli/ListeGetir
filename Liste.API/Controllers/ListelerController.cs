using Liste.Business.Abstract;
using Liste.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Liste.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListelerController : ControllerBase
    {
        private IListeService _listeService;
        public ListelerController(IListeService listeService)
        {
            _listeService = listeService; 
        }
        [HttpGet] //getir
        public List<SinifListesi> Get()
        {
            return _listeService.GetAllHotels();
        }

        [HttpGet("{id}")] // getir idye göre
        public SinifListesi Get(int id)
        {
            return _listeService.GetHotelById(id);
        }

        [HttpPost] // ekleme
        public SinifListesi Post([FromBody] SinifListesi sinifListesi)
        {
            return _listeService.CreateHotel(sinifListesi);
        }
        [HttpPut] //güncelleme
        public SinifListesi Put([FromBody] SinifListesi sinifListesi)
        {
            return _listeService.UpdateHotel(sinifListesi);
        }
        [HttpDelete("{id}")] //silme
        public void Delete(int id)
        {
            _listeService.DeleteHotel(id);
        }
    }
}

