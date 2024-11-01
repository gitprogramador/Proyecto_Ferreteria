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

    [Persistent(@"ventas")]
    public partial class Ventas : XPLiteObject
    {
        int fIdVentas;
        [Key(true)]
        [Persistent(@"idVentas")]
        public int IdVentas
        {
            get { return fIdVentas; }
            set { SetPropertyValue<int>(nameof(IdVentas), ref fIdVentas, value); }
        }
        string fNumeroComprobante;
        [Size(45)]
        public string NumeroComprobante
        {
            get { return fNumeroComprobante; }
            set { SetPropertyValue<string>(nameof(NumeroComprobante), ref fNumeroComprobante, value); }
        }
        DateTime fFechaEmitida;
        public DateTime FechaEmitida
        {
            get { return fFechaEmitida; }
            set { SetPropertyValue<DateTime>(nameof(FechaEmitida), ref fFechaEmitida, value); }
        }
        Clientes fClientes_CodigoCliente;
        [Association(@"VentasReferencesClientes")]
        public Clientes Clientes_CodigoCliente
        {
            get { return fClientes_CodigoCliente; }
            set { SetPropertyValue<Clientes>(nameof(Clientes_CodigoCliente), ref fClientes_CodigoCliente, value); }
        }
        Usuariosistema fUsuarioSistema_idUsuarioSistema;
        [Association(@"VentasReferencesUsuariosistema")]
        public Usuariosistema UsuarioSistema_idUsuarioSistema
        {
            get { return fUsuarioSistema_idUsuarioSistema; }
            set { SetPropertyValue<Usuariosistema>(nameof(UsuarioSistema_idUsuarioSistema), ref fUsuarioSistema_idUsuarioSistema, value); }
        }
        [Association(@"DetalleventaReferencesVentas")]
        public XPCollection<Detalleventa> Detalleventas { get { return GetCollection<Detalleventa>(nameof(Detalleventas)); } }
        [Association(@"TipocomprobanteReferencesVentas")]
        public XPCollection<Tipocomprobante> Tipocomprobantes { get { return GetCollection<Tipocomprobante>(nameof(Tipocomprobantes)); } }
    }

}
