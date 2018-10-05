using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Actividad_Keny.Models
{
    public class Producto
    {
        [Key]
        public int ID_Producto { get; set; }        
       
        #region PropiedadNombre
        [Required(ErrorMessage = "Tiene que proporcionar un nombre.")]
        [DisplayName("Nombre del Produto")]
        [StringLength(250)]
        public string nombre { get; set; }
        #endregion

        #region PropiedadPrecioCompra
        [Required(ErrorMessage = "Tiene que proporcinar un Precio de compra.")]
        [DisplayName("Precio de Compra")]
        [Range(0, 1000)]
        public decimal precioCompra { get; set; }
        #endregion

        #region PropiedadPrecioVenta
        [Required(ErrorMessage = "Tiene que proporcinar un Precio de Venta.")]
        [DisplayName("Precio de Compra de venta")]
        [Range(0, 1000)]
        public decimal precioVenta { get; set; }
        #endregion

        #region PropiedadCantidad
        [Required(ErrorMessage = "Tiene que proporcinar una")]
        [DisplayName("Cantidad")]
        [Range(0, 1000)]
        public int cantidad { get; set; }
        #endregion

        #region PropiedadFechaCaducidad
        [Required(ErrorMessage = "Proporcione una fecha")]
        [DisplayName("Fecha Caducidad")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public DateTime fechaCaducidad { get; set; }
        #endregion

        #region PropiedadFechaIngreso
        [Required(ErrorMessage = "Proporcione una fecha")]
        [DisplayName("Fecha Ingreso")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public DateTime fechaIngreso { get; set; }
        #endregion


        #region Relaciones
        public int ID_Categoria { get; set; }
        public virtual Categoria Categorias { get; set; } 
        #endregion
    }
}