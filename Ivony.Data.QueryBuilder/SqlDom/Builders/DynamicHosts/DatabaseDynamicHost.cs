﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Ivony.Data.SqlDom.Builders.DynamicHosts
{
  public class DatabaseDynamicHost : DynamicObject
  {

    public override bool TryGetMember( GetMemberBinder binder, out object result )
    {
      result = new TableDynamicHost( binder.Name );
      return true;
    }
  }
}
