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

    [Persistent(@"clientenatural")]
    public partial class Clientenatural : XPLiteObject
    {
        int fIdClienteNatural;
        [Key(true)]
        [Persistent(@"idClienteNatural")]
        public int IdClienteNatural
        {
            get { return fIdClienteNatural; }
            set { SetPropertyValue<int>(nameof(IdClienteNatural), ref fIdClienteNatural, value); }
        }
        string fDni;
        [Size(45)]
        [Persistent(@"dni")]
        public string Dni
        {
            get { return fDni; }
            set { SetPropertyValue<string>(nameof(Dni), ref fDni, value); }
        }
        string fNombre;
        [Size(145)]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fApellido;
        [Size(145)]
        public string Apellido
        {
            get { return fApellido; }
            set { SetPropertyValue<string>(nameof(Apellido), ref fApellido, value); }
        }
        Tiposcliente fTiposCliente_idTiposCliente;
        [Association(@"ClientenaturalReferencesTiposcliente")]
        public Tiposcliente TiposCliente_idTiposCliente
        {
            get { return fTiposCliente_idTiposCliente; }
            set { SetPropertyValue<Tiposcliente>(nameof(TiposCliente_idTiposCliente), ref fTiposCliente_idTiposCliente, value); }
        }
    }

}
