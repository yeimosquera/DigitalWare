using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWare.Model;
using System.ComponentModel;

namespace DigitalWare.data
{
    public class DataContext: DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Factura> tblFactura { get; set; }
        public DbSet<Producto> tblProducto { get; set; }
        public DbSet<DetalleFactura> tblDetalleFactura { get; set; }
        public DbSet<Cliente> tblCliente { get; set; }
        public DbSet<vColsultarFacturacion> vColsultarFacturacion { get; set; }




    }
}
