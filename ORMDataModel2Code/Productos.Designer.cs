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

    [Persistent(@"productos")]
    public partial class Productos : XPLiteObject
    {
        int fIdProductos;
        [Key(true)]
        [Persistent(@"idProductos")]
        public int IdProductos
        {
            get { return fIdProductos; }
            set { SetPropertyValue<int>(nameof(IdProductos), ref fIdProductos, value); }
        }
        string fNombreProducto;
        [Size(145)]
        public string NombreProducto
        {
            get { return fNombreProducto; }
            set { SetPropertyValue<string>(nameof(NombreProducto), ref fNombreProducto, value); }
        }
        string fDescripcion;
        [Size(255)]
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
        decimal fPrecio;
        public decimal Precio
        {
            get { return fPrecio; }
            set { SetPropertyValue<decimal>(nameof(Precio), ref fPrecio, value); }
        }
        int fStock;
        public int Stock
        {
            get { return fStock; }
            set { SetPropertyValue<int>(nameof(Stock), ref fStock, value); }
        }
        DateTime fFechaRegistro;
        public DateTime FechaRegistro
        {
            get { return fFechaRegistro; }
            set { SetPropertyValue<DateTime>(nameof(FechaRegistro), ref fFechaRegistro, value); }
        }
        Tipoproducto fTipoProducto_idTipoProducto;
        [Association(@"ProductosReferencesTipoproducto")]
        public Tipoproducto TipoProducto_idTipoProducto
        {
            get { return fTipoProducto_idTipoProducto; }
            set { SetPropertyValue<Tipoproducto>(nameof(TipoProducto_idTipoProducto), ref fTipoProducto_idTipoProducto, value); }
        }
        [Association(@"DetalleventaReferencesProductos")]
        public XPCollection<Detalleventa> Detalleventas { get { return GetCollection<Detalleventa>(nameof(Detalleventas)); } }
    }

}