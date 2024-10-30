using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Proyecto_Ferreteria.base_datos_ferreteria
{

    public partial class Usuariosistema
    {
        public Usuariosistema(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
