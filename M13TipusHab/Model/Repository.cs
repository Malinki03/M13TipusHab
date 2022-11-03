using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace M13TipusHab.Model
{
    internal class Repository
    {
        hotelEntities db;

        public Repository()
        {
            DbConnect();
        }

        // Método que conecta a la base de datos
        public void DbConnect()
        {
            db = new hotelEntities();
        }

        // Lista los tipos de balcón por orden de nombre
        public List<tipusBalco> GetTipusBalco()
        {
            List<tipusBalco> lt = new List<tipusBalco>();
            try
            {
                return db.tipusBalcoes.OrderBy(a => a.nomTipusBalco).ToList();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
            }
            return lt;
        }

        //Metode que elimina un tipus d'habitacio de la base de dades.
        public tipusHab DelTipusHab(tipusHab th) 
        {
            DelHabitacionsById(th);
            db.tipusHabs.Remove(th);
            db.SaveChanges();
            return th;
        }

        public void DelHabitacionsById(tipusHab th)
        {
            List<habitacio> habitacions = db.habitacios.Select(h => h).Where(h => h.TipusHab_codi.Equals(th.codi)).ToList();
            db.habitacios.RemoveRange(habitacions);
            db.SaveChanges();
        }

        // Lista los tipos de habitación por orden de código
        public List<tipusHab> GetTipusHabs()
        {
            return db.tipusHabs.OrderBy(a => a.codi).ToList();
        }

        public void addTipusHab(tipusHab tH)
        {
            db.tipusHabs.Add(tH);
            Console.WriteLine(tH);
            db.SaveChanges();
        }
    }
}
