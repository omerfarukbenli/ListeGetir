using Liste.DataAccess.Abstract;
using Liste.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste.DataAccess.Concrete
{
    public class ListeRepository : IListeRepository
    {
        public SinifListesi CreateHotel(SinifListesi sinifListesi)
        {
            using (var listeDbContext = new ListeDbContext())
            {
                listeDbContext.SinifListesis.Add(sinifListesi);
                listeDbContext.SaveChanges();
                return sinifListesi;
            }
        }

        public void DeleteHotel(int id)
        {
            using (var listeDbContext = new ListeDbContext())
            {
                var deletedListe = GetHotelById(id);
                listeDbContext.SinifListesis.Remove(deletedListe);
                listeDbContext.SaveChanges();
            }
        }

        public List<SinifListesi> GetAllHotels()
        {
            using (var listeDbContext = new ListeDbContext())
            {
                return listeDbContext.SinifListesis.ToList();
            }
        }

        public SinifListesi GetHotelById(int id)
        {
            using (var listeDbContext = new ListeDbContext())
            {
                return listeDbContext.SinifListesis.Find(id);
            }
        }

        public SinifListesi UpdateHotel(SinifListesi sinifListesi)
        {
            using(var listeDbContext = new ListeDbContext())
            {
                listeDbContext.SinifListesis.Update(sinifListesi);
                listeDbContext.SaveChanges();
                return sinifListesi;
            }
        }
    }
}
