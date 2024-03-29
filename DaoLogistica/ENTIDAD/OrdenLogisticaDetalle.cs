﻿using System;

namespace DaoLogistica.ENTIDAD
{
    public class OrdenLogisticaDetalle
    {
        public OrdenLogisticaDetalle(string codigo, string detalle, long id, int idClasificador, int idMeta,
            long idOrden, int cantidad, decimal monto, char tipoUsuario)
        {
            Codigo = codigo;
            Detalle = detalle;
            Id = id;
            IdClasificador = idClasificador;
            IdMeta = idMeta;
            IdOrden = idOrden;
            Monto = monto;
            Cantidad = cantidad;
            TipoUsuario = tipoUsuario;
        }

        public OrdenLogisticaDetalle()
        {
            Clear();
        }

        public void Clear()
        {
            Id = 0;
            IdOrden = 0;
            IdClasificador = 0;
            TipoUsuario = 'N';
            Codigo = String.Empty;
            Detalle = String.Empty;
            IdMeta = 0;
            Cantidad = 0;
            Monto = 0m;
            Exceso = 0m;
        }

        #region Properties
        public long Id { get; set; }
        public long IdOrden { get; set; }
        public int IdClasificador { get; set; }
        public char TipoUsuario { get; set; }
        public string Codigo { get; set; }
        public string Detalle { get; set; }
        public int IdMeta { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal Exceso { get; set; }

        #endregion
    }
}
