using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutosoftService.DAL;
using AutosoftService.Model;
using Microsoft.EntityFrameworkCore;

namespace AutosoftService.BLL
{
    public class FacturaBLL
    {

        public static bool Guardar(Facturas facturas)
        {
            if (!Existe(facturas.FacturaId))
                return Insertar(facturas);
            else
                return Modificar(facturas);
        }


        private static bool Insertar(Facturas facturas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.facturas.Add(facturas) != null)
                {
                    foreach (var item in facturas.Factura_Detalle)
                    {
                        db.articulos.Find(item.ArticuloId).Existencia -= item.Cantidad;
                    }
  
                }

                if (facturas.FacturaCredito != false)
                {
                    
                        db.clientes.Find(facturas.ClienteId).Deuda += facturas.Total;
                   
                    

                }


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




        public static bool Modificar(Facturas facturas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                Facturas facturaAnterior = db.facturas.Where(e => e.FacturaId == facturas.FacturaId)
                    .Include(f => f.Factura_Detalle)
                    .FirstOrDefault();


                if (facturas.FacturaCredito != false)
                {
                     var clientes = ClienteBLL.Buscar(facturaAnterior.ClienteId);
                    clientes.Deuda -= facturaAnterior.Total;
                    ClienteBLL.Guardar(clientes);
                }
             

                db = new Contexto();
                foreach (var item in facturaAnterior.Factura_Detalle)
                {
                    if (!facturas.Factura_Detalle.Any(f => f.Id == item.Id))
                    {
                        db.articulos.Find(item.ArticuloId).Existencia += item.Cantidad;
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in facturas.Factura_Detalle)
                {
                    if (item.Id == 0)
                    {
                        db.articulos.Find(item.ArticuloId).Existencia -= item.Cantidad;
                        db.Entry(item).State = EntityState.Added;

                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;

                    }
                }
                

                if (facturas.FacturaCredito != false)
                {
                    db.clientes.Find(facturas.ClienteId).Deuda += facturas.Total;
                }

                db.Entry(facturas).State = EntityState.Modified;
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


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                Facturas facturas = db.facturas.Where(e => e.FacturaId == id)
                    .Include(f => f.Factura_Detalle)
                    .FirstOrDefault();


                foreach (var item in facturas.Factura_Detalle)
                {
                    db.articulos.Find(item.ArticuloId).Existencia += item.Cantidad;

                }

                if(facturas.FacturaCredito != false)
                {
                    db.clientes.Find(facturas.ClienteId).Deuda -= facturas.Total;
                }

                db.facturas.Remove(facturas);
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


        public static Facturas Buscar(int id)
        {
            Facturas facturas = new Facturas();
            Contexto db = new Contexto();


            try
            {
                facturas = db.facturas.Include(o => o.Factura_Detalle).Where(o => o.FacturaId == id).SingleOrDefault();
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return facturas;
        }


        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();


            try
            {

                encontrado = db.facturas.Any(p => p.FacturaId == id);


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;

        }


        public static List<Facturas> GetList(Expression<Func<Facturas, bool>> expression)
        {
            List<Facturas> Lista = new List<Facturas>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.facturas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Lista;
        }

    }
}
