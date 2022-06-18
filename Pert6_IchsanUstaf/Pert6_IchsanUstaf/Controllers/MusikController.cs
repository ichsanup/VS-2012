using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Pert6_IchsanUstaf.Models;

namespace Pert6_IchsanUstaf.Controllers
{
    public class MusikController : ApiController
    {
        List<Musik> musiks = new List<Musik>{
            new Musik{
                id = 1,
                judul = "Judul 1",
                penyanyi = "Ichsan Ustaf",
                tahun = 2015
            },
            new Musik{
                id = 2,
                judul = "Judul 2",
                penyanyi = "Penyanyi 2",
                tahun = 2015
            }
        };

        public IEnumerable<Musik> Get()
        {
            return musiks;
        }
        public Musik Get(int id)
        {
            var musik = musiks.FirstOrDefault((m) => m.id == id);
            return musik;
        }
        public IEnumerable<Musik> Post([FromBody] Musik musik)
        {
            musiks.Add(musik);
            return musiks;
        }
        public IEnumerable<Musik> Put(int id, [FromBody] Musik musik_baru)
        {
            int idx = musiks.IndexOf(musiks.FirstOrDefault((m) => m.id == id));

            musiks[idx].judul = musik_baru.judul;
            musiks[idx].penyanyi = musik_baru.penyanyi;
            musiks[idx].tahun = musik_baru.tahun;
            return musiks;
        }
        public IEnumerable<Musik> Delete(int id)
        {
            int idx = musiks.IndexOf(musiks.FirstOrDefault((m) => m.id == id));

            musiks.RemoveAt(idx);
            return musiks;
        }
    }
}
