using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Actividad_Keny.Models
{
    public class Categoria
    {
        [Key]
        public int ID_Categoria { get; set; }

        #region PropiedadDescripción
        [Required(ErrorMessage = "Proporcione una descripción")]
        [DisplayName("Descripción")]
        [DataType(DataType.MultilineText)]
        public string descripcion { get; set; } 
        #endregion

        #region PropiedadFecha
        [Required(ErrorMessage = "Proporcione una fecha")]
        [DisplayName("Fecha ")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public DateTime fecha { get; set; }
        #endregion

        //Relaciones
        public virtual List<Producto> Productos { get; set; }
    }
}