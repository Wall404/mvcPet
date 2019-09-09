using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcPet.Entities
{
    public partial class Precio : IEntity
    {

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Id Servicio")]
        public int TipoServicioId { get; set; }

        [DisplayName("Fecha Desde")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaDesde { get; set; }

        [DisplayName("Fecha Hasta")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaHasta { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        public TipoServicio TipoServicio { get; set; }

    }
}
