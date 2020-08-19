using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;
        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitialiPies();
            }
        }

        private void InitialiPies()
        {
            _pies = new List<Pie>
            {
                new Pie{Id=1, Name="Apple Pie", Price=12.95M,ShortDescription="our famous apple pies!", LongDescription="Icing carrot cake jelly cheesecake"},
                new Pie{Id=2, Name="BlueBerry cheese cake", Price=12.95M,ShortDescription="our famous apple pies!", LongDescription="Icing carrot cake jelly cheesecake"},
                new Pie{Id=3, Name="cheese cake", Price=12.95M,ShortDescription="our famous apple pies!", LongDescription="Icing carrot cake jelly cheesecake"},
                new Pie{Id=4, Name="cherry Pie", Price=12.95M,ShortDescription="our famous apple pies!", LongDescription="Icing carrot cake jelly cheesecake"}
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
