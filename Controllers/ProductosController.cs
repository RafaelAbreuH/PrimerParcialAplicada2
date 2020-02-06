using Microsoft.EntityFrameworkCore;
using PrimerParcialAplicada2.Data;
using PrimerParcialAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PrimerParcialAplicada2.Controllers
{
    public class ProductosController
    {
        public bool Guardar(Productos entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Productos.Add(entity);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public bool Modificar(Productos entity)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public bool Eliminar(int Id)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                Productos persona = db.Productos.Find(Id);
                db.Entry(persona).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public Productos Buscar(int Id)
        {
            Productos persona;
            Contexto db = new Contexto();
            try
            {
                persona = db.Productos.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return persona;
        }
    }
}
