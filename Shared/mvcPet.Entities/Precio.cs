﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcPet.Entities
{
    public partial class Precio : IEntity
    {
        public Precio()
        {
            TipoServicios = new List<TipoServicio>();
        }

        [DisplayName("Id")]
        public int Id { get; set; }



        [DisplayName("Fecha Desde")]
        public DateTime FechaDesde { get; set; }

        [DisplayName("Fecha Hasta")]
        public DateTime FechaHasta { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        public IList<TipoServicio> TipoServicios { get; set; }

    }
}
