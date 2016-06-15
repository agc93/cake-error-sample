using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.Diagnostics;
using ExternalLib.Sample;

namespace Cake.Sample
{
    [CakeAliasCategory("Error")]
    public static class CakeAliases
    {
        [CakeAliasCategory("Sample")]
        [CakeNamespaceImport("ExternalLib.Sample")]
        public static void Run(this ICakeContext ctx, ExternalObject obj)
        {
            ctx.Log.Information(obj.GetMessage());
        }
    }
}
