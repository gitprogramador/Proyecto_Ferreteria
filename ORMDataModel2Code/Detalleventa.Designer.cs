﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Proyecto_Ferreteria.base_datos_ferreteria
{

    [Persistent(@"detalleventa")]
    public partial class Detalleventa : XPLiteObject
    {
        int fIddetalleventa;
        [Key(true)]
        [Persistent(@"iddetalleventa")]
        public int Iddetalleventa
        {
            get { return fIddetalleventa; }
            set { SetPropertyValue<int>(nameof(Iddetalleventa), ref fIddetalleventa, value); }
        }
        Productos fProductos_idProductos;
        [Association(@"DetalleventaReferencesProductos")]
        public Productos Productos_idProductos
        {
            get { return fProductos_idProductos; }
            set { SetPropertyValue<Productos>(nameof(Productos_idProductos), ref fProductos_idProductos, value); }
        }
        Ventas fVentas_idVentas;
        [Association(@"DetalleventaReferencesVentas")]
        public Ventas Ventas_idVentas
        {
            get { return fVentas_idVentas; }
            set { SetPropertyValue<Ventas>(nameof(Ventas_idVentas), ref fVentas_idVentas, value); }
        }
        int fUnidades;
        public int Unidades
        {
            get { return fUnidades; }
            set { SetPropertyValue<int>(nameof(Unidades), ref fUnidades, value); }
        }
        decimal fImporte;
        public decimal Importe
        {
            get { return fImporte; }
            set { SetPropertyValue<decimal>(nameof(Importe), ref fImporte, value); }
        }
    }

}
