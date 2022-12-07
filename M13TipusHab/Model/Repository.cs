using Pabo.Calendar;
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

        #region Querys a la base de datos

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
            }
            catch (Exception e)
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

        public List<tarifa> GetTarifas()
        {
            return db.tarifas.Select(t => t).ToList();
        }

        internal object GetCostas()
        {
            return db.costas.Select(c => c).ToList();
        }

        #endregion

        #region Insert Querys

        public void addTipusHab(tipusHab tH)
        {
            db.tipusHabs.Add(tH);
            Console.WriteLine(tH);
            try
            {
            db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Aquest tipus d'habitació ja està creat.");
            }
        }
        public void modTipusHab(tipusHab tH)
        {
            tipusHab ti = db.tipusHabs.Where(a => a.codi.Equals(tH.codi)).FirstOrDefault();
            ti = tH;

            try
            {
            db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Aquest tipus d'habitació ja està creat.");
            }
        }

        public void insertarDates(DateTime dataInici, DateTime dataFinal)
        {
            db.addDates(dataInici, dataFinal);
            db.SaveChanges();
        }

        public void actualitzarTarifes(DateTime dataInici, DateTime dataFinal, int tarifa)
        {
            List<DateTime> dates = new List<DateTime>();
            if (dataInici == dataFinal)
            {
                dates.Add(dataInici);
            }
            else
            {
                while (dataInici.Date <= dataFinal.Date)
                {
                    dates.Add(dataInici);
                    dataInici = dataInici.AddDays(1);
                }
                dates.Add(dataFinal);
            }
            foreach (DateTime dt in dates)
            {
                calendari date = db.calendaris.Select(c => c).Where(c => c.data.Equals(dt.Date)).FirstOrDefault();
                date.Tarifa_codi = tarifa;
            }
            db.SaveChanges();
        }

        #endregion

        #region DeleteQuerys

        public void eliminarCostos()
        {
            this.db.Database.ExecuteSqlCommand("DELETE FROM costa;");
        }

        #endregion

        #region Llamadas a procedures
        public void addCosta0(DateTime dataInici)
        {
            this.db.addCosta0(dataInici);
        }
        #endregion
    }
}
