using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<calendari> GetDates()
        {
            return db.calendaris.Select(c => c).ToList();
        }

        public tarifa GetTarifaPerCodi(int codiTarifa)
        {
            return db.tarifas.Select(t => t).Where(t => t.codi.Equals(codiTarifa)).FirstOrDefault();
        }

        public List<costa> GetCostas()
        {
            return db.costas.Select(c => c).ToList();
        }
        public List<costa> GetCostasPerData(DateTime dt)
        {
            return db.costas.Select(c => c).Where(c => c.DesDe == dt).ToList();
        }
        public List<DateTime> GetDatesDisponibles()
        {
            return db.costas.Select(c => c.DesDe).Distinct().ToList();
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
        public costa GetCostasById(int id1, int id2, decimal? newPreu)
        {
            costa costa = db.costas.Select(c => c).Where(c => c.TipusHab_codi == id1).Where(c => c.Tarifa_codi == id2).FirstOrDefault();
            costa.preu = newPreu;
            db.SaveChanges();
            return costa;
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

        public void GrabarCostos(List<costa> costos)
        {
            this.db.SaveChanges();
        }
        #endregion

        #region DeleteQuerys

        public void eliminarCostos(DateTime dt)
        {
            var cost = this.db.costas.Select(c => c).Where(c => c.DesDe == dt).ToList();
            foreach(costa c in cost)
            {
                this.db.costas.Remove(c);
            }
            this.db.SaveChanges();
        }

        #endregion

        #region Llamadas a procedures
        public void addCosta0(DateTime dataInici)
        {
            this.db.addCosta0(dataInici);
            this.db.SaveChanges();
        }
        #endregion
    }
}
